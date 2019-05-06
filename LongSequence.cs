using System;

class LongSequence
{
    public int LongSequence(int N)
    {
        int i = 0, currentLength = 0, beforeZeroLength = 0, LongestSeq = 0;

        while (N > 0)
        {
            if ((N & (1 << i)) != 0)
            {
                currentLength++;
                N = N & N - 1;
            }
            else if ((N & (1 << i)) == 0)
            {
                beforeZeroLength = !((N & (1 << i + 1)) == 0) ? currentLength : 0;
                currentLength = 0;
            }
            i++;
            int TotalLength = beforeZeroLength + currentLength + 1;
            LongestSeq = TotalLength > LongestSeq ? TotalLength : LongestSeq;
        }

        return LongestSeq;
    }
}