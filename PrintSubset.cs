using System;
using System.Text;

class PrintSubset
{
    public void SolveSubset(string ip, string op)
    {
        if(ip.Length==0)
        {
            Console.WriteLine(op);
            return;
        }

        string op1=op;
        string op2=op;

        op2=op2+ip[0];
        ip=ip.Remove(0,1);

        SolveSubset(ip,op1);
        SolveSubset(ip,op2);

        return;
    }
}