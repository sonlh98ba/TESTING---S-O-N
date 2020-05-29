using HttpRequest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TESTING___S_O_N
{
    public partial class frmAccountManagerment : Form
    {
        public frmAccountManagerment()
        {
            InitializeComponent();
            Image img = Image.FromFile(@"C:\Users\HP\source\repos\TESTING - S O N\TESTING - S O N\Resources\8 - con lon.png");
            ptbLogo.Image = img;
            Control.CheckForIllegalCrossThreadCalls = false;
            grbAccountInfo.Enabled = false;
            runningLoadAccount();
        }
        int stt = 0;

        string fileLoad = @".\Account.txt";
        string fileExport = @".\AccountOut.txt";

        #region Methods

        public void LoadAccount(string filePath)
        {
            lblStatus.Text = "Status: Loading!";
            //Load Data(Dưới dạng csdl)
            StreamReader file = new StreamReader(filePath);
            string[] all = file.ReadToEnd().Split('\n');
            if (all.Length > 0)
            {
                //Create Data(Tạo Data lưu dữ liệu)
                DataTable data = new DataTable();

                data.Columns.Add("STT");
                data.Columns.Add("ID");
                data.Columns.Add("PASSWORD");
                data.Columns.Add("TOKEN");
                data.Columns.Add("EMAIL");
                data.Columns.Add("PHONE");
                data.Columns.Add("NAME");
                data.Columns.Add("FRIENDS");
                data.Columns.Add("GROUPS");
                data.Columns.Add("BIRTHDAY");
                data.Columns.Add("GENDER");
                data.Columns.Add("BACKUP DATE");
                data.Columns.Add("STATUS");

                stt = 0;
                for (int i = 0; i < all.Length - 1; i++)
                {
                    string[] strLoad = all[i].Split('|');

                    DataRow dr = data.NewRow();

                    stt++;
                    dr["STT"] = stt;

                    for (int j = 0; j < strLoad.Length; j++)
                    {
                        if (strLoad[j].Split(':')[0] == "id") dr["ID"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "password") dr["PASSWORD"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "token") dr["TOKEN"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "email") dr["EMAIL"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "phone") dr["PHONE"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "name") dr["NAME"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "friends") dr["FRIENDS"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "groups") dr["GROUPS"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "birthday") dr["BIRTHDAY"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "gender") dr["GENDER"] = strLoad[j].Split(':')[1];
                        if (strLoad[j].Split(':')[0] == "backup date") dr["BACKUP DATE"] = null;
                        if (strLoad[j].Split(':')[0] == "status") dr["STATUS"] = strLoad[j].Split(':')[1];
                    }

                    data.Rows.Add(dr);
                }
                file.Close();
                ///
                //Load Data
                ///
                dtgvLoad.DataSource = data;

                txtID.DataBindings.Clear();
                txtID.DataBindings.Add("text", data, "ID");
                txtPassword.DataBindings.Clear();
                txtPassword.DataBindings.Add("text", data, "PASSWORD");
                txtToken.DataBindings.Clear();
                txtToken.DataBindings.Add("text", data, "TOKEN");
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("text", data, "EMAIL");
                txtPhone.DataBindings.Clear();
                txtPhone.DataBindings.Add("text", data, "PHONE");
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("text", data, "NAME");
                txtFriends.DataBindings.Clear();
                txtFriends.DataBindings.Add("text", data, "FRIENDS");
                txtGroups.DataBindings.Clear();
                txtGroups.DataBindings.Add("text", data, "GROUPS");
                txtBirthday.DataBindings.Clear();
                txtBirthday.DataBindings.Add("text", data, "BIRTHDAY");
                cbGender.DataBindings.Clear();
                cbGender.DataBindings.Add("text", data, "GENDER");
                txtBackupdate.DataBindings.Clear();
                txtBackupdate.DataBindings.Add("text", data, "BACKUP DATE");
                txtStatus.DataBindings.Clear();
                txtStatus.DataBindings.Add("text", data, "STATUS");
                //More Option(Tuỳ chỉnh thêm cho đẹp :)))
                dtgvLoad.RowHeadersVisible = false;

                //              Ẩn một số cột không cần thiết
                ///
                ///
                dtgvLoad.Columns[3].Visible = false;
                dtgvLoad.Columns[4].Visible = false;
                dtgvLoad.Columns[5].Visible = false;
                dtgvLoad.Columns[9].Visible = false;
                dtgvLoad.Columns[10].Visible = false;
                ///
                ///


                dtgvLoad.ReadOnly = true;
                dtgvLoad.AutoGenerateColumns = false; // turn off generate columns (Tắt thêm dòng)
                dtgvLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // fill all columns (Fill dữ liệu dàn đều trên datagridview)
                if (cbShowPassword.Checked == true) dtgvLoad.Columns[2].Visible = true; // show password column (Hiện password)
                else dtgvLoad.Columns[2].Visible = false;
                dtgvLoad.AllowUserToResizeRows = false; // turn off resize rows (Tắt chỉnh độ cao dòng)
                dtgvLoad.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
                dtgvLoad.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Căn giữa Stt
                dtgvLoad.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Căn giữa Birthday
                dtgvLoad.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa Gender
                dtgvLoad.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa Status
                dtgvLoad.Columns[0].Width = 50;

                try
                {
                    if (stt > 0) dtgvLoad.CurrentCell.Selected = false;
                }
                catch { }

                dtgvLoad.AllowUserToAddRows = false;
                lblTotalAccount.Text = "Total Account: " + dtgvLoad.Rows.Count.ToString();
            }
            lblStatus.Text = "Status: Done!";
        }

        // Xuất file
        void ExportFile(string filePath)
        {
            lblStatus.Text = "Status: Loading!";
            
            StreamWriter writer = new StreamWriter(filePath);
            for (int i = 0; i < dtgvLoad.Rows.Count; i++)
            {
                string acc = "id:" + dtgvLoad.Rows[i].Cells[1].Value.ToString() + "|" +
                             "password:" + dtgvLoad.Rows[i].Cells[2].Value.ToString() + "|" +
                             "token:" + dtgvLoad.Rows[i].Cells[3].Value.ToString() + "|" +
                             "email:" + dtgvLoad.Rows[i].Cells[4].Value.ToString() + "|" +
                             "phone:" + dtgvLoad.Rows[i].Cells[5].Value.ToString() + "|" +
                             "name:" + dtgvLoad.Rows[i].Cells[6].Value.ToString() + "|" +
                             "friends:" + dtgvLoad.Rows[i].Cells[7].Value.ToString() + "|" +
                             "groups:" + dtgvLoad.Rows[i].Cells[8].Value.ToString() + "|" +
                             "birthday:" + dtgvLoad.Rows[i].Cells[9].Value.ToString() + "|" +
                             "gender:" + dtgvLoad.Rows[i].Cells[10].Value.ToString() + "|" +
                             "backup date:" + dtgvLoad.Rows[i].Cells[11].Value.ToString() + "|" +
                             "status:" + dtgvLoad.Rows[i].Cells[12].Value.ToString();
                writer.WriteLine(acc);
            }
            writer.Close();
            lblStatus.Text = "Status: Done!";
        }

        // Login 1 account với i là stt của account trong datagridview
        void LoginOneIdPass(int i)
        {
            // Vài thủ tục loại bỏ noti
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true; // to hide cmd
            ChromeDriver chrome = new ChromeDriver(service, options);
            chrome.Navigate().GoToUrl("https://facebook.com");

            // get uid & password from DataGridView
            string uid = dtgvLoad[1, i].Value.ToString();
            string passWord = dtgvLoad[2, i].Value.ToString();

            // fill uid & password
            chrome.FindElementById("email").SendKeys(uid);
            chrome.FindElementById("pass").SendKeys(passWord);

            // login
            chrome.FindElementById("loginbutton").Click();
        }

        // Login toàn bộ account được chọn
        void LoginFullSelectedIdPass()
        {
            lblStatus.Text = "Status: Loading!";
            int count = 0; // Đếm tài khoản không có pass

            // Check number of selected rows
            if (dtgvLoad.SelectedRows.Count != 0)
            {
                // Login all selected rows
                for (int i = dtgvLoad.RowCount - 1; i >= 0; i--)
                {
                    
                    if (dtgvLoad[1, i].Selected)
                    {
                        if (dtgvLoad[2, i].Value.ToString() != "")
                        {
                            LoginOneIdPass(i);
                        }
                        else count++;
                    }
                }

                if (count > 0)
                    if (dtgvLoad.SelectedRows.Count == count)
                    {
                        MessageBox.Show("All account selected haven't password!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Total " + count + " account haven't password!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Not Selected yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            lblStatus.Text = "Status: Done!";
        }

        // Login 1 account bằng cookie
        void LoginOneCookie(int stt)
        {
            //get cookies from token

            string token = dtgvLoad[3, stt].Value.ToString(); // Token's Location (Vị trí lấy token trong datagridview)

            RequestHTTP request = new RequestHTTP();
            string htmlCookie = request.Request("GET", "https://api.facebook.com/method/auth.getSessionforApp?access_token=" + token + "&format=json&new_app_id=165907476854626&generate_session_cookies=1");
            var json_serializer = new JavaScriptSerializer();
            var obj = json_serializer.Deserialize<dynamic>(htmlCookie);

            List<Cookie> listCookies = new List<Cookie>();
            for (int i = 0; i < obj["session_cookies"].Length; i++)
            {
                Cookie cok = new Cookie(obj["session_cookies"][i]["name"], obj["session_cookies"][i]["value"], ".facebook.com", "/", DateTime.Now.AddDays(10));
                listCookies.Add(cok);
            }

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeDriver chrome = new ChromeDriver(service, options);
            chrome.Navigate().GoToUrl("https://facebook.com");

            foreach (Cookie item in listCookies)
            {
                chrome.Manage().Cookies.AddCookie(item);
            }

            chrome.Navigate().GoToUrl("https://facebook.com");
        }

        // Login toàn bộ account đã chọn bằng cookie
        void LoginFullSelectedCookie()
        {
            int error = 0;
            lblStatus.Text = "Status: Loading!";
            // Check number of selected rows
            if (dtgvLoad.SelectedRows.Count != 0)
            {
                // Login all selected rows
                for (int i = dtgvLoad.RowCount - 1; i >= 0; i--)
                {
                    if (dtgvLoad[1, i].Selected)
                    {
                        try
                        {
                            LoginOneCookie(i);
                        }
                        catch
                        {
                            error++;
                        }
                    }
                }
                if (error > 0) MessageBox.Show(error + " Account login error!");
            }
            else
            {
                MessageBox.Show("Not Selected yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            lblStatus.Text = "Status: Done!";
        }


        void UpStatusOneAccount(int stt)
        {
            // Vài thủ tục loại bỏ noti
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true; // to hide cmd
            ChromeDriver chrome = new ChromeDriver(service, options);
            chrome.Navigate().GoToUrl("https://facebook.com");

            // get uid & password from DataGridView
            string uid = dtgvLoad[1, stt].Value.ToString();
            string passWord = dtgvLoad[2, stt].Value.ToString();

            // fill uid & password
            chrome.FindElementById("email").SendKeys(uid);
            chrome.FindElementById("pass").SendKeys(passWord);

            // login
            chrome.FindElementById("loginbutton").Click();

            //chrome.Close();
        }

        // Login toàn bộ account đã chọn bằng cookie
        void UpStatusFullSelectedAccount()
        {
            int error = 0;
            lblStatus.Text = "Status: Loading!";
            // Check number of selected rows
            if (dtgvLoad.SelectedRows.Count != 0)
            {
                // Login all selected rows
                for (int i = dtgvLoad.RowCount - 1; i >= 0; i--)
                {
                    if (dtgvLoad[1, i].Selected)
                    {
                        try
                        {
                            UpStatusOneAccount(i);
                        }
                        catch
                        {
                            error++;
                        }
                    }
                }
                if (error > 0) MessageBox.Show(error + " Account Login Error!");
            }
            else
            {
                MessageBox.Show("Not Selected yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            lblStatus.Text = "Status: Done!";
        }

        void CheckFullSelectedAccount()
        {
            int live = 0;
            string token = "";
            lblStatus.Text = "Status: Loading!";
            // Check number of selected rows
            if (dtgvLoad.SelectedRows.Count != 0)
            {
                // Login all selected rows
                for (int i = dtgvLoad.RowCount - 1; i >= 0; i--)
                {
                    token = dtgvLoad[3, i].Value.ToString();
                    // Kiểm tra token không rỗng và được chọn
                    if (dtgvLoad[3, i].Selected && token.Length > 10)
                    {
                        RequestHTTP request = new RequestHTTP();
                        string htmlInfo = request.Request("GET", "https://graph.facebook.com/v2.11/me?fields=id,email,mobile_phone,name,birthday,gender&access_token=" + token);
                        htmlInfo = htmlInfo.Remove(htmlInfo.IndexOf('}'));
                        htmlInfo = htmlInfo.Substring(1);
                        htmlInfo = htmlInfo.Replace('"', ' ');
                        htmlInfo = htmlInfo.Replace(",", "|");
                        htmlInfo = htmlInfo.Replace(" ", string.Empty);

                        string strInfo = htmlInfo.Split('|')[0];

                        // Khởi tạo từng thông tin
                        string id = "";
                        string status = "";
                        if (strInfo.Split(':')[0] == "id") id = strInfo.Split(':')[1];

                        if (id.Length > 0)
                        {
                            status = "live";
                            live++;
                        }
                        else
                        {
                            status = "die";
                        }
                        dtgvLoad[12, i].Value = status;
                    }
                }
                MessageBox.Show(live + " Account live & " + (dtgvLoad.SelectedRows.Count - live) + " Account died!");
            }
            else
            {
                MessageBox.Show("Not Selected yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            lblStatus.Text = "Status: Done!";
        }

        #endregion

        private void btnLoadAccount_Click(object sender, EventArgs e)
        {
            dtgvLoad.Hide();
            btnLoadAccount.Enabled = false;
            dtgvLoad.DataSource = null;
            dtgvLoad.Refresh();
            new Thread(new ThreadStart(runningLoadAccount)).Start();
        }

        private void runningLoadAccount()
        {
            LoadAccount(fileLoad);
            btnLoadAccount.Enabled = true;
            dtgvLoad.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            new Thread(new ThreadStart(runningExport)).Start();
        }

        private void runningExport()
        {
            ExportFile(fileExport);
            btnExport.Enabled = true;
        }

        private void ctmsDelete_Click(object sender, EventArgs e)
        {
            if (dtgvLoad.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Delete?", "Notification!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtgvLoad.SelectedRows)
                    {
                        dtgvLoad.Rows.Remove(row);
                    }
                    lblTotalAccount.Text = "Total Account: " + (dtgvLoad.Rows.Count).ToString();
                    if (dtgvLoad.Rows.Count > 0) dtgvLoad.CurrentCell.Selected = false;
                }
            }
            else
            {
                MessageBox.Show("Not Selected yet!", "Notification!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLoginCookie_Click(object sender, EventArgs e)
        {
            LoginFullSelectedCookie();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dtgvLoad.DataSource != null)
            {
                dtgvLoad.DataSource = null;
                dtgvLoad.Refresh();
                txtID.Text = "";
                txtPassword.Text = "";
                txtToken.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtName.Text = "";
                txtFriends.Text = "";
                txtBirthday.Text = "";
                cbGender.Text = "";
                txtBackupdate.Text = "";
                txtStatus.Text = "";
                lblTotalAccount.Text = "Total Account: " + (dtgvLoad.Rows.Count).ToString() ;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frmAddingQuestion quest = new frmAddingQuestion();
            quest.Show();
        }

        private void frmAccountManagerment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quit?", "Oops!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes) e.Cancel = true;
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "File Load";
            openFileDialog.InitialDirectory = @".\";  //Thư mục mặc định khi mở
            openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";  // Lọc ra những file cần hiển thị
            openFileDialog.FilterIndex = 2;  //chúng ta có All files là 1, exe là 2 
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLoad = openFileDialog.FileName;  //đường dẫn của file nhập
            }
        }

        private void btnFileExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "File Export";
            openFileDialog.InitialDirectory = @".\";  //Thư mục mặc định khi mở
            openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";  // Lọc ra những file cần hiển thị
            openFileDialog.FilterIndex = 2;  //chúng ta có All files là 1,exe là 2 
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileExport = openFileDialog.FileName;  //đường dẫn của file xuất
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true) dtgvLoad.Columns[2].Visible = true; // show password column (Hiện password)
                else dtgvLoad.Columns[2].Visible = false;
        }

        private void btnLoginIDPass_Click(object sender, EventArgs e)
        {
            LoginFullSelectedIdPass();
        }

        private void frmAccountManagerment_Click(object sender, EventArgs e)
        {
            dtgvLoad.ClearSelection();
            tsmiSelectAll.Text = "Select All";
            this.ActiveControl = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            if (dtgvLoad.SelectedRows.Count != dtgvLoad.Rows.Count)
            {
                tsmiSelectAll.Text = "Unselect All";
                dtgvLoad.SelectAll();
            }
            else
            {
                dtgvLoad.ClearSelection();
                tsmiSelectAll.Text = "Select All";
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar==true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "Show";
            }
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            if (grbAccountInfo.Enabled==false)
            {
                grbAccountInfo.Enabled = true;
                btnEditMode.Text = "Normal Mode";
            }
            else
            {
                grbAccountInfo.Enabled = false;
                btnEditMode.Text = "Edit Mode";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dtgvLoad.Refresh();
            MessageBox.Show("Updating Success!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAccountManagerment_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/sonlh98ba");
        }

        private void btnUpStatus_Click(object sender, EventArgs e)
        {
            UpStatusFullSelectedAccount();
        }

        private void btnCheckLive_Click(object sender, EventArgs e)
        {
            CheckFullSelectedAccount();
        }

    }
}
