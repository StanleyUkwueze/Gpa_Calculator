using System;
using System.Collections.Generic;
using Week3Task;
using System.Text;

namespace Week3Task
{
    class Program
    {

        static void Main(string[] args)
        {
           
           

            List<Course> courseList = new List<Course>();

            try
            {

                string userInput;
                do
                {
                   
                    Course course = new Course();
                    Console.WriteLine("Enter your Course Name: ");
                    Console.WriteLine();
                    course.CourseName = Console.ReadLine();

                    Console.WriteLine("Enter course code: ");
                    var coursename = course.CourseName;


                    var coursecode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Course Unit: ");
                    course.CourseUnit = int.Parse(Console.ReadLine());
                    var courseunit = course.CourseUnit;
                    Console.WriteLine("Enter course Score: ");
                 
                    var score = Convert.ToDecimal((Console.ReadLine()));

                    // assign user input to course objects
                    course.CourseName = coursename;
                    course.courseCode = coursecode;
                
                    course.Score = score;
                    course.CourseUnit = courseunit;

                    courseList.Add(course);//debuging point...

                    Console.WriteLine("Do you want to register another course: yes/no");
                   
                    userInput = Console.ReadLine();

                }

                while ((userInput.ToLower() == "yes"));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input! try again...");
            }

            DisplayGpa(courseList);
            Console.WriteLine();
            Console.WriteLine( $"Your Gpa is {Calculations.qualityPointCalculation(courseList):N3} to three decimal places"); ;
         }

        static void DisplayGpa(List<Course> courseList)
        {
            Console.WriteLine($"|--------------|------------|-------|-----------|");
            Console.WriteLine($"|COURSE & CODE |COURSE UNIT | GRADE | GRADE-UNIT|");
            Console.WriteLine($"|--------------|------------|-------|-----------|");


            // looping through list container(courses) to get user inputs

            foreach (var item in courseList)
            {
                Console.WriteLine($"|{item.CourseName, -2}  {item.courseCode,-6}| {item.CourseUnit,-11}| { Calculations.Grade(item.Score),-6}| { Calculations.GradePoint(Calculations.Grade(item.Score)),-10}|");

            }
            Console.WriteLine($"|================================================|");

        }

    }

}

