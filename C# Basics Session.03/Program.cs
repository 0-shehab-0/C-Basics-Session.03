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

            Book? book = null;

            string? title = book?.Title;

            Console.WriteLine(title ?? "Untitled");

            title ??= "Untitled";

            Console.WriteLine(title);


            #endregion






        }

    }
}

