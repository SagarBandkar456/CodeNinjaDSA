class Program
{
    public static void Main(string[] args)
    {
        // DutchFlagAlgo objDutchFlagAlgo=new DutchFlagAlgo();
        // objDutchFlagAlgo.sort();

        // KadaneAlgo objKadaneAlgo=new KadaneAlgo();
        // int max=objKadaneAlgo.maxSubArray();
        // Console.Write("KadaneAlgo max: " + max);

        // KmpAlgo objKmpAlgo=new KmpAlgo();
        // objKmpAlgo.KmpSearch();

        // List<int> ls=new List<int>{5,4,3,2,1};
        // SortArrayRecurssion objSARecurssion=new SortArrayRecurssion();
        // objSARecurssion.Sort(ls);
        // foreach(var a in ls)
        //     Console.Write(a+" ");

        Stack<int> s = new Stack<int>();
        s.Push(5);
        s.Push(4);
        s.Push(3);
        s.Push(2);
        s.Push(1);

        // SortStackRecurssion objSSRecurssion = new SortStackRecurssion();
        // objSSRecurssion.Sort(s);

        // Stack<int> res=new Stack<int>(s.ToArray());
        // while(res.Count>0)
        // {
        //     Console.Write(res.Pop()+" ");
        // }

        // DeleteMiddleRecurssion objDelMidEle=new DeleteMiddleRecurssion();
        // objDelMidEle.DeleteMiddle(s,s.Count());

        // while(s.Count>0)
        // {
        //     Console.Write(s.Pop()+" ");
        // }

        ReverseStack objReverse=new ReverseStack();
        objReverse.StackReverse(s);

        while(s.Count>0)
        {
            Console.Write(s.Pop()+" ");
        }

    }
}