using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
   public class Book
    {
        private List<double> grades; // private members are accessed within class
        public string Name;


        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
      

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }



        public statistics Getstat()
        {
            var result = new statistics();
            result.Average = 0.0; 
            result.high = double.MinValue;
            result.low = double.MaxValue;

            foreach (var grade in grades)
            {
                if (grade > result.high)  /// no need of if loop
                {
                    result.high = grade;   /// highGrade=math.Min(number, highGrade);
                }

                if (grade < result.low)    /// no need of if loop
                {
                    result.low = grade;   /// lowGrade=math.Max(number, lowGrade);
                }
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }



        
    }
}
