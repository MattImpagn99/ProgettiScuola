using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Tamagogi_complesso
{
    class Program
    {
        static void Main(string[] args)
        {   while (true)
            {
                int contatore = 0;
                int cont = 1;
                int co = 2;
                int conta = 3;
                string risp;
                Console.WriteLine("A per mangiare");
                Console.WriteLine("B per dormire");
                Console.WriteLine("C per sorridere");
                Console.WriteLine("D per farlo arrabbiare");
                risp = Console.ReadLine();
                if(risp =="A")
                {
                    if (contatore == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  O       O *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   *******  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO FAMEE  -__-");
                        Thread.Sleep(400);
                    }

                    if (cont == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  O       O *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   -------  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO FAMEE  -__-");
                        Thread.Sleep(400);
                    }

                    if (co == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  O       O *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*    /////   *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO FAMEE  -__-");
                        Thread.Sleep(400);
                    }
                    contatore++;
                    if (conta == 3)
                    {
                        contatore = 0;
                    }
                }
                if (risp == "B")
                {
                    if (contatore == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  +       + *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   *******  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO SONNO  -__-");
                        Thread.Sleep(400);
                    }

                    if (cont == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  +       + *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   ZZZZZZZZ *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO SONNO  -__-");
                        Thread.Sleep(400);
                    }

                    if (co == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  +       + *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*    ******  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("HO SONNO  -__-");
                        Thread.Sleep(400);
                    }
                    contatore++;
                    if (conta == 3)
                    {
                        contatore = 0;
                    }
                }
                if (risp == "C")
                {
                    if (contatore == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  0       0 *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   (_____)  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("SORRISONI NE ABBIAMO? ^_^");
                        Thread.Sleep(300);
                    }

                    if (cont == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  ^       ^ *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   ________ *");
                        Console.WriteLine("**************");
                        Console.WriteLine("SORRISONI NE ABBIAMO? ^_^");
                        Thread.Sleep(400);
                    }

                    if (co == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  --      ^ *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   (_____)  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("SORRISONI NE ABBIAMO? ^_^");
                        Thread.Sleep(400);
                    }
                    contatore++;
                    if (conta == 3)
                    {
                        contatore = 0;
                    }
                }
                if (risp == "D")
                {
                    if (contatore == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("* <!#>   <!#> ");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   -------  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("UFFA ><");
                        Thread.Sleep(400);
                    }

                    if (cont == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("*  9       9 *");
                        Console.WriteLine("*      I     *");
                        Console.WriteLine("*   -------  *");
                        Console.WriteLine("**************");
                        Console.WriteLine("UFFA ><");
                        Thread.Sleep(400);
                    }

                    if (co == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("**************");
                        Console.WriteLine("* [!]    [!] *");
                        Console.WriteLine("*     II     *");
                        Console.WriteLine("*    |  |    *");
                        Console.WriteLine("**************");
                        Console.WriteLine("UFFA ><");
                        Thread.Sleep(400);
                    }
                    contatore++;
                    if (conta == 3)
                    {
                        contatore = 0;
                    }
                }
            }
        }
    }
}
