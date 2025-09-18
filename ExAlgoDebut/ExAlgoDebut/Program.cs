// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

namespace ExAlgoDebut
{
    public class Program
    {
        private const int MaxValue = 874;
        private const int MinValue = 6;
        private const int Seconde = 60;
        private const int Heure = 24;

        public static void Main(string[] args)
        {
            Program exo = new Program();
            
            exo.Exo4();
            exo.Exo3();
            exo.Exo1();
            exo.Exo2();
            
        }

        public void Exo4()
        {
            int[] intArray = new int[1500];
            for (int i = 0; i < intArray.Length; i++)
            {
                Random random = new Random();
                intArray[i] = random.Next(1, 11);
                
            }
            Console.WriteLine(string.Join(", ", intArray));
            int trois = 0;
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                if (intArray[i] == 3)
                {
                    trois += 1;
                    
                }    
            }
            Console.WriteLine(trois);
            int [] newArray = new int[1500 - trois];
            for (int i = intArray.Length-1 ; i>=0; i--)
            {
                if (intArray[i] == 3)
                {
                    continue;

                }   
                newArray[i] = intArray[i];
                
            }
            
            Console.WriteLine(string.Join(", ", newArray));    
        }
        
        
        
        public void Exo3()
        {
            Console.WriteLine("beaucoup de mot");
            string avant = Console.ReadLine();
            int mot = 0;
            foreach (char space in avant)
            {
                mot += 1;
            }
            Console.WriteLine(mot);
        } 
        
        
        
        
        public void Exo1()
        {
            Console.WriteLine("Donne un nombre entre 6 et 874"); 
            string input = Console.ReadLine();
            int nombre;
            if (int.TryParse(input, out nombre) && nombre >= MinValue && nombre <= MaxValue)
            {
                for (int i = 0; i <= nombre; i++)
                {
                    string str = "";
                    if (i % 3 == 0 || i % 4 == 0)
                    {
                        str += "C";
                    }
                    if  (i % 7 == 0 || i % 18 == 0)
                    {
                        str += "A";
                    }
                    if (i % 42 == 0)
                    {
                        str += "CA";
                    }

                    if (str != "")
                    {
                        Console.WriteLine(i+str);
                    }
                }
            }

        }
        public void Exo2()
        {
            Console.WriteLine("Donne un nombre de seconde");
            int NombreSeconde = int.Parse(Console.ReadLine());
            int NombreMinute =  NombreSeconde / Seconde;
            int NombreHeure = NombreMinute / Seconde;
            int NombreJour = NombreHeure / Heure;
            int ResteMinutes = NombreMinute % Seconde;
            
            DateTime ValueDate = DateTime.Now;
            
            Console.WriteLine("Nombre de seconde: " + NombreSeconde);
            Console.WriteLine("Nombre de minute: " + NombreMinute);
            Console.WriteLine("Nombre d'heure: " + NombreHeure);
            Console.WriteLine("Nombre de jour: " + NombreJour);
            Console.WriteLine("Date actuelle: " + ValueDate);
            
            ValueDate = ValueDate.AddHours(NombreHeure);
            ValueDate = ValueDate.AddMinutes(ResteMinutes);
            
            Console.WriteLine("Nouvelle date: " + ValueDate);
            Exo2();
            
        }
        
        
    }

}   
