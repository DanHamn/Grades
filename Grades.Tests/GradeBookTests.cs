using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
        [TestMethod]
        public void ComputeLetterGrade()
        {
            GradeBook book = new();

            float[] numbers = new float[] { 91, 89.5f, 10 };

            book.AddGrade(numbers[0]);
            book.AddGrade(numbers[1]);
            book.AddGrade(numbers[2]);
            GradeStatistics result1 = book.ComputeStatistics();
            float avarage = (numbers[0] + numbers[1] + numbers[2]) / 3;

            string result2 = LetterFind(avarage);

            Assert.AreEqual(result2, result1.LetterGrade);

        }

        private static string LetterFind(float avarage)
        {
            string result2;
            if (Math.Round(avarage) >= 90)
            {
                result2 = "A";
            }
            else if (Math.Round(avarage) >= 80)
            {
                result2 = "B";
            }
            else if (Math.Round(avarage) >= 70)
            {
                result2 = "C";
            }
            else if (Math.Round(avarage) >= 60)
            {
                result2 = "D";
            }
            else
            {
                result2 = "F";
            }

            return result2;
        }
    }
}
