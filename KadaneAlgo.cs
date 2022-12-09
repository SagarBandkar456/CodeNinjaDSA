using System;

class KadaneAlgo
{
    public int maxSubArray()
    {
        int[] array = { -1, 2, -2, 5, 7, -3, 1 };
        int length = array.Length;
        int currSum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < length; i++)
        {
            currSum = currSum + array[i];
            maxSum = Math.Max(maxSum, currSum);

            if (currSum < 0) currSum = 0;
        }

        return maxSum;
    }
}