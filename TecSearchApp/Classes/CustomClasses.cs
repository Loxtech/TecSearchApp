using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TecSearchApp.Classes
{
    // Enum for 3 criterias
    public enum Options
    {
        Teacher,
        Student,
        Course
    }


    // Abstract class for all custom methodes 
    abstract class CustomClasses
    {
        // This methode checks if the users input(ToLower) is one of the following options (Teachers names), if it is true will be returned if not false is returned and the program will infor the user that an error occured
        public static bool TeacherNameCheck(string teacherName)
        {
            if (teacherName == "niels olesen" 
                || teacherName == "flemming sørensen" 
                || teacherName == "peter lindenskov" 
                || teacherName == "henrik poulsen")
            {
                return true;
            }
            else 
                return false;
        }
        // This methode checks if the users input(ToLower) is one of the following options (Student names), if it is true will be returned if not false is returned and the program will infor the user that an error occured
        public static bool StudentNameCheck(string studentName) 
        { 
           
            if (studentName == "alexander thamdrup" 
                || studentName == "allan gawron" 
                || studentName == "darab haqnazar" 
                || studentName == "felix berger" 
                || studentName == "jamie el-dessouky" 
                || studentName == "jeppe pedersen" 
                || studentName == "kamil kulpa" 
                || studentName == "loke bendtsen" 
                || studentName == "mark larsen" 
                || studentName == "niklas jensen" 
                || studentName == "rasmus hjorth" 
                || studentName == "sammy damiri" 
                || studentName == "thomas holmberg" 
                || studentName == "tobias besser" 
                || studentName == "tobias larsen" 
                || studentName == "joseph holland-hale") 
            {
                return true;
            }
            else 
                return false;
        }
        // This methode checks if the users input(ToLower) is one of the following options (Courses), if it is true will be returned if not false is returned and the program will infor the user that an error occured
        public static bool CourseNameCheck(string courseName)
        {
            if (courseName == "studieteknik" 
                || courseName == "grundlæggende programmering" 
                || courseName == "database programmering" 
                || courseName == "oop" 
                || courseName == "computerteknologi" 
                || courseName == "clientside programmering" 
                || courseName == "netværk")
            {
                return true;
            }
            else
                return false;
        }

        // This methode just checks if the use inputs a number from 1-4 in the main menu, if not false is returned
        public static bool CriteriaCheck(string criteria)
        {
            if (criteria == "1" 
                || criteria == "2" 
                || criteria == "3" 
                || criteria == "4")
            {
                return true;
            }
            else
                return false;

        }
    }
}
