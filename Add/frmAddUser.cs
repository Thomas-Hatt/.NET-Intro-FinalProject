using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
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

            return isValid;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);

            // Clear the inputs and set a default for the date
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            DOBDateTimePicker.Value = new DateTime(2000, 1, 1);
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Validate the inputs before continuing
            if (!ValidateFormInputs()) return;

            // Create a new date to use for the database
            DateTime selectedDate = DOBDateTimePicker.Value.Date;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            // Calculate the member's age
            int age = CalculateAge(DOBDateTimePicker.Value);

            // Determine the membership type depending on age
            int membershipType = ValidateInput.ClassValidateInput.GetAgeRange(age);

            // Generate a random LCN
            string lcn = LibraryCard.LibraryCard.GenerateLibraryCardNumber();

            try
            {
                // Use the TableAdapter to insert the user data
                tblUsersTableAdapter.InsertUser(
                    lastNameTextBox.Text,
                    firstNameTextBox.Text,
                    lcn,
                    formattedDate,
                    0,  // TotalBorrowedBooks default value
                    0,  // TotalOverdueBooks default value
                    membershipType.ToString()  // Assuming CHAR(1) for MembershipType
                );

                // Give the user a confirmation message and clear the form
                MessageBox.Show("User inserted successfully!");

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message);
            }
        }

        private void RefreshUserList()
        {
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
        }

        // Calculate the age of the user
        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        // Determine which membership type the user should have
        private string DetermineMembershipType(int age)
        {
            // Child
            if (age <= 12) return "C";

            // Preteen
            if (age >= 13 && age < 18) return "P";
            // Adult
            if (age >= 18 && age < 65) return "A";

            // Senior
            if (age >= 65) return "S";

            // Default of "C";
            else
            {
                return "C";
            }
        }
    }
}