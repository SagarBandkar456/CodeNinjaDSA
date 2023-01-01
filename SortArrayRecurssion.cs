using System;
using System.Collections.Generic;

class SortArrayRecurssion
{
    public void Sort(List<int> l)
    {
        if(l.Count==1) return;

        int temp=l[l.Count-1];
        l.RemoveAt(l.Count-1);

        Sort(l);
        Insert(l,temp);
    }

    void Insert(List<int> l,int temp)
    {
        if(l.Count ==0 || l[l.Count-1]<=temp)
        {
            l.Add(temp);
            return;
        }

        int val=l[l.Count-1];
        l.RemoveAt(l.Count-1);

        Insert(l,temp);
        l.Add(val);
        return;

    }
}