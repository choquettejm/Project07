using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project07
{


    public class Course
    {
        public string courseDept { get; set; }
        public int courseNum { get; set; }
        public int courseSec { get; set; }
        public List<int> grades { get; set; }

        public Course(string department, int number, int section)
        {
            courseDept = department;
            courseNum = number;
            courseSec = section;
            grades = new List<int>();
        }

        public void AddGrade(int input)
        {
            grades.Add(input);
        }



        //public static double CalcAverage(List<int> grades)
        //{
        //    if (grades.Count == 0)
        //    {
        //        return 0;
        //    }

        //    int sum = 0;
        //    foreach (int grade in grades)
        //    {
        //        sum += grade;
        //    }

        //    double average = (double)sum / grades.Count;
        //    return Math.Round(average, 1);
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

    }
}




