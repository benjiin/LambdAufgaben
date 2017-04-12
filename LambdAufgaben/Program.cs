using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdAufgaben    
{
    public delegate long PotenzMaker(int faktor, int potenz);
    public delegate int Fabbelnaschi(int zahl);
    public delegate string SmallerHandler(string input, char pivot);
    public delegate string BiggerHandler(string input, char pivot);
    public delegate string QuicksortHandler(string input);


    class Program
    {
        PotenzMaker viagra; //Klassenvariable
        Fabbelnaschi fabbi;
        static SmallerHandler smaller;
        static BiggerHandler bigger;
        static QuicksortHandler quicksort;

        static void Main(string[] args)
        {
            Program app = new Program();
            // app.Potenz();
            //app.Fibunacci();
            app.Quicksort();

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
        public void Quicksort()
        {
            smaller = (input, pivot) => input == "" ? "" : input[0] <= pivot ? input[0] + smaller(input.Substring(1), pivot) : smaller(input.Substring(1), pivot);
            bigger = (input, pivot) => input == "" ? "" : input[0] > pivot ? input[0] + bigger(input.Substring(1), pivot) : bigger(input.Substring(1), pivot);
            quicksort = input => input == "" ? "" : quicksort(smaller(input.Substring(1), input[0])) + input[0] + quicksort(bigger(input.Substring(1), input[0]));
            Console.WriteLine(quicksort("23879203223879203286250239842387920328625023984238792032862502398423879203286250239842387920328625023984238792032862502398423879203286250239848625023984"));
            Console.ReadLine();
        }
    }

}
