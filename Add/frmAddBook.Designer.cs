namespace Final_Project___Library_Management_System
{
    partial class frmAddBook
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label languageLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label ageRangeLabel;
            System.Windows.Forms.Label copiesLabel;
            System.Windows.Forms.Label label1;
            this.booksDataSet = new Final_Project___Library_Management_System.BooksDataSet();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBooksTableAdapter = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.tblBooksTableAdapter();
            this.tableAdapterManager = new Final_Project___Library_Management_System.BooksDataSetTableAdapters.TableAdapterManager();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboAgeRange = new System.Windows.Forms.ComboBox();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            languageLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ageRangeLabel = new System.Windows.Forms.Label();
            copiesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(65, 89);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(50, 24);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(65, 149);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(71, 24);
            authorLabel.TabIndex = 3;
            authorLabel.Text = "Author:";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagesLabel.Location = new System.Drawing.Point(65, 209);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(68, 24);
            pagesLabel.TabIndex = 5;
            pagesLabel.Text = "Pages:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genreLabel.Location = new System.Drawing.Point(65, 269);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(68, 24);
            genreLabel.TabIndex = 7;
            genreLabel.Text = "Genre:";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageLabel.Location = new System.Drawing.Point(65, 329);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new System.Drawing.Size(100, 24);
            languageLabel.TabIndex = 9;
            languageLabel.Text = "Language:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ratingLabel.Location = new System.Drawing.Point(65, 389);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(68, 24);
            ratingLabel.TabIndex = 11;
            ratingLabel.Text = "Rating:";
            // 
            // ageRangeLabel
            // 
            ageRangeLabel.AutoSize = true;
            ageRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageRangeLabel.Location = new System.Drawing.Point(65, 449);
            ageRangeLabel.Name = "ageRangeLabel";
            ageRangeLabel.Size = new System.Drawing.Size(111, 24);
            ageRangeLabel.TabIndex = 13;
            ageRangeLabel.Text = "Age Range:";
            // 
            // copiesLabel
            // 
            copiesLabel.AutoSize = true;
            copiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            copiesLabel.Location = new System.Drawing.Point(65, 509);
            copiesLabel.Name = "copiesLabel";
            copiesLabel.Size = new System.Drawing.Size(74, 24);
            copiesLabel.TabIndex = 15;
            copiesLabel.Text = "Copies:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(215, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 37);
            label1.TabIndex = 19;
            label1.Text = "Add New Book";
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
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(222, 84);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(373, 29);
            this.titleTextBox.TabIndex = 2;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(222, 144);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(373, 29);
            this.authorTextBox.TabIndex = 4;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Pages", true));
            this.pagesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesTextBox.Location = new System.Drawing.Point(222, 204);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(373, 29);
            this.pagesTextBox.TabIndex = 6;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBooksBindingSource, "Copies", true));
            this.copiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesTextBox.Location = new System.Drawing.Point(222, 504);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(373, 29);
            this.copiesTextBox.TabIndex = 16;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(69, 577);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(151, 51);
            this.btnAddBook.TabIndex = 18;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(444, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 51);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(222, 261);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(373, 32);
            this.cboGenre.TabIndex = 20;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // cboAgeRange
            // 
            this.cboAgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboAgeRange.FormattingEnabled = true;
            this.cboAgeRange.Location = new System.Drawing.Point(222, 441);
            this.cboAgeRange.Name = "cboAgeRange";
            this.cboAgeRange.Size = new System.Drawing.Size(373, 32);
            this.cboAgeRange.TabIndex = 21;
            // 
            // cboRating
            // 
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Location = new System.Drawing.Point(222, 381);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(373, 32);
            this.cboRating.TabIndex = 22;
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(222, 321);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(373, 32);
            this.cboLanguage.TabIndex = 23;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 640);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.cboRating);
            this.Controls.Add(this.cboAgeRange);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnAddBook);
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
            this.Name = "frmAddBook";
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.ComboBox cboAgeRange;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.ComboBox cboLanguage;
    }
}