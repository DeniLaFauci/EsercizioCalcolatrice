using System;
using System.Collections.Generic;
using System.Text;

namespace MyInserimento
{
    class Inserimento
    {
       
        public static int insertInto() 
        {
            int x;
            bool success;
            do
            {
                Console.WriteLine("Inserisci il primo numero e primi invio");
                string numero1 = Console.ReadLine();
                success = Int32.TryParse(numero1, out x);
                if (success == false)          //
                {
                    Console.WriteLine("Il valore inserito non è corretto, riprovare");
                }
            } while (success == false);
            return x;
        }
    }
  
}
