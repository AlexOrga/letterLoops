using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type absolutely anything you want.");
            var userInput = Console.ReadLine().ToLower();
            int index = 0;
            string stringBuilder = "";

            foreach(char letter in userInput)
            {
                index++;
                for (int i = 0; i < index; i++)
                {
                    if(i == 0)
                    {
                        stringBuilder += letter.ToString().ToUpper();
                    }
                    else
                    {
                        stringBuilder += letter;
                    }
                }
                if(index < userInput.Length)
                {
                    stringBuilder += "-";
                }
            }
            Console.WriteLine(stringBuilder);
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
