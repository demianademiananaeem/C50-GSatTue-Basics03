using System.ComponentModel;

namespace Assignmnet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Q1
            //string title = "clean code";
            //string upperTitle=title.ToUpper();
            //Console.WriteLine(upperTitle);
            //Console.WriteLine(title);
            #endregion

            #region Q2
            string title1 = "Clean Code", title2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(title1, title2));

            #endregion


        }
    }
}
