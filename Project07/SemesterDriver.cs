using System;
using System.Collections.Generic;
using Project07;


public class Program
{
    public static void Main(string[] args)
    {
        List<Course> courses = new List<Course>();
        string studentName, semester;

        Console.Write("What is the student name: ");
        studentName = Console.ReadLine();

        Console.Write("What is the current semester: ");
        semester = Console.ReadLine();

        bool addMoreCourses = true;
        while (addMoreCourses)
        {
            Course course = AddCourse();
            courses.Add(course);

            Console.WriteLine("Add another course? (Y/N)");
            string response = Console.ReadLine();
            addMoreCourses = response.Equals("Y", StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine();
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("==========================");

        foreach (Course course in courses)
        {
            Console.WriteLine();
            Console.WriteLine(course.courseDept.ToUpper() + " " + course.courseNum + "-" + course.courseSec);
            Console.WriteLine("Grades: " + string.Join(", ", course.grades));
            Console.WriteLine("Average: " + CalcAverage(course.grades) + "%");
            Console.WriteLine("-------------------------------");
        }
    }

    public static Course AddCourse()
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter course information:");
        Console.Write("Department (i.e., CSCI, HIST): ");
        string Department = Console.ReadLine();

        Console.Write("Course Number (i.e., 1250, 1200): ");
        int Number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Course Section (i.e., 001, 901): ");
        int Section = Convert.ToInt32(Console.ReadLine());

        Course course = new Course(Department, Number, Section);

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enter grade " + i + ":");
            int grade = Convert.ToInt32(Console.ReadLine());
            course.AddGrade(grade);
            //course.grades.Add(grade);
        }

        return course;
    }

    public static double CalcAverage(List<int> grades)
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }

        double average = (double)sum / grades.Count;
        return Math.Round(average, 1);
    }
}