using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauromachiaVegana
{
    class CassettaDiCarote
    {                           
        int peso;
        int numerocarote;
        int età;
        public CassettaDiCarote(string p,string nc,string e)
        {
            peso = int.Parse(p);
            numerocarote = int.Parse(nc);
            età = int.Parse(e);
        }

        public CassettaDiCarote()
        {

        }

        public void SetPeso()
        {
            Console.WriteLine("Inserisci il peso della CAROTA: ");
            peso = int.Parse(Console.ReadLine());
        }
        public void SetNumeroCarote()
        {
            Console.WriteLine("Inserisci il numero delle CAROTE: ");
            numerocarote = int.Parse(Console.ReadLine());
        }
        public void SetEtà()
        {
            Console.WriteLine("Inserisci l'età della CAROTA");
            età = int.Parse(Console.ReadLine());
        }
        public int GetPeso()
        {
            return peso;
        }
        public int GetNumeroCarote()
        {
            return numerocarote;
        }
        public int GetEtà()
        {
            return età;
        }
        //PUZZO
    }
}
