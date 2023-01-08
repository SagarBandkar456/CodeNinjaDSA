using System;

class GenerateAllPar
{
    public void Solve(int open,int close,string op)
    {
        if(open==0 && close==0) 
        {
            Console.WriteLine(op);
            return;
        }

        if(open!=0)
        {
            string op1=op;
            op1=op1+"(";
            Solve(open-1,close,op1);
        }

        if(close>open)
        {
            string op2=op;
            op2=op2+")";

            Solve(open,close-1,op2);

        }
        return;
    }
}