using System;

namespace student
{
    class Student_name
    {
        string name;


        public Student_name()
        { 
        
        }
        public Student_name(string n)
        {
            name = n;  
        }

        static void Main(string[] args)
        {
            Student_name s = new Student_name();

            Console.WriteLine("enter student name: ");
            string nam= Console.ReadLine();
            Console.WriteLine("student name:"+nam);
           
        }
    }
}
