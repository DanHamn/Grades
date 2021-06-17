using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.Name = "Dan's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
             
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($" {book.Name}");
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($" {description}: {result:F2}");
        }
    }

}
 