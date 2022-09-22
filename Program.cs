using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// William Cram
// 09/22/2022
// In class example - Lecture 1

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Commenting
            // Commenting code can take two forms, eithe
            // Either with a double forward slash , //, which comments out a single line of code.
            /*
             * Or a a forward slash and an astrix followed by a astrix * and forward slash. This creates a block comment
             */
            // There are multiple ways to short cut comments. The first is the buttons on the tool bar up above
            // This is a little square with a green block in the middle. That comments. The one to the right with the arrow, uncomments
            // The hot keys are ctrl + k, and ctrl + c to comment, or ctrl + k and ctrl + u to uncomment
            // Mac: command + k and command + c, and command + k and comman + u

            // Displaying Text

            // We use two methods. Console.WriteLine();
            Console.WriteLine("Hello, World");
            // This displays the text, then goes to the next line
            // And Console.Write()
            Console.Write("First Word\n");
            // This displays the text, but keeps the cursor on the same line.
            // If you Did 
            // Console.Write("1");
            // Console.Write("2");
            // Console.Write("3");
            // Console.Write("4");
            // Console.Write("5");
            // Your result would be 12345

            // Declaring and Initializing Variables
            // Declaring a varible starts with the type. In this example we use a string.
            // Then we give our variable a name. It should describe what the variable is holding.
            // Then we do the =, followed by a string. This assigns a value.
            // Now when we access that variable name, it will display the value.
            string faculty = "Professor";
            string school = "Renton Technical College";
            string city = "Renton";
            // Remeber strings are recognized by being in double quotes " "

            // You can change the value of your variable further down your code by assigning it a new value.
            faculty = "Cat";
            // Make sure you don't put the word string before it again. Otherwise it will throw and arrow. 
            // You only need to Declare once

            // Concatenate
            // Concatinating is when you add, +, two STRINGS together. They come together to form 1 large string.
            Console.WriteLine(faculty + " Dog");
            Console.WriteLine(school + " " + faculty);
            // This is how you can combine strings and variables. You can concatenate as many as you need.
            // You can even concatenate variables. The computers just sees them as strings.
            
            // Creating spaces between lines - \n
            // If you want to either do a new line break or an extra space when displaying text you have two options.
            Console.WriteLine();
            // A blank Console.WriteLine() will move to the next line
            // or the ESCAPE character \n will work when placed inside a string.
            Console.WriteLine("This will appear on \n a new line");

            // A head of the game
            // This is how we call a method. We type the name we gave to the method, followed by parentheses.
            HelloWorld("Programming 1");
            HelloWorld("Programming 2");
            HelloWorld("Programming 3");
            HelloWorld("Programming 4");
            HelloWorld("Programming 5");

            Question1();
        } // Main()

        // Declaring a method
        // Think of a method like a variable, but with multiple lines of code instead of just a variable.
        // Method names Start in upper case, and every new word is upper case
        public static void Question1()
        {
            Console.WriteLine("This is question 1");
        } // Question1()

        public static void HelloWorld(string userInput)
        {
            Console.WriteLine(userInput);
        } // HelloWorld()

        //public static void PrintName(string name)
        //{
        //    Console.WriteLine(name + " Name: ");
        //    Console.WriteLine(name + " Name: ");
        //    Console.WriteLine(name + " Name: ");
        //} // PrintName

    } // class

} // namespace
