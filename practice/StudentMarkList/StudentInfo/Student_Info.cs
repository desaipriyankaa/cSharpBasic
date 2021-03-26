using System;
using System.Collections.Generic;


namespace StudentInfo
{
    class Student_Info
    {
       public string name;
        public int[] marks = new int[5];
        
    }

    class StudentMark
    {

        public List<Student_Info> s = new List<Student_Info>();
        public void AddMarks(string name, int[] marks)
        {
            Student_Info si = new Student_Info();
            si.name = name;
            si.marks = marks;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter sub "+i+"marks:");
       
            }



        }
        
        
    }

    class View
    {
        static public StudentMark sm = new StudentMark();
        static public void ViewMarks()
        {

          
            int[] marks = new int[5];

            Console.WriteLine("Enter name of student :");
            string nam = Console.ReadLine();

            Console.WriteLine("Enter marks of student :");

            for (int i=1;i<=5;i++)
            {
               Console.Write("Sub " + i.ToString() + " marks: ");
                marks[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
           
           

            Console.WriteLine("Student name:" + nam);

            for (int i =1; i <=5; i++)
            {

                Console.WriteLine("Sub " + i.ToString() + " marks: ",marks[i]);
                marks[i - 1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

            }

        }
    
        static void Main(string[] args)
        {

        Console.WriteLine("**********Welcome to student marklist Application**********");
        
        ViewMarks();


        }
    }
}
