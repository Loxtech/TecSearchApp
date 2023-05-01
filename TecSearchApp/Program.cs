using System.Security.Authentication.ExtendedProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TecSearchApp.Classes;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace TecSearchApp;

public class MainClass
{
    public static void Main(string[] args)
    {
        
        string[][] multiArray = new string[3][];
        multiArray[0] = new string[4] {
                   "Niels Olesen",
                   "Flemming Sørensen",
                   "Peter Lindenskov",
                   "Henrik Poulsen" };
        multiArray[1] = new string[16] {
                   "Alexander Thamdrup",
                   "Allan Gawron",
                   "Darab Haqnazar",
                   "Felix Berger",
                   "Jamie El-Dessouky",
                   "Jeppe Pedersen",
                   "Joseph Holland-Hale",
                   "Kamil Kulpa",
                   "Loke Bendtsen",
                   "Mark Larsen",
                   "Niklas Jensen",
                   "Rasmus Hjorth",
                   "Sammy Damiri",
                   "Thomas Holmberg",
                   "Tobias Besser",
                   "Tobias Larsen" };
        multiArray[2] = new string[7]{
                   "Studieteknik",
                   "Grundlæggende Programmering",
                   "Database Programmering",
                   "OOP",
                   "Computerteknologi",
                   "Clientside Programmering",
                   "Netværk"
        };


    string[,] student = new string[2,7] {
        {
                "Studieteknik",
                "Grundlæggende Programmering",
                "Database Programmering",
                "OOP",
                "Computerteknologi",
                "Clientside Programmering",
                "Netværk"
        },
        {
                "Niels Olesen",
                "Niels Olesen",
                "Niels Olesen",
                "Flemming Sørensen",
                "Niels Olesen",
                "Peter Suni Lindenskov",
                "Henrik Vincents Poulsen"
        }
        };


        bool close = false;
        Options a = Options.Teacher;
        Options b = Options.Student;
        Options c = Options.Course;

        while (close == false) 
        {
            
            Console.WriteLine("----- Welcome to TechSearcApp -----");
            Console.WriteLine("-- Please choose search criteria --");
            Console.WriteLine($"Type \"1\" for: {a}");
            Console.WriteLine($"Type \"2\" for: {b}");
            Console.WriteLine($"Type \"3\" for: {c}");
            Console.WriteLine("Type \"4\" to close application");
            Console.Write("Input choice: ");

            //Tjek for fejlindtastning
            string? answer = Console.ReadLine();
            bool criteriaCheck = CustomClasses.criteriaCheck(answer);
            if (criteriaCheck == true)
            {
                switch (answer)
                {
                    case "1": // Teachers
                        bool flag = true;
                        do
                        {
                            Console.WriteLine($"Please input the desired {a}'s First and Last name");
                            Console.WriteLine("Options: \"Niels Olesen\", \"Flemming Sørensen\", \"Peter Suni Lindenskov\", \"Henrik Vincents Poulsen\"");
                            string? teacherName = Console.ReadLine().ToLower();

                            bool checkTeacherName = CustomClasses.teacherNameCheck(teacherName);
                            if (checkTeacherName == true)
                            {
                                foreach (string item in multiArray[0])
                                {

                                    Console.WriteLine("Correct Teacher Name");
                                    if (teacherName.Equals("niels olesen"))
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][0] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][1] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][2] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][4] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("flemming sørensen"))
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][3] + "\n"}");
                                        Console.WriteLine($"{b}s:");

                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("peter lindenskov"))
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][5] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("henrik poulsen"))
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][6] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                }
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input, please press any key and try again");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        } while (flag == true);
                        break;


                    case "2": // Students

                        flag = true;
                        do
                        {
                            Console.WriteLine($"Please input the desired {b}'s First and Last name");
                            string? studentName = Console.ReadLine();
                            bool checkStudentName = CustomClasses.studentNameCheck(studentName);
                            if (checkStudentName == true)
                            {
                                for (int i = 0; i <= student.GetUpperBound(1); i++)
                                {
                                    string course = student[0, i];
                                    Console.WriteLine($"{c}: {course}");
                                    string teacher = student[1, i];
                                    Console.WriteLine($"{a}: {teacher}\n");
                                }
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input, please press any key and try again");
                                Console.ReadKey();
                                Console.Clear();
                            }

                        } while (flag == true);
                        break;

                    case "3": // Courses

                        flag = true;
                        do
                        {
                            Console.WriteLine($"Please input the desired {c}");
                            Console.WriteLine("Options: \"Studieteknik\", \"Grundlæggende Programmering\", \"Database Programmering\", \"OOP\", \"Computerteknologi\", \"Clientside Programmering\", \"Netværk\"");
                            string? courseName = Console.ReadLine().ToLower();
                            bool courseNameCheck = CustomClasses.courseNameCheck(courseName);
                            //check
                            if (courseNameCheck == true)
                            {
                                foreach (string item in multiArray[2])
                                {
                                    Console.WriteLine("Correct Subject Name");
                                    if (courseName.Equals("studieteknik"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][0] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (courseName.Equals("grundlæggende programmering"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][0] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (courseName.Equals("database programmering"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][0] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;

                                    }
                                    else if (courseName.Equals("oop"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][1] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (courseName.Equals("computerteknologi"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][0] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (courseName.Equals("clientside programmering"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][2] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (courseName.Equals("netværk"))
                                    {
                                        Console.WriteLine($"{a}: {multiArray[0][3] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                }
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input, please press any key and try again");
                                Console.ReadKey();
                                Console.Clear();
                            }


                        } while (flag == true);



                        break;

                    case "4":
                        close = true;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Incorrect input, please press any key and try again");
                Console.ReadKey();
                Console.Clear();
            }


        }



    }
        

}