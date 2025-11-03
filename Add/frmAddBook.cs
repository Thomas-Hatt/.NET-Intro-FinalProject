using __ComboBoxPopulator;
using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.tblBooks' table. You can move, or remove it, as needed.
            this.tblBooksTableAdapter.Fill(this.booksDataSet.tblBooks);

            // Populate the genres, age ranges, ratings, and languages
            ComboBoxPopulator.PopulateBookGenresComboBox(cboGenre);
            ComboBoxPopulator.PopulateAgeCategoryComboBox(cboAgeRange);
            ComboBoxPopulator.PopulateRatingComboBox(cboRating);
            ComboBoxPopulator.PopulateLanguagesComboBox(cboLanguage);

            // Clear the inputs and set some default values
            titleTextBox.Text = string.Empty;
            authorTextBox.Text = string.Empty;
            pagesTextBox.Text = "0";
            cboGenre.SelectedIndex = 0;
            cboLanguage.SelectedIndex = 0;
            cboRating.SelectedIndex = 9;
            cboAgeRange.SelectedIndex = 1;
            copiesTextBox.Text = "1";
        }

        // Function that validates all comboboxes
        private bool ValidateComboBoxes()
        {
            return cboGenre.SelectedIndex == -1 ||
                   cboAgeRange.SelectedIndex == -1 ||
                   cboLanguage.SelectedIndex == -1 ||
                   cboRating.SelectedIndex == -1;
        }

        // Function that validates all input baed off of the ValidateInput class
        private bool ValidateFormInputs()
        {
            bool isValid = true;

            // Validate book title textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateTextBox(titleTextBox, "The title", 2);

            // Validate author textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateTextBox(authorTextBox, "The author", 2);

            // Validate pages textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateNumericTextbox(pagesTextBox, "The pages amount", out short pages);

            // Validate copies textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateNumericTextbox(copiesTextBox, "The copies amount", out short copies);

            // Validate combo boxes
            if (ValidateComboBoxes())
            {
                MessageBox.Show("Please select a value for all combo boxes.");
                isValid = false;
            }

            return isValid;
        }

        private void tblBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and convert pages amount
                if (!ValidateInput.ClassValidateInput.ValidateNumericTextbox(pagesTextBox, "The pages amount", out short pages)) return;

                // Validate and convert copies amount
                if (!ValidateInput.ClassValidateInput.ValidateNumericTextbox(copiesTextBox, "The copies amount", out short copies)) return;

                // Validate and convert rating from ComboBox
                if (!ValidateInput.ClassValidateInput.ValidateComboBox(cboRating, "The rating", out short rating)) return;

                // Retrieve age range from ComboBox
                if (cboAgeRange.SelectedItem == null)
                {
                    MessageBox.Show("Please select an age category.");
                    return;
                }

                // Extracting the integer value from the selected item
                int ageRange = (int)((dynamic)cboAgeRange.SelectedItem).Value;

                // Use the TableAdapter to insert the book data
                tblBooksTableAdapter.InsertBook(
                    titleTextBox.Text,
                    authorTextBox.Text,
                    pages,
                    cboGenre.Text,
                    cboLanguage.Text,
                    rating,
                    ageRange.ToString(),
                    copies
                );

                // Confirmation message
                MessageBox.Show("Book inserted successfully!");

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting book: " + ex.Message);
            }
        }
    }
}