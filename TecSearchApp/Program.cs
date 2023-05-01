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
        // Jagged 2d array that hold all the info of the teachers, students and courses
        // multiArray[0] Is the list of teachers, [1] is students and [2] is courses
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

        // Regular 2d array for the student search function, as every student has every teacher and every course
        string[,] student = new string[2, 7] {
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

        // flag named "close" which is set to false on boot, and if the user chooses option 4 in the main menu it will be set to true and the loop will stop, closing the application
        bool close = false;

        // Declaring the different enums 
        Options a = Options.Teacher;
        Options b = Options.Student;
        Options c = Options.Course;

        // Main while loop, which the entire program runs within
        while (close == false)
        {
            // Main menu with the criterias presented as options
            Console.WriteLine("----- Welcome to TechSearcApp -----");
            Console.WriteLine("-- Please choose search criteria --");
            Console.WriteLine($"Type \"1\" for: {a}");
            Console.WriteLine($"Type \"2\" for: {b}");
            Console.WriteLine($"Type \"3\" for: {c}");
            Console.WriteLine("Type \"4\" to close application");
            Console.Write("Input choice: ");
            
            // Reads users input and loads it into the string "answer"
            string? answer = Console.ReadLine();
            
            // Calls the methode "CriteriaCheck" to make sure the users input alligns with one of the possible options
            bool criteriaCheck = CustomClasses.CriteriaCheck(answer);

            // If the CriteriaCheck is correct it will proceed into this if-sentence and continue 
            if (criteriaCheck == true)
            {

                // Switch case for the different options
                switch (answer)
                {
                    case "1": // Case 1: Teachers
                        bool flag = true;
                        do
                        {
                            // Requests teachers name
                            Console.WriteLine($"Please input the desired {a}'s First and Last name");
                            Console.WriteLine("Options: \"Niels Olesen\", \"Flemming Sørensen\", \"Peter Suni Lindenskov\", \"Henrik Vincents Poulsen\"");

                            // Loads userinput into string "ToLower" to allow for name to be input in either lower or upper case
                            string? teacherName = Console.ReadLine().ToLower();

                            // Methode that checks if userinput is one of possible options
                            bool checkTeacherName = CustomClasses.TeacherNameCheck(teacherName);
                            if (checkTeacherName == true)
                            {
                                // Foreach loop to run through all of multiArray to check which of the arrays the userinput matches with
                                foreach (string item in multiArray[0])
                                {
                                    Console.WriteLine("Correct Teacher Name");

                                    // If sentence to check which of the teachers fits, afterwards the correct info is printed from the multiarray
                                    if (teacherName.Equals("niels olesen"))
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][0] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][1] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][2] + "\n"}");
                                        Console.WriteLine($"{c}: {multiArray[2][4] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        // Foreach just to print every student
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("flemming sørensen")) // Does the same as the "Niels Olesen" example
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][3] + "\n"}");
                                        Console.WriteLine($"{b}s:");

                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("peter lindenskov")) // Does the same as the "Niels Olesen" example
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][5] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                    else if (teacherName.Equals("henrik poulsen")) // Does the same as the "Niels Olesen" example
                                    {
                                        Console.WriteLine($"{c}: {multiArray[2][6] + "\n"}");
                                        Console.WriteLine($"{b}s:");
                                        foreach (string Student in multiArray[1])
                                        {
                                            Console.WriteLine(Student);
                                        }
                                        break;
                                    }
                                } // Lets the user know that they can press any button and the app will then go back to the main menu
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else
                            { // If  the user does not input one of the possible options this will trigger
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
                            // Asks the user to input the desired students name and loads it into the "studentName" string 
                            Console.WriteLine($"Please input the desired {b}'s First and Last name");
                            string? studentName = Console.ReadLine();
                            
                            //Checks if the userinput matches any of the possible correct student names if it does it will enter the if portion of the if-sentence if not it will print an error msg
                            bool checkStudentName = CustomClasses.StudentNameCheck(studentName);
                            if (checkStudentName == true)
                            {
                                // for loop to run though the student array and print out all matching teachers and courses
                                for (int i = 0; i <= student.GetUpperBound(1); i++)
                                {
                                    string course = student[0, i];
                                    Console.WriteLine($"{c}: {course}");
                                    string teacher = student[1, i];
                                    Console.WriteLine($"{a}: {teacher}\n");

                                } // Prompts the user to press any button and search again
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else // if the input was incorrect this is be ran
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
                            // Prompts the user to input the desired course name, with the options displayed
                            Console.WriteLine($"Please input the desired {c}");
                            Console.WriteLine("Options: \"Studieteknik\", \"Grundlæggende Programmering\", \"Database Programmering\", \"OOP\", \"Computerteknologi\", \"Clientside Programmering\", \"Netværk\"");

                            // loads the userinput into the courseName string and puts it ToLower 
                            string? courseName = Console.ReadLine().ToLower();

                            // Checks if its a possible answer and sets the check to true or false depending on the answer
                            bool courseNameCheck = CustomClasses.CourseNameCheck(courseName);
                            if (courseNameCheck == true) // If true this portion of the if sentence will be ran
                            {
                                // Foreach loop to check which of the different courses was writting, each course then has its own foreach loop and pulls the information regarding the course from multiArray
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
                                } // Prompts the user to press any button and search again
                                Console.WriteLine("Press Any button to search again.");
                                Console.ReadKey();
                                flag = false;
                                Console.Clear();
                            }
                            else // If the answer was incorrect the following will be printed
                            {
                                Console.WriteLine("Incorrect input, please press any key and try again");
                                Console.ReadKey();
                                Console.Clear();
                            }


                        } while (flag == true);
                        break;

                    case "4": // Close, this simply ends the console app if chosen
                        close = true;
                        break;
                }
            }
            else // If the answer is not 1-4 thiis will be printed and the program loop back to the beginning
            {
                Console.WriteLine("Incorrect input, please press any key and try again");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }


}