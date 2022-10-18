//Pedro Castaneda
//10-18-2022
//Reverse It
//Create a program that will reverse a string or number
using System;
using System.Linq;
bool run = true;

while (run)
{
    bool wrongAnswer = false;
    Console.WriteLine("Welcome to Reverse It!");
    Console.WriteLine("Do you want to reverse word or a number? (type 'word' or 'number')");
    while (!wrongAnswer)
    {
        string input = Console.ReadLine().ToLower();
        if (input == "number")
        {
            int num = 0;
            bool checkNum = false;
            Console.WriteLine("Enter a number:");
            while (!checkNum)
            {
                int remainder, reverse = 0;
                checkNum = Int32.TryParse(Console.ReadLine(), out num);
                if(checkNum == true)
                {
                    Console.WriteLine($"You entered: {num}");
                    while (num > 0)
                    {
                        remainder = num % 10;
                        reverse = (reverse * 10) + remainder;
                        num = num / 10;
                    }
                    Console.WriteLine($"Here is your number reversed: {reverse}");
                    wrongAnswer = true;
                }
                if (checkNum == false)
                {
                    Console.WriteLine("Please enter a number!");
                }
                
            }
        }
        else if (input == "word")
        {
            Console.WriteLine("Enter a word:");
            bool wordValid = true;
            while(wordValid)
            {
                string word = Console.ReadLine();
                bool isAlpha = word.All(Char.IsLetter);
                if(isAlpha == false) {
                    {
                        Console.WriteLine("Please enter a word");
                        wordValid = true;
                    }
                }
                else
                {
                    Console.WriteLine($"You entered: {word}");
                    string reverseString = string.Empty;
                    for(int k = word.Length - 1; k >= 0; k--)
                    {
                        reverseString += word[k];
                    }
                    Console.WriteLine($"Here is your word reversed: {reverseString}");
                    wordValid = false;
                    wrongAnswer = true;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter 'word' or 'number'!");
            wrongAnswer = false;
        }
    }
    PlayAgain();
}

void PlayAgain()
{
    bool replay = true;
    Console.WriteLine("Would you like to play again?");
    while (replay)
    {
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "yes" || userInput == "y")
        {
            replay = false;
            run = true;
        }
        else if (userInput == "no" || userInput == "n")
        {
            replay = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
        }
    }
}