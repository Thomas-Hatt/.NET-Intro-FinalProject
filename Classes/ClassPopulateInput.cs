using __BookCharacteristics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace __ComboBoxPopulator
{
    public static class ComboBoxPopulator
    {
        // Loop through the list of the book genres and add that to the books combobox
        public static void PopulateBookGenresComboBox(ComboBox comboBox)
        {
            List<string> genres = ClassBookCharacteristics.GetBookGenres();
            comboBox.Items.AddRange(genres.ToArray());
        }

        // Loop through the list of the book languages and add that to the languages combobox
        public static void PopulateLanguagesComboBox(ComboBox comboBox)
        {
            List<string> languages = ClassBookCharacteristics.GetLanguages();
            comboBox.Items.AddRange(languages.ToArray());
        }

        // Loop through the enum of the age category and add that to the age combobox
        public static void PopulateAgeCategoryComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(new { Text = "Child", Value = (int)ClassBookCharacteristics.AgeCategory.Child });
            comboBox.Items.Add(new { Text = "PG13", Value = (int)ClassBookCharacteristics.AgeCategory.PG13 });
            comboBox.Items.Add(new { Text = "Adult", Value = (int)ClassBookCharacteristics.AgeCategory.Adult });

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
        }


        // Loop from 1 to 10 and add those values to the Ratings combobox
        public static void PopulateRatingComboBox(ComboBox comboBox)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBox.Items.Add(i);
            }
        }
    }
}
