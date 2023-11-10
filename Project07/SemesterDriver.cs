using System;
using System.Collections.Generic;
using Project07;


public class Program
{
    public static void Main()
    {
        List<Course> courses = new List<Course>();
        string studentName, semester;

        Console.Write("What is the student name: ");
        studentName = Console.ReadLine();

        while (string.IsNullOrEmpty(studentName))
        {
            Console.WriteLine("Student Name can't be empty! Please Input your name");
            studentName = Console.ReadLine();
        }

        Console.Write("What is the current semester: ");
        semester = Console.ReadLine();

        
        while (string.IsNullOrEmpty(semester))
        {
            Console.WriteLine("the semester can't be empty! Please Input the current semester");
            semester = Console.ReadLine();
        }

        bool addCourses = true;
        while (addCourses)
        {
            Course course = AddCourse();
            courses.Add(course);

            Console.WriteLine("Add another course? (Y/N)");
            string response = Console.ReadLine();
            addCourses = response.Equals("Y", StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine();
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("==========================");
        

        foreach (Course course in courses)
        {
            Console.WriteLine();
            Console.WriteLine(course.courseDept.ToUpper() + " " + String.Format("{0:0000}", course.courseNum) + "-" + String.Format("{0:000}", course.courseSec));
            Console.WriteLine("Grades: " + course.ToString());
            Console.WriteLine("Average: " + course.GetGradeAverage()  + "%") ;
            Console.WriteLine("-------------------------------");
        }
    }

    public static Course AddCourse()
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter course information:");
        Console.Write("Department (i.e., CSCI, HIST): ");
        string Department = Console.ReadLine();

        while (string.IsNullOrEmpty(Department))
        {
            Console.WriteLine("the Department can't be empty! Please Input the department");
            Department = Console.ReadLine();
        }

        Console.Write("Course Number (i.e., 1250, 1200): ");
        var numberAsString = Console.ReadLine();

        while (string.IsNullOrEmpty(numberAsString))
        {
            Console.WriteLine("the Couse Number can't be empty! Please Input the Course Number");
            numberAsString = Console.ReadLine();
        }

        int Number;
        while (!int.TryParse(numberAsString, out Number))
        {
            Console.WriteLine("the Course Number can't contain letters! Please Input the Course Number");
            numberAsString = Console.ReadLine();
        }

        Console.Write("Course Section (i.e., 001, 901): ");
        var sectionAsString = Console.ReadLine();

        while (string.IsNullOrEmpty(sectionAsString))
        {
            Console.WriteLine("the Course Section can't be empty! Please Input the Course Section");
            sectionAsString = Console.ReadLine();
        }

        int Section;
        while (!int.TryParse(sectionAsString, out Section))
        {
            Console.WriteLine("the Course Section can't contain letters! Please Input the Course Section");
            sectionAsString = Console.ReadLine();
        }

        Console.WriteLine(Department.ToUpper() + " " + String.Format("{0:0000}", Number) + "-" + String.Format("{0:000}", Section) + " has been added");
        Console.WriteLine("");

        Course course = new Course(Department, Number, Section);

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enter grade " + i + ":");
            string gradeAsString = Console.ReadLine();


            while (string.IsNullOrEmpty(gradeAsString))
            {
                Console.WriteLine("Grade can't be empty! Please Input Grade " + i);
                gradeAsString = Console.ReadLine();
            }

            int grade;
            while (!int.TryParse(gradeAsString, out grade) || grade < 0)
            {
                Console.WriteLine("Grade must contain a positive number ! Please Input Grade " + i);
                gradeAsString = Console.ReadLine();
                        
            }

            
            course.AddGrade(grade);
            

        }

        return course;
    }
           
}