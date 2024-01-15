using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Tell me your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    static int PromptUserNumber()
    {   
        int favNumber;
        Console.Write("Tell me your favorite number: ");
        string userInput = Console.ReadLine();
        favNumber = int.Parse(userInput);
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}

/*
Create the following functions:
1. DisplayWelcome = "Welcome to the Program!"
2. PromptUserName = Asks for and returns the user's name(as a string)
3. PromptUserNumber = Asks for and returns the user's favorite number (as an integer)
4. SquareNumber = Accepts an integer as a parameter and returns that number squared (as an integer)
5. DisplayResult = Accepts the user's name and the squared number and displays them

example output:

Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Brother Burton, the square of your number is 1764


*/