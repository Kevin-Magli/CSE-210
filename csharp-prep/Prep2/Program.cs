using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";
        string sign = "";
        float signGiver = grade % 10;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            
        }

        if (letter == "F" || grade >= 97)
        {
            sign = "";
        }
        else if (signGiver >= 7)
        {
            sign = "+";
        }
        else if (signGiver < 3)
        {
            sign = "-";
        }

        Console.Write($"You received an {letter}{sign}.");

        if (letter == "A")
        {
            Console.WriteLine(" Nice!");
        }
        else if (letter == "B")
        {
            Console.WriteLine(" Okay :)");
        }
        else if (letter == "C")
        {
            Console.WriteLine(" I mean, it's alright.");
        }
        else if (letter == "D")
        {
            Console.WriteLine(" Bruh...");
        }
        else
        {
            Console.WriteLine(".. you have permission to go home, retrieve your brain and come back later.");
            Console.WriteLine("Ps: if you tell your parents you're probably dead, so good luck with that ;)");
            
        }
        
    }
}