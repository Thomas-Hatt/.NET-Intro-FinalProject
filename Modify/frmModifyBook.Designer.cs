namespace Final_Project___Library_Management_System.Modify
{
    partial class frmModifyBook
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label copiesLabel;
            System.Windows.Forms.Label ageRangeLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label languageLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label titleLabel;
            this.booksDataSet = new Final_Project___Library_Management_System.BooksDataSet();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBooksTableAdapter = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.tblBooksTableAdapter();
            this.tableAdapterManager = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.TableAdapterManager();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.cboAgeRange = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnModifyBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            copiesLabel = new System.Windows.Forms.Label();
            ageRangeLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            languageLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(234, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 37);
            label1.TabIndex = 38;
            label1.Text = "Modify Book";
            // 
            // copiesLabel
            // 
            copiesLabel.AutoSize = true;
            copiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            copiesLabel.Location = new System.Drawing.Point(65, 504);
            copiesLabel.Name = "copiesLabel";
            copiesLabel.Size = new System.Drawing.Size(74, 24);
            copiesLabel.TabIndex = 34;
            copiesLabel.Text = "Copies:";
            // 
            // ageRangeLabel
            // 
            ageRangeLabel.AutoSize = true;
            ageRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageRangeLabel.Location = new System.Drawing.Point(65, 444);
            ageRangeLabel.Name = "ageRangeLabel";
            ageRangeLabel.Size = new System.Drawing.Size(111, 24);
            ageRangeLabel.TabIndex = 33;
            ageRangeLabel.Text = "Age Range:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ratingLabel.Location = new System.Drawing.Point(65, 384);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(68, 24);
            ratingLabel.TabIndex = 32;
            ratingLabel.Text = "Rating:";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageLabel.Location = new System.Drawing.Point(65, 324);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new System.Drawing.Size(100, 24);
            languageLabel.TabIndex = 31;
            languageLabel.Text = "Language:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genreLabel.Location = new System.Drawing.Point(65, 264);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(68, 24);
            genreLabel.TabIndex = 30;
            genreLabel.Text = "Genre:";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagesLabel.Location = new System.Drawing.Point(65, 204);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(68, 24);
            pagesLabel.TabIndex = 28;
            pagesLabel.Text = "Pages:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(65, 144);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(71, 24);
            authorLabel.TabIndex = 26;
            authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(65, 84);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(50, 24);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Title:";
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBooksBindingSource
            // 
            this.tblBooksBindingSource.DataMember = "tblBooks";
            this.tblBooksBindingSource.DataSource = this.booksDataSet;
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
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(222, 316);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(373, 32);
            this.cboLanguage.TabIndex = 4;
            // 
            // cboRating
            // 
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Location = new System.Drawing.Point(222, 376);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(373, 32);
            this.cboRating.TabIndex = 5;
            // 
            // cboAgeRange
            // 
            this.cboAgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboAgeRange.FormattingEnabled = true;
            this.cboAgeRange.Location = new System.Drawing.Point(222, 436);
            this.cboAgeRange.Name = "cboAgeRange";
            this.cboAgeRange.Size = new System.Drawing.Size(373, 32);
            this.cboAgeRange.TabIndex = 6;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(222, 256);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(373, 32);
            this.cboGenre.TabIndex = 3;
            // 
            // btnModifyBook
            // 
            this.btnModifyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyBook.Location = new System.Drawing.Point(69, 572);
            this.btnModifyBook.Name = "btnModifyBook";
            this.btnModifyBook.Size = new System.Drawing.Size(151, 51);
            this.btnModifyBook.TabIndex = 8;
            this.btnModifyBook.Text = "Modify Book";
            this.btnModifyBook.UseVisualStyleBackColor = true;
            this.btnModifyBook.Click += new System.EventHandler(this.btnModifyBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(444, 572);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Copies", true));
            this.copiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesTextBox.Location = new System.Drawing.Point(222, 499);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(373, 29);
            this.copiesTextBox.TabIndex = 7;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Pages", true));
            this.pagesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesTextBox.Location = new System.Drawing.Point(222, 199);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(373, 29);
            this.pagesTextBox.TabIndex = 2;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(222, 139);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(373, 29);
            this.authorTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(222, 79);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(373, 29);
            this.titleTextBox.TabIndex = 0;
            // 
            // frmModifyBook
            // 
            this.AcceptButton = this.btnModifyBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(661, 643);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.cboRating);
            this.Controls.Add(this.cboAgeRange);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnModifyBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(copiesLabel);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(ageRangeLabel);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(languageLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModifyBook";
            this.Text = "frmModifyBook";
            this.Load += new System.EventHandler(this.frmModifyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private BooksDataSetTableAdapters.tblBooksTableAdapter tblBooksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.ComboBox cboAgeRange;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnModifyBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}