using System;

namespace Grades
{
    class Program
    {
        static void Main()
        {

            GradeBook book = new();

            book.NameChanged += OnNameChanged;

            book.Name = "Dan's Grade Book";

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            book.WriteGrades(Console.Out);
             
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($" {book.Name}");
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Desciption, stats.LetterGrade);
        }

        private static void WriteResult(string description, string result)
        {
            Console.WriteLine($" {description}: {result}", description, result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($" {description}: {result:F2}", description, result);
        }

        static void OnNameChanged(object sender, NamesChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changed name from {args.ExistingName} to {args.NewName}");
            Console.WriteLine($"***");
        } 

    }

}
 