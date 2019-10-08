using System;
using System.Collections.Generic;
using System.Text;



//Classe per contare il numero di caratteri in una stringa
namespace Estensioni
{
    static class Estensioni
    {
        public static int Conta(this string testo, char character) // questo è un metodo statico
        {
            int result = 0; // dichiarazione di un contatore

            foreach (var c in testo) // serve per iterare su ogni oggetto di una collezione
            {
                if (c == character) // se vale questa condizione, incrementa il contatore
                {
                    result++;
                }
            }

            return result;
        }
    }
}
