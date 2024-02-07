using System;

class Program
{
    static void Main(string[] args)
    {   

    }
}

class Activity
{
    /* Methods: 
    1. opening message displaying the name of the activity, description
    1.1 asks the duration of the activity in seconds and sets it.
    2. ending message "good job", what activity was completed,  how much time was spended, and pauses before finished.
    3. Create pause animation
    */

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public static Activity DisplayOpeningMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name} Activity.{Environment.NewLine}");
        Console.WriteLine(description + Environment.NewLine);
        Console.Write("How long, in seconds would you like for your section? ");
        int durationInput = int.Parse(Console.ReadLine());
        return new Activity(null, null, durationInput);
    }

    public static void DisplayEndingMessage(string ending, string _name, int _duration)
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
    }

    public static void DisplayPauseAnimation()
    {
        ;
    }

    
    
    class Breathing
    {
        /*
        - attribute: description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing"
        - Create alternate messages of Breathe in Breathe out. After each message the program pauses and shows a countdown.
        - This continues until the seconds determined by the user reach their point.
        */
    }
    class Reflection
    {
        /*
        - attribute: description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        - Display a random prompt from a list.
            prompts = {
                Think of a time when you stood up for someone else.
                Think of a time when you did something really difficult.
                Think of a time when you helped someone in need.
                Think of a time when you did something truly selfless.
            }
        - Display reflect question from the list:
            reflectQuestion = {
                Why was this experience meaningful to you?
                Have you ever done anything like this before?
                How did you get started?
                How did you feel when it was complete?
                What made this time different than other times when you were not as successful?
                What is your favorite thing about this experience?
                What could you learn from this experience that applies to other situations?
                What did you learn about yourself through this experience?
                How can you keep this experience in mind in the future?
            }
        - pause for some seconds, and present with other prompts until user time has reached the limit.
        */
    }
    class Listing
    {
        /*
        - attribute: description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        - select random prompt:
            prompts = {
                Who are people that you appreciate?
                What are personal strengths of yours?
                Who are people that you have helped this week?
                When have you felt the Holy Ghost this month?
                Who are some of your personal heroes?
            }
        - give a pause for the user to reflect
        - prompt to keep listing items, and retrieve the number of entries the user created
        - display number of entries
        */
    }
}