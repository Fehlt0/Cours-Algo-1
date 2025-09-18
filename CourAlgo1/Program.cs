using System;
using System.Collections.Generic;

namespace CourAlgo1
{
    public class ExoClass
    {
        private const int minValue = 6;
        private const int maxValue = 874;
        private string multipleString;
        public static void Main(string[] args)
        {
            ExoClass exo = new ExoClass();
            
            exo.Exo4();
        }

        public void Exo4()
        {
            Random random = new Random();
            int[] tableauGrand = new int[1500];
            int nombreDe3 = 0;
            
            for (int i = 0; i < tableauGrand.Length; i++)
            {
                tableauGrand[i] = random.Next(1,10);
            }
            for (int i = tableauGrand.Length; i > 0; i--)
            {
                if (tableauGrand[i] == 3)
                {
                    nombreDe3++;
                }
            }
            Console.WriteLine("Il y a " + nombreDe3 + " 3");
            int[] tableauReverse = new int[tableauGrand.Length - nombreDe3];
            int countTable3 = 0;
            for (int i = 0; i < tableauGrand.Length; i++)
            {
                if (tableauGrand[i] != 3)
                {
                    tableauReverse[countTable3] = tableauGrand[tableauGrand.Length - i];
                    countTable3++;
                }
            }
        }
        
        public void Exo3()
        {
            Console.WriteLine("Dit un truc : ");
            string texte = Console.ReadLine();
            int i = 0;
            foreach (char space in texte)
            {
                i++;
            }
            Console.WriteLine("Il y a " + i + " mots.");
            Console.WriteLine("Il y a " + i + " nombres de lettres.");
        }
        
        

        public void Exo2()
        {
            Console.WriteLine("Donne moi un nombre de secondes : ");
            string secondesString = Console.ReadLine();
            int seconds = 0;
            if (!int.TryParse(secondesString, out seconds)) return;
            Console.WriteLine("Ca fait " + seconds/60 + " minutes");
            Console.WriteLine("Ca fait " + seconds/3600 + " heures");
            Console.WriteLine("Ca fait " + seconds/86400 + " jours");
            Console.WriteLine("On est le " + DateTime.Now);


            DateTime test = new DateTime();
            test = DateTime.Now;
            double secondsDouble = seconds;
            test = test.AddSeconds(secondsDouble);
            Console.WriteLine("On aura cette date : " + test);
        }
        
        
        public void Exo1()
        {
            Console.WriteLine("Donne moi un nombre entre 6 et 874 : ");
            string numberString = Console.ReadLine();
            int number = 0;
            while (number == 0)
            {
                if (!int.TryParse(numberString, out number))
                {
                    Console.WriteLine("T'as pas mis un nombre.");
                    number = 0;
                }
                
                if (number < minValue || number > maxValue)
                {
                    Console.WriteLine("T'as pas mis un nombre dans la range.");
                    number = 0;
                }
            }
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    multipleString += "C";
                }
                if (i % 7 == 0 || i % 18 == 0)
                {
                    multipleString += "A";
                }
                if (i % 42 == 0)
                {
                    multipleString += "CA";
                }

                if (multipleString != "")
                {
                    Console.WriteLine(i.ToString() + " " + multipleString);
                    multipleString = "";
                }
            }
        }
        
        
        public void Exo1Version1()
        {
            Console.WriteLine("Donne moi un nombre entre 6 et 874 : ");
            string numberString = Console.ReadLine();
            int number = 0;
            while (number == 0)
            {
                if (int.TryParse(numberString, out number))
                {
                    Console.WriteLine("T'as pas mis un nombre.");
                    number = 0;
                }
                
                if (number < minValue || number > maxValue)
                {
                    Console.WriteLine("T'as pas mis un nombre dans la range.");
                    number = 0;
                }
            }
            List<int> listMultiple = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0)
                {
                    listMultiple.Add(i);
                }
                else if (i % 4 == 0)
                {
                    listMultiple.Add(i);
                }
                else if (i % 7 == 0)
                {
                    listMultiple.Add(i);
                }
                else if (i % 18 == 0)
                {
                    listMultiple.Add(i);
                }
                else if (i % 42 == 0)
                {
                    listMultiple.Add(i);
                }
            }

            
            foreach (int multiple in listMultiple)
            {
                if (multiple % 3 == 0 || multiple % 4 == 0)
                {
                    multipleString += "C";
                }
                if (multiple % 7 == 0 || multiple % 18 == 0)
                {
                    multipleString += "A";
                }
                if (multiple % 42 == 0)
                {
                    multipleString += "CA";
                }
                Console.WriteLine(multiple.ToString() + multipleString);
                multipleString = "";
            }
        }
    }
}