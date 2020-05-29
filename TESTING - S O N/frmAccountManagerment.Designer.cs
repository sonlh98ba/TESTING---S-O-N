namespace TESTING___S_O_N
{
    partial class frmAccountManagerment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagerment));
            this.dtgvLoad = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadAccount = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTotalAccount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLoginCookie = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.btnFileExport = new System.Windows.Forms.Button();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLoginIDPass = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBackupdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGroups = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFriends = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.grbFunctions = new System.Windows.Forms.GroupBox();
            this.btnUpStatus = new System.Windows.Forms.Button();
            this.grbInputFunctions = new System.Windows.Forms.GroupBox();
            this.btnCheckLive = new System.Windows.Forms.Button();
            this.grbOutputFunctions = new System.Windows.Forms.GroupBox();
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoad)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.grbFunctions.SuspendLayout();
            this.grbInputFunctions.SuspendLayout();
            this.grbOutputFunctions.SuspendLayout();
            this.grbAccountInfo.SuspendLayout();
            this.grbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLoad
            // 
            this.dtgvLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvLoad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoad.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvLoad.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvLoad.Location = new System.Drawing.Point(6, 19);
            this.dtgvLoad.Name = "dtgvLoad";
            this.dtgvLoad.ReadOnly = true;
            this.dtgvLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoad.Size = new System.Drawing.Size(636, 350);
            this.dtgvLoad.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAll,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(122, 22);
            this.tsmiSelectAll.Text = "Select All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(122, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.ctmsDelete_Click);
            // 
            // btnLoadAccount
            // 
            this.btnLoadAccount.Location = new System.Drawing.Point(6, 77);
            this.btnLoadAccount.Name = "btnLoadAccount";
            this.btnLoadAccount.Size = new System.Drawing.Size(117, 26);
            this.btnLoadAccount.TabIndex = 2;
            this.btnLoadAccount.Text = "Load Account";
            this.btnLoadAccount.UseVisualStyleBackColor = true;
            this.btnLoadAccount.Click += new System.EventHandler(this.btnLoadAccount_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(190, 77);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 26);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTotalAccount
            // 
            this.lblTotalAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAccount.AutoSize = true;
            this.lblTotalAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAccount.Location = new System.Drawing.Point(725, 505);
            this.lblTotalAccount.Name = "lblTotalAccount";
            this.lblTotalAccount.Size = new System.Drawing.Size(91, 13);
            this.lblTotalAccount.TabIndex = 5;
            this.lblTotalAccount.Text = "Total Account:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(224, 505);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // btnLoginCookie
            // 
            this.btnLoginCookie.Location = new System.Drawing.Point(6, 45);
            this.btnLoginCookie.Name = "btnLoginCookie";
            this.btnLoginCookie.Size = new System.Drawing.Size(166, 26);
            this.btnLoginCookie.TabIndex = 8;
            this.btnLoginCookie.Text = "Login Cookie";
            this.btnLoginCookie.UseVisualStyleBackColor = true;
            this.btnLoginCookie.Click += new System.EventHandler(this.btnLoginCookie_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(6, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 26);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 45);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(117, 26);
            this.btnAddAccount.TabIndex = 14;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::TESTING___S_O_N.Properties.Resources._8___con_lon;
            this.ptbLogo.InitialImage = null;
            this.ptbLogo.Location = new System.Drawing.Point(190, 10);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(105, 61);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 9;
            this.ptbLogo.TabStop = false;
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.Location = new System.Drawing.Point(129, 77);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(68, 26);
            this.btnFileLoad.TabIndex = 15;
            this.btnFileLoad.Text = "File Load";
            this.btnFileLoad.UseVisualStyleBackColor = true;
            this.btnFileLoad.Click += new System.EventHandler(this.btnFileLoad_Click);
            // 
            // btnFileExport
            // 
            this.btnFileExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileExport.Location = new System.Drawing.Point(89, 45);
            this.btnFileExport.Name = "btnFileExport";
            this.btnFileExport.Size = new System.Drawing.Size(95, 26);
            this.btnFileExport.TabIndex = 16;
            this.btnFileExport.Text = "File Export";
            this.btnFileExport.UseVisualStyleBackColor = true;
            this.btnFileExport.Click += new System.EventHandler(this.btnFileExport_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(129, 51);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(111, 16);
            this.cbShowPassword.TabIndex = 17;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnLoginIDPass
            // 
            this.btnLoginIDPass.Location = new System.Drawing.Point(6, 77);
            this.btnLoginIDPass.Name = "btnLoginIDPass";
            this.btnLoginIDPass.Size = new System.Drawing.Size(166, 26);
            this.btnLoginIDPass.TabIndex = 18;
            this.btnLoginIDPass.Text = "Login ID | Password";
            this.btnLoginIDPass.UseVisualStyleBackColor = true;
            this.btnLoginIDPass.Click += new System.EventHandler(this.btnLoginIDPass_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 20;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(223, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(251, 44);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(47, 23);
            this.btnShowPassword.TabIndex = 46;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbGender.Location = new System.Drawing.Point(98, 254);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(62, 20);
            this.cbGender.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(98, 306);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(62, 20);
            this.txtStatus.TabIndex = 43;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 14);
            this.label11.TabIndex = 42;
            this.label11.Text = "Backup Date:";
            // 
            // txtBackupdate
            // 
            this.txtBackupdate.Location = new System.Drawing.Point(98, 280);
            this.txtBackupdate.Name = "txtBackupdate";
            this.txtBackupdate.Size = new System.Drawing.Size(121, 20);
            this.txtBackupdate.TabIndex = 41;
            this.txtBackupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 40;
            this.label10.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 38;
            this.label9.Text = "Birthday:";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(98, 228);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(121, 20);
            this.txtBirthday.TabIndex = 37;
            this.txtBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 36;
            this.label8.Text = "Groups:";
            // 
            // txtGroups
            // 
            this.txtGroups.Location = new System.Drawing.Point(98, 202);
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.Size = new System.Drawing.Size(62, 20);
            this.txtGroups.TabIndex = 35;
            this.txtGroups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 34;
            this.label7.Text = "Friends:";
            // 
            // txtFriends
            // 
            this.txtFriends.Location = new System.Drawing.Point(98, 176);
            this.txtFriends.Name = "txtFriends";
            this.txtFriends.Size = new System.Drawing.Size(62, 20);
            this.txtFriends.TabIndex = 33;
            this.txtFriends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 32;
            this.label6.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(98, 72);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(200, 20);
            this.txtToken.TabIndex = 25;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 14);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(147, 20);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(68, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 14);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // btnEditMode
            // 
            this.btnEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMode.Location = new System.Drawing.Point(6, 77);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(178, 26);
            this.btnEditMode.TabIndex = 22;
            this.btnEditMode.Text = "Edit Mode";
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(148, 14);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© developing by AppleS";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(1046, 505);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(113, 14);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Check for Update!";
            // 
            // grbFunctions
            // 
            this.grbFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFunctions.Controls.Add(this.txtUpStatus);
            this.grbFunctions.Controls.Add(this.btnUpStatus);
            this.grbFunctions.Controls.Add(this.btnLoginIDPass);
            this.grbFunctions.Controls.Add(this.btnLoginCookie);
            this.grbFunctions.Location = new System.Drawing.Point(491, 12);
            this.grbFunctions.Name = "grbFunctions";
            this.grbFunctions.Size = new System.Drawing.Size(358, 109);
            this.grbFunctions.TabIndex = 27;
            this.grbFunctions.TabStop = false;
            this.grbFunctions.Text = "Actions";
            // 
            // btnUpStatus
            // 
            this.btnUpStatus.Location = new System.Drawing.Point(178, 77);
            this.btnUpStatus.Name = "btnUpStatus";
            this.btnUpStatus.Size = new System.Drawing.Size(174, 26);
            this.btnUpStatus.TabIndex = 19;
            this.btnUpStatus.Text = "Up Status";
            this.btnUpStatus.UseVisualStyleBackColor = true;
            this.btnUpStatus.Click += new System.EventHandler(this.btnUpStatus_Click);
            // 
            // grbInputFunctions
            // 
            this.grbInputFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInputFunctions.Controls.Add(this.btnCheckLive);
            this.grbInputFunctions.Controls.Add(this.cbShowPassword);
            this.grbInputFunctions.Controls.Add(this.btnFileLoad);
            this.grbInputFunctions.Controls.Add(this.btnLoadAccount);
            this.grbInputFunctions.Controls.Add(this.btnAddAccount);
            this.grbInputFunctions.Location = new System.Drawing.Point(201, 12);
            this.grbInputFunctions.Name = "grbInputFunctions";
            this.grbInputFunctions.Size = new System.Drawing.Size(284, 109);
            this.grbInputFunctions.TabIndex = 18;
            this.grbInputFunctions.TabStop = false;
            this.grbInputFunctions.Text = "Input Functions";
            // 
            // btnCheckLive
            // 
            this.btnCheckLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckLive.Location = new System.Drawing.Point(203, 77);
            this.btnCheckLive.Name = "btnCheckLive";
            this.btnCheckLive.Size = new System.Drawing.Size(75, 26);
            this.btnCheckLive.TabIndex = 18;
            this.btnCheckLive.Text = "Check Live";
            this.btnCheckLive.UseVisualStyleBackColor = true;
            this.btnCheckLive.Click += new System.EventHandler(this.btnCheckLive_Click);
            // 
            // grbOutputFunctions
            // 
            this.grbOutputFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbOutputFunctions.Controls.Add(this.ptbLogo);
            this.grbOutputFunctions.Controls.Add(this.btnClear);
            this.grbOutputFunctions.Controls.Add(this.btnExport);
            this.grbOutputFunctions.Controls.Add(this.btnEditMode);
            this.grbOutputFunctions.Controls.Add(this.btnFileExport);
            this.grbOutputFunctions.Location = new System.Drawing.Point(855, 12);
            this.grbOutputFunctions.Name = "grbOutputFunctions";
            this.grbOutputFunctions.Size = new System.Drawing.Size(301, 109);
            this.grbOutputFunctions.TabIndex = 28;
            this.grbOutputFunctions.TabStop = false;
            this.grbOutputFunctions.Text = "Output Functions";
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAccountInfo.Controls.Add(this.btnUpdate);
            this.grbAccountInfo.Controls.Add(this.txtGroups);
            this.grbAccountInfo.Controls.Add(this.btnShowPassword);
            this.grbAccountInfo.Controls.Add(this.txtID);
            this.grbAccountInfo.Controls.Add(this.cbGender);
            this.grbAccountInfo.Controls.Add(this.lblID);
            this.grbAccountInfo.Controls.Add(this.label2);
            this.grbAccountInfo.Controls.Add(this.txtPassword);
            this.grbAccountInfo.Controls.Add(this.txtStatus);
            this.grbAccountInfo.Controls.Add(this.lblPassword);
            this.grbAccountInfo.Controls.Add(this.label11);
            this.grbAccountInfo.Controls.Add(this.txtToken);
            this.grbAccountInfo.Controls.Add(this.txtBackupdate);
            this.grbAccountInfo.Controls.Add(this.label3);
            this.grbAccountInfo.Controls.Add(this.label10);
            this.grbAccountInfo.Controls.Add(this.txtEmail);
            this.grbAccountInfo.Controls.Add(this.label9);
            this.grbAccountInfo.Controls.Add(this.label4);
            this.grbAccountInfo.Controls.Add(this.txtBirthday);
            this.grbAccountInfo.Controls.Add(this.txtPhone);
            this.grbAccountInfo.Controls.Add(this.label8);
            this.grbAccountInfo.Controls.Add(this.label5);
            this.grbAccountInfo.Controls.Add(this.txtName);
            this.grbAccountInfo.Controls.Add(this.label7);
            this.grbAccountInfo.Controls.Add(this.label6);
            this.grbAccountInfo.Controls.Add(this.txtFriends);
            this.grbAccountInfo.Location = new System.Drawing.Point(855, 127);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Size = new System.Drawing.Size(304, 375);
            this.grbAccountInfo.TabIndex = 29;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "ACCOUNT INFOMATION";
            // 
            // grbData
            // 
            this.grbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbData.Controls.Add(this.dtgvLoad);
            this.grbData.Location = new System.Drawing.Point(201, 127);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(648, 375);
            this.grbData.TabIndex = 30;
            this.grbData.TabStop = false;
            this.grbData.Text = "ALL ACCOUNT";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 375);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 109);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // txtUpStatus
            // 
            this.txtUpStatus.Location = new System.Drawing.Point(178, 19);
            this.txtUpStatus.Multiline = true;
            this.txtUpStatus.Name = "txtUpStatus";
            this.txtUpStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpStatus.Size = new System.Drawing.Size(174, 52);
            this.txtUpStatus.TabIndex = 20;
            // 
            // frmAccountManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1171, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.grbAccountInfo);
            this.Controls.Add(this.grbOutputFunctions);
            this.Controls.Add(this.grbInputFunctions);
            this.Controls.Add(this.grbFunctions);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotalAccount);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountManagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Managerment - MIN SOFTWARE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountManagerment_FormClosing);
            this.Load += new System.EventHandler(this.frmAccountManagerment_Load);
            this.Click += new System.EventHandler(this.frmAccountManagerment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoad)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.grbFunctions.ResumeLayout(false);
            this.grbFunctions.PerformLayout();
            this.grbInputFunctions.ResumeLayout(false);
            this.grbInputFunctions.PerformLayout();
            this.grbOutputFunctions.ResumeLayout(false);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.grbData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLoad;
        private System.Windows.Forms.Button btnLoadAccount;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotalAccount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Button btnLoginCookie;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnFileLoad;
        private System.Windows.Forms.Button btnFileExport;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnLoginIDPass;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBackupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGroups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFriends;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox grbFunctions;
        private System.Windows.Forms.GroupBox grbInputFunctions;
        private System.Windows.Forms.GroupBox grbOutputFunctions;
        private System.Windows.Forms.GroupBox grbAccountInfo;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpStatus;
        private System.Windows.Forms.Button btnCheckLive;
        private System.Windows.Forms.TextBox txtUpStatus;
    }
}

