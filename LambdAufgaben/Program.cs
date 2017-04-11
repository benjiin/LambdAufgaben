using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAufgaben    
{
    public delegate long potenzMaker(int a, int b);

    class Program
    {
        // Potenz
        
        //public static int potenz(int a, int b)
        //{
        //    int x = a;
        //    for(int i=1; i<=b-1; i++)
        //    {
        //        x = x * a;
        //    }
        //    return x;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine(potenz(2, 3));
        }
    }
}
