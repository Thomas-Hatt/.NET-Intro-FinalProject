using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);

            // Close the form
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Display all records
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            // Show records by first or last name
            this.tblUsersTableAdapter.FillByName(this.usersDataSet.tblUsers, txtSearch.Text);
        }

        private void btnSearchByLCN_Click(object sender, EventArgs e)
        {
            // Show records by LCN
            this.tblUsersTableAdapter.FillByLCN(this.usersDataSet.tblUsers, txtSearch.Text);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Open the Add User Form (frmAddUser)
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();

            // Set intID equal to the amount of rows + 1
            int intID = tblUsersDataGridView.Rows
                .OfType<DataGridViewRow>()
                .Max(r => int.Parse(r.Cells[0].Value.ToString())) + 1;

            // Clear out the search box
            txtSearch.Clear();

            // Display all records
            this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            // Validate that a row was selected
            if (tblUsersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to modify");
            }
            else
            {
                // Get the unique ID of the member to send to frmModifyMember
                int intID = int.Parse(tblUsersDataGridView.CurrentRow.Cells[0].Value.ToString());

                // Open the Modify Member Form (frmModifyMember)
                frmModifyMember frmModifyMember = new frmModifyMember(intID);
                frmModifyMember.ShowDialog();

                // Clear out the search box
                txtSearch.Clear();

                // Display all records
                this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            // Validate that a row was selected
            if (tblUsersDataGridView.SelectedRows.Count == 0) MessageBox.Show("Select a user to delete");

            // Get the unique ID of the member to delete
            int intID = int.Parse(tblUsersDataGridView.CurrentRow.Cells[0].Value.ToString());

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (result == DialogResult.Yes)
                {
                    // Delete the member
                    this.tblUsersTableAdapter.DeleteUserQuery(intID);

                    // Give the user confirmation
                    MessageBox.Show("Member deleted successfully!");

                    // Clear out the search box
                    txtSearch.Clear();

                    // Display all records
                    this.tblUsersTableAdapter.Fill(this.usersDataSet.tblUsers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}