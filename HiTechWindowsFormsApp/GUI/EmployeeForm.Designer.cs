namespace HiTechWindowsFormsApp.GUI
{
    partial class EmployeeForm
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
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeJobID = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeStatusID = new System.Windows.Forms.ComboBox();
            this.labelSearchEmployee = new System.Windows.Forms.Label();
            this.comboBoxSearchEmployeeOpton = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmployeeSearch = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ListAll = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.dataGridViewListEmployeeData = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployeeData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Location = new System.Drawing.Point(64, 383);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(108, 43);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "PhoneNumber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status ID";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(171, 44);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeeID.TabIndex = 8;
            // 
            // textBoxEmployeePhoneNumber
            // 
            this.textBoxEmployeePhoneNumber.Location = new System.Drawing.Point(171, 94);
            this.textBoxEmployeePhoneNumber.Name = "textBoxEmployeePhoneNumber";
            this.textBoxEmployeePhoneNumber.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeePhoneNumber.TabIndex = 9;
            // 
            // textBoxEmployeeEmail
            // 
            this.textBoxEmployeeEmail.Location = new System.Drawing.Point(465, 162);
            this.textBoxEmployeeEmail.Name = "textBoxEmployeeEmail";
            this.textBoxEmployeeEmail.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeeEmail.TabIndex = 10;
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(465, 97);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeeLastName.TabIndex = 13;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(465, 44);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeeFirstName.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeJobID);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeStatusID);
            this.groupBox1.Controls.Add(this.textBoxEmployeeFirstName);
            this.groupBox1.Controls.Add(this.textBoxEmployeeLastName);
            this.groupBox1.Controls.Add(this.textBoxEmployeeEmail);
            this.groupBox1.Controls.Add(this.textBoxEmployeePhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxEmployeeID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(26, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EmployeeData";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "employee12@gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(168, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "5 digits";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "(438)123-1111";
            // 
            // comboBoxEmployeeJobID
            // 
            this.comboBoxEmployeeJobID.FormattingEnabled = true;
            this.comboBoxEmployeeJobID.Location = new System.Drawing.Point(171, 214);
            this.comboBoxEmployeeJobID.Name = "comboBoxEmployeeJobID";
            this.comboBoxEmployeeJobID.Size = new System.Drawing.Size(121, 26);
            this.comboBoxEmployeeJobID.TabIndex = 21;
            // 
            // comboBoxEmployeeStatusID
            // 
            this.comboBoxEmployeeStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeStatusID.FormattingEnabled = true;
            this.comboBoxEmployeeStatusID.Location = new System.Drawing.Point(171, 154);
            this.comboBoxEmployeeStatusID.Name = "comboBoxEmployeeStatusID";
            this.comboBoxEmployeeStatusID.Size = new System.Drawing.Size(121, 26);
            this.comboBoxEmployeeStatusID.TabIndex = 20;
            // 
            // labelSearchEmployee
            // 
            this.labelSearchEmployee.AutoSize = true;
            this.labelSearchEmployee.Location = new System.Drawing.Point(73, 146);
            this.labelSearchEmployee.Name = "labelSearchEmployee";
            this.labelSearchEmployee.Size = new System.Drawing.Size(85, 18);
            this.labelSearchEmployee.TabIndex = 34;
            this.labelSearchEmployee.Text = "Enter data";
            // 
            // comboBoxSearchEmployeeOpton
            // 
            this.comboBoxSearchEmployeeOpton.FormattingEnabled = true;
            this.comboBoxSearchEmployeeOpton.Items.AddRange(new object[] {
            "Employee Id",
            "First Name",
            "Last Name",
            "Email",
            "Phone Number",
            "JobId",
            "StatusId"});
            this.comboBoxSearchEmployeeOpton.Location = new System.Drawing.Point(76, 109);
            this.comboBoxSearchEmployeeOpton.Name = "comboBoxSearchEmployeeOpton";
            this.comboBoxSearchEmployeeOpton.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchEmployeeOpton.TabIndex = 33;
            this.comboBoxSearchEmployeeOpton.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchEmployeeOpton_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select Search Option";
            // 
            // textBoxEmployeeSearch
            // 
            this.textBoxEmployeeSearch.Location = new System.Drawing.Point(76, 176);
            this.textBoxEmployeeSearch.Name = "textBoxEmployeeSearch";
            this.textBoxEmployeeSearch.Size = new System.Drawing.Size(142, 24);
            this.textBoxEmployeeSearch.TabIndex = 15;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search.Location = new System.Drawing.Point(76, 216);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(108, 43);
            this.button_Search.TabIndex = 18;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.Location = new System.Drawing.Point(215, 383);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(108, 43);
            this.button_Update.TabIndex = 16;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Delete.Location = new System.Drawing.Point(371, 383);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(108, 43);
            this.button_Delete.TabIndex = 17;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_ListAll
            // 
            this.button_ListAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_ListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ListAll.Location = new System.Drawing.Point(543, 383);
            this.button_ListAll.Name = "button_ListAll";
            this.button_ListAll.Size = new System.Drawing.Size(108, 43);
            this.button_ListAll.TabIndex = 19;
            this.button_ListAll.Text = "List All";
            this.button_ListAll.UseVisualStyleBackColor = false;
            this.button_ListAll.Click += new System.EventHandler(this.button_ListAll_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Close.Location = new System.Drawing.Point(1085, 9);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(108, 43);
            this.button_Close.TabIndex = 20;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dataGridViewListEmployeeData
            // 
            this.dataGridViewListEmployeeData.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridViewListEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEmployeeData.Location = new System.Drawing.Point(187, 467);
            this.dataGridViewListEmployeeData.Name = "dataGridViewListEmployeeData";
            this.dataGridViewListEmployeeData.RowHeadersWidth = 51;
            this.dataGridViewListEmployeeData.RowTemplate.Height = 24;
            this.dataGridViewListEmployeeData.Size = new System.Drawing.Size(718, 209);
            this.dataGridViewListEmployeeData.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(366, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Employee Management System";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxSearchEmployeeOpton);
            this.groupBox2.Controls.Add(this.labelSearchEmployee);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxEmployeeSearch);
            this.groupBox2.Controls.Add(this.button_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(764, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 265);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__12_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewListEmployeeData);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_ListAll);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Save);
            this.DoubleBuffered = true;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployeeData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxEmployeePhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmployeeEmail;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_ListAll;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridView dataGridViewListEmployeeData;
        private System.Windows.Forms.TextBox textBoxEmployeeSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEmployeeJobID;
        private System.Windows.Forms.ComboBox comboBoxEmployeeStatusID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSearchEmployee;
        private System.Windows.Forms.ComboBox comboBoxSearchEmployeeOpton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}