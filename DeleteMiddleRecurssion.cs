using System;

class DeleteMiddleRecurssion
{
    public Stack<int> DeleteMiddle(Stack<int> s, int n)
    {
        if(s.Count==0) return s;

        int k=(n/2)+1;
        Solve(s,k);
        return s;
    }

    void Solve(Stack<int> s,int k)
    {
        if(k==1)
        {
            s.Pop();
            return;
        }
        int temp=s.Pop();
        Solve(s,k-1);
        s.Push(temp);
    }
}