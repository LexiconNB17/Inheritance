using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass a = new AClass(4);
            BClass b = new BClass();
            AClass c = b;
            
            WriteLine(a.Override());
            WriteLine(b.Override());
            WriteLine(c.Override());
            WriteLine();

            WriteLine(a.Hidden());
            WriteLine(b.Hidden());
            WriteLine(c.Hidden());
            WriteLine();

            WriteLine(a.Abstract());
            WriteLine(b.Abstract());
            WriteLine();

            WriteLine(a.Concrete());
            WriteLine(b.Concrete());
            WriteLine();

            WriteLine(b.I2());
            WriteLine((c as BClass).I2());
            WriteLine();

            WriteLine(a.I1());
            WriteLine(b.I1());
            WriteLine(c.I1());
            WriteLine((b as Interface2).I1());
            WriteLine();

        }
    }
}
 