using System;

namespace StudentInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("Welcome to my Bank!");
            Console.WriteLine("************************");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. List all students");
                Console.WriteLine("3. Add a course");
                Console.WriteLine("4. List all courses");
                Console.WriteLine("5. Add student score");
                Console.WriteLine("6. Add a student scores");
                Console.Write("Select an option");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Student Information System!");
                        return;
                    case "1":
                        Console.Write("Name ");
                        var name = Console.ReadLine();
                        Console.Write("Address ");
                        var address = Console.ReadLine();
                        Console.Write("Email ");
                        var email = Console.ReadLine();
                        Console.Write("Date of Birth");
                        var dob = DateTime.Parse(Console.ReadLine());
                        var s1 = Admin.AddStudent(name, address, email, dob);
                        Console.WriteLine($"Student ID : {s1.Id}, Name: {s1.Name} Address: {s1.Address}, Email: {s1.Email}, DOB: {s1.Dob} ");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }
            }



        }
    }
        
}
