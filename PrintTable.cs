namespace gpaCalculator
{
    internal class PrintTable
    {
        public static void printTable()
        {
            string Title = "------------------------------------------------------------GPA CALCULATOR-----------------------------------------------------";
            string headLine1 = "|----------------------------|-----------------------|------------|---------------------|------------------|------------------|";
            string headLine2 = "|----------------------------|-----------------------|------------|---------------------|------------------|------------------|";


            string CourseCodeHeading = "COURSE & CODE";
            string CourseUnitHeading = "COURSE UNIT";
            string GradeHeading = "GRADE";
            string GradeUnitHeading = "GRADE - UNIT";
            string WeightPtHeading = "WEIGHT Pt.";
            string RemarkHeading = "REMARK";

                Console.WriteLine(Title);
                Console.WriteLine(headLine1);
                Console.WriteLine("");  

                Console.WriteLine("| {0,-26} | {1,-21} | {2,-10} | {3,-19} | {4,-16} | {5,-16} |",
                        CourseCodeHeading, CourseUnitHeading, GradeHeading,
                        GradeUnitHeading, WeightPtHeading, RemarkHeading);
                Console.WriteLine("");
                Console.WriteLine(headLine2);            
                                     
        }
    }
}