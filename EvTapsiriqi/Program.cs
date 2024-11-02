using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Mətni daxil edin: ");
        string text = Console.ReadLine();

        // Hər hərfin sayını saxlamaq üçün Dictionary yaradılır
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        foreach (char letter in text)
        {
            // Hərfi böyük və ya kiçik olmasından asılı olmayaraq nəzərə alırıq
            char lowerLetter = char.ToLower(letter);

            // Hərfin yalnız əlifba hərfi olduğuna əmin olmaq üçün yoxlayırıq
            if (char.IsLetter(lowerLetter))
            {
                if (letterCounts.ContainsKey(lowerLetter))
                {
                    letterCounts[lowerLetter]++;
                }
                else
                {
                    letterCounts[lowerLetter] = 1;
                }
            }
        }

        // Nəticəni ekrana çap edir
        Console.WriteLine("Hərflərin sayı:");
        foreach (var entry in letterCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}