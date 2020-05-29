namespace TESTING___S_O_N
{
    partial class frmAddingQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddingQuestion));
            this.btnIDPassword = new System.Windows.Forms.Button();
            this.btnToken = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIDPassword
            // 
            this.btnIDPassword.Location = new System.Drawing.Point(12, 41);
            this.btnIDPassword.Name = "btnIDPassword";
            this.btnIDPassword.Size = new System.Drawing.Size(359, 23);
            this.btnIDPassword.TabIndex = 0;
            this.btnIDPassword.Text = "ID | Password";
            this.btnIDPassword.UseVisualStyleBackColor = true;
            this.btnIDPassword.Click += new System.EventHandler(this.btnIDPassword_Click);
            // 
            // btnToken
            // 
            this.btnToken.Location = new System.Drawing.Point(12, 70);
            this.btnToken.Name = "btnToken";
            this.btnToken.Size = new System.Drawing.Size(359, 23);
            this.btnToken.TabIndex = 1;
            this.btnToken.Text = "ID | Password | Token";
            this.btnToken.UseVisualStyleBackColor = true;
            this.btnToken.Click += new System.EventHandler(this.btnToken_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(296, 118);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "What type of your input data do you want to use?";
            // 
            // frmAddingQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnToken);
            this.Controls.Add(this.btnIDPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddingQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Question!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIDPassword;
        private System.Windows.Forms.Button btnToken;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
    }
}