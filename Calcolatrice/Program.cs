using System;
using MyOperazioni;
using MyInserimento;
//using CalcolatriceAuliaria;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sto per fare un operazione

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
