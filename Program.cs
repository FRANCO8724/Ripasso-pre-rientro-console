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
                Console.WriteLine("          6 - Visualizzazione di tre campi a scelta: ");
                Console.WriteLine("          7 - Ricerca record: ");
                Console.WriteLine("          8 - Modifica record: ");
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

                    case 5:

                        Console.Clear();
                        Console.WriteLine("Inserire records da aggiungere:");
                        string d = Console.ReadLine();
                        f.Aggrecord(d);

                        break;

                    case 6:
          
                        string[] r = new string [3];   

                        Console.Clear();
                        Console.WriteLine("Inserire numero di campi da cercare (massimo 3): ");
                        int cont = int.Parse(Console.ReadLine());

                        for(int i=0; i<cont; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Inserire campo da cercare: ");
                            r[i] = Console.ReadLine();
                        }

                        string aa = r[0];
                        string b = r[1];
                        string c = r[2];

                        int a1 = 0;
                        int b1 = 0;
                        int c1 = 0;

                        bool a2 = false;
                        bool b2 = false;
                        bool c2 = false;
                       
                        using (StreamReader sw = new StreamReader(path))
                        {
                            string ddd = sw.ReadLine();

                            string[] campi = ddd.Split(';');

                            int dim = 0;

                            for (int i = 0; i < campi.Length; i++)
                            {
                                if (aa == campi[dim])
                                {
                                    a1 = dim;
                                }
                                if (b == campi[dim])
                                {
                                    b1 = dim;
                                }
                                if (c == campi[dim])
                                {
                                    c1 = dim;
                                }

                                if (aa == "")
                                {
                                    a2 = true;
                                }
                                if (b == "")
                                {
                                    b2 = true;
                                }
                                if (c == "")
                                {
                                    c2 = true;
                                }

                                dim++;
                            }

                        }

                        using (StreamReader sw = new StreamReader(path))
                        {
                            string ddd = sw.ReadLine();

                            while (ddd != null)
                            {

                                string[] campi = ddd.Split(';');

                                if (a2 == true)
                                {
                                    Console.WriteLine("Campo1: ");
                                }
                                else
                                {
                                    Console.WriteLine("Campo1: " + campi[a1]);
                                }

                                if (b2 == true)
                                {
                                    Console.WriteLine("Campo2: ");
                                }
                                else
                                {
                                    Console.WriteLine("Campo2: " + campi[b1]);
                                }

                                if (c2 == true)
                                {
                                    Console.WriteLine("Campo3: ");
                                }
                                else
                                {
                                    Console.WriteLine("Campo3: " + campi[c1]);
                                }

                                Console.WriteLine("");

                                ddd = sw.ReadLine();

                            }
                        }
                

                break;

                    case 7:

                        Console.Clear();
                        Console.WriteLine("Inserire campo del record da cercare: ");
                        string w = Console.ReadLine();

                       string w1 = f.Ricercarec(w);

                        Console.WriteLine(w1);

                        break;

                        case 8:

                        Console.Clear();
                        Console.WriteLine("Inserire campo del record da modificare: ");
                        string h = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Inserire nuovo record: ");
                        string h2 = Console.ReadLine();

                        f.Modifica(h,h2);

                        break;

                }

    
                Console.ReadLine();
            } while (scelta != 0);
        }
    }
}





        

    

