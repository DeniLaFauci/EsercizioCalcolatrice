using System;
using MyOperazioni;
using MyInserimento;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            int Op;
            int n1;
            int n2;
            int ris;
            Console.WriteLine("BENVENUTO IN UMANA CALCULATOR! SCEGLIERE L'OPERAZIONE DESIDERATA!");
            n1 = Inserimento.insertInto();
            n2 = Inserimento.insertInto();
            ris = Operazioni.InsertOperazioni(n1, n2);   //op ancora nn esiste
            Console.WriteLine("risultato ",ris);
            Console.ReadLine();
        }
    }
}
