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
            //string title = "Clean Code";
            //int page = 464;
            //Console.WriteLine("Book:"+title+" , Page:"+page);
            #endregion

            #region Q6
            //string title = "Clean Code";
            //int page = 464;
            //Console.WriteLine($"Book:{title} , Page:{page}");
            #endregion

            #region Q7
            //string title = "Clean Code";
            //int page = 464;
            //string mas = string.Format("Book:{0} , Page:{1}",title,page);
            //Console.WriteLine(mas);
            #endregion

            #region Q8
            //int page = 464;
            //if (page > 300) Console.WriteLine("Long Book");
            //else Console.WriteLine("Short Book");
            #endregion

            #region Q9
            //int page = 464;
            //bool isAvailable = true;
            //if (page > 300&&isAvailable==true) Console.WriteLine("You can borrow this book");
            //else Console.WriteLine("Not Available!");
            #endregion

            #region Q10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Q11
            //int page = 464;
            //string sizeLabel = page > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Q12
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{books[i]}");
            //}
            #endregion

            #region Q13
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while ( i<books.Length) {
            //    Console.WriteLine($"{books[i]}");
            //    i++;
            //}
            #endregion

            #region Q14
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i<3);
            #endregion

            #region Q15
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Q16
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //        break;
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Q17
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Q18
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            void PrintFirstBook(string[] books)
            {
                if (books.Length == 0) return;
                Console.WriteLine(books[0]);
            }
            PrintFirstBook(books);
            #endregion
        }
         
    }
}
