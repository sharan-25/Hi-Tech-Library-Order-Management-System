namespace HiTechWindowsFormsApp.GUI
{
    partial class OrdersForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchOrders = new System.Windows.Forms.ComboBox();
            this.labelOrderSearch = new System.Windows.Forms.Label();
            this.textBoxOrderSearch = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.button_ListAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderCustomerID = new System.Windows.Forms.ComboBox();
            this.textBoxOrderQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSerachBookOrders = new System.Windows.Forms.ComboBox();
            this.labelSearchBookOrders = new System.Windows.Forms.Label();
            this.textBoxBookOrderSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewBookOrders = new System.Windows.Forms.DataGridView();
            this.buttonListAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxBookOrdersOrderId = new System.Windows.Forms.ComboBox();
            this.comboBoxBookOrderISBN = new System.Windows.Forms.ComboBox();
            this.textBoxBookOrderId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__5_;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.dataGridViewOrders);
            this.tabPage1.Controls.Add(this.button_ListAll);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button_Update);
            this.tabPage1.Controls.Add(this.button_Save);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OrderDetails";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboBoxSearchOrders);
            this.groupBox4.Controls.Add(this.labelOrderSearch);
            this.groupBox4.Controls.Add(this.textBoxOrderSearch);
            this.groupBox4.Controls.Add(this.button_Search);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(842, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 278);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Orders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Select Search Option";
            // 
            // comboBoxSearchOrders
            // 
            this.comboBoxSearchOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOrders.FormattingEnabled = true;
            this.comboBoxSearchOrders.Items.AddRange(new object[] {
            "Order Id",
            "Order Date",
            "Total Amount",
            "Order Status",
            "Order Type",
            "Customer Id",
            "Order Quantity"});
            this.comboBoxSearchOrders.Location = new System.Drawing.Point(31, 76);
            this.comboBoxSearchOrders.Name = "comboBoxSearchOrders";
            this.comboBoxSearchOrders.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchOrders.TabIndex = 33;
            this.comboBoxSearchOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchOrders_SelectedIndexChanged);
            // 
            // labelOrderSearch
            // 
            this.labelOrderSearch.AutoSize = true;
            this.labelOrderSearch.Location = new System.Drawing.Point(28, 120);
            this.labelOrderSearch.Name = "labelOrderSearch";
            this.labelOrderSearch.Size = new System.Drawing.Size(85, 18);
            this.labelOrderSearch.TabIndex = 19;
            this.labelOrderSearch.Text = "Enter data";
            // 
            // textBoxOrderSearch
            // 
            this.textBoxOrderSearch.Location = new System.Drawing.Point(31, 148);
            this.textBoxOrderSearch.Name = "textBoxOrderSearch";
            this.textBoxOrderSearch.Size = new System.Drawing.Size(142, 24);
            this.textBoxOrderSearch.TabIndex = 15;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search.Location = new System.Drawing.Point(31, 191);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(108, 43);
            this.button_Search.TabIndex = 18;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(73, 423);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(718, 149);
            this.dataGridViewOrders.TabIndex = 49;
            // 
            // button_ListAll
            // 
            this.button_ListAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_ListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ListAll.Location = new System.Drawing.Point(551, 350);
            this.button_ListAll.Name = "button_ListAll";
            this.button_ListAll.Size = new System.Drawing.Size(108, 43);
            this.button_ListAll.TabIndex = 48;
            this.button_ListAll.Text = "List All";
            this.button_ListAll.UseVisualStyleBackColor = false;
            this.button_ListAll.Click += new System.EventHandler(this.button_ListAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Order Management System";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.Location = new System.Drawing.Point(380, 350);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(108, 43);
            this.button_Delete.TabIndex = 47;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerOrderDate);
            this.groupBox1.Controls.Add(this.comboBoxOrderType);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBoxOrderStatus);
            this.groupBox1.Controls.Add(this.comboBoxOrderCustomerID);
            this.groupBox1.Controls.Add(this.textBoxOrderQuantity);
            this.groupBox1.Controls.Add(this.textBoxOrderTotalAmount);
            this.groupBox1.Controls.Add(this.textBoxOrderId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 278);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OrderData";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(474, 100);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerOrderDate.TabIndex = 35;
            // 
            // comboBoxOrderType
            // 
            this.comboBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderType.FormattingEnabled = true;
            this.comboBoxOrderType.Items.AddRange(new object[] {
            "Phone",
            "Fax",
            "Email"});
            this.comboBoxOrderType.Location = new System.Drawing.Point(465, 41);
            this.comboBoxOrderType.Name = "comboBoxOrderType";
            this.comboBoxOrderType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxOrderType.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "4 digits";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped"});
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(171, 214);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(121, 26);
            this.comboBoxOrderStatus.TabIndex = 21;
            // 
            // comboBoxOrderCustomerID
            // 
            this.comboBoxOrderCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderCustomerID.FormattingEnabled = true;
            this.comboBoxOrderCustomerID.Location = new System.Drawing.Point(171, 154);
            this.comboBoxOrderCustomerID.Name = "comboBoxOrderCustomerID";
            this.comboBoxOrderCustomerID.Size = new System.Drawing.Size(121, 26);
            this.comboBoxOrderCustomerID.TabIndex = 20;
            // 
            // textBoxOrderQuantity
            // 
            this.textBoxOrderQuantity.Location = new System.Drawing.Point(487, 159);
            this.textBoxOrderQuantity.Name = "textBoxOrderQuantity";
            this.textBoxOrderQuantity.Size = new System.Drawing.Size(142, 24);
            this.textBoxOrderQuantity.TabIndex = 10;
            // 
            // textBoxOrderTotalAmount
            // 
            this.textBoxOrderTotalAmount.Location = new System.Drawing.Point(171, 94);
            this.textBoxOrderTotalAmount.Name = "textBoxOrderTotalAmount";
            this.textBoxOrderTotalAmount.Size = new System.Drawing.Size(142, 24);
            this.textBoxOrderTotalAmount.TabIndex = 9;
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(170, 44);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(142, 24);
            this.textBoxOrderId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.Location = new System.Drawing.Point(224, 350);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(108, 43);
            this.button_Update.TabIndex = 46;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Location = new System.Drawing.Point(73, 350);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(108, 43);
            this.button_Save.TabIndex = 45;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__6_;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridViewBookOrders);
            this.tabPage2.Controls.Add(this.buttonListAll);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BookOrders";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxSerachBookOrders);
            this.groupBox3.Controls.Add(this.labelSearchBookOrders);
            this.groupBox3.Controls.Add(this.textBoxBookOrderSearch);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(689, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 258);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search BookOrders";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Select Search Option";
            // 
            // comboBoxSerachBookOrders
            // 
            this.comboBoxSerachBookOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerachBookOrders.FormattingEnabled = true;
            this.comboBoxSerachBookOrders.Items.AddRange(new object[] {
            "BookOrder Id",
            "ISBN",
            "Order Id"});
            this.comboBoxSerachBookOrders.Location = new System.Drawing.Point(31, 76);
            this.comboBoxSerachBookOrders.Name = "comboBoxSerachBookOrders";
            this.comboBoxSerachBookOrders.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSerachBookOrders.TabIndex = 33;
            this.comboBoxSerachBookOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerachBookOrders_SelectedIndexChanged);
            // 
            // labelSearchBookOrders
            // 
            this.labelSearchBookOrders.AutoSize = true;
            this.labelSearchBookOrders.Location = new System.Drawing.Point(28, 120);
            this.labelSearchBookOrders.Name = "labelSearchBookOrders";
            this.labelSearchBookOrders.Size = new System.Drawing.Size(85, 18);
            this.labelSearchBookOrders.TabIndex = 19;
            this.labelSearchBookOrders.Text = "Enter data";
            // 
            // textBoxBookOrderSearch
            // 
            this.textBoxBookOrderSearch.Location = new System.Drawing.Point(31, 148);
            this.textBoxBookOrderSearch.Name = "textBoxBookOrderSearch";
            this.textBoxBookOrderSearch.Size = new System.Drawing.Size(142, 24);
            this.textBoxBookOrderSearch.TabIndex = 15;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(31, 191);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 43);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewBookOrders
            // 
            this.dataGridViewBookOrders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewBookOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookOrders.Location = new System.Drawing.Point(81, 425);
            this.dataGridViewBookOrders.Name = "dataGridViewBookOrders";
            this.dataGridViewBookOrders.RowHeadersWidth = 51;
            this.dataGridViewBookOrders.RowTemplate.Height = 24;
            this.dataGridViewBookOrders.Size = new System.Drawing.Size(718, 149);
            this.dataGridViewBookOrders.TabIndex = 56;
            // 
            // buttonListAll
            // 
            this.buttonListAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonListAll.Location = new System.Drawing.Point(560, 352);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(108, 43);
            this.buttonListAll.TabIndex = 55;
            this.buttonListAll.Text = "List All";
            this.buttonListAll.UseVisualStyleBackColor = false;
            this.buttonListAll.Click += new System.EventHandler(this.buttonListAll_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(423, 29);
            this.label10.TabIndex = 57;
            this.label10.Text = "BookOrders Management System";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(388, 352);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 43);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBoxBookOrdersOrderId);
            this.groupBox2.Controls.Add(this.comboBoxBookOrderISBN);
            this.groupBox2.Controls.Add(this.textBoxBookOrderId);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(62, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 278);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BookOrdersData";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(197, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "5 digits";
            // 
            // comboBoxBookOrdersOrderId
            // 
            this.comboBoxBookOrdersOrderId.FormattingEnabled = true;
            this.comboBoxBookOrdersOrderId.Location = new System.Drawing.Point(200, 154);
            this.comboBoxBookOrdersOrderId.Name = "comboBoxBookOrdersOrderId";
            this.comboBoxBookOrdersOrderId.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBookOrdersOrderId.TabIndex = 21;
            // 
            // comboBoxBookOrderISBN
            // 
            this.comboBoxBookOrderISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookOrderISBN.FormattingEnabled = true;
            this.comboBoxBookOrderISBN.Location = new System.Drawing.Point(200, 100);
            this.comboBoxBookOrderISBN.Name = "comboBoxBookOrderISBN";
            this.comboBoxBookOrderISBN.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBookOrderISBN.TabIndex = 20;
            // 
            // textBoxBookOrderId
            // 
            this.textBoxBookOrderId.Location = new System.Drawing.Point(200, 41);
            this.textBoxBookOrderId.Name = "textBoxBookOrderId";
            this.textBoxBookOrderId.Size = new System.Drawing.Size(142, 24);
            this.textBoxBookOrderId.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Order ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 18);
            this.label17.TabIndex = 6;
            this.label17.Text = "ISBN";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "BookOrder Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(232, 352);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 43);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(81, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 43);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogOut.Location = new System.Drawing.Point(1221, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(108, 43);
            this.buttonLogOut.TabIndex = 56;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 721);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button button_ListAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.ComboBox comboBoxOrderType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.ComboBox comboBoxOrderCustomerID;
        private System.Windows.Forms.TextBox textBoxOrderQuantity;
        private System.Windows.Forms.TextBox textBoxOrderTotalAmount;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewBookOrders;
        private System.Windows.Forms.Button buttonListAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSerachBookOrders;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxBookOrdersOrderId;
        private System.Windows.Forms.ComboBox comboBoxBookOrderISBN;
        private System.Windows.Forms.Label labelSearchBookOrders;
        private System.Windows.Forms.TextBox textBoxBookOrderSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxBookOrderId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchOrders;
        private System.Windows.Forms.Label labelOrderSearch;
        private System.Windows.Forms.TextBox textBoxOrderSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button buttonLogOut;
    }
}