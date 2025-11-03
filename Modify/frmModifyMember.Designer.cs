namespace Final_Project___Library_Management_System
{
    partial class frmModifyMember
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label totalBorrowedBooksLabel;
            System.Windows.Forms.Label totalOverdueBooksLabel;
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalBorrowedBooksTextBox = new System.Windows.Forms.TextBox();
            this.totalOverdueBooksTextBox = new System.Windows.Forms.TextBox();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Final_Project___Library_Management_System.UsersDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersTableAdapter = new Final_Project___Library_Management_System.UsersDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new Final_Project___Library_Management_System.UsersDataSetTableAdapters.TableAdapterManager();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            totalBorrowedBooksLabel = new System.Windows.Forms.Label();
            totalOverdueBooksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            lastNameLabel.Location = new System.Drawing.Point(70, 117);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 24);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            firstNameLabel.Location = new System.Drawing.Point(68, 54);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(106, 24);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dOBLabel.Location = new System.Drawing.Point(119, 180);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(55, 24);
            dOBLabel.TabIndex = 23;
            dOBLabel.Text = "DOB:";
            // 
            // totalBorrowedBooksLabel
            // 
            totalBorrowedBooksLabel.AutoSize = true;
            totalBorrowedBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            totalBorrowedBooksLabel.Location = new System.Drawing.Point(20, 241);
            totalBorrowedBooksLabel.Name = "totalBorrowedBooksLabel";
            totalBorrowedBooksLabel.Size = new System.Drawing.Size(154, 24);
            totalBorrowedBooksLabel.TabIndex = 24;
            totalBorrowedBooksLabel.Text = "Borrowed Books:";
            // 
            // totalOverdueBooksLabel
            // 
            totalOverdueBooksLabel.AutoSize = true;
            totalOverdueBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            totalOverdueBooksLabel.Location = new System.Drawing.Point(28, 306);
            totalOverdueBooksLabel.Name = "totalOverdueBooksLabel";
            totalOverdueBooksLabel.Size = new System.Drawing.Size(146, 24);
            totalOverdueBooksLabel.TabIndex = 25;
            totalOverdueBooksLabel.Text = "Overdue Books:";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyUser.Location = new System.Drawing.Point(223, 373);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(153, 48);
            this.btnModifyUser.TabIndex = 5;
            this.btnModifyUser.Text = "Modify Member";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(409, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 48);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblUsersDataGridView
            // 
            this.tblUsersDataGridView.AutoGenerateColumns = false;
            this.tblUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblUsersDataGridView.DataSource = this.tblUsersBindingSource;
            this.tblUsersDataGridView.Location = new System.Drawing.Point(527, 9);
            this.tblUsersDataGridView.Name = "tblUsersDataGridView";
            this.tblUsersDataGridView.Size = new System.Drawing.Size(22, 16);
            this.tblUsersDataGridView.TabIndex = 21;
            this.tblUsersDataGridView.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lastNameTextBox.Location = new System.Drawing.Point(223, 112);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(307, 29);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstNameTextBox.Location = new System.Drawing.Point(223, 49);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(307, 29);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblUsersBindingSource, "DOB", true));
            this.DOBDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DOBDateTimePicker.Location = new System.Drawing.Point(223, 175);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(307, 29);
            this.DOBDateTimePicker.TabIndex = 2;
            // 
            // totalBorrowedBooksTextBox
            // 
            this.totalBorrowedBooksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "TotalBorrowedBooks", true));
            this.totalBorrowedBooksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalBorrowedBooksTextBox.Location = new System.Drawing.Point(223, 238);
            this.totalBorrowedBooksTextBox.Name = "totalBorrowedBooksTextBox";
            this.totalBorrowedBooksTextBox.Size = new System.Drawing.Size(307, 29);
            this.totalBorrowedBooksTextBox.TabIndex = 3;
            // 
            // totalOverdueBooksTextBox
            // 
            this.totalOverdueBooksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "TotalOverdueBooks", true));
            this.totalOverdueBooksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalOverdueBooksTextBox.Location = new System.Drawing.Point(223, 301);
            this.totalOverdueBooksTextBox.Name = "totalOverdueBooksTextBox";
            this.totalOverdueBooksTextBox.Size = new System.Drawing.Size(307, 29);
            this.totalOverdueBooksTextBox.TabIndex = 4;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LibraryCardNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "LibraryCardNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn5.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalBorrowedBooks";
            this.dataGridViewTextBoxColumn6.HeaderText = "TotalBorrowedBooks";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalOverdueBooks";
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalOverdueBooks";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MembershipType";
            this.dataGridViewTextBoxColumn8.HeaderText = "MembershipType";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project___Library_Management_System.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmModifyMember
            // 
            this.AcceptButton = this.btnModifyUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.Controls.Add(totalOverdueBooksLabel);
            this.Controls.Add(this.totalOverdueBooksTextBox);
            this.Controls.Add(totalBorrowedBooksLabel);
            this.Controls.Add(this.totalBorrowedBooksTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.tblUsersDataGridView);
            this.Controls.Add(this.btnModifyUser);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModifyMember";
            this.Text = "frmModifyMember";
            this.Load += new System.EventHandler(this.frmModifyMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnCancel;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private UsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblUsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.TextBox totalBorrowedBooksTextBox;
        private System.Windows.Forms.TextBox totalOverdueBooksTextBox;
    }
}