using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauromachiaVegana
{
    class Bovino
    {
        int peso;
        int età;
        public Bovino()
        {

        }
        public Bovino(string p,string e)
        {
            peso = int.Parse(p);
            età = int.Parse(e);
        }         
        public void SetPeso()
        {
            Console.WriteLine("Inserisci il peso del BOVINO: ");
            peso = int.Parse(Console.ReadLine());
        }
        public void SetEtà()
        {
            Console.WriteLine("Inserisci l'età del BOVINO: ");
            età = int.Parse(Console.ReadLine());
        }
        public int GetPeso()
        {
            return peso;
        }
        public int GetEtà()
        {
            return età;
        }
        //PUZZO
    }
}
