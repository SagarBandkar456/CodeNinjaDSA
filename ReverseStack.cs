using System;

class ReverseStack
{
    public void StackReverse(Stack<int> s)
    {
        if (s.Count == 1) return;

        int temp = s.Pop();
        StackReverse(s);
        Insert(s, temp);
    }

    void Insert(Stack<int> l, int ele)
    {
        if (l.Count == 0)
        {
            l.Push(ele);
            return;
        }

      int temp=l.Pop();
      Insert(l,ele);
      l.Push(temp);
      return;
    }
}