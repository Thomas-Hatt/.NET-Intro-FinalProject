using __ComboBoxPopulator;
using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System.Modify
{
    public partial class frmModifyBook : Form
    {
        private int _ContactID;

        public frmModifyBook(int contactID)
        {
            InitializeComponent();
            _ContactID = contactID;
        }

        private void frmModifyBook_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes
            ComboBoxPopulator.PopulateBookGenresComboBox(cboGenre);
            ComboBoxPopulator.PopulateAgeCategoryComboBox(cboAgeRange);
            ComboBoxPopulator.PopulateRatingComboBox(cboRating);
            ComboBoxPopulator.PopulateLanguagesComboBox(cboLanguage);

            // Load book data for modification
            try
            {
                this.tblBooksTableAdapter.FillByID(this.booksDataSet.tblBooks, _ContactID);

                if (this.booksDataSet.tblBooks.Rows.Count > 0)
                {
                    var row = this.booksDataSet.tblBooks.Rows[0];

                    // Set text boxes
                    titleTextBox.Text = row["Title"].ToString();
                    authorTextBox.Text = row["Author"].ToString();
                    pagesTextBox.Text = row["Pages"].ToString();
                    copiesTextBox.Text = row["Copies"].ToString();

                    // Set selected values for ComboBoxes
                    cboGenre.SelectedItem = row["Genre"].ToString();
                    cboLanguage.SelectedItem = row["Language"].ToString();
                    cboRating.SelectedItem = Convert.ToInt32(row["Rating"]);

                    // Set selected item for cboAgeRange based on its value
                    int ageRangeValue = Convert.ToInt32(row["AgeRange"]);
                    foreach (var item in cboAgeRange.Items)
                    {
                        if ((int)((dynamic)item).Value == ageRangeValue)
                        {
                            cboAgeRange.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No book found with the provided ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book data: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        // Function that validates all comboboxes
        private bool ValidateComboBoxes()
        {
            return cboGenre.SelectedIndex == -1 ||
                   cboAgeRange.SelectedIndex == -1 ||
                   cboLanguage.SelectedIndex == -1 ||
                   cboRating.SelectedIndex == -1;
        }

        // Function that validates all input based off of the ValidateInput class
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

        private void btnModifyBook_Click(object sender, EventArgs e)
        {
            // Validate the inputs before continuing
            if (!ValidateFormInputs()) return;

            try
            {
                var row = this.booksDataSet.tblBooks.Rows[0];

                // Update the DataRow with the new values from ComboBoxes
                row["Title"] = titleTextBox.Text;
                row["Author"] = authorTextBox.Text;
                row["Pages"] = pagesTextBox.Text;
                row["Copies"] = copiesTextBox.Text;
                row["Genre"] = cboGenre.SelectedItem.ToString();
                row["Language"] = cboLanguage.SelectedItem.ToString();
                row["Rating"] = Convert.ToInt32(cboRating.SelectedItem);

                // Retrieve and set AgeRange correctly
                if (cboAgeRange.SelectedItem != null)
                {
                    row["AgeRange"] = (int)((dynamic)cboAgeRange.SelectedItem).Value; // Correctly retrieve integer value
                }

                this.Validate();
                this.tblBooksBindingSource.EndEdit();
                int rowsAffected = this.tableAdapterManager.UpdateAll(this.booksDataSet);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Changes saved successfully!");
                    this.Close();
                }
                else
                {
                    throw new InvalidOperationException("No changes were made or saving failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
    }
}