using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A. Add a print line to prompt the user for the length of the rectangle.
            B. Define a variable to handle the user’s response.
            C. Repeat the previous two steps to ask for and store the rectangle’s width.
            D. Use the length and width values to calculate the rectangle’s area.
            E. Print a statement using concatenation to communicate to the user what the 
            area of their rectangle is.*/
            Console.WriteLine("Provide rectangle length:");
            // takes input via ReadLine (ie "7") then parses the input into a integer and stores
            // in the length variable
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Provide a width:");
            int width = int.Parse(Console.ReadLine());
            // calculate length x width
            int area = length * width;
            // lets alter this concatenation to be a template literal
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
    }
}
