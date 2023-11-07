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
         List<int> grades { get; set; }

        public Course(string department, int number, int section)
        {
            courseDept = department;
            courseNum = number;
            courseSec = section;
            grades = new List<int>();
        
        
        }

        public override string ToString()
        {
            string gradesString = string.Join(", ", grades);

            return gradesString;
        }

        public void AddGrade(int input)
        {
            grades.Add(input);
        }


        private double CalcAverage()
        {
            
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }

            double average = (double)sum / grades.Count;
            return average;
        }

        public double GetGradeAverage()
        {
           
            return CalcAverage();

        }


    }
}




