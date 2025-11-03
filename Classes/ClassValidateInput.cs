using System;
using System.Linq;
using System.Windows.Forms;

namespace ValidateInput
{
    public static class ClassValidateInput
    {
        // Method to check if the textbox is not empty
        public static bool IsNotEmpty(TextBox textbox, string textboxName)
        {
            // If the textbox is null or white space, display an error and return false
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                MessageBox.Show(textboxName + " cannot be empty.");
                return false;
            }
            return true;
        }

        // Method to check if the textbox contains a numeric value
        public static bool IsNumeric(TextBox textbox, string textboxName)
        {
            // If the textbox does not contain a number, display an error and return false
            if (!float.TryParse(textbox.Text, out _))
            {
                MessageBox.Show(textboxName + " must be a valid number.");
                return false;
            }
            return true;
        }

        // Method to check if there is a valid date
        public static bool IsValidDate(DateTimePicker dateTimePicker)
        {
            // The minimum date a user can select
            DateTime minDate = new DateTime(1900, 1, 1);

            // The maximum date a user can select
            DateTime maxDate = DateTime.Today;

            DateTime selectedDate = dateTimePicker.Value;

            // If the selected date is under the minimum or over the maximum, display an error and return false
            if (selectedDate < minDate || selectedDate > maxDate)
            {
                MessageBox.Show($"The date must be between {minDate.ToShortDateString()} and {maxDate.ToShortDateString()}.");
                return false;
            }

            return true;
        }

        // Method to check if the textbox contains a valid length
        public static bool HasLength(TextBox textbox, int requiredLength, string textboxName)
        {
            // If the textbox is not the required length, display and error and return false
            if (textbox.Text.Length < requiredLength)
            {
                MessageBox.Show(textboxName + $" is not long enough. The requirement is {requiredLength} characters.");
                return false;
            }

            return true;
        }

        // Method to check if the number in a textbox is greater than or equal to zero
        private static bool IsNumberPositive(TextBox textBox, string textboxName)
        {
            if (float.TryParse(textBox.Text, out float number))
            {
                if (number >= 0)
                {
                    return true;
                }
            }

            MessageBox.Show(textboxName + " must contain a number greater than 0.");
            return false;
        }

        // Method to check if the books textbox is valid
        public static bool IsValidBookInput(TextBox textbox, string textboxName)
        {
            // Check if the input is a number, has the correct length, and that the number is greater than or equal to 0
            if (ClassValidateInput.IsNumeric(textbox, textboxName) && HasLength(textbox, 1, textboxName) && IsNumberPositive(textbox, textboxName))
            {
                return true;
            }
            return false;
        }

        // Method to check if the textbox contains only letters
        public static bool IsAlphabetic(TextBox textbox, string textboxName)
        {
            if (textbox.Text.Any(char.IsDigit))
            {
                MessageBox.Show(textboxName + " must contain only letters.");
                return false;
            }
            return true;
        }

        // Determine the age range of the user
        public static int GetAgeRange(int age)
        {
            if (age <= 12) return 0;  // Child
            if (age >= 13 && age < 18) return 1;  // PG-13
            if (age >= 18 && age < 65) return 2;  // Adult 
            if (age >= 65) return 'S'; // Senior
            return 'U';  // Unknown, if necessary
        }

        // Helper method to remove some redundancy for alphabetic textboxes
        public static bool ValidateTextBox(TextBox textbox, string textboxName, int requiredLength)
        {
            bool isValid = true;
            isValid &= IsNotEmpty(textbox, textboxName);
            isValid &= IsAlphabetic(textbox, textboxName);
            isValid &= HasLength(textbox, requiredLength, textboxName);
            return isValid;
        }

        // Helper method to remove some redundancy for numeric textboxes
        public static bool ValidateNumericTextbox(TextBox textbox, string textboxName, out short result)
        {
            result = 0;

            // Check if the textbox is empty
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                MessageBox.Show($"{textboxName} cannot be empty.");
                return false;
            }

            // Check if the textbox text is a valid short
            if (!short.TryParse(textbox.Text, out result))
            {
                MessageBox.Show($"{textboxName} must be a valid number.");
                return false;
            }

            // Check if the number is positive
            if (result <= 0)
            {
                MessageBox.Show($"{textboxName} must be a positive number.");
                return false;
            }

            return true;
        }

        // Validate combo boxes
        public static bool ValidateComboBox(ComboBox comboBox, string comboBoxName, out short result)
        {
            result = 0;

            // Check if an item is selected
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show($"{comboBoxName} must be selected.");
                return false;
            }

            // Attempt to convert the selected item to short
            if (!short.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                MessageBox.Show($"{comboBoxName} must be a valid number.");
                return false;
            }

            return true;
        }

        // Validate the age range combobox
        public static bool ValidateAgeRangeComboBox(ComboBox comboBox, string comboBoxName, out int result)
        {
            result = -1;
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show($"{comboBoxName} must be selected.");
                return false;
            }

            if (!int.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                MessageBox.Show($"{comboBoxName} must be a valid number.");
                return false;
            }

            return true;
        }
    }
}