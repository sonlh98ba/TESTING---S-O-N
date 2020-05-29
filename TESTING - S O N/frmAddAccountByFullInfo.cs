using HttpRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTING___S_O_N
{
    public partial class frmAddAccountByFullInfo : Form
    {
        public frmAddAccountByFullInfo()
        {
            InitializeComponent();
        }


        #region Methods

        public void AddAllAccountByToken(string listAccount)
        {
            // Tách token
            string[] strAccount = listAccount.Split('\n');
            lblTotalToken.Text = "Total Account: " + strAccount.Length.ToString();

            int successToken; // Đếm số token add thành công và không thành công
            successToken = 0;

            // Duyệt từng token
            for (int i = 0; i < strAccount.Length; i++)
            {
                if (strAccount[i].Split('|').Length == 3)
                {
                    string token = strAccount[i].Split('|')[2];

                    // Kiểm tra token rỗng
                    if (token.Length > 10)
                    {
                        RequestHTTP request = new RequestHTTP();
                        string htmlInfo = request.Request("GET", "https://graph.facebook.com/v2.11/me?fields=id,email,mobile_phone,name,birthday,gender&access_token=" + token);
                        htmlInfo = htmlInfo.Remove(htmlInfo.IndexOf('}'));
                        htmlInfo = htmlInfo.Substring(1);
                        htmlInfo = htmlInfo.Replace('"', ' ');
                        htmlInfo = htmlInfo.Replace(",", "|");
                        htmlInfo = htmlInfo.Replace(" ", string.Empty);

                        // Xử lý kí tự đặc biệt bằng RegEx
                        htmlInfo = Regex.Replace(htmlInfo, @"\\u([\dA-Fa-f]{4})", v => ((char)Convert.ToInt32(v.Groups[1].Value, 16)).ToString());
                        htmlInfo.Replace("/", "-");

                        string[] strInfo = htmlInfo.Split('|');
                        // Khởi tạo từng thông tin
                        string id = "";
                        string passWord = strAccount[i].Split('|')[1];
                        string email = "";
                        string phone = "";
                        string name = "";
                        string friends = "";
                        string groups = "";
                        string birthday = "";
                        string gender = "";
                        string backupDate = "";
                        string status = "";
                        // Quét từng thông tin của token
                        for (int j = 0; j < strInfo.Length; j++)
                        {
                            if (strInfo[j].Split(':')[0] == "id") id = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "password") passWord = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "email") email = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "mobile_phone") phone = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "name") name = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "friends") friends = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "groups") groups = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "birthday") birthday = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "gender") gender = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "backup date") backupDate = strInfo[j].Split(':')[1];
                            if (strInfo[j].Split(':')[0] == "status") status = strInfo[j].Split(':')[1];
                        }

                        string acc = "id:" + id + "|" +
                                     "password:" + passWord + "|" +
                                     "token:" + token + "|" +
                                     "email:" + email + "|" +
                                     "phone:" + phone + "|" +
                                     "name:" + name + "|" +
                                     "friends:" + friends + "|" +
                                     "groups:" + groups + "|" +
                                     "birthday:" + birthday + "|" +
                                     "gender:" + gender + "|" +
                                     "backup date:" + backupDate + "|" +
                                     "status:live";
                        if (id != "")
                        {
                            successToken++;
                            // Ghi thêm vào file text (phải check được id mới add)
                            using (StreamWriter sw = new StreamWriter(@".\Account.txt", true))
                            {
                                sw.WriteLine(acc);
                            }
                        }
                    }
                }
            }

            MessageBox.Show(successToken.ToString() + " Account successed and " + (strAccount.Length - successToken).ToString() + " Account failed!","Result");

        }

        #endregion
        private void btnOK_Click(object sender, EventArgs e)
        {
            txtListToken.Enabled = false;
            if (txtListToken.Text != "")
            {
                btnOK.Text = "Waiting...";
                AddAllAccountByToken(txtListToken.Text);
                btnOK.Text = "OK";
                txtListToken.Enabled = true;
                txtListToken.Clear();
            }
            else
            {
                MessageBox.Show("Not Info Yet!","Notification!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                txtListToken.Enabled = true;
            }
            txtListToken.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtListToken.Text=="")
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Back to Home?","Notification!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtListToken.Text == "")
            {
                this.Close();
                frmAddingQuestion newform = new frmAddingQuestion();
                newform.Show();
            }
            else
            {
                if (MessageBox.Show("Exit?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    frmAddingQuestion newform = new frmAddingQuestion();
                    newform.Show();
                }
            }
        }

        private void txtListToken_TextChanged(object sender, EventArgs e)
        {
            if(txtListToken.Text!="")
                lblTotalToken.Text = "Total Account: " + txtListToken.Text.Split('\n').Length.ToString();
        }
    }
}
