using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input from console. Add a new line
            Console.WriteLine("Hi, guess the animal. Press 1 for Cat and 2 for Dog");

            //this object is irrelevant and not used but extends animal. i.e. a cat is a type of animal
            Cat c = new Cat();

            //read input and covert to a number - ! is a null forgiving operator
            string StringInput = Console.ReadLine()!;
            //a string to help build the response
            string CorrectAnswer = "";
            //this is used to demonstrate converting a string to an int
            int InputNumber = 0;

            /*
             * try catch block demonstrates handling exceptions on input. In this case
             * a user may not follow instructions and enter some other value
             */
            
            try
            {
               InputNumber = Convert.ToInt32(StringInput);
                // this is a ternary conditional operator.  It is like a short hand if statement
               CorrectAnswer = InputNumber == 1 ? "Correct" : "False";
            }
            catch (System.FormatException e)
            {
                // recover from exception
                CorrectAnswer = "not a valid input. " + e.Message;

            }


            //return 
            Console.Write($"You guessed {StringInput} that is {CorrectAnswer}");


        }
    }
}
