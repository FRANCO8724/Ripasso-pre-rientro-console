using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso_pre_rientro
{
    internal class Program
    {
        public string path = @"../../Arrigoni.csv";
        
        static void Main(string[] args)
        {
            Funzioni f;
            f = new Funzioni();
            int scelta = 0;
            

            //stuttura menù
            do
            {
                //stampa delle opzioni

                Console.Clear();
                Console.WriteLine("          1 - Aggiunta numero casuale: ");
                Console.WriteLine("          2 - quantità campi del record: ");
                Console.WriteLine("          3 - Lunghezza massima dei record: ");
                Console.WriteLine("          4 - Lunghezza fissa dei record: ");
                Console.WriteLine("          5 - Aggiunta record: ");
                Console.WriteLine("          6 - Modifica di un nome: ");
                Console.WriteLine("          7 - Visualizzazione di tre campi a scelta: ");
                Console.WriteLine("          8 - Ricerca campo di un record: ");
                Console.WriteLine("          9 - Cancellazione logica: ");
                Console.WriteLine(" ");
                Console.WriteLine("0 - uscita");
                Console.WriteLine(" ");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:

                    f.numcasual();

                        break;

                }

    
                Console.ReadLine();
            } while (scelta != 0);
        }
    }
}





        

    

