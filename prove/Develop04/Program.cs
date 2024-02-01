using System;

class Program
{
    static void Main(string[] args)
    {   

        // The code starts with a string scriptureEntry that represents a Bible verse. It prints this verse to the console.
        string scriptureEntry = "James 1:5 If any of you lacks wisdom, let him ask God, who gives generously to all without reproach, and it will be given him.";
        Console.WriteLine(scriptureEntry);


        // The verse is then split into words, and the first two words are stored in book and reference. The remaining words are stored in the words list after removing the first two words.
        List<string> _wordsToMemorize = scriptureEntry.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        string book = _wordsToMemorize[0];
        string reference = _wordsToMemorize[1];
        _wordsToMemorize.RemoveRange(0, 2);
        
        // this is generating a random number between 0 and the number of words in the list words
        // The code initializes a Random object and a HashSet<int> to keep track of randomly selected word indices.
        Random random = new Random();
        HashSet<int> randomIndices = new HashSet<int>();

        // int maxNumbersToAdd = Math.Min(3, _wordsToMemorize.Count); // no more than 3 random indices will be added
        int maxNumbersToAdd = 3; // no more than 3 random indices will be added
        int totalNumbersToAdd = 0; // title is self explanatory. This is basically "how many numbers were added thus far.


        while(true)
        {
            while(!(maxNumbersToAdd == totalNumbersToAdd))
            {
                int index = random.Next(_wordsToMemorize.Count);
                while (randomIndices.Contains(index))
                {
                    index = random.Next(_wordsToMemorize.Count);
                }

                randomIndices.Add(index);
                totalNumbersToAdd++;
                Console.WriteLine(index);

                if (_wordsToMemorize.Count == randomIndices.Count)
                {
                    Console.WriteLine("The end");
                    break;
                }
            }
            foreach (int index in randomIndices)
            {
                string word = _wordsToMemorize[index];
                string underscore = new string('_', word.Length);
                _wordsToMemorize[index] = underscore;
            }

            foreach (string word in _wordsToMemorize)
            {
                Console.Write($"{word} ");
            }
            Console.ReadLine();
            foreach (int n in randomIndices)
            {
                Console.Write($"{n} ");
            }
            totalNumbersToAdd = 0;
        }



    }
}