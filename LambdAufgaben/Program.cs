using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAufgaben    
{
    public delegate long PotenzMaker(int faktor, int potenz);

    class Program
    {
        PotenzMaker viagra; //Klassenvariable

        static void Main(string[] args)
        {
            Program app = new Program();
            // app.Potenz();
            app.Fibunacci();
        }
        public void Potenz()
        {
        //        public static int Popotenz(int faktor, int potenz)
        //{
        //    int x = faktor;
        //    for (int i = 1; i <= potenz - 1; i++)
        //    {
        //        x = x * faktor;
        //    }
        //    return x;
        //}
        //Console.WriteLine(Popotenz(2,3));
                     
            viagra = (faktor, potenz) => potenz == 0 ? 1 : potenz == 1 ? faktor : faktor * viagra(faktor, potenz - 1);

            Console.WriteLine(viagra(2, 3));            
        }
        public void Fibunacci()
        {
            int
                zahl = 6,
                zahl2 = 0;
            for(int i=1; i<zahl; i++)
            {
                zahl2 += i;
            }
            Console.WriteLine(zahl2);

        }
    }

}
