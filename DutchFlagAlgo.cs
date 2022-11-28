using System;

class DutchFlagAlgo
{
    public void swap(ref int i,ref int j)
    {
        int temp=i;
        i=j;
        j=temp;
    }
    public void sort()
    {
        int[] a = { 2, 2, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2 };

        int low = 0;
        int mid = 0;
        int high = a.Length - 1;

        while (mid <= high)
        {
            if (a[mid] == 0)
            {
                swap(ref a[mid], ref a[low]);
                mid++;
                low++;
            }
            else if (a[mid] == 1)
            {
                mid++;
            }
            else
            {
                swap(ref a[high], ref a[mid]);
                high--;
            }
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}