using System.ComponentModel;
using System.Runtime.InteropServices.JavaScript;

public class Program
{
    public static void Main(string[] args)
    {
        Program exo = new Program();
        exo.Exo3();
    }

    //variables exo1
    private const int min = 6;
    private const int max = 874;
    private string reponse;
    private int i;
    
    
    
    
    //variables exo2
    
    public void Exo2()
    {
        Console.WriteLine("donnez un nombre en secondes");
        int.TryParse(Console.ReadLine(), out int secondes);

        int minutesTotales = secondes / 60;
        int heuresTotales = secondes / 3600;
        int joursTotals = secondes / 86400;
        
        Console.WriteLine(secondes + "s ou "+ minutesTotales +"min ou " + heuresTotales+"h ou " + joursTotals + "j ");
        
        int jours = secondes / 86400;
        int heures = (secondes - jours*86400) / 3600;    
        int minutes = (secondes - heures*3600 - jours*86400)/60;
        int secondesRestantes = secondes - 86400 * jours - 3600 * heures - 60 * minutes;
                
        Console.WriteLine(jours + "j "+heures +"h " + minutes +"m " + secondesRestantes +" s");

        Console.WriteLine("on est le " + DateTime.Now);
        
    }


    private int nombre3;
    public void Exo3()
    {
        
        //génération
        Random random = new Random();
        int[] Array = new int[1500];

        for (i = 0; i < 1500; i++)
        {
            Array[i] = random.Next(1, 11);
        }
        
        Console.WriteLine(string.Join(", ",Array));
        
        //nombre de 3
        for (i = 1499; i > 0; i--)
        {
            int element = Array[i];
            if (element == 3)
            {
            nombre3 += 1;
            }
        }
        
        Console.WriteLine(nombre3);

        int[] Array2 = new int[1500 - nombre3];
        for (i = 0; i < (1500 - nombre3); i++)
        {
            if (Array[1499 - i] != 3)
            { 
                Array2[i] = Array[1499 - i]; 
            }
            else
            {
                
            }
        }
        
        Console.WriteLine(string.Join(", ",Array2));
        


    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    public void Exo1()
    {
        
        
        Console.WriteLine("donnez un nombre");
        int.TryParse(Console.ReadLine(), out int nombre);
        
        if (nombre >= min && nombre <= max)
        {
            Console.WriteLine("le nombre est entre 6 et 874");
            
            for(int i = 0; i <= nombre; i++) {

                if (i % 3 == 0 || i % 4 == 0)
                {
                    reponse += "c";
                }

                if (i % 7 == 0 || i % 18 == 0)
                {
                    reponse += "a";
                }

                if (i % 42 == 0)
                {
                    reponse += "ca";
                }
                
                
                if (reponse == "caca")
                {
                    Console.WriteLine(i+" "+reponse);
                    reponse = "";    
                }
                else
                {
                    reponse = "";
                }
            }
        }
        else
        {
            Console.WriteLine("le nombre n'est pas entre 6 et 874");
        }
    }

}