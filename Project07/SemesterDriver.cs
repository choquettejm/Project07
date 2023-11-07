using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SemesterDriver
{

    // Course Class and Attributes
    public class Course
    {
        private string department;
        private int courseNum;
        private int section;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public int CourseNum
        {
            get { return courseNum; }
            set { courseNum = value; }
        }

        public int Section
        {
            get { return section; }
            set { section = value; }
        }
    }

    public class Grades
    {
        public int grade { get; set; }
    }


    //private List<int> gradeList = new List<int>();
    


    // MAIN Method

    static void Main()
    {

        string studentName = "";
        string currentSemester = "";

        while (string.IsNullOrEmpty(studentName))
        {
            Console.Write("What is the student name? ");
            studentName = Console.ReadLine();
        }

        while (string.IsNullOrEmpty(currentSemester))
        {
            Console.Write("What is the current semester? ");
            currentSemester = Console.ReadLine();
        }



        AddCourse();
        
               
                     
        //course.ToString(studentName, currentSemester, course.Department, course.CourseNum, course.Section);

        

    }

    static void AddCourse()
    {
        List<Course> courseList = new List<Course>();
        Grades courseGrades = new Grades();

        int numOfGrades = 5;
        string i = "y";

        while (i == "y")
        {

            Console.WriteLine("");
            Console.WriteLine("Please enter course informtion: ");

            Console.Write("Department (i.e., CSCI, HIST): ");
            string Department = Console.ReadLine();

            Console.Write("Course Number (i.e., 1250, 1200): ");
            int CourseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course section (i.e., 001, 901): ");
            int Section = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Course course = new Course { Department = Department, CourseNum = CourseNum, Section = Section };
            courseList.Add(course);
            Console.WriteLine(course.Department.ToUpper() + " " + course.CourseNum + "-" + course.Section + " has been added");
            Console.WriteLine("");
                       
            
            Console.WriteLine("Please enter " + numOfGrades + " grades for this course:");
            for (int x = 0; x < numOfGrades; x++)
            {
                Console.WriteLine($"Grade item { x + 1}: ");
                int input = Convert.ToInt32(Console.ReadLine());

               AddGrades(input);

            }



            Console.WriteLine("Do you have another course to enter? (y/n)");
            i = Console.ReadLine().ToLower();


        }


       
        foreach (Course course in courseList)
        {
            Console.WriteLine($"{course.Department}, {course.CourseNum}, {course.Section}");
        }


    }


    static void AddGrades(int input)
    {
        List<int> gradeList = new List<int>();
        
        gradeList.Add(input);

        //Console.WriteLine("");
        //gradeList.ForEach(element => Console.Write($"{element} "));



    }

        
    public string ToGradeString()
    {
        List<int> gradeList = new List<int>();

        StringBuilder gradesString = new StringBuilder();
        foreach (int grade in gradeList)
        {
            gradesString.AppendLine("Grade: " + grade);
        }
        return gradesString.ToString();
    }



}


