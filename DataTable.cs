using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator
{
    public class DataTable
    {
        internal static void PrinTDataTable()
        {
            Console.WriteLine("How many course did you take this session: ");
            int NumOfCourseTaken = int.Parse(Console.ReadLine());
            string[] CourseCode = new string[NumOfCourseTaken];
            int[] CourseUnit = new int[NumOfCourseTaken];
            int[] GradeUnit = new int[NumOfCourseTaken];
            string[] Grade = new string[NumOfCourseTaken];
            string[] Remark = new string[NumOfCourseTaken];
            double[] WeightPt = new double[NumOfCourseTaken];
            double TotalWeightPt = 0;
           


            for (int i = 0; i < NumOfCourseTaken; i++)
            {
                Console.WriteLine("Input your course code {0}", i + 1);
                CourseCode[i] = Console.ReadLine();
                Console.Write("Course Unit: ");
                CourseUnit[i] = int.Parse(Console.ReadLine());
                Console.Write("Score: ");
                GradeUnit[i] = int.Parse(Console.ReadLine());

                if (GradeUnit[i] >= 70)
                {
                    GradeUnit[i] = 5;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "A";
                    Remark[i] = "Excellent";
                }
                else if (GradeUnit[i] >= 60 && GradeUnit[i] <= 69)
                {
                    GradeUnit[i] = 4;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "B";
                    Remark[i] = "Very Good";
                }
                else if (GradeUnit[i] >= 50 && GradeUnit[i] <= 59)
                {
                    GradeUnit[i] = 3;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "C";
                    Remark[i] = "Good";
                }
                else if (GradeUnit[i] >= 45 && GradeUnit[i] <= 49)
                {
                    GradeUnit[i] = 2;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "D";
                    Remark[i] = "Fair";
                }
                else if (GradeUnit[i] >= 40 && GradeUnit[i] <= 44)
                {
                    GradeUnit[i] = 1;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "E";
                    Remark[i] = "Pass";
                }
                else if (GradeUnit[i] >= 0 && GradeUnit[i] <= 39)
                {
                    GradeUnit[i] = 0;
                    WeightPt[i] = GradeUnit[i] * CourseUnit[i];
                    Grade[i] = "F";
                    Remark[i] = "Fail";
                }
                else
                {
                    WeightPt[i] = 0;
                    Grade[i] = "Out of range";
                    Remark[i] = "";
                }
                
                Console.WriteLine("");
            }

            
            PrintTable.printTable();

            for (int i = 0; i < NumOfCourseTaken; i++)
            {

                Console.WriteLine("| {0,-26} | {1,-21} | {2,-10} | {3,-19} | {4,-16} | {5,-16} |", CourseCode[i], CourseUnit[i], Grade[i],
                                GradeUnit[i], WeightPt[i], Remark[i]);

            }

            int TotalNoOfCourseReg = 0;
            int TotalNoOfCoursePassed = 0;
            

            for (int i = 0; i < NumOfCourseTaken; i++)
            {

                TotalNoOfCourseReg += CourseUnit[i];
                if (GradeUnit[i] > 0)
                {
                    TotalNoOfCoursePassed++;
                }
            }


            double TotalUnitReg = CourseUnit.Sum();
            double TotalCourseScore = GradeUnit.Sum();
            double TotalWeightPnt = WeightPt.Sum();
            double GPA = TotalWeightPnt / TotalUnitReg;


            Footer.footer();
            Console.WriteLine();
            Console.WriteLine("Total Course Unit Registered: {0}", TotalNoOfCourseReg);
            Console.WriteLine("Total Number of Course Passed: {0}", TotalNoOfCoursePassed);
            Console.WriteLine("Your GPA is : {0:F2}", GPA);
            Console.ReadLine();

            
        }
    }
}