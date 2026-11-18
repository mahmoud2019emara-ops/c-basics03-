using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            //both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle); 
            #endregion

            #region question 2
            //Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.
            //string title01 = "Clean Code";
            //string title02 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title01, title02));
            #endregion

            #region question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            // object.Print the final result.
            // StringBuilder sb = new StringBuilder();
            //sb.Append("book list");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);
            #endregion

            #region question 4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            StringBuilder sb = new StringBuilder();
            //sb.Append("book list");
            //sb.Append(" - Updated");
            //sb.Replace("book list", "Library");
            //Console.WriteLine(sb);


            #endregion

            #region question 5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //  Pages: 464" using the + operator.
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("book:" + title + ", Pages: " + pages);
            #endregion

            #region question 6
            //Build the same sentence as above, but using string interpolation ($"...").
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"book:{title}, Pages: {pages}");
            #endregion

            #region question 7
            //Build the same sentence again, but using string.Format().
            //string title = "clean code";
            //int pages = 464;
            //console.writeline(string.format("book:{0}, pages: {1}", title, pages));
            #endregion

            #region question 8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //   300, otherwise prints "Short Book".
            //int pages = 464;
            //if(pages>300)
            //    Console.WriteLine("long Book");
            //else
            //    Console.WriteLine("short Book");
            #endregion

            #region question 9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //  greater than 300 and isAvailable is true.Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;
            //if(pages>300 && isAvailable == true)
            // Console.WriteLine("You can borrow this book");

            #endregion

            #region question 10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            // "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //switch(title)
            //{
            //    case "clean code":
            //        Console.WriteLine("great choice");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("nice pick");
            //        break;
            //    default:
            //        Console.WriteLine("never heard of it");
            //        break;
            //}
            #endregion

            #region question 11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            //  variable sizeLabel(same rule as question 8: long if pages > 300).

            //int pages = 464;
            //string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            #endregion

            #region question 12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            // to print each book with its position number, like 1.Clean Code.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i=0 ; i<books.Length ; i++) 
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");

            #endregion

            #region question 13
            //Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length) 
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion

            #region question 14
            //Write a do -while loop that prints "Checking book..." exactly 3 times.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("checking book...");
            //    i++;
            //} 
            //while (i > 3);
            #endregion

            #region question 15
            //Using the same books array, use a foreach loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string i in books)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region question 16

            //Using the same books array, loop through it and print each title, but stop completely(break) once
            // you reach "Refactoring".

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string i in books)
            //{
            //    Console.WriteLine(i);
            //    if (i == "Refactoring")
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region question 17

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string i in books)
            //{ 
            //    if (i == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region question 18
            //Write a method PrintFirstBook() that prints the first book in the books array.If the array is empty,
            //use return to exit the method early instead of printing anything.
            
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            void PrintFirstBook(string[] books)
            {
                
                if (books == null || books.Length == 0)
                {
                    return;
                }

               
                Console.WriteLine(books[0]);
            }
            #endregion

        }
    }
}
