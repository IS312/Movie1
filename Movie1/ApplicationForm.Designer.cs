namespace Movie1
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.txtRentedCost = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.gvRental = new System.Windows.Forms.DataGridView();
            this.RentedMovies = new System.Windows.Forms.TabPage();
            this.gvMovies = new System.Windows.Forms.DataGridView();
            this.MyMovies = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.OurCustomers = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ddlMovie = new System.Windows.Forms.ComboBox();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtIsuue = new System.Windows.Forms.DateTimePicker();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1RentedMOvies = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlAllCust = new System.Windows.Forms.ComboBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1ShowData = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).BeginInit();
            this.RentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).BeginInit();
            this.MyMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.OurCustomers.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRentedCost
            // 
            this.txtRentedCost.Location = new System.Drawing.Point(499, 125);
            this.txtRentedCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentedCost.Name = "txtRentedCost";
            this.txtRentedCost.ReadOnly = true;
            this.txtRentedCost.Size = new System.Drawing.Size(103, 26);
            this.txtRentedCost.TabIndex = 40;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(365, 125);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(92, 26);
            this.txtYear.TabIndex = 39;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(365, 60);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 26);
            this.txtTitle.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(34, 226);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 26);
            this.txtPhone.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 144);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 47);
            this.txtAddress.TabIndex = 31;
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCustomer.Location = new System.Drawing.Point(338, 202);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(203, 40);
            this.DeleteCustomer.TabIndex = 26;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCustomer.Location = new System.Drawing.Point(305, 277);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(204, 40);
            this.UpdateCustomer.TabIndex = 25;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // gvRental
            // 
            this.gvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRental.Location = new System.Drawing.Point(4, 4);
            this.gvRental.Margin = new System.Windows.Forms.Padding(4);
            this.gvRental.Name = "gvRental";
            this.gvRental.RowHeadersWidth = 51;
            this.gvRental.Size = new System.Drawing.Size(1229, 292);
            this.gvRental.TabIndex = 0;
            // 
            // RentedMovies
            // 
            this.RentedMovies.BackColor = System.Drawing.Color.Transparent;
            this.RentedMovies.Controls.Add(this.gvRental);
            this.RentedMovies.Location = new System.Drawing.Point(4, 31);
            this.RentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.RentedMovies.Name = "RentedMovies";
            this.RentedMovies.Size = new System.Drawing.Size(1239, 296);
            this.RentedMovies.TabIndex = 2;
            this.RentedMovies.Text = "RentedMovies";
            // 
            // gvMovies
            // 
            this.gvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovies.Location = new System.Drawing.Point(5, 7);
            this.gvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.gvMovies.Name = "gvMovies";
            this.gvMovies.RowHeadersWidth = 51;
            this.gvMovies.Size = new System.Drawing.Size(1226, 288);
            this.gvMovies.TabIndex = 0;
            // 
            // MyMovies
            // 
            this.MyMovies.Controls.Add(this.gvMovies);
            this.MyMovies.Location = new System.Drawing.Point(4, 31);
            this.MyMovies.Margin = new System.Windows.Forms.Padding(4);
            this.MyMovies.Name = "MyMovies";
            this.MyMovies.Padding = new System.Windows.Forms.Padding(4);
            this.MyMovies.Size = new System.Drawing.Size(1239, 296);
            this.MyMovies.TabIndex = 1;
            this.MyMovies.Text = "MyMovies";
            this.MyMovies.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(8, 7);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.Size = new System.Drawing.Size(1223, 288);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // OurCustomers
            // 
            this.OurCustomers.Controls.Add(this.CustomersDataGridView);
            this.OurCustomers.Location = new System.Drawing.Point(4, 29);
            this.OurCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.OurCustomers.Name = "OurCustomers";
            this.OurCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.OurCustomers.Size = new System.Drawing.Size(1239, 298);
            this.OurCustomers.TabIndex = 0;
            this.OurCustomers.Text = "OurCustomers";
            this.OurCustomers.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.OurCustomers);
            this.TabControl.Controls.Add(this.MyMovies);
            this.TabControl.Controls.Add(this.RentedMovies);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(10, -1);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1247, 331);
            this.TabControl.TabIndex = 21;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ddlCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.AddCustomer);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.DeleteCustomer);
            this.groupBox1.Controls.Add(this.UpdateCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 614);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(605, 345);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Update / Delete Customers";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(334, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(230, 68);
            this.label22.TabIndex = 54;
            this.label22.Text = "Note: Select Customer from above Dropdown to Update or Delete";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.Location = new System.Drawing.Point(303, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(5, 331);
            this.label15.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(333, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Select Customer:";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(337, 81);
            this.ddlCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(227, 28);
            this.ddlCustomer.TabIndex = 51;
            this.ddlCustomer.SelectedIndexChanged += new System.EventHandler(this.ddlCustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 26);
            this.txtName.TabIndex = 44;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.AddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCustomer.Location = new System.Drawing.Point(31, 277);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(203, 45);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(364, 267);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(81, 26);
            this.txtRating.TabIndex = 47;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(365, 192);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(237, 26);
            this.txtGenre.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ddlMovie);
            this.groupBox2.Controls.Add(this.btnAddMOvie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDelMOvie);
            this.groupBox2.Controls.Add(this.txtRating);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRentedCost);
            this.groupBox2.Controls.Add(this.txtGenre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 625);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(632, 333);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add / Update / Delete Movies";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(255, 68);
            this.label23.TabIndex = 55;
            this.label23.Text = "Note: Select Movie from above Dropdown to Update or Delete";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.RoyalBlue;
            this.label20.Location = new System.Drawing.Point(349, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(5, 331);
            this.label20.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "Select Movie:";
            // 
            // ddlMovie
            // 
            this.ddlMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMovie.FormattingEnabled = true;
            this.ddlMovie.Location = new System.Drawing.Point(28, 70);
            this.ddlMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlMovie.Name = "ddlMovie";
            this.ddlMovie.Size = new System.Drawing.Size(231, 28);
            this.ddlMovie.TabIndex = 55;
            this.ddlMovie.SelectedIndexChanged += new System.EventHandler(this.ddlMovie_SelectedIndexChanged);
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMOvie.Location = new System.Drawing.Point(467, 251);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(144, 50);
            this.btnAddMOvie.TabIndex = 52;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = false;
            this.btnAddMOvie.Click += new System.EventHandler(this.btnAddMOvie_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Rent($):";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(129, 261);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 40);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Rating:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre:";
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelMOvie.Location = new System.Drawing.Point(28, 178);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(203, 40);
            this.btnDelMOvie.TabIndex = 53;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = false;
            this.btnDelMOvie.Click += new System.EventHandler(this.btnDelMOvie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(34, 52);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(345, 24);
            this.radioButton1.TabIndex = 61;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Customers who borrows most movies";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(34, 137);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(204, 24);
            this.radioButton2.TabIndex = 62;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Most popular movies";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(34, 94);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(225, 24);
            this.radioButton3.TabIndex = 63;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Show all rented movies";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtReturn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtIsuue);
            this.groupBox3.Controls.Add(this.btnIssueMovie);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(469, 336);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(357, 252);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie Rent Panel";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(20, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(325, 62);
            this.label21.TabIndex = 53;
            this.label21.Text = "Note: Select Customer and Movie from dropdowns in respective panels to Put on Ren" +
    "t";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Issue Date:";
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(145, 75);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(200, 26);
            this.dtReturn.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Return Date:";
            // 
            // dtIsuue
            // 
            this.dtIsuue.Location = new System.Drawing.Point(145, 34);
            this.dtIsuue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtIsuue.Name = "dtIsuue";
            this.dtIsuue.Size = new System.Drawing.Size(200, 26);
            this.dtIsuue.TabIndex = 50;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueMovie.Location = new System.Drawing.Point(20, 126);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(325, 40);
            this.btnIssueMovie.TabIndex = 27;
            this.btnIssueMovie.Text = "Put on Rent";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1RentedMOvies);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ddlAllCust);
            this.groupBox4.Controls.Add(this.btnReturnMovie);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(854, 333);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(415, 255);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Movie Return Panel";
            // 
            // listBox1RentedMOvies
            // 
            this.listBox1RentedMOvies.FormattingEnabled = true;
            this.listBox1RentedMOvies.ItemHeight = 20;
            this.listBox1RentedMOvies.Location = new System.Drawing.Point(35, 139);
            this.listBox1RentedMOvies.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1RentedMOvies.Name = "listBox1RentedMOvies";
            this.listBox1RentedMOvies.Size = new System.Drawing.Size(287, 84);
            this.listBox1RentedMOvies.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Select Customer:";
            // 
            // ddlAllCust
            // 
            this.ddlAllCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAllCust.FormattingEnabled = true;
            this.ddlAllCust.Location = new System.Drawing.Point(33, 64);
            this.ddlAllCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlAllCust.Name = "ddlAllCust";
            this.ddlAllCust.Size = new System.Drawing.Size(213, 28);
            this.ddlAllCust.TabIndex = 55;
            this.ddlAllCust.SelectedIndexChanged += new System.EventHandler(this.ddlAllCust_SelectedIndexChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnMovie.Location = new System.Drawing.Point(273, 58);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(115, 40);
            this.btnReturnMovie.TabIndex = 28;
            this.btnReturnMovie.Text = "Return";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Select Rented Movie:";
            // 
            // button1ShowData
            // 
            this.button1ShowData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1ShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1ShowData.Location = new System.Drawing.Point(34, 191);
            this.button1ShowData.Margin = new System.Windows.Forms.Padding(4);
            this.button1ShowData.Name = "button1ShowData";
            this.button1ShowData.Size = new System.Drawing.Size(161, 40);
            this.button1ShowData.TabIndex = 66;
            this.button1ShowData.Text = "Show Info";
            this.button1ShowData.UseVisualStyleBackColor = false;
            this.button1ShowData.Click += new System.EventHandler(this.button1ShowData_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox5.Controls.Add(this.button1ShowData);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 255);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Customers And Movies";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(625, 605);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 355);
            this.label16.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(11, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1247, 10);
            this.label17.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(454, 324);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 271);
            this.label18.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(837, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 271);
            this.label19.TabIndex = 70;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 953);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ApplicationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Rental Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).EndInit();
            this.RentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).EndInit();
            this.MyMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.OurCustomers.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRentedCost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.DataGridView gvRental;
        private System.Windows.Forms.TabPage RentedMovies;
        private System.Windows.Forms.DataGridView gvMovies;
        private System.Windows.Forms.TabPage MyMovies;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage OurCustomers;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private System.Windows.Forms.ComboBox ddlMovie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtIsuue;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1RentedMOvies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlAllCust;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1ShowData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
    }
}

