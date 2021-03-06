﻿using System;
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

            Console.WriteLine("GradeBook::ComputeStatistics");


            GradeStatistics stats = new GradeStatistics();


            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--) // List properties use the Count property. Arrays use the Length property.
            {
                destination.WriteLine(grades[i - 1]);
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }


                if (_name != value && NameChanged != null)
                {
                    NamedChangedEventArgs args = new NamedChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;

            }
        }

        public event NameChangedDelegate NameChanged;

        private string _name;
        protected List<float> grades; // list convention: names are lower case.
    }
}
