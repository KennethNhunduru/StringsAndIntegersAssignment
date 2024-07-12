using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //CONSOLE APP STRINGS AND INTEGERS ASSIGNMENT

        try
        {
            //creating a LIST of integers.
            List<int> intList = new List<int> { 80, 72, 66, 42, 33, 105, 9, 15, 24, 92 };

            //Requesting user input of divisor integer.

            Console.WriteLine("Please enter your divisor integer");
            int intDivisor = Convert.ToInt32(Console.ReadLine()); //coverting input string to integer'
            Console.WriteLine(); //adding blank line to the output.

            //creating a loop that takes each integer in the LIST and divides it by the intDivisor and displays the result.

            for (int i = 0; i < intList.Count; i++)
            {
                int intQuotient = intList[i] / intDivisor;
                Console.WriteLine("Quotient of " + intList[i] + " divided by " + intDivisor + " is " + intQuotient);
                Console.WriteLine(); //inserting a blank line in the output.
            }
            //Note, in this case, the remainder from the the division process is disregarded.
            //The remainder can be obtained from the Modulo(%) operation which simply returns the remainder after dividing an integer by another.
        }

        //catch block to display the error message for dividing by zero.

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            //"Message" is a standard system feedback message from the Exception Handler;
            //Message = Attempted to divide by zero.

            //Sometimes customisation of the feedback message is necessary when the system message is not very clear for the user to understand.
            //In this case the variable ex for the message is not used.
            //Note for the purpose of logging the EXACT system message to the database use of the variable ex is still required.
            Console.WriteLine("Please avoid dividing by zero");
            return; //returning an error page to the user.
        }

        //catch block to display error message for inputting string in place of integer input.
            
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            //"Message" is a standard feedback message from the Exception Handler:
            //Message = "Input string was not in a correct format."

            //customising the feedback message                
            Console.WriteLine("Please provide an integer or whole number");
            return; //returning an error page to the user.
        }

        finally
        //This block of code always runs, no matter there is an exception or not.
        //The need for the finally block:
        /*When the try block catches an error, most of the times execution of whatever is happening stops, and 
        1. there may be a need to log errors to a database, and 
        2. there may be a need to execute something, for example, 'return;' an error page to the user.*/
        {
            Console.WriteLine(); //inserting a blank line in the output.
            //Line to confirm exit from try/catch block.
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution!");
            Console.ReadLine(); //This statement enables the logging of all events.
            //the finally block guarantees the statement will be executed. 
        }            
    }
}

