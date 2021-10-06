using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_Coordinator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Course Coordinator application");
       
           var students = new List<string> {"Jones Ray", "John Brown", "Mae Lee", "Bruce Green", "Bill Cooper"};
           String [] studentsNames = {"Jones Ray", "John Brown", "Mae Lee", "Bruce Green", "Bill Cooper"};
           String [] coursesList = {"Nursing", "Vision Science", "Science", "Business", "Information technology"}; 
           var nameQuery = from student in studentsNames
                 where student[0]=='B'
                 select student;
        
           var moreStudents = new List<string> {"Charlotte Smith", "Charlie Brown", "Michael Cooper", "Katie Brown", "Grahame Allen", "Matt Polm"};
           var courses = new List<string> {"Nursing", "Vision Science", "Science", "Business", "Information technology"};
           
            while(true)
            {
                Console.WriteLine("What do you want to do?");
                 Console.WriteLine("Students");
                 Console.WriteLine("Courses");
                 Console.WriteLine("Enrollment");
                 Console.WriteLine("Unenrol");
                 Console.WriteLine("AddCourse");
                 Console.WriteLine("Remove course");  
                 Console.WriteLine("Find a Student by the letter");
                 Console.WriteLine("List of courses that each student enrolled on");
                 Console.WriteLine("X = Exit"); 
                 var userInput = Console.ReadLine();

                 if (userInput.ToLower() == "x" || userInput.ToUpper() == "X")
                 {
                     break;
                 }
                 // respond to the user command
                switch (userInput)
               {

                   case "Students":
                
                 
                 Console.WriteLine("Here is a list of students:");
                
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }

                 break;

                 case "Courses":
                 Console.WriteLine("Here is a list of courses:");

                 foreach (var course in courses)
                 {
                   Console.WriteLine(course);     
                 }
                
                  break;

                 case "Enrollment":
                 
                 students.AddRange(moreStudents);
                 for (var i=0; i<students.Count; i++)

                 {
                     Console.WriteLine(students[i]);
                 }

                 break;

                 case "Unenrol":

                 students.RemoveAt(4);
                 for (var i=0; i<students.Count; i++)
                 {
                     Console.WriteLine(students[i]);
                 }
                 break;

                 case "AddCourse":

                 courses.Insert(1,"Teaching");
                
                for (var i=0; i<courses.Count; i++)
         
                 {
                    Console.WriteLine(courses[i]);  
                         
                 }
                 break;

                 case "Remove course":
                 courses.Remove("Science");
                 for(var i = 0; i < courses.Count; i++)

                 {
                   Console.WriteLine(courses[i]);  
                 }

                 break;

                 case "Find a Student by the letter":
                 
                 foreach(string s in nameQuery)
                 {
                     Console.WriteLine(s);
                 }
                 break;

                case "List of courses that each student enrolled on":
                for (int i = 0; i < studentsNames.Length; i++) 
             
                 {
                     Console.WriteLine($"Students {studentsNames[i]} enrolled on following course {coursesList[i]}");
                 }

                  break;
  
                 default:

                 Console.WriteLine("I did not recognise that command");
                 break;
               }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

               }


            }

        }
    }
