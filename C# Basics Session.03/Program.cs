using System.Drawing;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Net.NetworkInformation;

namespace C__Basics_Session._03
{
    internal class Program
    {

        class Book
        {
            public string Title = "Name";
            public int Pages = 100;
        }


        static void Main(string[] args)
        {
            #region quistion 11 ass 1
            //Declare an int? year = null;. Print whether it has a value,
            //then assign it 2023 and print its value.

            //int? year = null;

            //Console.WriteLine(year.HasValue);

            //year = 2023;

            //Console.WriteLine(year);


            #endregion

            #region Quistion 12 Ass 1
            //Declare a string? reviewer = null;. Print whether it is null.

            //string? reviewer = null;

            //Console.WriteLine(reviewer == null);

            #endregion

            #region Quiston 13 Ass 1
            //Declare a Book? book = null;. Use ?. to safely read book.
            //Title without crashing the program, and print the result.



            //Book? book = null;

            //Console.WriteLine(book?.Title);


            #endregion

            #region Quistion 14 Ass 1
            // Using title from the previous question, use ?? to print
            // "Untitled" if title is null.Then use ??= to assign title
            // the value "Untitled" only if it's still null.

            //Book? book = null;

            //string? title = book?.Title;

            //Console.WriteLine(title ?? "Untitled");

            //title ??= "Untitled";

            //Console.WriteLine(title);


            #endregion

            #region Quistion 15 Ass 1
            // Given string? name = "Ahmed"; (you are sure it's not null here),
            // assign it to a non-nullable string confirmedName using the ! operator.

            //string? name = "Ahmed";

            //string confirmedName = name!;

            #endregion


            #region Quistion 1 
            //Declare string title = "clean code";. Call title.
            //ToUpper() and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.

            //string title = "clean code";

            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);


            #endregion

            #region Quistion 2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            //to check if they point to the same object in memory.

            //string str1 = "Clean Code";
            //string str2 = "Clean Code";

            //Console.WriteLine(string.ReferenceEquals(str1, str2));

            #endregion

            #region Quistion 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            //object.Print the final result.

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine(sb);

            #endregion

            #region Quistion 4
            //Using the StringBuilder from the question above,
            //use Replace() to change "Book List" into "Library". 
            //Print the result.

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            sb.Replace("Book List", "Library");

            Console.WriteLine(sb);


            #endregion



        }

    }
}

