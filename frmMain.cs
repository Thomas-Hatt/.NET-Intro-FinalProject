using System;
using System.Windows.Forms;

namespace Final_Project___Library_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void btnEnterUserFrm_Click(object sender, EventArgs e)
        {
            // Open the users form (frmUsers)
            frmMembers UsersForm = new frmMembers();
            UsersForm.ShowDialog();
        }

        private void btnEnterLibraryFrm_Click(object sender, EventArgs e)
        {
            // Open the library form (frmLibrary)
            frmLibrary LibraryForm = new frmLibrary();
            LibraryForm.ShowDialog();
        }

        private void btnEnterReportFrm_Click(object sender, EventArgs e)
        {
            // Open the generate report form (frmGeneratedReport)
            frmGeneratedReport frmGeneratedReport = new frmGeneratedReport();
            frmGeneratedReport.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }
    }
}