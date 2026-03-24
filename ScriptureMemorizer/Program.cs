using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("Genesis", 6, 5),
                "The Lord saw how great the wickedness of the human race had become on the earth."
            ),
            new Scripture(
                new Reference("Genesis", 6, 9, 10),
                "Noah was a righteous man blameless among the people of his time and he walked faithfully with God."
            ),
            new Scripture(
                new Reference("Genesis", 7, 17),
                "For forty days the flood kept coming on the earth and as the waters increased they lifted the ark high above the earth."
            ),
            new Scripture(
                new Reference("Genesis", 8, 1),
                "But God remembered Noah and all the wild animals and the livestock that were with him in the ark."
            ),
            new Scripture(
                new Reference("Genesis", 9, 13),
                "I have set my rainbow in the clouds and it will be the sign of the covenant between me and the earth."
            ),
            new Scripture(
                new Reference("Genesis", 11, 4),
                "Then they said come let us build ourselves a city with a tower that reaches to the heavens."
            )
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(new Random().Next(2, 5));
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}