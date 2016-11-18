using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RiordineVetInC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vettore generato casualmente");
            Thread.Sleep(1500);
            int[] intVetArray = new int[8];
            Random r = new Random();
            for(int i=0;i<intVetArray.Length;i++)
            {
                intVetArray[i] = r.Next(1, 15);                
                Console.WriteLine(intVetArray[i]);
            }
            Array.Sort(intVetArray);
            Console.WriteLine(" ");
            Console.WriteLine("Ecco il vettore riordinato: ");
            Thread.Sleep(1000);
            for(int i=0;i<intVetArray.Length;i++)
            {
                Console.WriteLine(intVetArray[i]);
            }

            Console.ReadLine();
        }
    }
}
