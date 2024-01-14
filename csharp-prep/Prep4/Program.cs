using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers;
        numbers = new List<int>();
        
        
        
        int number;

        do
        {
            
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput); 
            numbers.Add(number); // this will also add 0, so deal with it.
        } while (!(number == 0));


        Console.WriteLine(numbers.Count); //this is counting how many items the list has.
        
    }
}

/* 
The next step is to show the items inside the list, correct the "adding 0" problem and do the following:
- find a way to compute the sum, the average and the largest number in the list.
- add negative numbers also and add a option to find the smallest positive number
- sort the numbers in the list and print them.
*/