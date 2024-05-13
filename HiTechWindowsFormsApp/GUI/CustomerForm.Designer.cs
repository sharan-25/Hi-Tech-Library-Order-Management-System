namespace HiTechWindowsFormsApp.GUI
{
    partial class CustomerForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewListCustomersDB = new System.Windows.Forms.DataGridView();
            this.button_ListCustomersfromDB = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCustomerCredtLimit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCustomerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerLastName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFaxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBoxCustomerStreet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCustomerCity = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ListCustomersfromDS = new System.Windows.Forms.Button();
            this.dataGridViewListCustomersDS = new System.Windows.Forms.DataGridView();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomersDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(425, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "Customer Management System";
            // 
            // dataGridViewListCustomersDB
            // 
            this.dataGridViewListCustomersDB.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewListCustomersDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCustomersDB.Location = new System.Drawing.Point(44, 475);
            this.dataGridViewListCustomersDB.Name = "dataGridViewListCustomersDB";
            this.dataGridViewListCustomersDB.RowHeadersWidth = 51;
            this.dataGridViewListCustomersDB.RowTemplate.Height = 24;
            this.dataGridViewListCustomersDB.Size = new System.Drawing.Size(538, 209);
            this.dataGridViewListCustomersDB.TabIndex = 28;
            // 
            // button_ListCustomersfromDB
            // 
            this.button_ListCustomersfromDB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_ListCustomersfromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListCustomersfromDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ListCustomersfromDB.Location = new System.Drawing.Point(81, 426);
            this.button_ListCustomersfromDB.Name = "button_ListCustomersfromDB";
            this.button_ListCustomersfromDB.Size = new System.Drawing.Size(257, 43);
            this.button_ListCustomersfromDB.TabIndex = 27;
            this.button_ListCustomersfromDB.Text = "List Customers From DB";
            this.button_ListCustomersfromDB.UseVisualStyleBackColor = false;
            this.button_ListCustomersfromDB.Click += new System.EventHandler(this.button_ListCustomersfromDB_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.Location = new System.Drawing.Point(611, 359);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(108, 43);
            this.button_Delete.TabIndex = 26;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.Location = new System.Drawing.Point(729, 359);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(181, 43);
            this.button_Update.TabIndex = 25;
            this.button_Update.Text = "Update Database";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxCustomerCredtLimit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxCustomerFirstName);
            this.groupBox1.Controls.Add(this.textBoxCustomerLastName);
            this.groupBox1.Controls.Add(this.textBoxCustomerFaxNumber);
            this.groupBox1.Controls.Add(this.textBoxCustomerPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxCustomerID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 278);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerData";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(480, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "$ 10000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(168, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "1-416-555-1234";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(480, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "(438)123-1111";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(168, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "3 digits";
            // 
            // textBoxCustomerCredtLimit
            // 
            this.textBoxCustomerCredtLimit.Location = new System.Drawing.Point(483, 162);
            this.textBoxCustomerCredtLimit.Name = "textBoxCustomerCredtLimit";
            this.textBoxCustomerCredtLimit.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerCredtLimit.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Credit Limit";
            // 
            // textBoxCustomerFirstName
            // 
            this.textBoxCustomerFirstName.Location = new System.Drawing.Point(483, 44);
            this.textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            this.textBoxCustomerFirstName.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerFirstName.TabIndex = 14;
            // 
            // textBoxCustomerLastName
            // 
            this.textBoxCustomerLastName.Location = new System.Drawing.Point(171, 103);
            this.textBoxCustomerLastName.Name = "textBoxCustomerLastName";
            this.textBoxCustomerLastName.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerLastName.TabIndex = 13;
            // 
            // textBoxCustomerFaxNumber
            // 
            this.textBoxCustomerFaxNumber.Location = new System.Drawing.Point(171, 159);
            this.textBoxCustomerFaxNumber.Name = "textBoxCustomerFaxNumber";
            this.textBoxCustomerFaxNumber.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerFaxNumber.TabIndex = 10;
            // 
            // textBoxCustomerPhoneNumber
            // 
            this.textBoxCustomerPhoneNumber.Location = new System.Drawing.Point(483, 109);
            this.textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            this.textBoxCustomerPhoneNumber.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerPhoneNumber.TabIndex = 9;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(171, 44);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "PhoneNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "FaxNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enter Customer ID";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(28, 105);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerSearch.TabIndex = 15;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search.Location = new System.Drawing.Point(45, 169);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(108, 43);
            this.button_Search.TabIndex = 18;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "City";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Location = new System.Drawing.Point(383, 359);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(108, 43);
            this.button_Save.TabIndex = 24;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBoxCustomerStreet
            // 
            this.textBoxCustomerStreet.Location = new System.Drawing.Point(106, 48);
            this.textBoxCustomerStreet.Name = "textBoxCustomerStreet";
            this.textBoxCustomerStreet.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerStreet.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "PostalCode";
            // 
            // textBoxCustomerPostalCode
            // 
            this.textBoxCustomerPostalCode.Location = new System.Drawing.Point(108, 172);
            this.textBoxCustomerPostalCode.Name = "textBoxCustomerPostalCode";
            this.textBoxCustomerPostalCode.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerPostalCode.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxCustomerCity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxCustomerPostalCode);
            this.groupBox2.Controls.Add(this.textBoxCustomerStreet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(832, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 267);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(103, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "1233 Du Fort";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(103, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "H3H 3B1";
            // 
            // textBoxCustomerCity
            // 
            this.textBoxCustomerCity.Location = new System.Drawing.Point(108, 111);
            this.textBoxCustomerCity.Name = "textBoxCustomerCity";
            this.textBoxCustomerCity.Size = new System.Drawing.Size(142, 24);
            this.textBoxCustomerCity.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_Search);
            this.groupBox3.Controls.Add(this.textBoxCustomerSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1127, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 267);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Customer";
            // 
            // button_ListCustomersfromDS
            // 
            this.button_ListCustomersfromDS.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_ListCustomersfromDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListCustomersfromDS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ListCustomersfromDS.Location = new System.Drawing.Point(885, 426);
            this.button_ListCustomersfromDS.Name = "button_ListCustomersfromDS";
            this.button_ListCustomersfromDS.Size = new System.Drawing.Size(244, 43);
            this.button_ListCustomersfromDS.TabIndex = 31;
            this.button_ListCustomersfromDS.Text = "List Customers From DS";
            this.button_ListCustomersfromDS.UseVisualStyleBackColor = false;
            this.button_ListCustomersfromDS.Click += new System.EventHandler(this.button_ListCustomersfromDS_Click);
            // 
            // dataGridViewListCustomersDS
            // 
            this.dataGridViewListCustomersDS.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewListCustomersDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCustomersDS.Location = new System.Drawing.Point(611, 475);
            this.dataGridViewListCustomersDS.Name = "dataGridViewListCustomersDS";
            this.dataGridViewListCustomersDS.RowHeadersWidth = 51;
            this.dataGridViewListCustomersDS.RowTemplate.Height = 24;
            this.dataGridViewListCustomersDS.Size = new System.Drawing.Size(538, 209);
            this.dataGridViewListCustomersDS.TabIndex = 32;
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Modify.Location = new System.Drawing.Point(497, 359);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(108, 43);
            this.button_Modify.TabIndex = 33;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Close.Location = new System.Drawing.Point(588, 715);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(108, 43);
            this.button_Close.TabIndex = 34;
            this.button_Close.Text = "LogOut";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__11_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1375, 770);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.dataGridViewListCustomersDS);
            this.Controls.Add(this.button_ListCustomersfromDS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewListCustomersDB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_ListCustomersfromDB);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Save);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CustomerForm";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomersDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCustomersDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewListCustomersDB;
        private System.Windows.Forms.Button button_ListCustomersfromDB;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.TextBox textBoxCustomerFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerLastName;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBoxCustomerFaxNumber;
        private System.Windows.Forms.TextBox textBoxCustomerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBoxCustomerStreet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCustomerPostalCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCustomerCredtLimit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCustomerCity;
        private System.Windows.Forms.Button button_ListCustomersfromDS;
        private System.Windows.Forms.DataGridView dataGridViewListCustomersDS;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}