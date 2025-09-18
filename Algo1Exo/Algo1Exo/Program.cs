using System.Collections.Generic;
using System; /* alt + enter pour importer rapidement
              /  shift shift pour chercher qqchose*/

namespace Algo1Exo
{
    public class Program
    {
        
        // 
        
        private const int MINVALUE = 6;
        private const int MAXVALUE = 874;
        
        //
        
        public static void Main(string[] args)
        {
            Program exo = new Program();
            
            //exo.Exo1();
            //exo.Exo2();
            exo.Exo3();
        }
        
        //
        
        public void Exo1()
        {
            while (true)
            {
                Console.WriteLine("Donne un chiffre entre " + MINVALUE + " et " + MAXVALUE + " : ");
                string input = Console.ReadLine();
                int nombre;
                if (!(int.TryParse(input, out nombre)))
                {
                    Console.WriteLine("Non");
                    continue;
                }

                if (nombre >= MINVALUE && nombre <= MAXVALUE) 
                {
                    for (int i = 1; i <= nombre; i++)
                    {
                        string chaine = "";
                        if (i % 3 == 0 || i % 4 == 0)
                        {
                            chaine += "C";
                        }
                        if (i % 7 == 0 || i % 18 == 0)
                        {
                            chaine += "A";
                        }
                        if (i % 42 == 0)
                        {
                            chaine += "CA";
                        }

                        if (chaine != "")
                        {
                            Console.WriteLine(i + chaine);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Non");
                    continue;
                }

                break;
            }
        } 
        
        //

        public void Exo2()
        {
            Console.WriteLine("Donne un nombre de seconde :");
            string input = Console.ReadLine();
            int nbSeconds;
            if (!(int.TryParse(input, out nbSeconds)))
            {
                Console.WriteLine("Non");
                Exo2();
                return;
            }
            
            //

            int nbMinutes = nbSeconds / 60; 
            int nbHours = nbMinutes / 60;
            int nbDays = nbHours / 24;
            Console.WriteLine("Temps en Secondes : " + nbSeconds);
            Console.WriteLine("Temps en Minutes : " + nbMinutes);
            Console.WriteLine("Temps en Heures : " + nbHours);
            Console.WriteLine("Temps en Jours : " + nbDays);
            
            //

            DateTime valueDate = DateTime.Now;
            DateTime valueNewDate = valueDate.AddSeconds(nbSeconds);
            Console.WriteLine("Date : " + valueDate);
            Console.WriteLine("Date + : " + valueNewDate);
            
            //

            Exo2();
        }
        
        // 

        public void Exo3()
        {
            int[] intArray = new int[1500];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++ )
            {
                intArray[i] = rnd.Next(1, 11);
            }
            Console.WriteLine(string.Join(", ", intArray));
            
            //
            
            int nb3 = 0;
            for (int j = intArray.Length - 1; j >= 0; j--)
            {
                if (intArray[j] == 3)
                {
                    nb3 += 1;
                }
            }
            Console.WriteLine("Nombre de 3 : " + nb3);
            
            //

            int l = 0;
            int[] intNewArray = new int[1500 - nb3];
            for (int k = intArray.Length - 1; k >= 0; k--)
            {
                if (intArray[k] == 3)
                {
                    continue;
                }

                intNewArray[l] = intArray[k];
                l++;
            }
            
            Console.WriteLine(string.Join(", ", intNewArray));
        }
    }
}