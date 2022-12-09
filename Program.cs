class Program
{
    public static void Main(string []args)
    {
        // DutchFlagAlgo objDutchFlagAlgo=new DutchFlagAlgo();
        // objDutchFlagAlgo.sort();

        // KadaneAlgo objKadaneAlgo=new KadaneAlgo();
        // int max=objKadaneAlgo.maxSubArray();
        // Console.Write("KadaneAlgo max: " + max);

        KmpAlgo objKmpAlgo=new KmpAlgo();
        objKmpAlgo.KmpSearch();

    }
}