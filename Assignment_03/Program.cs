using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Timers;

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
            ////1
            //Dictionary<int, string> leaderboard = new Dictionary<int, string>()
            // {
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //     { 350, "Mona" }
            // };
            ////2
            //LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            ////3
            //int firstKey = leaderboard.Keys.ElementAt(0);
            //string firstValue = leaderboard.Values.ElementAt(0);
            //Console.WriteLine($"First Value {firstValue} , First key {firstKey}");
            //Console.WriteLine("======================================");
            ////4
            //bool exist = leaderboard.ContainsKey(500);
            //Console.WriteLine(exist);
            //Console.WriteLine("======================================");
            ////5
            //leaderboard.Add(999, "Mohamed");
            //LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            ////6
            //leaderboard.Remove(200);
            //LeaderBoardHelper.PrintLeaderBoard(leaderboard);
            #endregion

            #region Exercise 3: Phone Book
            ////1
            //Dictionary<int ,string> Contacts = new Dictionary<int, string>()
            //{
            //        { 0107666, "Ahmed" },
            //        { 0112345, "Sara" },
            //        { 0122324, "Ali" },
            //        { 0151232, "Mona" }
            //};
            ////2
            //Contacts[0151234] = "Menna" ;
            //ContactsHelper.GetAllContacts(Contacts) ;
            ////3
            ////Contacts.Add(0107666, "Ahmed");
            ////ContactsHelper.GetAllContacts(Contacts);
            //// the exception Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: 107666
            ////at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
            ////at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
            //Console.WriteLine("An item with the same key has already been added");
            //Console.WriteLine("======================================");
            ////4
            //bool success = Contacts.TryAdd(0107666, "Ahmed");
            //Console.WriteLine(success);
            //Console.WriteLine("======================================");
            ////5
            //bool exist = Contacts.ContainsKey(0122329);
            //Console.WriteLine(exist);
            //Console.WriteLine("======================================");
            ////6
            //exist = Contacts.ContainsKey(01223212);
            //if (!exist)
            //{
            //    Console.WriteLine("not found");
            //}
            //else { Console.WriteLine("found"); }
            //Console.WriteLine("======================================");
            ////7
            //foreach (var contact in Contacts.Keys)
            //{
            //        Console.Write(contact + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("======================================");
            //foreach (var contact in Contacts.Values)
            //{
            //    Console.Write(contact + " ");
            //}
            #endregion


            #region Exercise 4: Unique Email Validator
            ////1
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            ////2
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            ////3
            //Console.WriteLine(emails.Count);
            ////because it's not allowed to store the same value on the hashset only uniqe values are stored . 
            //Console.WriteLine("======================================");
            ////4
            //HashSet<int> A = new HashSet<int>() { 1 ,2,3 ,4 ,5};
            //HashSet<int> B = new HashSet<int>() { 4, 5, 6, 7, 8 };

            ////5
            //A.UnionWith(B);
            //SetsHelper<int>.PrintSet(A);

            //HashSet<int> A2 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //A2.IntersectWith(B);
            //SetsHelper<int>.PrintSet(A2);

            //HashSet<int> A3 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //A3.ExceptWith(B);
            //SetsHelper<int>.PrintSet(A3);

            //HashSet<int> A4 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //bool result = new HashSet<int> { 1, 2 }.IsSubsetOf(A4);
            //Console.WriteLine(result);
            #endregion

            #region Exercise 5: Print Queue Simulator
            //Queue<string> Printer = new Queue<string>();
            //Printer.Enqueue("Report.pdf");
            //Printer.Enqueue("Invoice.pdf");
            //Printer.Enqueue("Letter.docx");
            //Printer.Enqueue("Resume.pdf");
            //Printer.Enqueue("Photo.jpg");

            ////1
            //foreach (string item in Printer)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"---->the count {Printer.Count}");
            //Console.WriteLine("======================================");
            ////2
            //Console.WriteLine(Printer.Peek());
            //Console.WriteLine("======================================");
            ////3
            //while (Printer.Count > 0)
            //{
            //    string word = Printer.Dequeue();
            //    Console.WriteLine($"Printing : [{word}]");
            //}
            //Console.WriteLine("======================================");
            ////4
            ////Printer.TryDequeue();
            //////it gave a compile time error because there is nothing to dequeue on the queue .
            #endregion


            #region Exercise 6: Browser History (Undo)
            //Stack<string> History = new Stack<string>();
            
            ////1
            //History.Push("google.com");
            //History.Push("github.com");
            //History.Push("stackoverflow.com");
            //History.Push("youtube.com");
            //History.Push("claude.ai");
            ////2
            //Console.WriteLine(History.Peek());
            //Console.WriteLine("======================================");
            ////3
            //for (int i = 0; i < 3; i++)
            //{
            //    string word = History.Pop();
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine("======================================");
            ////4 
            //Console.WriteLine(History.Peek());
            //Console.WriteLine("======================================");
            ////5
            //History.Clear();
            //History.Pop();
            ////exception. System.InvalidOperationException: Stack empty.
            ////at System.Collections.Generic.Stack`1.ThrowForEmptyStack()
            ////at System.Collections.Generic.Stack`1.Pop()
            //// as u see it does throw an exception because the sstack is empty .

            #endregion 
        }
    }
}