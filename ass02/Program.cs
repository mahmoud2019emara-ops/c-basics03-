using System.Drawing;

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
            string title01 = "Clean Code";
            string title02 = "Clean Code";
            Console.WriteLine(ReferenceEquals(title01, title02));
            #endregion

        }
    }
}
