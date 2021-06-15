
namespace RentalService
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.moviesGridView = new System.Windows.Forms.DataGridView();
            this.tabRentedMovies = new System.Windows.Forms.TabPage();
            this.rentedMoviesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.tbMovieId = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.tbCopies = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbMovieTitle = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.tbRMID = new System.Windows.Forms.TextBox();
            this.gbRentedMovies = new System.Windows.Forms.GroupBox();
            this.rbAllRented = new System.Windows.Forms.RadioButton();
            this.rbOutRented = new System.Windows.Forms.RadioButton();
            this.tabCustomersBorrowingMoreMovies = new System.Windows.Forms.TabPage();
            this.customersMoreMoviesGridView = new System.Windows.Forms.DataGridView();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.tabMostBorrowedMovies = new System.Windows.Forms.TabPage();
            this.mostBorrowedMoviesDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).BeginInit();
            this.tabRentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataGrid)).BeginInit();
            this.gbRentedMovies.SuspendLayout();
            this.tabCustomersBorrowingMoreMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersMoreMoviesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            this.tabMostBorrowedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostBorrowedMoviesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageMovies);
            this.tabControl1.Controls.Add(this.tabRentedMovies);
            this.tabControl1.Controls.Add(this.tabCustomersBorrowingMoreMovies);
            this.tabControl1.Controls.Add(this.tabMostBorrowedMovies);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.customerGridView);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(869, 279);
            this.tabPageCustomers.TabIndex = 0;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGridView.Location = new System.Drawing.Point(3, 3);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.Size = new System.Drawing.Size(863, 273);
            this.customerGridView.TabIndex = 0;
            this.customerGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.customerGridView_RowStateChanged);
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.moviesGridView);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(869, 279);
            this.tabPageMovies.TabIndex = 1;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // moviesGridView
            // 
            this.moviesGridView.AllowUserToAddRows = false;
            this.moviesGridView.AllowUserToDeleteRows = false;
            this.moviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesGridView.Location = new System.Drawing.Point(3, 3);
            this.moviesGridView.Name = "moviesGridView";
            this.moviesGridView.ReadOnly = true;
            this.moviesGridView.Size = new System.Drawing.Size(863, 273);
            this.moviesGridView.TabIndex = 0;
            this.moviesGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.moviesGridView_RowStateChanged);
            // 
            // tabRentedMovies
            // 
            this.tabRentedMovies.Controls.Add(this.rentedMoviesDataGrid);
            this.tabRentedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabRentedMovies.Name = "tabRentedMovies";
            this.tabRentedMovies.Size = new System.Drawing.Size(869, 279);
            this.tabRentedMovies.TabIndex = 2;
            this.tabRentedMovies.Text = "Rented Movies";
            this.tabRentedMovies.UseVisualStyleBackColor = true;
            // 
            // rentedMoviesDataGrid
            // 
            this.rentedMoviesDataGrid.AllowUserToAddRows = false;
            this.rentedMoviesDataGrid.AllowUserToDeleteRows = false;
            this.rentedMoviesDataGrid.AutoGenerateColumns = false;
            this.rentedMoviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedMoviesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.rentalCostDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.rentedMoviesDataGrid.DataSource = this.rentedMoviesBindingSource;
            this.rentedMoviesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentedMoviesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.rentedMoviesDataGrid.Name = "rentedMoviesDataGrid";
            this.rentedMoviesDataGrid.ReadOnly = true;
            this.rentedMoviesDataGrid.Size = new System.Drawing.Size(869, 279);
            this.rentedMoviesDataGrid.TabIndex = 0;
            this.rentedMoviesDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.rentedMoviesDataGrid_RowStateChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(19, 375);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(124, 377);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(106, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(236, 377);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(104, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(346, 378);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(139, 20);
            this.tbAddress.TabIndex = 4;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(491, 378);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(104, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(176, 319);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(280, 320);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(124, 323);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.Size = new System.Drawing.Size(32, 20);
            this.tbCustID.TabIndex = 8;
            // 
            // tbMovieId
            // 
            this.tbMovieId.Location = new System.Drawing.Point(124, 423);
            this.tbMovieId.Name = "tbMovieId";
            this.tbMovieId.Size = new System.Drawing.Size(32, 20);
            this.tbMovieId.TabIndex = 16;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(280, 420);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteMovie.TabIndex = 15;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(176, 419);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateMovie.TabIndex = 14;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // tbCopies
            // 
            this.tbCopies.Location = new System.Drawing.Point(427, 472);
            this.tbCopies.Name = "tbCopies";
            this.tbCopies.Size = new System.Drawing.Size(104, 20);
            this.tbCopies.TabIndex = 13;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(346, 472);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(75, 20);
            this.tbYear.TabIndex = 12;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(236, 471);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(104, 20);
            this.tbRating.TabIndex = 11;
            // 
            // tbMovieTitle
            // 
            this.tbMovieTitle.Location = new System.Drawing.Point(124, 471);
            this.tbMovieTitle.Name = "tbMovieTitle";
            this.tbMovieTitle.Size = new System.Drawing.Size(106, 20);
            this.tbMovieTitle.TabIndex = 10;
            this.tbMovieTitle.Tag = "";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(19, 469);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(98, 23);
            this.btnAddMovie.TabIndex = 9;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Plot";
            // 
            // tbPlot
            // 
            this.tbPlot.Location = new System.Drawing.Point(537, 472);
            this.tbPlot.Multiline = true;
            this.tbPlot.Name = "tbPlot";
            this.tbPlot.Size = new System.Drawing.Size(188, 58);
            this.tbPlot.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Genre";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(731, 469);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(104, 20);
            this.tbGenre.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Phone";
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Red;
            this.btnIssueMovie.Location = new System.Drawing.Point(645, 375);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(80, 56);
            this.btnIssueMovie.TabIndex = 29;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Green;
            this.btnReturnMovie.Location = new System.Drawing.Point(740, 375);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(80, 56);
            this.btnReturnMovie.TabIndex = 30;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // tbRMID
            // 
            this.tbRMID.Location = new System.Drawing.Point(826, 394);
            this.tbRMID.Name = "tbRMID";
            this.tbRMID.Size = new System.Drawing.Size(32, 20);
            this.tbRMID.TabIndex = 31;
            // 
            // gbRentedMovies
            // 
            this.gbRentedMovies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbRentedMovies.Controls.Add(this.rbOutRented);
            this.gbRentedMovies.Controls.Add(this.rbAllRented);
            this.gbRentedMovies.Location = new System.Drawing.Point(124, 521);
            this.gbRentedMovies.Name = "gbRentedMovies";
            this.gbRentedMovies.Size = new System.Drawing.Size(200, 85);
            this.gbRentedMovies.TabIndex = 32;
            this.gbRentedMovies.TabStop = false;
            this.gbRentedMovies.Text = "Rented Movies";
            // 
            // rbAllRented
            // 
            this.rbAllRented.AutoSize = true;
            this.rbAllRented.Checked = true;
            this.rbAllRented.Location = new System.Drawing.Point(7, 42);
            this.rbAllRented.Name = "rbAllRented";
            this.rbAllRented.Size = new System.Drawing.Size(74, 17);
            this.rbAllRented.TabIndex = 0;
            this.rbAllRented.TabStop = true;
            this.rbAllRented.Text = "All Rented";
            this.rbAllRented.UseVisualStyleBackColor = true;
            this.rbAllRented.CheckedChanged += new System.EventHandler(this.rbAllRented_CheckedChanged);
            // 
            // rbOutRented
            // 
            this.rbOutRented.AutoSize = true;
            this.rbOutRented.Location = new System.Drawing.Point(108, 42);
            this.rbOutRented.Name = "rbOutRented";
            this.rbOutRented.Size = new System.Drawing.Size(80, 17);
            this.rbOutRented.TabIndex = 1;
            this.rbOutRented.Text = "Out Rented";
            this.rbOutRented.UseVisualStyleBackColor = true;
            this.rbOutRented.CheckedChanged += new System.EventHandler(this.rbOutRented_CheckedChanged);
            // 
            // tabCustomersBorrowingMoreMovies
            // 
            this.tabCustomersBorrowingMoreMovies.Controls.Add(this.customersMoreMoviesGridView);
            this.tabCustomersBorrowingMoreMovies.Location = new System.Drawing.Point(4, 22);
            this.tabCustomersBorrowingMoreMovies.Name = "tabCustomersBorrowingMoreMovies";
            this.tabCustomersBorrowingMoreMovies.Size = new System.Drawing.Size(869, 279);
            this.tabCustomersBorrowingMoreMovies.TabIndex = 3;
            this.tabCustomersBorrowingMoreMovies.Text = "Customers Borrowing More Movies";
            this.tabCustomersBorrowingMoreMovies.UseVisualStyleBackColor = true;
            // 
            // customersMoreMoviesGridView
            // 
            this.customersMoreMoviesGridView.AllowUserToAddRows = false;
            this.customersMoreMoviesGridView.AllowUserToDeleteRows = false;
            this.customersMoreMoviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersMoreMoviesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersMoreMoviesGridView.Location = new System.Drawing.Point(0, 0);
            this.customersMoreMoviesGridView.Name = "customersMoreMoviesGridView";
            this.customersMoreMoviesGridView.ReadOnly = true;
            this.customersMoreMoviesGridView.Size = new System.Drawing.Size(869, 279);
            this.customersMoreMoviesGridView.TabIndex = 0;
            // 
            // rMIDDataGridViewTextBoxColumn
            // 
            this.rMIDDataGridViewTextBoxColumn.DataPropertyName = "RMID";
            this.rMIDDataGridViewTextBoxColumn.HeaderText = "RMID";
            this.rMIDDataGridViewTextBoxColumn.Name = "rMIDDataGridViewTextBoxColumn";
            this.rMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalCostDataGridViewTextBoxColumn
            // 
            this.rentalCostDataGridViewTextBoxColumn.DataPropertyName = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.HeaderText = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.Name = "rentalCostDataGridViewTextBoxColumn";
            this.rentalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            this.dateRentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            this.dateReturnedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataSource = typeof(RentalService.Models.RentedMovies);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "RMID";
            // 
            // tabMostBorrowedMovies
            // 
            this.tabMostBorrowedMovies.Controls.Add(this.mostBorrowedMoviesDataGrid);
            this.tabMostBorrowedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMostBorrowedMovies.Name = "tabMostBorrowedMovies";
            this.tabMostBorrowedMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMostBorrowedMovies.Size = new System.Drawing.Size(869, 279);
            this.tabMostBorrowedMovies.TabIndex = 4;
            this.tabMostBorrowedMovies.Text = "Most Borrowed Movies";
            this.tabMostBorrowedMovies.UseVisualStyleBackColor = true;
            // 
            // mostBorrowedMoviesDataGrid
            // 
            this.mostBorrowedMoviesDataGrid.AllowUserToAddRows = false;
            this.mostBorrowedMoviesDataGrid.AllowUserToDeleteRows = false;
            this.mostBorrowedMoviesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostBorrowedMoviesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostBorrowedMoviesDataGrid.Location = new System.Drawing.Point(3, 3);
            this.mostBorrowedMoviesDataGrid.Name = "mostBorrowedMoviesDataGrid";
            this.mostBorrowedMoviesDataGrid.ReadOnly = true;
            this.mostBorrowedMoviesDataGrid.Size = new System.Drawing.Size(863, 273);
            this.mostBorrowedMoviesDataGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 618);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbRentedMovies);
            this.Controls.Add(this.tbRMID);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPlot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMovieId);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.tbCopies);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbMovieTitle);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.tbCustID);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Rental Service";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.tabPageMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).EndInit();
            this.tabRentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataGrid)).EndInit();
            this.gbRentedMovies.ResumeLayout(false);
            this.gbRentedMovies.PerformLayout();
            this.tabCustomersBorrowingMoreMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersMoreMoviesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            this.tabMostBorrowedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mostBorrowedMoviesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabRentedMovies;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridView moviesGridView;
        private System.Windows.Forms.DataGridView rentedMoviesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.TextBox tbMovieId;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox tbCopies;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.TextBox tbMovieTitle;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.TextBox tbRMID;
        private System.Windows.Forms.GroupBox gbRentedMovies;
        private System.Windows.Forms.RadioButton rbAllRented;
        private System.Windows.Forms.RadioButton rbOutRented;
        private System.Windows.Forms.TabPage tabCustomersBorrowingMoreMovies;
        private System.Windows.Forms.DataGridView customersMoreMoviesGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabMostBorrowedMovies;
        private System.Windows.Forms.DataGridView mostBorrowedMoviesDataGrid;
    }
}

