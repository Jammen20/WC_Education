using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using Client.Models;
using Client.Repositories;

namespace Client
{
    class Program
    {
        static string coursesPath = Path.Combine(Environment.CurrentDirectory, "Data", "courses.json");
        static Storage<Courses> courseStorage = new();
        static List<Courses> courses = courseStorage.Read(coursesPath);

        static string studentsPath = Path.Combine(Environment.CurrentDirectory, "Data", "students.json");
        static Storage<Students> storage = new();
        static List<Students> students = storage.Read(studentsPath);

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("\nVälkommen till WestCoast Education!");
                Console.WriteLine("\nVälj siffra för att komma till din bla bla bla");
                Console.WriteLine("1. Kurser");
                Console.WriteLine("2. Lägg till Kurser");
                Console.WriteLine("3. Studenter");
                Console.WriteLine("4. Lägg till Studenter");
                Console.WriteLine("5. Avsluta ");
                Console.WriteLine("\n");



                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (!courses.Any())
                        {
                            Console.WriteLine("Inga Kurser finns");
                        }
                        foreach (var currentCourse in courses)
                        {
                            Console.WriteLine(currentCourse);
                        }
                        Console.WriteLine("\n Tryck Enter för att fortsätta...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("Kursnummer: ");
                        string courseNumber = Console.ReadLine()!;

                        Console.Write("Titel: ");
                        string title = Console.ReadLine()!;

                        //Program kraschar vid fel inmatning. Borde fixas 
                        Console.Write("Längd: ");
                        int length = int.Parse(Console.ReadLine()!);

                        Console.Write("Startdatum (yyyy-MM-dd): ");
                        DateTime startDate = DateTime.Parse(Console.ReadLine()!);

                        Console.Write("Slutdatum (yyyy-MM-dd): ");
                        DateTime endDate = DateTime.Parse(Console.ReadLine()!);

                        Console.WriteLine("Välj kurstyp:");
                        Console.WriteLine("1. Classroom");
                        Console.WriteLine("2. Distance");
                        string? courseTypeChoice = Console.ReadLine();

                        CourseType courseType;

                        if (courseTypeChoice == "1")
                        {
                            courseType = CourseType.Classroom;
                        }
                        else
                        {
                            courseType = CourseType.Distance;
                        }

                        Courses course = new()
                        {
                            CourseNumber = courseNumber,
                            Title = title,
                            Length = length,
                            StartDate = startDate,
                            EndDate = endDate,
                            CourseType = courseType
                        };
                        courses.Add(course);

                        courseStorage.Write(coursesPath, courses);

                        Console.WriteLine("Kurs sparad!");
                        Console.WriteLine("\n Tryck Enter för att fortsätta...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":

                        if (!students.Any())
                        {
                            Console.WriteLine("Inga Studenter finns");
                        }
                        foreach (var currentStudent in students)
                        {
                            Console.WriteLine(currentStudent);
                        }
                        Console.WriteLine("\n Tryck Enter för att fortsätta...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Write("Förnamn: ");
                        string firstName = Console.ReadLine()!;

                        Console.Write("Efternamn: ");
                        string surName = Console.ReadLine()!;

                        Console.Write("Telefon: ");
                        string phone = Console.ReadLine()!;

                        Console.Write("Personnummer: ");
                        string personNmr = Console.ReadLine()!;

                        Console.Write("Adress: ");
                        string addressLine = Console.ReadLine()!;

                        Console.Write("Postkod: ");
                        string postalCode = Console.ReadLine()!;

                        Console.Write("Stad: ");
                        string city = Console.ReadLine()!;

                        Students student = new()
                        {
                            FirstName = firstName,
                            SurName = surName,
                            Phone = phone,
                            PersonNmr = personNmr,
                            AddressLine = addressLine,
                            PostalCode = postalCode,
                            City = city
                        };

                        students.Add(student);

                        storage.Write(studentsPath, students);

                        Console.WriteLine("Student sparad!");
                        Console.WriteLine("\n Tryck Enter för att fortsätta...");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case "5":

                        return;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }
    }
}
