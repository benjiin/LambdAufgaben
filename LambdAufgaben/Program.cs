using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAufgaben    
{
    public delegate long PotenzMaker(int faktor, int potenz);
    public delegate int Fabbelnaschi(int zahl);

    class Program
    {
        PotenzMaker viagra; //Klassenvariable
        Fabbelnaschi fabbi;

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

            // int
            //     zahl = 33;

            //List<int> liste = new List<int> { 0, 1} ; // copy from https://trainyourprogrammer.de/csharp-28-ausgabe-der-fibonacci-folge.html
            //// Ein Textbuffer gedoense


            //for (int i = 2; i < zahl; i++)
            // {
            //     liste.Add(liste[i - 1] + liste[i - 2]);
            // }
            // foreach (var item in liste)
            // {
            //     Console.WriteLine("{0} ",item);
            // }

            fabbi = (zahl) => zahl == 0 ? 0 : zahl == 1 ? 1 : fabbi(zahl - 2) + fabbi(zahl - 1);
            
            Console.WriteLine(fabbi(6));
            Console.ReadKey();
             
             

        }
    }

}
