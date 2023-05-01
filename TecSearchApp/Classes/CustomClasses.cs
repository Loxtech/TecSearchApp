using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TecSearchApp.Classes
{
    public enum Options
    {
        Teacher,
        Student,
        Course
    }



    public class CustomClasses
    {

        public static bool teacherNameCheck(string teacherName)
        {
            if (teacherName == "niels olesen" || teacherName == "flemming sørensen" || teacherName == "peter lindenskov" || teacherName == "henrik poulsen")
            {
                return true;
            }
            else 
                return false;

        }  
        public static bool studentNameCheck(string studentName) 
        { 
           
        if (studentName == "alexander thamdrup" || studentName == "allan gawron" || studentName == "darab haqnazar" || studentName == "felix berger" || studentName == "jamie el-dessouky" || studentName == "jeppe pedersen" || studentName == "kamil kulpa" || studentName == "loke bendtsen" || studentName == "mark larsen" || studentName == "niklas jensen" || studentName == "rasmus hjorth" || studentName == "sammy damiri" || studentName == "thomas holmberg" || studentName == "tobias besser" || studentName == "tobias larsen" || studentName == "joseph holland-hale") 
            {
                return true;
            }
            else 
                return false;
        }
        public static bool courseNameCheck(string courseName)
        {
            if (courseName == "studieteknik" || courseName == "grundlæggende programmering" || courseName == "database programmering" || courseName == "oop" || courseName == "computerteknologi" || courseName == "clientside programmering" || courseName == "netværk")
            {
                return true;
            }
            else
                return false;
        }
        public static bool criteriaCheck(string criteria)
        {
            if (criteria == "1" || criteria == "2" || criteria == "3" || criteria == "4")
            {
                return true;
            }
            else
                return false;

        }
    }
}


// Niels Olesen
// Studieteknik, Grndl prog, Database, Computertek, 

// Flemming Sørensen
// OOP

// Peter Suni Lindenskov
// Clientside

// Henrik Vincents Poulsen
// Netværk

// Studieteknik

// Alt andent

// Alexander Mathias Thamdrup
// Allan Gawron
// Darab Haqnazar
// Felix Enok Berger
// Jamie Jamahl de la Sencerie El-Dessouky
// Jeppe Carlseng Pedersen
// Joseph Holland-Hale
// Kamil Marcin Kulpa
// Loke Emil Bendtsen
// Mark Hyrsting Larsen
// Niklas Kim Jensen
// Rasmus Peter Hjorth
// Sammy Damiri
// Thomas Mose Holmberg
// Tobias Casanas Besser
// Tobias Kofoed Larsen
