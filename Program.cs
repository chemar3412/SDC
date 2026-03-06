/*************************************
 * Name: Chelsea Martin
 * Date: 3/3/2026
 * Assignment: Phase 1
 * Main Program
 * This application allows the user
 * to input two values and display the result.
 *************************************/

using System;

class Addition
{
    static void Main()
    {
        // Print information line for project
        Console.WriteLine("Project 1, User Interaction and I/O, Chelsea Martin");

        // Declare variables
        int number1;
        int number2;
        float number3;
        float number4;
        int sum;
        float answer;


        // Prompt user for first number
        Console.Write("Please input a number: ");
        while(!int.TryParse(Console.ReadLine(), out number1))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.Write("Please enter another number: ");
        while(!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        // Perform addition
        sum = number1 + number2;

        // Display result
        Console.WriteLine($"Sum is {sum}. {number1} + {number2} = {sum}");

        //prompt use for first number second calculation
        Console.Write("Input number for second calculation: ");

        while(!float.TryParse(Console.ReadLine(), out number3))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        //prompt user for second nummber for second calculation 
        Console.Write("Input second number for second calculation: ");
        while(!float.TryParse(Console.ReadLine(), out number4))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        //perform calculation
        answer = number4 - number3;

        //display result
        Console.WriteLine($"answer is {answer}. {number4} - {number3} = {answer}");

        //end prompt 
        Console.Write("Thank you for using simple calculator!");
    }
}
