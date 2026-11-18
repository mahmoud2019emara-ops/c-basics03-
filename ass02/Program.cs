using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

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
            string title = "Clean Code";
            int pages = 464;
            Console.WriteLine("book:" + title + ", Pages: " + pages);
            #endregion

            #region question 6
            //Build the same sentence as above, but using string interpolation ($"...").
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("book:" + title + ", Pages: " + pages);
            #endregion

        }
    }
}
