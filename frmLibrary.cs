using Final_Project___Library_Management_System.Modify;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmLibrary : Form
    {
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void tblBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'booksDataSet.tblBooks' table. You can move, or remove it, as needed.
                this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Display all records
            this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            // Open the Add User Form (frmAddUser)
            frmAddBook frmAddBook = new frmAddBook();
            frmAddBook.ShowDialog();

            // Set intID equal to the amount of rows + 1
            int intID = tblBooksDataGridView.Rows
                .OfType<DataGridViewRow>()
                .Max(r => int.Parse(r.Cells[0].Value.ToString())) + 1;

            // Clear out the search box
            txtSearch.Clear();

            // Display all records
            this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);
        }

        private void btnModifyBook_Click(object sender, EventArgs e)
        {
            // Validate that a row was selected
            if (tblBooksDataGridView.SelectedRows.Count == -1)
            {
                MessageBox.Show("Select a book to modify");
            }
            else
            {
                // Get the unique ID of the book to send to frmModifyBook
                int intID = int.Parse(tblBooksDataGridView.CurrentRow.Cells[0].Value.ToString());

                // Open the Modify Book Form (frmModifyBook)
                frmModifyBook frmModifyBook = new frmModifyBook(intID);
                frmModifyBook.ShowDialog();

                // Clear out the search box
                txtSearch.Clear();

                // Display all records
                this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);
            }
        }

        private void cboSearchQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                switch (comboBox.SelectedIndex)
                {
                    // Search by Title
                    case 0:
                        this.tblBooksTableAdapter.FillByTitle(this.booksDataSet.tblBooks, txtSearch.Text);

                        break;

                    // Search by Author
                    case 1:
                        this.tblBooksTableAdapter.FillByAuthor(this.booksDataSet.tblBooks, txtSearch.Text);

                        break;

                    // Search by Genre
                    case 2:
                        this.tblBooksTableAdapter.FillByGenre(this.booksDataSet.tblBooks, txtSearch.Text);

                        break;

                    // Search by Language
                    case 3:
                        this.tblBooksTableAdapter.FillByLanguage(this.booksDataSet.tblBooks, txtSearch.Text);

                        break;

                    // Search by Rating (>=)
                    case 4:
                        // Validate that the search input is a valid number
                        if (!ValidateInput.ClassValidateInput.ValidateNumericTextbox(txtSearch, "The rating amount", out short rating)) return;
                        if (rating > 10) rating = 10;
                        txtSearch.Text = rating.ToString();

                        // Use the TableAdapter method to filter by rating
                        this.tblBooksTableAdapter.FillByRating(this.booksDataSet.tblBooks, rating);
                        break;

                    default:
                        // Code for when no valid item is selected
                        MessageBox.Show("No valid item selected.");
                        break;
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // Validate that a row was selected
            if (tblBooksDataGridView.SelectedRows.Count == 0) MessageBox.Show("Select a user to delete");

            // Get the unique ID of the book to delete
            int intID = int.Parse(tblBooksDataGridView.CurrentRow.Cells[0].Value.ToString());

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (result == DialogResult.Yes)
                {
                    // Delete the book
                    this.tblBooksTableAdapter.DeleteBooksQuery(intID);

                    // Give the user confirmation
                    MessageBox.Show("Book deleted successfully!");

                    // Clear out the search box
                    txtSearch.Clear();

                    // Display all records
                    this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}