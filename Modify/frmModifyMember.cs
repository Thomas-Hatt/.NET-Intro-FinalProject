using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmModifyMember : Form
    {
        int _ContactID;
        public frmModifyMember(int contactID)
        {
            InitializeComponent();
            _ContactID = contactID;
        }

        private void frmModifyMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.FillByID(this.usersDataSet.tblUsers, _ContactID);
        }

        // Function that validates all input baed off of the ValidateInput class
        private bool ValidateFormInputs()
        {
            bool isValid = true;

            // Validate first name textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateTextBox(firstNameTextBox, "Your first name", 2);

            // Validate last name textbox
            isValid &= ValidateInput.ClassValidateInput.ValidateTextBox(lastNameTextBox, "Your last name", 2);

            // Validate DOB
            isValid &= ValidateInput.ClassValidateInput.IsValidDate(DOBDateTimePicker);

            // Validate borrowed books
            isValid &= ValidateInput.ClassValidateInput.IsValidBookInput(totalBorrowedBooksTextBox, "Borrowed books");

            // Validate overdue books
            isValid &= ValidateInput.ClassValidateInput.IsValidBookInput(totalOverdueBooksTextBox, "Overdue books");

            return isValid;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            // Validate the inputs before continuing
            if (!ValidateFormInputs()) return;

            try
            {
                this.Validate();
                this.tblUsersBindingSource.EndEdit();
                int rowsAffected = this.tableAdapterManager.UpdateAll(this.usersDataSet);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Changes saved successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No changes were made or saving failed.");
                }
            }
            // If there was an outside error, display that error message
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
    }
}