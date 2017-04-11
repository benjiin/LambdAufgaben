using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAufgaben    
{
    public delegate long potenzMaker(int faktor, int potenz);

    class Program
    {
        // Potenz

        //public static int potenz(int faktor, int potenz)
        //{
        //    int x = faktor;
        //    for (int i = 1; i <= potenz - 1; i++)
        //    {
        //        x = x * faktor;
        //    }
        //    return x;
        //}
        //Console.WriteLine(potenz(2,3));

        static void Main(string[] args)
        {
            potenzMaker viagra;
            viagra = (faktor, potenz) => potenz == 0 ? faktor = 1 : faktor * viagra(2, 3);

            Console.WriteLine(viagra(2,3));
        }
    }
}
