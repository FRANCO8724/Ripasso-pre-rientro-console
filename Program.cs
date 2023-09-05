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
        
        
        static void Main(string[] args)
        {
            string path = @"../../../Arrigoni.csv";
             Funzioni f;
            f = new Funzioni();
            int scelta = 0;
            int lung = 0;
            

            //stuttura menù
            do
            {
                //stampa delle opzioni

                Console.Clear();
                Console.WriteLine("          1 - Aggiunta numero casuale: ");
                Console.WriteLine("          2 - Conta campi dei record: ");
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

                    case 2:

                    int a3 = f.Contacampi();

                        Console.Clear();
                   Console.WriteLine("Il numero dei campi è: " + a3);

                    break;

                    case 3:

                        using (StreamReader sw = new StreamReader(path))
                        {
                            int dim = 0;

                            string a = sw.ReadLine();

                            string[] campi = a.Split(';');

                            int[] arr = new int[(campi.Length) + 1];

                            for (int i = 0; i < campi.Length; i++)
                            {
                                arr[dim] = campi[i].Length;
                                dim++;
                            }
                            arr[(arr.Length) - 1] = a.Length;

                            while (a != null)
                            {
                                dim = 0;

                                string[] campi2 = a.Split(';');

                                for (int i = 0; i < campi2.Length; i++)
                                {
                                    if (arr[dim] < campi2[i].Length)
                                    {
                                        arr[dim] = campi2[i].Length;
                                    }

                                    dim++;
                                }

                                if (arr[(arr.Length) - 1] < a.Length)
                                {
                                    arr[(arr.Length) - 1] = a.Length;
                                }

                                a = sw.ReadLine();

                            }

                            dim = 0;

                            Console.Clear();

                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i != arr.Length - 1)
                                {
                                    Console.WriteLine("Lunghezza campo " + dim.ToString() + ": " + arr[i]);
                                }
                                else
                                {
                                    Console.WriteLine("Lunghezza record " + dim.ToString() + ": " + (arr[arr.Length - 1] + 1));
                                }
                                dim++;
                            }

                            lung = arr[arr.Length - 1];
                        }

                        break;

                    case 4:

                        f.Lungfissa(lung);

                        break;

                }

    
                Console.ReadLine();
            } while (scelta != 0);
        }
    }
}





        

    

