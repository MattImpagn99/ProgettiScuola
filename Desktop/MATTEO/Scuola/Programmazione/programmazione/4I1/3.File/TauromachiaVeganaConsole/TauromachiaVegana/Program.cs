using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TauromachiaVegana
{
    class Program
    {
        static void Main(string[] args)
        {
            Bovino bv = new Bovino();                                   //Istanzo la classe Bovino
            CassettaDiCarote cdc = new CassettaDiCarote();             //Istanzo la classe CassettaDiCarote  
            Bovino[] vetbov = new Bovino[3];                          //Creo il vettore bovino con lunghezza prestabilita
            CassettaDiCarote[] vetcarote = new CassettaDiCarote[3];  //Creo il vettore carote con lunghezza prestabilita
           
            int indiceVetBov = 0;   //Indice VetBov
            int indiceVetCar = 0;  //Indice VetCar
          
            int cont = 0;
            while (cont != 18)
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("1.Leggi BOVINO da file");
                Console.WriteLine("2.Leggi CAROTA da file");
                Console.WriteLine("3.Inserisci BOVINO");
                Console.WriteLine("4.Inserisci CAROTA");
                Console.WriteLine("5.Ridimensiona vettore BOVINO");
                Console.WriteLine("6.Ridimensiona vettore CAROTA ");
                Console.WriteLine("7.Salva nuovi BOVINI su file");
                Console.WriteLine("8.Salva nuove CAROTE su file");
                Console.WriteLine("9.Stampa tutti i BOVINI ordinati per peso");
                Console.WriteLine("10.Stampa tutti i BOVINI ordinati per età");
                Console.WriteLine("11.Stampa tutte le cassette di CAROTE ordinate per peso");
                Console.WriteLine("12.Stampa tutte le cassette di CAROTE ordinate per numero carote");
                Console.WriteLine("13.Scegli il TORO da combattimento inserendo l'indice del vettore");
                Console.WriteLine("14.Scegli la cassetta di CAROTE da far combattere inserendo l'indice del vettore");
                Console.WriteLine("15.Cerca BOVINO in base al peso");
                Console.WriteLine("16.Cerca CAROTA in base al peso");
                Console.WriteLine("17.FIGHT");
                Console.WriteLine("18.ESCI DAL PROGRAMMA");
                string scelta = Console.ReadLine();
                cont = int.Parse(scelta);

                switch (cont)
                {
                    case 1:   //Leggi BOVINO da file

                        string path = @"C:\Users\Ospite\Desktop\MATTEO\Scuola\Programmazione\programmazione\4I1\3.File\TauromachiaVeganaFile\bovini.txt";
                        if (File.Exists(path))
                        {
                            StreamReader sr = new StreamReader(path);
                            string riga;
                            int ibov = 0;
                            while ((riga = sr.ReadLine()) != null)
                            {
                                string[] apbov = riga.Split('#');
                                string pesob = apbov[0];
                                string etab = apbov[1];
                                bv = new Bovino(pesob, etab);
                                vetbov[ibov] = bv;
                                ibov++;

                            }
                            Console.WriteLine(" ");

                        }
                            break;


                    case 2:  //Leggi CAROTA da file

                        path = @"C:\Users\Ospite\Desktop\MATTEO\Scuola\Programmazione\programmazione\4I1\3.File\TauromachiaVeganaFile\carote.txt";
                        if (File.Exists(path))
                        {
                            StreamReader sr = new StreamReader(path);
                            string riga;
                            int icar = 0;
                            Console.WriteLine(" ");
                            while ((riga = sr.ReadLine()) != null)
                            {
                                string[] apcar = riga.Split('#');
                                string pesoc = apcar[0];
                                string numerocarote = apcar[1];
                                string etàc = apcar[2];
                                cdc = new CassettaDiCarote(pesoc,numerocarote,etàc);                           
                                vetcarote[icar] = cdc;
                                icar++;
                            }
                            Console.WriteLine(" ");

                        }
                        break;
                  
                                          
                    case 3: //Inserisci Bovino

                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            vetbov[i] = new Bovino();
                            vetbov[i].SetPeso();
                            vetbov[i].SetEtà();
                        }
                        break;


                    case 4:  //Inserisci Carota

                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            vetcarote[i] = new CassettaDiCarote();
                            vetcarote[i].SetPeso();
                            vetcarote[i].SetNumeroCarote();
                            vetcarote[i].SetEtà();
                        }
                        Console.WriteLine(" ");
                        break;


                    case 5:  //Ridimensiona Vettore Bovino

                        Console.WriteLine(" ");
                        Console.WriteLine("Inserisci un valore per ridimensionare il vettore BOVINO: ");
                        int ridvetbov = int.Parse(Console.ReadLine());
                        vetbov = new Bovino[ridvetbov];
                        Console.WriteLine(" ");                        
                        break;


                    case 6:   //Ridimensiona Vettore Carota

                        Console.WriteLine(" ");
                        Console.WriteLine("Inserisci un valore per ridimensionare il vettore BOVINO: ");
                        int ridvetcar = int.Parse(Console.ReadLine());
                        vetcarote = new CassettaDiCarote[ridvetcar];
                        Console.WriteLine(" ");
                        break;


                    case 7:  //Salva nuovi BOVINI su file

                        path = @"C:\Users\Ospite\Desktop\MATTEO\Scuola\Programmazione\programmazione\4I1\3.File\TauromachiaVeganaFile\bovini.txt";
                        if (!System.IO.File.Exists(path))
                        {
                            System.IO.File.Create(path);
                        }
                        StreamWriter sw = new StreamWriter(path, false);
                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            sw.WriteLine(vetbov[i].GetPeso()+"#"+vetbov[i].GetEtà());
                            
                        }
                        
                        sw.Close();
                        Console.WriteLine(" ");
                        break;


                    case 8:   //Salva nuove CAROTE su file

                        path = @"C:\Users\Ospite\Desktop\MATTEO\Scuola\Programmazione\programmazione\4I1\3.File\TauromachiaVeganaFile\carote.txt";
                        if (!System.IO.File.Exists(path))
                        {
                            System.IO.File.Create(path);
                        }                                              
                        sw = new StreamWriter(path, false);
                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            sw.WriteLine(vetcarote[i].GetPeso()+"#"+ vetcarote[i].GetNumeroCarote()+"#" + vetcarote[i].GetEtà());  
                            
                        }
                        sw.Close();
                        Console.WriteLine(" ");
                        break;


                    case 9:  //Stampa tutti i BOVINI ordinati per peso

                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            for (int x = 0; x < vetbov.Length; x++)
                            {
                                if (x + 1 != vetbov.Length)
                                {
                                    if (vetbov[x].GetPeso() > vetbov[x + 1].GetPeso())
                                    {
                                        Bovino f = new Bovino();
                                        f = vetbov[x + 1];
                                        vetbov[x + 1] = vetbov[x];
                                        vetbov[x] = f;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            Console.WriteLine("Bovino n" + i + ":" + vetbov[i].GetPeso());
                        }
                        Console.WriteLine(" ");
                        break;


                    case 10:   //Stampa tutti i BOVINI ordinati per età

                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            for (int x = 0; x < vetbov.Length; x++)
                            {
                                if (x + 1 != vetbov.Length)
                                {
                                    if (vetbov[x].GetEtà() > vetbov[x + 1].GetEtà())
                                    {
                                        Bovino f = new Bovino();
                                        f = vetbov[x + 1];
                                        vetbov[x + 1] = vetbov[x];
                                        vetbov[x] = f;
                                    }
                                }

                            }
                        }
                        for (int i = 0; i < vetbov.Length; i++)
                        {
                            Console.WriteLine("Bovino n" + i + " " + "l'eta è: " +vetbov[i].GetEtà() + " " + " anno/i");
                        }
                        Console.WriteLine(" ");
                        break;


                    case 11:   //Stampa tutte le cassette di CAROTE ordinate per peso

                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            for (int x = 0; x < vetcarote.Length; x++)
                            {
                                if (x + 1 != vetcarote.Length)
                                {
                                    if (vetcarote[x].GetPeso() > vetcarote[x + 1].GetPeso())
                                    {
                                        CassettaDiCarote cc = new CassettaDiCarote();
                                        cc = vetcarote[x + 1];
                                        vetcarote[x + 1] = vetcarote[x];
                                        vetcarote[x] = cc;
                                    }
                                }

                            }
                        }
                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            Console.WriteLine("Carota n" + i + " " + "il peso è: " + vetcarote[i].GetPeso() + " " + "chilo/i");
                        }
                        Console.WriteLine(" ");
                        break;


                    case 12:   //Stampa tutte le cassette di CAROTE ordinate per numero carote

                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            for (int x = 0; x < vetcarote.Length; x++)
                            {
                                if (x + 1 != vetcarote.Length)
                                {
                                    if (vetcarote[x].GetNumeroCarote() > vetcarote[x + 1].GetNumeroCarote())
                                    {
                                        CassettaDiCarote cc = new CassettaDiCarote();
                                        cc = vetcarote[x + 1];
                                        vetcarote[x + 1] = vetcarote[x];
                                        vetcarote[x] = cc;
                                    }
                                }

                            }
                        }
                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            Console.WriteLine("Carota n" + i + " " + "il numero delle CAROTE è: "+ vetcarote[i].GetNumeroCarote());
                        }
                        Console.WriteLine(" ");
                        break;


                    case 13:   //Scegli il TORO da combattimento inserendo l'indice del vettore

                        Console.WriteLine("Inserisci il numero della cella del vettore per scegliere il TORO da far combattere");
                        indiceVetBov = int.Parse(Console.ReadLine());
                        Console.WriteLine("Il TORO che hai scelto pesa: " + vetbov[indiceVetBov].GetPeso() + " " + "chilo/i");
                        Console.WriteLine("La sua età è: " + vetbov[indiceVetBov].GetEtà() + " " + "anno/i");
                        Console.WriteLine(" ");
                        break;


                    case 14:   //Scegli la cassetta di CAROTE da far combattere inserendo l'indice del vettore

                        Console.WriteLine("Inserisci il numero della cella del vettore per scegliere la CAROTA da far combattere");
                        indiceVetCar = int.Parse(Console.ReadLine());
                        Console.WriteLine("La CAROTA che hai scelto pesa: " + vetcarote[indiceVetCar].GetPeso() + " " + "chilo/i");
                        Console.WriteLine("Il numero di CAROTE che hanno questo peso sono: " + vetcarote[indiceVetCar].GetNumeroCarote());
                        Console.WriteLine(" ");
                        break;


                    case 15:   //Cerca BOVINO in base al peso

                        Console.WriteLine("Inserisci il peso del BOVINO e ti sarà restituito l'età e la posizione");
                        int pesobov = int.Parse(Console.ReadLine());

                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            if (vetbov[i].GetPeso() == pesobov)
                            {
                                Console.WriteLine("L'età è : " + vetbov[i].GetEtà() + " la posizione è :" + i);
                            }
                            if (vetbov[i].GetPeso() != pesobov)
                            {
                                Console.WriteLine("CELLA VUOTA");
                            }
                        }
                        Console.WriteLine(" ");
                        break;


                    case 16:  //Cerca CAROTA in base al peso

                        Console.WriteLine("Inserisci il peso della CAROTA e ti sarà restituita l'età e la posizione");
                        int pesocar = int.Parse(Console.ReadLine());

                        for (int i = 0; i < vetcarote.Length; i++)
                        {
                            if (vetcarote[i].GetPeso() == pesocar)
                            {
                                Console.WriteLine("L'età è : "+ vetcarote[i].GetEtà() + " " + "anno/i" + " " + "la posizione è :" + i);
                            }
                            if (vetcarote[i].GetPeso() != pesocar)
                            {
                                Console.WriteLine("CELLA VUOTA");
                            }
                        }
                        Console.WriteLine(" ");
                        break;                   


                    case 17:   //FIGHT

                        if (vetbov[indiceVetBov].GetPeso() > vetcarote[indiceVetCar].GetPeso() * 2 && vetbov[indiceVetBov].GetEtà() < vetcarote[indiceVetCar].GetNumeroCarote() && vetbov[indiceVetBov].GetPeso() > vetcarote[indiceVetCar].GetPeso() * 3 && vetbov[indiceVetBov].GetEtà() < vetcarote[indiceVetCar].GetNumeroCarote() * 3)
                        {
                            Console.WriteLine("RULLO DI TAMBURI...");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("IL VINCITORE E': ");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(250);
                            Console.Write(".");
                            Thread.Sleep(300);
                            Console.Write(".");
                            Thread.Sleep(350);
                            Console.Write("IL TORO");
                            Console.WriteLine(" ");
                            Thread.Sleep(600);
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("RULLO DI TAMBURI");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("LA VINCITRICE E': ");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(250);
                            Console.Write(".");
                            Thread.Sleep(300);
                            Console.Write(".");
                            Thread.Sleep(350);
                            Console.Write("LA CAROTA");
                            Console.WriteLine(" ");
                            Thread.Sleep(600);
                            Console.WriteLine(" ");
                        }
                        break;

                    case 18:

                        //esce dal programma

                        break;
                        


            

                       


                        

                }

            }
        }


    }
}
