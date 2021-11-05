using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> DNA = new Dictionary<char, int>();

        int count_A = 0;
        int count_C = 0;
        int count_G = 0;
        int count_T = 0;
        bool invalid = false;

        int DNA_length = sequence.Length;
        char[] aux = sequence.ToCharArray();

        for (int i = 0; i < DNA_length; i++)
        {
            switch (aux[i])
            {
                case 'A':
                {
                    count_A++;
                    break;
                    }

                case 'C':
                {
                    count_C++;
                    break;
                    }

                case 'G':
                {
                    count_G++;
                    break;
                    }

                case 'T':
                {
                    count_T++;
                    break;
                    }

                default:
                   throw new ArgumentException();
                    break;
            }  
        }

        DNA.Add('A', count_A);
        DNA.Add('C', count_C);
        DNA.Add('G', count_G);
        DNA.Add('T', count_T);

        return DNA;    
    }
}