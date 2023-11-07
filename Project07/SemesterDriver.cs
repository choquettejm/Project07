using System;
using System.Collections.Generic;

public class Course
{
    //public string Name { get; set; }
    public string courseDept { get; set; }
    public int courseNum { get; set; }
    public int courseSec { get; set; }
    public List<int> Grades { get; set; }

    public Course(string department, int number, int section)
    {
        //Name = name;
        courseDept = department;
        courseNum = number;
        courseSec = section;
        Grades = new List<int>();
    }
}

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

        foreach (Course course in courses)
        {
            Console.WriteLine();
            Console.WriteLine(course.courseDept.ToUpper() + " " + course.courseNum + "-" + course.courseSec);
            Console.WriteLine("Grades: " + string.Join(", ", course.Grades) + " (Average: " + CalculateAverage(course.Grades) + "%)");
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
            course.Grades.Add(grade);
        }

        return course;
    }

    public static double CalculateAverage(List<int> grades)
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