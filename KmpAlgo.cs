using System;

class KmpAlgo
{
    public void KmpSearch()
    {
        string txt="aaabaaahaaabaaac";
        string pat="aaabaaac";

        int m = pat.Length;
        int n = txt.Length;

        int[] lps = new int[m];

        //compute LPS array
        ComputeLPS(pat, m, lps);

        //search in an array
        int i = 0;
        int j = 0;

        while (i < n)
        {
            if (txt[i] == pat[j])
            {
                i++;
                j++;
            }
            else
            {
                if (j != 0) j = lps[j - 1];
                else i++;
            }

            if (j == m)
            {
                Console.WriteLine("Pattern found at index " + (i - j));
                j = lps[j - 1];
            }
        }
    }


    public void ComputeLPS(string pat, int n, int[] lps)
    {
        int len = 0;
        int i = 1;

        lps[0] = 0;

        while (i < n)
        {
            if (pat[i] == pat[len])
            {
                lps[i] = len + 1;
                i++;
                len++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
    }
}

