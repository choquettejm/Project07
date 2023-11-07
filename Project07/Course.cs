using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project07
{


    public class Course
    {
        //public string Name { get; set; }
        public string courseDept { get; set; }
        public int courseNum { get; set; }
        public int courseSec { get; set; }
        public List<int> grades { get; set; }

        public Course(string department, int number, int section)
        {
            //Name = name;
            courseDept = department;
            courseNum = number;
            courseSec = section;
            grades = new List<int>();
        }



        //public void AddGrade(int input)
        //{
        //    List<int> gradeList = new List<int>();

        //    gradeList.Add(input);
        //}



        //private List<int> grades = new List<int>();

        //private double CalcAverage()
        //{
        //    if (grades.Count == 0)
        //    {
        //        return 0; // Return 0 if the grades List is empty to avoid division by zero
        //    }

        //    int sum = 0;
        //    foreach (int grade in grades)
        //    {
        //        sum += grade;
        //    }

        //    double average = (double)sum / grades.Count;
        //    return average;
        //}


        //public override string ToString()
        //{
        //    StringBuilder gradesString = new StringBuilder();
        //    foreach (int grade in gradesString)
        //    {
        //        gradesString.AppendLine("Grade: " + grade);
        //    }
        //    return gradesString.ToString();
        //}








        //    }

        //    public void ToString(string studentName, string currentSemester, string Department, int courseNum, int courseSec)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Student: " + studentName);
        //        Console.WriteLine("Semester: " + currentSemester);
        //        Console.WriteLine("================================");
        //        Console.WriteLine("Course: " + Department.ToUpper() + " " + courseNum + "-" + courseSec);
        //        Console.Write("Grades: ");
        //        grades.ForEach(element => Console.Write($"{element} "));
        //        Console.WriteLine("Average: " + grades.Average());
        //        Console.WriteLine("-------------------------------");


        //    }




    }
}




