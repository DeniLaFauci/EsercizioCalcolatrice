using System;
using System.Collections.Generic;
using System.Text;

namespace MyOperazioni
{
    class Operazioni
    {
        public static int InsertOperazioni(int n1, int n2) 
        {
            int ris = 0;
            bool controllo = true;
            int sc = 0;
            int rest = 0;
            string risultato;
            do
            {
                Console.WriteLine("Puoi scegliere una delle seguenti operazioni \n" +
                                 "1 somma \n" +
                                 "2 sottrazione \n" +
                                 "3 moltiplicazione \n" +
                                 "4 divisione \n" +
                                 "5 divisione con resto");
                risultato = Console.ReadLine();
                if (!Int32.TryParse(risultato, out sc))          //
                {
                    Console.WriteLine("Il valore inserito non è corretto, riprovare");
                }
               
                if (sc == 1)
                {
                    ris = n1 + n2;
                    controllo = false;
                    Console.WriteLine(ris);
                }
                else if (sc == 2)
                {
                    ris = n1 - n2;
                    controllo = false;
                    Console.WriteLine(ris);
                }
                else if (sc == 3)
                {
                    ris = n1 * n2;
                    controllo = false;
                    Console.WriteLine(ris);
                }
                else if (sc == 4)
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("numero non valido\nInserisci un numero diverso da '0' ");
                    }
                    else
                    {
                        ris = n1 / n2;
                        controllo = false;
                        Console.WriteLine(ris);
                    }
                    controllo = false;
                }
                else if (sc == 5)
                {
                    
                    controllo = false;
                }
                else
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("numero non valido\nInserisci un numero diverso da '0' ");
                    }
                    else
                    {
                        ris = n1 / n2;
                        rest = n1 % n2;
                        controllo = false;
                        Console.WriteLine(ris + " col resto di " + rest);
                    }
              
                }
            } while (controllo);
            return ris;
        }
    }
}
