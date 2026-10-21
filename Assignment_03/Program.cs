using System.Runtime.ExceptionServices;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            ////1
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65, 67 };
            ////2
            //GradesHelper<int>.PrintList(grades);
            ////3
            //grades.Sort();
            //GradesHelper<int>.PrintList(grades);
            ////4
            //int? Biggerthan90 = grades.Find(x => x > 90);
            //Console.WriteLine(Biggerthan90);
            //Console.WriteLine("======================================");
            ////5
            //List<int> bellow75 = grades.FindAll(x => x < 75);
            //GradesHelper<int>.PrintList(bellow75);
            ////6
            //GradesHelper<int>.RemoveBelow75(grades);
            //GradesHelper<int>.PrintList(grades);
            ////7
            //bool exist = grades.Contains(100);
            //Console.WriteLine(exist);
            //Console.WriteLine("======================================");
            ////8
            //List<string> Slist = GradesHelper<int>.StringGrade(grades);
            //GradesHelper<string>.PrintList(Slist);
            #endregion

            #region Exercise 2: Leaderboard
            //1
            Dictionary<int, string> leaderboard = new Dictionary<int, string>()
             {
                { 500, "Ahmed" },
                { 200, "Sara" },
                { 800, "Ali" },
                 { 350, "Mona" }
             };
            //2
            LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            //3
            int firstKey = leaderboard.Keys.ElementAt(0);
            string firstValue = leaderboard.Values.ElementAt(0);
            Console.WriteLine($"First Value {firstValue} , First key {firstKey}");
            Console.WriteLine("======================================");
            //4
            bool exist = leaderboard.ContainsKey(500);
            Console.WriteLine(exist);
            Console.WriteLine("======================================");
            //5
            leaderboard.Add(999, "Mohamed");
            LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            //6
            leaderboard.Remove(200);
            LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            #endregion 
        }
    }
}
