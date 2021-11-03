using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    public static class Calculations
    {
        //grading system...
        public static char Grade(decimal score)
        {
            if (score >= 70 && score <= 100)
            {
                return 'A';

            }
            else if ((score >= 60) &&( score <= 69))
            {
                return 'B';
            }
            else if ((score >= 50) && (score <= 59))
            {
                return 'C';
            }
            else if (score >= 45 && score <= 49)
            {
                return 'D';

            }
            else if (score >= 40 && score <= 44)
            {
                return 'E';

            }
            else
            {
                return 'F';
            }

        }

        //switch case...
        public static int GradePoint(char grade)
        {
              switch(grade)
            {
                case 'A':

                    return 5;
                case 'B':
                    return 4;
                case 'C':
                    return 3;
                case 'D':
                    return 2;
                case 'E':
                    return 1;
                case 'F':
                    return 0;
                default:
                    return 0;


            }
        }

        //quality point calculations...
        
        public static decimal qualityPointCalculation(List<Course> course)

        {
            int totalCourseUnit = 0;
           
            int totalQualityPoint = 0;
            decimal gpa = 0;

            for (int i = 0; i < course.Count; i++)
            {
                totalQualityPoint +=  ( course[i].CourseUnit * GradePoint(Grade(course[i].Score)));
                totalCourseUnit += course[i].CourseUnit;
            }
      
            try
            {
                gpa = (decimal)totalQualityPoint / totalCourseUnit;
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input! try again...");
            }
            return gpa;
        }

      

    }
}