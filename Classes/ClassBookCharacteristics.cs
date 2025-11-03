using System;
using System.Collections.Generic;

namespace __BookCharacteristics
{
    public class ClassBookCharacteristics
    {
        // Public properties for the book
        public string Title { get; set; }

        public string Author { get; set; }
        public int Pages { get; set; }
        public List<string> Genres { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }
        public char AgeRange { get; set; }
        public int Copies { get; set; }

        // Constructor to initialize a new book instance
        public ClassBookCharacteristics(string title, string author, int pages, List<string> genres, string language, int rating, char ageRange, int copies)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Genres = genres;
            Language = language;
            Rating = rating;
            AgeRange = ageRange;
            Copies = copies;
        }

        // Enum for all age categories (and grouping them for the database)
        public enum AgeCategory
        {
            Child = 0,
            PG13 = 1,
            Adult = 2
        }


        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Pages: {Pages}");
            Console.WriteLine($"Genres: {string.Join(", ", Genres)}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Rating: {Rating}");
            Console.WriteLine($"Age Range: {AgeRange}");
            Console.WriteLine($"Copies: {Copies}");
        }

        // List for the different book genres
        public static List<string> GetBookGenres()
        {
            return new List<string>
            {
                "Fantasy",
                "Science Fiction",
                "Mystery",
                "Thriller",
                "Romance",
                "Horror",
                "Historical Fiction",
                "Non-Fiction",
                "Biography",
                "Poetry",
                "Adventure",
                "Fiction"
            };
        }

        // List for the different book languages
        public static List<string> GetLanguages()
        {
            return new List<string>
            {
                "English",
                "Spanish",
                "French",
                "Other"
            };
        }
    }
}