using System;
using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Course(string name)
    {
        Name = name;
        Grades = new List<int>();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Course> courses = new List<Course>();
        string studentName, semester;

        Console.WriteLine("Enter student name:");
        studentName = Console.ReadLine();

        Console.WriteLine("Enter semester:");
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
            Console.WriteLine("Course: " + course.Name);
            Console.WriteLine("Grades: " + string.Join(", ", course.Grades) + " (Average: " + CalculateAverage(course.Grades) + "%)");
        }
    }

    public static Course AddCourse()
    {
        Console.WriteLine();
        Console.WriteLine("Enter course name:");
        string courseName = Console.ReadLine();

        Course course = new Course(courseName);

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