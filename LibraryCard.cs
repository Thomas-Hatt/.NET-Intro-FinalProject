using Final_Project___Library_Management_System.UsersDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCard
{
    public static class LibraryCard
    {
        private static Random random = new Random();

        // Method to generate a random library card
        public static string GenerateLibraryCardNumber()
        {
            string libraryCardNumber;
            bool exists;

            do
            {
                // Generate a random number and prepend "LCN-"
                int randomNumber = random.Next(000000, 999999);
                libraryCardNumber = "LCN-" + randomNumber;

                // Check if this library card number already exists in the database
                exists = CheckLibraryCardNumberExists(libraryCardNumber);
            } while (exists);

            return libraryCardNumber;
        }

        // Method to validate that the LCN doesn't already exist
        private static bool CheckLibraryCardNumberExists(string libraryCardNumber)
        {
            // Create an instance of the TableAdapter
            tblUsersTableAdapter adapter = new tblUsersTableAdapter();

            // Use the instance to call the GetLCNCount method
            int count = (int)adapter.GetLCNCount(libraryCardNumber);

            return count > 0; // Return true if the count is greater than 0
        }
    }
}