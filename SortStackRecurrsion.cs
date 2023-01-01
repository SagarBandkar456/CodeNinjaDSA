using System;
using System.Collections.Generic;

class SortStackRecurssion
{
    public void Sort(Stack<int> s)
    {
        if(s.Count==1) return;

        int temp=s.Pop();
        Sort(s);

        Insert(s,temp);
    }

    void Insert(Stack<int> s, int temp)
    {
        if(s.Count== 0 || s.ElementAt(s.Count-1)<=temp) 
        {
            s.Push(temp); return;
        }

        int val=s.Pop();
        
        Insert(s,temp);
        s.Push(val);
    }
}