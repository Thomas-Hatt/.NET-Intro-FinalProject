using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmGeneratedReport : Form
    {
        public frmGeneratedReport()
        {
            InitializeComponent();
        }

        private void frmGeneratedReport_Load(object sender, EventArgs e)
        {
            // Fill the dataset tables (these are invisible but are important for loading in the data from the database)
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
            this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);

            // Create variables to reference the data tables
            var usersTable = this.usersDataSet.tblUsers;
            var booksTables = this.booksDataSet.tblBooks;

            // Calculate the required values
            // Totals
            int totalMembers = usersTable.Count;
            int totalBorrowedBooks = (int)this.tblUsersTableAdapter.GetTotalBorrowedBooks();
            int totalOverdueBooks = (int)this.tblUsersTableAdapter.GetTotalOverdueBooks();
            int totalBookCopies = (int)this.tblBooksTableAdapter.GetTotalCopies();

            // Average
            DateTime? averageAge = (DateTime?)this.tblUsersTableAdapter.GetAverageAge();
            int averageRating = (int)this.tblBooksTableAdapter.GetAverageRating();
            int averageBookPageCount = (int)this.tblBooksTableAdapter.GetAveragePageCount();

            // Most common
            string mostCommonLanguage = this.tblBooksTableAdapter.GetMostCommonLanguage();
            string mostCommonBookGenre = this.tblBooksTableAdapter.GetMostCommonGenre();

            // Update labels with the calculated values
            lblTotalMembers.Text += $"{totalMembers}";
            lblTotalBorrowedBooks.Text += $"{totalBorrowedBooks}";
            lblTotalOverdueBooks.Text += $"{totalOverdueBooks}";
            lblAverageMemberAge.Text += $"{averageAge:MM/dd/yyyy}";
            lblAverageBookRating.Text += $"{averageRating}";
            lblAverageBookPageCount.Text += $"{averageBookPageCount}";
            lblMostCommonLanguage.Text += $"{mostCommonLanguage}";
            lblMostCommonBookGenre.Text += $"{mostCommonBookGenre}";
            lblTotalCopiesOfBooks.Text += $"{totalBookCopies}";
        }

        private void tblBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
