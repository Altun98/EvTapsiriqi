using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Console.Write("Zehmet olmasa metin daxil edin: ");
        string text = Console.ReadLine();
        int count = 0;
        // metin daxilinde olan heriflerin sayini ve herfin ozunu saxlamaq ucun dictionary yaradiriq
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        foreach (char letter in text)
        {
            //boyuk ve ya kicik herifleri eyhilesdirerek nezere aliriq 
            char lowerLetter = char.ToLower(letter);

            // IsLatter metodu ile metnin daxilinde olan yalniz herifleri goururuk
            if (char.IsLetter(lowerLetter))
            {
                //ContainsKey() metodu vasitesile hemin herfin olub ol
                if (letterCounts.ContainsKey(lowerLetter))
                {
                    letterCounts[lowerLetter]++;

                }
                else
                {
                    letterCounts[lowerLetter] = 1;
                }
                count++;
            }
        }

        // Nəticəni ekrana çap edir
        Console.WriteLine("*********************");
        foreach (var entry in letterCounts)
        {
            Console.WriteLine($"herif:{entry.Key}: sayi:{entry.Value}: hemin herfin metindeki umumi faizi:{(entry.Value * 100) / count} %");
        }
        Console.WriteLine("*********************");

        Dictionary<string, char[]> barmaqlar = new Dictionary<string, char[]>();
        barmaqlar.Add("sol5", new char[] { 'q', 'a', 'z' });
        barmaqlar.Add("sol4", new char[] { 'w', 's', 'x', 'ü' });
        barmaqlar.Add("sol3", new char[] { 'e', 'd', 'c' });
        barmaqlar.Add("sol2", new char[] { 'r', 'f', 'v', 't', 'g', 'b' });
        barmaqlar.Add("saq5", new char[] { 'p', 'ö', 'ğ', 'ə', 'ı' });
        barmaqlar.Add("saq4", new char[] { 'o', 'l', 'ş' });
        barmaqlar.Add("saq3", new char[] { 'i', 'k', 'ş' });
        barmaqlar.Add("saq", new char[] { 'y', 'h', 'n', 'u', 'j', 'm' });

    }
}