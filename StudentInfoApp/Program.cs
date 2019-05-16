﻿using System;

namespace StudentInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("Welcome to Student Information System!");
            Console.WriteLine("************************");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. List all students");
                Console.WriteLine("3. Add a course");
                Console.WriteLine("4. List all courses");
                Console.WriteLine("5. Add student score");
                Console.WriteLine("6. List student scores");
                Console.Write("Select an option");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Student Information System!");
                        return;

                    case "1":
                        try
                        {
                            Console.Write("Name ");
                            var name = Console.ReadLine();
                            Console.Write("Address ");
                            var address = Console.ReadLine();
                            Console.Write("Email ");
                            var email = Console.ReadLine();
                            Console.Write("Date of Birth mm/dd/yyyy ");
                            var dob = DateTime.Parse(Console.ReadLine());
                            var s1 = Admin.AddStudent(name, address, email, dob);
                            Console.WriteLine($"Student ID : {s1.Id}, Name: {s1.Name}, Address: {s1.Address}, Email: {s1.Email}, DOB: {s1.Dob} ");
                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Please enter valid input. {nx.Message}");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Sorry something went wrong- {ex.Message}");
                        }
                        break;

                    case "2":
                        var students = Admin.GetAllStudents();
                        foreach (var student in students)
                         Console.WriteLine($"Student ID : {student.Id}, Student Name: {student.Name}, Address: {student.Address}, Email: {student.Email}, DOB: {student.Dob} ");
                        break;

                    case "3":
                        try
                        {
                            Console.Write("Course name ");
                            var cName = Console.ReadLine();
                            Console.Write("Credit hours ");
                            var creditHours = Convert.ToInt32(Console.ReadLine());
                            var c1 = Admin.AddCourse(cName, creditHours);
                            Console.WriteLine($" Course ID : {c1.Id}, Course Name: {c1.Name}, Credit Hours: {c1.CreditHours} ");

                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Please enter valid input. {nx.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"CreditHour error. Please provide valid credit hours. Try again");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Sorry something went wrong- {ex.Message}");
                        }
                        break;

                    case "4":
                        var courses = Admin.GetAllCourses();
                        foreach (var course in courses)
                           Console.WriteLine($"Course ID : {course.Id}, Course Name: {course.Name}, Credit Hours: {course.CreditHours} ");
                        break;

                    case "5":
                        try
                        {
                            Console.Write("Student ID ");
                            var sId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Course ID ");
                            var cId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Score ");
                            var score = Convert.ToInt32(Console.ReadLine());
                            Admin.AddStudentScore(sId, cId, score);
                            Console.WriteLine("Student score successfully added!");
                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Please enter valid input. {nx.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Sorry something went wrong- {ex.Message}");
                        }
                        break;
                        ;

                    case "6":
                        try
                        {
                            Console.Write("Student ID ");
                            var studentId = Convert.ToInt32(Console.ReadLine());
                            
                            var studentScores = Admin.GetScoresForStudent(studentId);
                            foreach (var score in studentScores)
                            {
                                Console.WriteLine($"Student Id: {score.StudentId}, Course Id: {score.CourseId}, Score: {score.Score}");
                            }
                        }
                        catch (ArgumentNullException nx)
                        {
                            Console.WriteLine($"Please enter valid input. {nx.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Sorry something went wrong- {ex.Message}");
                        }
                        break;

                    default:
                        break;
                }
            }



        }
    }
    
}
