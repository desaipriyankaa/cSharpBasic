using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            var book = new Book("priyanka's grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.4);
            book.AddGrade(20.5);
            var stat = book.Getstat();
             
            Console.WriteLine("lowest number is : " + stat.low);
            Console.WriteLine("highest number is : " + stat.high);
            Console.WriteLine("the average grade is: "+stat.Average);





        }
    }
}
