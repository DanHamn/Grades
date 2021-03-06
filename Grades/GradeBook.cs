using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        internal void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i-1]);
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NamesChangedEventArgs args = new();
                        args.ExistingName = _name;
                        args.NewName = value;
                        
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }
        public event NameChangedDelegate NameChanged;

        private string _name;
        private readonly List<float> grades;
    }
}
 