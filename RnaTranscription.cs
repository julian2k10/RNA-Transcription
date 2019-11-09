using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        List<char> RNA = new List<char>();// Store new RNA sequence
        Dictionary<char, char> key = new Dictionary<char, char>();//Store key for DNA mapping sequence
        key.Add('G', 'C');
        key.Add('C', 'G');
        key.Add('T', 'A');
        key.Add('A', 'U');
        
        foreach (char letter in nucleotide)
        {
            char value = Char.ToUpper(letter);
            List<char> valid_keys = key.Keys.ToList();
            if (valid_keys.Contains(value))
            {
                RNA.Add(key[value]);
            }
            else
            {
                Console.WriteLine("Invalid Character Detected!\n '{0}' is not a valid DNA nucleotide.", value);
            }
        }
        return String.Join("", RNA);
    }
}