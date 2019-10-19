namespace MCM_Management_System
{
    partial class ClientAcctMgnt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUpdateClient = new System.Windows.Forms.TabControl();
            this.tabNewClient = new System.Windows.Forms.TabPage();
            this.CustSub = new System.Windows.Forms.Button();
            this.custReset = new System.Windows.Forms.Button();
            this.cScheduleRemarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cScheduleType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cPoolType = new System.Windows.Forms.ComboBox();
            this.cType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cPoolRemarks = new System.Windows.Forms.TextBox();
            this.cAddress = new System.Windows.Forms.TextBox();
            this.cCNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientMgnt = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.sCID = new System.Windows.Forms.TextBox();
            this.sCName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.uScheduleRemarks = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.uScheduleType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.uPoolType = new System.Windows.Forms.ComboBox();
            this.uCustType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.uPoolRemarks = new System.Windows.Forms.TextBox();
            this.uAddress = new System.Windows.Forms.TextBox();
            this.uContactNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.uEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.uCID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabUpdateClient.SuspendLayout();
            this.tabNewClient.SuspendLayout();
            this.tabClientMgnt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUpdateClient
            // 
            this.tabUpdateClient.Controls.Add(this.tabNewClient);
            this.tabUpdateClient.Controls.Add(this.tabClientMgnt);
            this.tabUpdateClient.Controls.Add(this.tabPage1);
            this.tabUpdateClient.Location = new System.Drawing.Point(4, 4);
            this.tabUpdateClient.Name = "tabUpdateClient";
            this.tabUpdateClient.SelectedIndex = 0;
            this.tabUpdateClient.Size = new System.Drawing.Size(601, 445);
            this.tabUpdateClient.TabIndex = 0;
            // 
            // tabNewClient
            // 
            this.tabNewClient.Controls.Add(this.CustSub);
            this.tabNewClient.Controls.Add(this.custReset);
            this.tabNewClient.Controls.Add(this.cScheduleRemarks);
            this.tabNewClient.Controls.Add(this.label9);
            this.tabNewClient.Controls.Add(this.label8);
            this.tabNewClient.Controls.Add(this.cScheduleType);
            this.tabNewClient.Controls.Add(this.label7);
            this.tabNewClient.Controls.Add(this.cPoolType);
            this.tabNewClient.Controls.Add(this.cType);
            this.tabNewClient.Controls.Add(this.label4);
            this.tabNewClient.Controls.Add(this.label5);
            this.tabNewClient.Controls.Add(this.label6);
            this.tabNewClient.Controls.Add(this.cPoolRemarks);
            this.tabNewClient.Controls.Add(this.cAddress);
            this.tabNewClient.Controls.Add(this.cCNumber);
            this.tabNewClient.Controls.Add(this.label3);
            this.tabNewClient.Controls.Add(this.cEmail);
            this.tabNewClient.Controls.Add(this.label2);
            this.tabNewClient.Controls.Add(this.cName);
            this.tabNewClient.Controls.Add(this.label1);
            this.tabNewClient.Location = new System.Drawing.Point(4, 25);
            this.tabNewClient.Name = "tabNewClient";
            this.tabNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewClient.Size = new System.Drawing.Size(593, 416);
            this.tabNewClient.TabIndex = 0;
            this.tabNewClient.Text = "New Client";
            this.tabNewClient.UseVisualStyleBackColor = true;
            // 
            // CustSub
            // 
            this.CustSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSub.Location = new System.Drawing.Point(312, 381);
            this.CustSub.Name = "CustSub";
            this.CustSub.Size = new System.Drawing.Size(269, 29);
            this.CustSub.TabIndex = 20;
            this.CustSub.Text = "Welcome New Customer";
            this.CustSub.UseVisualStyleBackColor = true;
            this.CustSub.Click += new System.EventHandler(this.CustSub_Click);
            // 
            // custReset
            // 
            this.custReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custReset.Location = new System.Drawing.Point(6, 381);
            this.custReset.Name = "custReset";
            this.custReset.Size = new System.Drawing.Size(269, 29);
            this.custReset.TabIndex = 19;
            this.custReset.Text = "Reset";
            this.custReset.UseVisualStyleBackColor = true;
            this.custReset.Click += new System.EventHandler(this.CustReset_Click);
            // 
            // cScheduleRemarks
            // 
            this.cScheduleRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cScheduleRemarks.Location = new System.Drawing.Point(329, 336);
            this.cScheduleRemarks.Name = "cScheduleRemarks";
            this.cScheduleRemarks.Size = new System.Drawing.Size(258, 34);
            this.cScheduleRemarks.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Schedule Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pool Remarks";
            // 
            // cScheduleType
            // 
            this.cScheduleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cScheduleType.FormattingEnabled = true;
            this.cScheduleType.Items.AddRange(new object[] {
            "Monthly",
            "Bi-Weekly (Recommended for hotels)",
            "Weekly ( Recommended for Hotels with Heavy Use)",
            "Bi-Monthly ( Recommeneded for Home Owner)",
            "Special Request (Anytime set earlier in the system)"});
            this.cScheduleType.Location = new System.Drawing.Point(329, 293);
            this.cScheduleType.Name = "cScheduleType";
            this.cScheduleType.Size = new System.Drawing.Size(258, 37);
            this.cScheduleType.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pool Type";
            // 
            // cPoolType
            // 
            this.cPoolType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPoolType.FormattingEnabled = true;
            this.cPoolType.Items.AddRange(new object[] {
            "1: Small size swimming pool",
            "2: Medium size swimming pool",
            "3: Large swimming pool",
            "4: Large and complex swimming pool"});
            this.cPoolType.Location = new System.Drawing.Point(329, 210);
            this.cPoolType.Name = "cPoolType";
            this.cPoolType.Size = new System.Drawing.Size(258, 37);
            this.cPoolType.TabIndex = 13;
            // 
            // cType
            // 
            this.cType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cType.FormattingEnabled = true;
            this.cType.Items.AddRange(new object[] {
            "Hotel",
            "Homeowner",
            "Apartment"});
            this.cType.Location = new System.Drawing.Point(329, 167);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(258, 37);
            this.cType.TabIndex = 12;
            this.cType.SelectedIndexChanged += new System.EventHandler(this.CType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schedule Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // cPoolRemarks
            // 
            this.cPoolRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPoolRemarks.Location = new System.Drawing.Point(329, 253);
            this.cPoolRemarks.Name = "cPoolRemarks";
            this.cPoolRemarks.Size = new System.Drawing.Size(258, 34);
            this.cPoolRemarks.TabIndex = 7;
            // 
            // cAddress
            // 
            this.cAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress.Location = new System.Drawing.Point(329, 127);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(258, 34);
            this.cAddress.TabIndex = 6;
            // 
            // cCNumber
            // 
            this.cCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCNumber.Location = new System.Drawing.Point(329, 87);
            this.cCNumber.Name = "cCNumber";
            this.cCNumber.Size = new System.Drawing.Size(258, 34);
            this.cCNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Number";
            // 
            // cEmail
            // 
            this.cEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEmail.Location = new System.Drawing.Point(329, 47);
            this.cEmail.Name = "cEmail";
            this.cEmail.Size = new System.Drawing.Size(258, 34);
            this.cEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            // 
            // cName
            // 
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.Location = new System.Drawing.Point(329, 7);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(258, 34);
            this.cName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // tabClientMgnt
            // 
            this.tabClientMgnt.Controls.Add(this.btnSearch);
            this.tabClientMgnt.Controls.Add(this.btnClose);
            this.tabClientMgnt.Controls.Add(this.txtBxResult);
            this.tabClientMgnt.Controls.Add(this.sCID);
            this.tabClientMgnt.Controls.Add(this.sCName);
            this.tabClientMgnt.Controls.Add(this.label11);
            this.tabClientMgnt.Controls.Add(this.label10);
            this.tabClientMgnt.Location = new System.Drawing.Point(4, 25);
            this.tabClientMgnt.Name = "tabClientMgnt";
            this.tabClientMgnt.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientMgnt.Size = new System.Drawing.Size(593, 416);
            this.tabClientMgnt.TabIndex = 1;
            this.tabClientMgnt.Text = "Client Account Mgnt";
            this.tabClientMgnt.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(258, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(255, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close Account";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(4, 123);
            this.txtBxResult.Multiline = true;
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(583, 251);
            this.txtBxResult.TabIndex = 5;
            // 
            // sCID
            // 
            this.sCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCID.Location = new System.Drawing.Point(332, 46);
            this.sCID.Name = "sCID";
            this.sCID.Size = new System.Drawing.Size(258, 34);
            this.sCID.TabIndex = 4;
            // 
            // sCName
            // 
            this.sCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCName.Location = new System.Drawing.Point(332, 6);
            this.sCName.Name = "sCName";
            this.sCName.Size = new System.Drawing.Size(258, 34);
            this.sCName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Client ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Client Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClearAll);
            this.tabPage1.Controls.Add(this.btnClientUpdate);
            this.tabPage1.Controls.Add(this.uScheduleRemarks);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.uScheduleType);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.uPoolType);
            this.tabPage1.Controls.Add(this.uCustType);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.uPoolRemarks);
            this.tabPage1.Controls.Add(this.uAddress);
            this.tabPage1.Controls.Add(this.uContactNumber);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.uEmail);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.btnUpdateClient);
            this.tabPage1.Controls.Add(this.uCID);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 416);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update Client Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(11, 375);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(241, 35);
            this.btnClearAll.TabIndex = 36;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(342, 375);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(241, 35);
            this.btnClientUpdate.TabIndex = 35;
            this.btnClientUpdate.Text = "Update Client Information";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            // 
            // uScheduleRemarks
            // 
            this.uScheduleRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uScheduleRemarks.Location = new System.Drawing.Point(342, 335);
            this.uScheduleRemarks.Name = "uScheduleRemarks";
            this.uScheduleRemarks.Size = new System.Drawing.Size(241, 34);
            this.uScheduleRemarks.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 29);
            this.label13.TabIndex = 33;
            this.label13.Text = "Schedule Remarks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 29);
            this.label14.TabIndex = 32;
            this.label14.Text = "Pool Remarks";
            // 
            // uScheduleType
            // 
            this.uScheduleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uScheduleType.FormattingEnabled = true;
            this.uScheduleType.Items.AddRange(new object[] {
            "Monthly",
            "Bi-Weekly (Recommended for hotels)",
            "Weekly ( Recommended for Hotels with Heavy Use)",
            "Bi-Monthly ( Recommeneded for Home Owner)",
            "Special Request (Anytime set earlier in the system)"});
            this.uScheduleType.Location = new System.Drawing.Point(342, 292);
            this.uScheduleType.Name = "uScheduleType";
            this.uScheduleType.Size = new System.Drawing.Size(241, 37);
            this.uScheduleType.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 29);
            this.label15.TabIndex = 30;
            this.label15.Text = "Pool Type";
            // 
            // uPoolType
            // 
            this.uPoolType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPoolType.FormattingEnabled = true;
            this.uPoolType.Items.AddRange(new object[] {
            "1: Small size swimming pool",
            "2: Medium size swimming pool",
            "3: Large swimming pool",
            "4: Large and complex swimming pool"});
            this.uPoolType.Location = new System.Drawing.Point(342, 209);
            this.uPoolType.Name = "uPoolType";
            this.uPoolType.Size = new System.Drawing.Size(241, 37);
            this.uPoolType.TabIndex = 29;
            // 
            // uCustType
            // 
            this.uCustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCustType.FormattingEnabled = true;
            this.uCustType.Items.AddRange(new object[] {
            "Hotel",
            "Homeowner",
            "Apartment"});
            this.uCustType.Location = new System.Drawing.Point(342, 166);
            this.uCustType.Name = "uCustType";
            this.uCustType.Size = new System.Drawing.Size(241, 37);
            this.uCustType.TabIndex = 28;
            this.uCustType.SelectedIndexChanged += new System.EventHandler(this.UCustType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 29);
            this.label16.TabIndex = 27;
            this.label16.Text = "Customer Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 29);
            this.label17.TabIndex = 26;
            this.label17.Text = "Schedule Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 29);
            this.label18.TabIndex = 25;
            this.label18.Text = "Address";
            // 
            // uPoolRemarks
            // 
            this.uPoolRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPoolRemarks.Location = new System.Drawing.Point(342, 252);
            this.uPoolRemarks.Name = "uPoolRemarks";
            this.uPoolRemarks.Size = new System.Drawing.Size(241, 34);
            this.uPoolRemarks.TabIndex = 24;
            // 
            // uAddress
            // 
            this.uAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uAddress.Location = new System.Drawing.Point(342, 126);
            this.uAddress.Name = "uAddress";
            this.uAddress.Size = new System.Drawing.Size(241, 34);
            this.uAddress.TabIndex = 23;
            // 
            // uContactNumber
            // 
            this.uContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uContactNumber.Location = new System.Drawing.Point(342, 86);
            this.uContactNumber.Name = "uContactNumber";
            this.uContactNumber.Size = new System.Drawing.Size(241, 34);
            this.uContactNumber.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 29);
            this.label19.TabIndex = 21;
            this.label19.Text = "Contact Number";
            // 
            // uEmail
            // 
            this.uEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uEmail.Location = new System.Drawing.Point(342, 46);
            this.uEmail.Name = "uEmail";
            this.uEmail.Size = new System.Drawing.Size(241, 34);
            this.uEmail.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 29);
            this.label20.TabIndex = 19;
            this.label20.Text = "E-mail";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(342, 6);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(241, 34);
            this.btnUpdateClient.TabIndex = 12;
            this.btnUpdateClient.Text = "Search";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
            // 
            // uCID
            // 
            this.uCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCID.Location = new System.Drawing.Point(116, 6);
            this.uCID.Name = "uCID";
            this.uCID.Size = new System.Drawing.Size(220, 34);
            this.uCID.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Client ID";
            // 
            // ClientAcctMgnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabUpdateClient);
            this.Name = "ClientAcctMgnt";
            this.Size = new System.Drawing.Size(605, 449);
            this.tabUpdateClient.ResumeLayout(false);
            this.tabNewClient.ResumeLayout(false);
            this.tabNewClient.PerformLayout();
            this.tabClientMgnt.ResumeLayout(false);
            this.tabClientMgnt.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUpdateClient;
        private System.Windows.Forms.TabPage tabNewClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cPoolType;
        private System.Windows.Forms.ComboBox cType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cPoolRemarks;
        private System.Windows.Forms.TextBox cAddress;
        private System.Windows.Forms.TextBox cCNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabClientMgnt;
        private System.Windows.Forms.Button CustSub;
        private System.Windows.Forms.Button custReset;
        private System.Windows.Forms.TextBox cScheduleRemarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cScheduleType;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.TextBox sCID;
        private System.Windows.Forms.TextBox sCName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox uCID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.TextBox uScheduleRemarks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox uScheduleType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox uPoolType;
        private System.Windows.Forms.ComboBox uCustType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox uPoolRemarks;
        private System.Windows.Forms.TextBox uAddress;
        private System.Windows.Forms.TextBox uContactNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox uEmail;
        private System.Windows.Forms.Label label20;
    }
}
