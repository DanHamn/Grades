using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Desciption
        {
            get
            {
                string result = LetterGrade switch
                {
                    "A" => "Excellent",
                    "B" => "Good",
                    "C" => "Average",
                    "D" => "Below Average",
                    _ => "Failing",
                };
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (Math.Round(AverageGrade) >= 90)
                {
                    result = "A";
                }
                else if (Math.Round(AverageGrade) >= 80)
                {
                    result = "B";
                }
                else if (Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }
                else if (Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
