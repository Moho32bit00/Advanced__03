namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = new List <int>() { 85, 92, 78, 95, 88, 70, 100, 65  , 67};
            GradesHelper<int>.PrintList(grades);
            grades.Sort();
            GradesHelper<int>.PrintList(grades);
            int? Biggerthan90 = grades.Find(x => x > 90);        
            Console.WriteLine(Biggerthan90);
            Console.WriteLine("======================================");
            List<int> bellow75 = grades.FindAll(x => x < 75);
            GradesHelper<int>.PrintList(bellow75);
            GradesHelper<int>.RemoveBelow75(grades);
            GradesHelper<int>.PrintList(grades);
            List <string > Slist = GradesHelper<int>.StringGrade(grades);
            GradesHelper<string>.PrintList(Slist);
            #endregion


        }
    }
}
