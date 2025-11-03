namespace Final_Project___Library_Management_System
{
    partial class frmLibrary
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
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnModifyBook = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchQuery = new System.Windows.Forms.ComboBox();
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tblBooksTableAdapter = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.tblBooksTableAdapter();
            this.tableAdapterManager = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDeleteBook.Location = new System.Drawing.Point(350, 508);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(130, 52);
            this.btnDeleteBook.TabIndex = 5;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnModifyBook
            // 
            this.btnModifyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnModifyBook.Location = new System.Drawing.Point(190, 508);
            this.btnModifyBook.Name = "btnModifyBook";
            this.btnModifyBook.Size = new System.Drawing.Size(130, 52);
            this.btnModifyBook.TabIndex = 4;
            this.btnModifyBook.Text = "Modify Book";
            this.btnModifyBook.UseVisualStyleBackColor = true;
            this.btnModifyBook.Click += new System.EventHandler(this.btnModifyBook_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddNewBook.Location = new System.Drawing.Point(37, 508);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(130, 52);
            this.btnAddNewBook.TabIndex = 3;
            this.btnAddNewBook.Text = "Add Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCloseForm.Location = new System.Drawing.Point(580, 508);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(130, 52);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(37, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // cboSearchQuery
            // 
            this.cboSearchQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboSearchQuery.FormattingEnabled = true;
            this.cboSearchQuery.Items.AddRange(new object[] {
            "Search By Title",
            "Search by Author",
            "Search by Genre",
            "Search by Language",
            "Search by Rating (>=)"});
            this.cboSearchQuery.Location = new System.Drawing.Point(350, 64);
            this.cboSearchQuery.Name = "cboSearchQuery";
            this.cboSearchQuery.Size = new System.Drawing.Size(200, 32);
            this.cboSearchQuery.TabIndex = 1;
            this.cboSearchQuery.SelectedIndexChanged += new System.EventHandler(this.cboSearchQuery_SelectedIndexChanged);
            // 
            // tblBooksDataGridView
            // 
            this.tblBooksDataGridView.AllowUserToAddRows = false;
            this.tblBooksDataGridView.AllowUserToDeleteRows = false;
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
            this.tblBooksDataGridView.Location = new System.Drawing.Point(37, 119);
            this.tblBooksDataGridView.Name = "tblBooksDataGridView";
            this.tblBooksDataGridView.ReadOnly = true;
            this.tblBooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblBooksDataGridView.Size = new System.Drawing.Size(673, 367);
            this.tblBooksDataGridView.TabIndex = 20;
            this.tblBooksDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 55;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 35;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pages";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn6.HeaderText = "Language";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AgeRange";
            this.dataGridViewTextBoxColumn8.HeaderText = "Age Range";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Copies";
            this.dataGridViewTextBoxColumn9.HeaderText = "Copies";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 50;
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
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(580, 63);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(130, 32);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
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
            // frmLibrary
            // 
            this.AcceptButton = this.btnAddNewBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseForm;
            this.ClientSize = new System.Drawing.Size(747, 606);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.tblBooksDataGridView);
            this.Controls.Add(this.cboSearchQuery);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnModifyBook);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLibrary";
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnModifyBook;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearchQuery;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private BooksDataSetTableAdapters.tblBooksTableAdapter tblBooksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblBooksDataGridView;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}