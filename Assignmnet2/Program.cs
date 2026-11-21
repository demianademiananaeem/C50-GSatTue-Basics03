using System.ComponentModel;
using System.Text;

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
            //string title1 = "Clean Code", title2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title1, title2));

            #endregion

            #region Q3
            //StringBuilder text = new StringBuilder();
            //text.Append("Book List ");
            //text.Append("_Udated");
            //Console.WriteLine(text.ToString());
            #endregion

            #region Q4
            //StringBuilder text = new StringBuilder();
            //text.Append("Book List ");
            //text.Append("_Udated");
            //text.Replace("Book List ", "Libaray ");
            //Console.WriteLine(text.ToString());
            #endregion

            #region Q5
            string title = "Clean Code";
            int page = 464;
            Console.WriteLine("Book:"+title+" , Page:"+page);
            #endregion


        }
    }
}
