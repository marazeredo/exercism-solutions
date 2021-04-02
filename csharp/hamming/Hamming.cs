using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;
        char[] fS = firstStrand.ToCharArray();
        char[] sS = secondStrand.ToCharArray();

        if (firstStrand.Length == secondStrand.Length)
        {
            for (int ctr = 0; ctr < fS.Length; ctr++)
            {
                if (fS[ctr] != sS[ctr])
                {
                    hammingDistance++;
                }
            }
            return hammingDistance;
        }
        else
        {
            throw new ArgumentException();
        }

    }
}