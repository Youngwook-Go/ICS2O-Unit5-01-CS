// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets random number and user number
// This function compares random number and user number and answer.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        Random random = new Random();
        int number = random.Next(1,6);
        int input;

        Console.WriteLine("This program gets and compares random number and user number and answer.");
        Console.Write("Enter random integer number between 1 to 6 --> "); input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        // output
        if (input == number)
        {
            Console.WriteLine("Your answer is :" + input + ".");
            Console.WriteLine("The number was :" + number + ".");
            Console.WriteLine("You got it!");
        }
        else if(input>6 || input<0)
        {
            Console.WriteLine("Input is not a number from 1 to 6!");
        }
        else
        {
            Console.WriteLine("Your answer is : " + input + ".");
            Console.WriteLine("The number was : " + number + ".");
            Console.WriteLine("Try again!");
        }
        Console.WriteLine("\ndone.");
    }
}