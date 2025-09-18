// See https://aka.ms/new-console-template for more information

namespace algo1
{
    public class ExoClass
    {
        public static void Main(string[] args)
        {
            ExoClass exo = new ExoClass();
            
            exo.Exo1();
            exo.Exo2();
            exo.Exo4();

        }

        public void Exo1()
        {
            string mot;
            List<string> listeDeCaca = new List<string>();
            Console.WriteLine("Entre un nombre : ");
            int nb = int.Parse(Console.ReadLine());
            if (nb < 6 || nb > 874)
            {
                Console.WriteLine("Entrez un nombre entre 6 et 874");
                Exo1();
            }
            else 
            {
                for (int i = 1; i <= nb; i++)
                {
                    if (i % 3 is 0 || i % 4 == 0 || i % 7 == 0 || i % 18 == 0 || i % 42 == 0)
                    {
                        mot = i.ToString();
                    
                        if (i % 3 == 0 ||  i % 4 == 0 )
                        {
                            mot += "" + "C";
                        }
                        if (i % 7 == 0 ||  i % 18 == 0)
                        {
                            mot += "" + "A";
                        }
                        if (i % 42 == 0)
                        {
                            mot += "" + "CA";

                        }

                        Console.WriteLine(mot);

                        if (mot.Contains("CACA"))
                        {
                            listeDeCaca.Add(i.ToString());
                        }
                        
                        
                    }
                }
                Console.WriteLine("Les nombres contenant CACA sont :" + string.Join(", ", listeDeCaca));
            }
            
        }
        
        public void Exo2()
        {
            Console.WriteLine("Nombre de secondes :");
            int nbSec = int.Parse(Console.ReadLine());
            int Minutes = nbSec / 60;
            int Heures = nbSec / 3600;
            int Jours = nbSec / 86400;
            
            Console.WriteLine(Minutes + " Minutes");
            Console.WriteLine((Heures + " Heures"));
            Console.WriteLine(Jours + " Jours");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Add(new TimeSpan(Heures, Minutes, nbSec % 60)));
            //Exo2();
            
        }


        public void Exo3()
        {
            //Console.WriteLine("Dit un truc zebi :");
            //string phrase = Console.ReadLine();
            
        }

        public void Exo4()
        {
            int[] tab = new int[1500];
            
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < 1500; i++)
            {
                tab[i] = rand.Next(1, 10);
            }
            
            Console.WriteLine(string.Join(", ", tab));
            
            
            for (int j = 1499; j >= 0 ; j -= 1)
            {
                if (tab[j] == 3)
                {
                    count += 1;
                }
            }
            
            int[] nvtab = new int[1500 - count];
            int counttab = 0;

            for (int j = 1499; j > 0; j--)
            {
                if (tab[j] == 3)
                {
                    continue;
                }
                else
                {
                    nvtab[counttab] = tab[j];
                    counttab += 1;
                }



            }
            Console.WriteLine("nombre de 3: " + count); 
            Console.WriteLine(string.Join(", ", nvtab));
        }
    }
}