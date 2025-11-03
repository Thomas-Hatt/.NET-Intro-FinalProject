namespace Final_Project___Library_Management_System
{
    partial class frmGeneratedReport
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
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblAverageMemberAge = new System.Windows.Forms.Label();
            this.lblTotalOverdueBooks = new System.Windows.Forms.Label();
            this.lblTotalBorrowedBooks = new System.Windows.Forms.Label();
            this.lblMostCommonBookGenre = new System.Windows.Forms.Label();
            this.lblMostCommonLanguage = new System.Windows.Forms.Label();
            this.lblTotalCopiesOfBooks = new System.Windows.Forms.Label();
            this.lblAverageBookRating = new System.Windows.Forms.Label();
            this.lblAverageBookPageCount = new System.Windows.Forms.Label();
            this.tblBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new Final_Project___Library_Management_System.BooksDataSet();
            this.usersDataSet = new Final_Project___Library_Management_System.UsersDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new Final_Project___Library_Management_System.UsersDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager1 = new Final_Project___Library_Management_System.UsersDataSetTableAdapters.TableAdapterManager();
            this.tblUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblBooksTableAdapter = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.tblBooksTableAdapter();
            this.tableAdapterManager = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalMembers.Location = new System.Drawing.Point(31, 45);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(156, 24);
            this.lblTotalMembers.TabIndex = 0;
            this.lblTotalMembers.Text = "Total Members:   ";
            // 
            // lblAverageMemberAge
            // 
            this.lblAverageMemberAge.AutoSize = true;
            this.lblAverageMemberAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAverageMemberAge.Location = new System.Drawing.Point(31, 419);
            this.lblAverageMemberAge.Name = "lblAverageMemberAge";
            this.lblAverageMemberAge.Size = new System.Drawing.Size(217, 24);
            this.lblAverageMemberAge.TabIndex = 1;
            this.lblAverageMemberAge.Text = "Average Member Age:   ";
            // 
            // lblTotalOverdueBooks
            // 
            this.lblTotalOverdueBooks.AutoSize = true;
            this.lblTotalOverdueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalOverdueBooks.Location = new System.Drawing.Point(31, 158);
            this.lblTotalOverdueBooks.Name = "lblTotalOverdueBooks";
            this.lblTotalOverdueBooks.Size = new System.Drawing.Size(207, 24);
            this.lblTotalOverdueBooks.TabIndex = 3;
            this.lblTotalOverdueBooks.Text = "Total Overdue Books:   ";
            // 
            // lblTotalBorrowedBooks
            // 
            this.lblTotalBorrowedBooks.AutoSize = true;
            this.lblTotalBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalBorrowedBooks.Location = new System.Drawing.Point(31, 102);
            this.lblTotalBorrowedBooks.Name = "lblTotalBorrowedBooks";
            this.lblTotalBorrowedBooks.Size = new System.Drawing.Size(215, 24);
            this.lblTotalBorrowedBooks.TabIndex = 2;
            this.lblTotalBorrowedBooks.Text = "Total Borrowed Books:   ";
            // 
            // lblMostCommonBookGenre
            // 
            this.lblMostCommonBookGenre.AutoSize = true;
            this.lblMostCommonBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMostCommonBookGenre.Location = new System.Drawing.Point(31, 314);
            this.lblMostCommonBookGenre.Name = "lblMostCommonBookGenre";
            this.lblMostCommonBookGenre.Size = new System.Drawing.Size(259, 24);
            this.lblMostCommonBookGenre.TabIndex = 5;
            this.lblMostCommonBookGenre.Text = "Most Common Book Genre:   ";
            // 
            // lblMostCommonLanguage
            // 
            this.lblMostCommonLanguage.AutoSize = true;
            this.lblMostCommonLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMostCommonLanguage.Location = new System.Drawing.Point(31, 259);
            this.lblMostCommonLanguage.Name = "lblMostCommonLanguage";
            this.lblMostCommonLanguage.Size = new System.Drawing.Size(291, 24);
            this.lblMostCommonLanguage.TabIndex = 4;
            this.lblMostCommonLanguage.Text = "Most Common Book Language:   ";
            // 
            // lblTotalCopiesOfBooks
            // 
            this.lblTotalCopiesOfBooks.AutoSize = true;
            this.lblTotalCopiesOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalCopiesOfBooks.Location = new System.Drawing.Point(31, 207);
            this.lblTotalCopiesOfBooks.Name = "lblTotalCopiesOfBooks";
            this.lblTotalCopiesOfBooks.Size = new System.Drawing.Size(212, 24);
            this.lblTotalCopiesOfBooks.TabIndex = 7;
            this.lblTotalCopiesOfBooks.Text = "Total Copies of Books:   ";
            // 
            // lblAverageBookRating
            // 
            this.lblAverageBookRating.AutoSize = true;
            this.lblAverageBookRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAverageBookRating.Location = new System.Drawing.Point(31, 367);
            this.lblAverageBookRating.Name = "lblAverageBookRating";
            this.lblAverageBookRating.Size = new System.Drawing.Size(207, 24);
            this.lblAverageBookRating.TabIndex = 6;
            this.lblAverageBookRating.Text = "Average Book Rating:   ";
            // 
            // lblAverageBookPageCount
            // 
            this.lblAverageBookPageCount.AutoSize = true;
            this.lblAverageBookPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAverageBookPageCount.Location = new System.Drawing.Point(31, 470);
            this.lblAverageBookPageCount.Name = "lblAverageBookPageCount";
            this.lblAverageBookPageCount.Size = new System.Drawing.Size(253, 24);
            this.lblAverageBookPageCount.TabIndex = 8;
            this.lblAverageBookPageCount.Text = "Average Book Page Count:   ";
            // 
            // tblBooksDataGridView
            // 
            this.tblBooksDataGridView.AutoGenerateColumns = false;
            this.tblBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tblBooksDataGridView.DataSource = this.tblBooksBindingSource;
            this.tblBooksDataGridView.Location = new System.Drawing.Point(215, 28);
            this.tblBooksDataGridView.Name = "tblBooksDataGridView";
            this.tblBooksDataGridView.Size = new System.Drawing.Size(18, 19);
            this.tblBooksDataGridView.TabIndex = 10;
            this.tblBooksDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pages";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn6.HeaderText = "Language";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AgeRange";
            this.dataGridViewTextBoxColumn8.HeaderText = "AgeRange";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Copies";
            this.dataGridViewTextBoxColumn9.HeaderText = "Copies";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tblBooksBindingSource
            // 
            this.tblBooksBindingSource.DataMember = "tblBooks";
            this.tblBooksBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.usersDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Final_Project___Library_Management_System.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblUsersDataGridView
            // 
            this.tblUsersDataGridView.AutoGenerateColumns = false;
            this.tblUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.tblUsersDataGridView.DataSource = this.tblUsersBindingSource;
            this.tblUsersDataGridView.Location = new System.Drawing.Point(267, 36);
            this.tblUsersDataGridView.Name = "tblUsersDataGridView";
            this.tblUsersDataGridView.Size = new System.Drawing.Size(19, 11);
            this.tblUsersDataGridView.TabIndex = 10;
            this.tblUsersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn11.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn12.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LibraryCardNumber";
            this.dataGridViewTextBoxColumn13.HeaderText = "LibraryCardNumber";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn14.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TotalBorrowedBooks";
            this.dataGridViewTextBoxColumn15.HeaderText = "TotalBorrowedBooks";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TotalOverdueBooks";
            this.dataGridViewTextBoxColumn16.HeaderText = "TotalOverdueBooks";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MembershipType";
            this.dataGridViewTextBoxColumn17.HeaderText = "MembershipType";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(35, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(234, 55);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tblBooksTableAdapter
            // 
            this.tblBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBooksTableAdapter = this.tblBooksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project___Library_Management_System.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmGeneratedReport
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(457, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tblUsersDataGridView);
            this.Controls.Add(this.tblBooksDataGridView);
            this.Controls.Add(this.lblAverageBookPageCount);
            this.Controls.Add(this.lblTotalCopiesOfBooks);
            this.Controls.Add(this.lblAverageBookRating);
            this.Controls.Add(this.lblMostCommonBookGenre);
            this.Controls.Add(this.lblMostCommonLanguage);
            this.Controls.Add(this.lblTotalOverdueBooks);
            this.Controls.Add(this.lblTotalBorrowedBooks);
            this.Controls.Add(this.lblAverageMemberAge);
            this.Controls.Add(this.lblTotalMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGeneratedReport";
            this.Text = "Generated Report";
            this.Load += new System.EventHandler(this.frmGeneratedReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblAverageMemberAge;
        private System.Windows.Forms.Label lblTotalOverdueBooks;
        private System.Windows.Forms.Label lblTotalBorrowedBooks;
        private System.Windows.Forms.Label lblMostCommonBookGenre;
        private System.Windows.Forms.Label lblMostCommonLanguage;
        private System.Windows.Forms.Label lblTotalCopiesOfBooks;
        private System.Windows.Forms.Label lblAverageBookRating;
        private System.Windows.Forms.Label lblAverageBookPageCount;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private BooksDataSetTableAdapters.tblBooksTableAdapter tblBooksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblBooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private UsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tblUsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button btnClose;
    }
}