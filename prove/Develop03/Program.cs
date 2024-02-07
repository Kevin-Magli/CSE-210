using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private List<string> _scripture;
    private string _book;
    private string _reference;

    // CONSTRUCTOR!
    public Scripture(List<string> scripture, string book, string reference)
    {
        _scripture = scripture;
        _book = book;
        _reference = reference;
    }

    public List<string> GetScripture()
    {
        return _scripture;
    }

    public string GetBook()
    {
        return _book;
    }

    public string GetReference()
    {
        return _reference;
    }

    public static string ChooseScripture()
    {
        List<string> ScripturesList = new List<string>
        {
            "John 3:16 For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.",
            "Proverbs 3:5-6 Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.",
            "Philippians 4:13 I can do all things through him who strengthens me.",
            "Jeremiah 29:11 For I know the plans I have for you, declares the Lord, plans for welfare and not for evil, to give you a future and a hope.",
            "Romans 8:28 And we know that in all things God works for the good of those who love him, who have been called according to his purpose.",
            "Matthew 28:19-20 Go therefore and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, teaching them to observe all that I have commanded you. And behold, I am with you always, to the end of the age.",
            "Psalm 23:1 The Lord is my shepherd; I shall not want.",
            "Romans 12:2 Do not be conformed to this world, but be transformed by the renewal of your mind, that by testing you may discern what is the will of God, what is good and acceptable and perfect.",
            "Ephesians 2:8-9 For by grace you have been saved through faith. And this is not your own doing; it is the gift of God, not a result of works, so that no one may boast.",
            "Proverbs 16:9 The heart of man plans his way, but the Lord establishes his steps.",
            "Isaiah 40:31 But they who wait for the Lord shall renew their strength; they shall mount up with wings like eagles; they shall run and not be weary; they shall walk and not faint.",
            "1 Corinthians 16:14 Let all that you do be done in love.",
            "James 1:22 But be doers of the word, and not hearers only, deceiving yourselves.",
            "Galatians 5:22-23 But the fruit of the Spirit is love, joy, peace, patience, kindness, goodness, faithfulness, gentleness, self-control; against such things there is no law.",
            "Psalm 119:105 Your word is a lamp to my feet and a light to my path.",
            "Colossians 3:23 Whatever you do, work heartily, as for the Lord and not for men.",
            "Hebrews 11:1 Now faith is the assurance of things hoped for, the conviction of things not seen.",
            "Matthew 11:28-30 Come to me, all who labor and are heavy laden, and I will give you rest. Take my yoke upon you, and learn from me, for I am gentle and lowly in heart, and you will find rest for your souls. For my yoke is easy, and my burden is light.",
            "2 Timothy 3:16-17 All Scripture is breathed out by God and profitable for teaching, for reproof, for correction, and for training in righteousness, that the man of God may be complete, equipped for every good work.",
            "Psalm 19:14 Let the words of my mouth and the meditation of my heart be acceptable in your sight, O Lord, my rock and my redeemer.",
            "James 1:5 If any of you lacks wisdom, let him ask God, who gives generously to all without reproach, and it will be given him."
        };

        Random random = new Random();
        int randomIndex = random.Next(ScripturesList.Count);
        string chosenScripture = ScripturesList[randomIndex];


        return chosenScripture;
    }
    private string _studentName;
    private string _topic;

    // ProcessScripture is taking all the words in the scripture and separating it by words in a list and attributes of the instance.
    public static Scripture ProcessScripture(string entry)
    {
        List<string> words = entry.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        string book = words[0];
        string reference = words[1];
        words.RemoveRange(0, 2);

        return new Scripture(words, book, reference);
    }
}

class Memorize
{
    private readonly Random _random;
    private List<string> _wordsToMemorize;
    private readonly Scripture _scripture;

    public Memorize(Scripture scripture)
    {
        _random = new Random();
        _wordsToMemorize = new List<string>(scripture.GetScripture());
        _scripture = scripture;
    }

    // MemorizeScripture is responsible for executing two other methods
    public void MemorizeScripture(Scripture scripture) 
    {
        List<string> memorizeScriptureList = ChooseRandomWords(scripture);
        DisplayMemorizedScripture(memorizeScriptureList);
        ; // return string
    }


    // ChooseRandomWords is the reason why this code took me TOO LONG to finish. The comented version is a version i already tested in another file and it worked nicely. If you want to see it for yourself, it's in Develop04 until i start working on the assignment for this week. Here this doesn't work the way i wanted, but it's still here for testing.

/*
    public List<string> ChooseRandomWords(Scripture scripture)
    class MathAssignment
    {

        HashSet<int> randomIndices = new HashSet<int>();
        int maxNumbersToAdd = 3;
        int totalNumbersToAdd = 0;
        private string _textbookSection;
        private string _problems;

        if (_wordsToMemorize.Count == randomIndices.Count)
        public void GetHomeworkList()
        {
            Console.WriteLine("No words to hide.");
            return _wordsToMemorize;
            ; // return string
        }
        while (totalNumbersToAdd < maxNumbersToAdd)
        {
            int index = _random.Next(_wordsToMemorize.Count);
            if (!randomIndices.Contains(index))
            {
                randomIndices.Add(index);
                totalNumbersToAdd++;
            }
        }
        foreach (int index in randomIndices)
        {
            string word = _wordsToMemorize[index];
            string underscore = new string('_', word.Length);
            _wordsToMemorize[index] = underscore;
        }
        return _wordsToMemorize;
    }
*/  

    //ChoseRandomWords Ver 2 here is responsible for chosing random indexes to give direction to what words should be replaced to underscores by their respective number of letters. Everything here works nice except the for loop(that was a while loop before). It checks if the number is unique and only then it has permission to add it to the list. What is happening is that this condition is ALWAYS IGNORED NO MATTER WHAT I DO. I remade this code almost 10 times in different ways and it just doesn't work here.
    public List<string> ChooseRandomWords(Scripture scripture)
    {
        List<int> randomIndices = new List<int>();



        if (_wordsToMemorize.Count == randomIndices.Count)
        {
            Console.WriteLine("No words to hide.");
            return _wordsToMemorize;
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    int randomNumber = _random.Next(_wordsToMemorize.Count);
                    if (!randomIndices.Contains(randomNumber))
                    {
                        randomIndices.Add(randomNumber);
                        break;
                    }
                } while (true);
            }
            ; // return string
        }

        foreach (int index in randomIndices)
        {
            string word = _wordsToMemorize[index];
            string underscore = new string('_', word.Length);
            _wordsToMemorize[index] = underscore;
        }

        return _wordsToMemorize;
    }

    private void DisplayMemorizedScripture(List<string> memorizedScripture)
    {
        Console.Write($"{_scripture.GetBook()} {_scripture.GetReference()} ");
        foreach (string word in memorizedScripture)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

}


class Program
{
    static void Main(string[] args)
    {

        string chosenScriptureString = Scripture.ChooseScripture();
        Scripture myScripture;
        myScripture = Scripture.ProcessScripture(chosenScriptureString);
        Memorize memorizer = new Memorize(myScripture);


        //this is here just to display the default scripture, i know it could be done in a smarter way using a do-while-loop but i was using 100% of my brain in that cursed part of the code :)
        Console.Clear();
        Console.WriteLine(chosenScriptureString);
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.ReadLine();

        while (true)
        {
            Console.Clear();
            memorizer.MemorizeScripture(myScripture);
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }
        }
        Console.WriteLine();
    }
}
