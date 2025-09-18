using System.Security.Cryptography;
using System.Linq ;

public class Program

{
    private static string inputValue;
    private static int userInt;
    
    private const int maxValue = 874;
    private const int minValue = 6;
    private static string messageToWrite;
    
    private static int threeCount;

    
    public static void Main(string[] args)
    {
        Console.Clear();
        Program program = new Program();
        program.ExoTabloRigolo();
    }
    
    public void Exo1()
    {
        Console.Write("enter value : ");
        inputValue = Console.ReadLine();
        
        if (!int.TryParse(inputValue, out userInt)) return ;
        if (userInt < minValue || userInt > maxValue) return;
        
        Console.Write($"value {userInt} is valid and give us : \n");

        for (int i = 0; i < userInt; i++)
        {
            if (userInt % 3 == 0 || userInt % 4 == 0)
            {
                messageToWrite += "C";
            }
        
            if (userInt % 7 == 0 || userInt % 18 == 0)
            {
                messageToWrite += "A";
            }
        
            if (userInt % 42 == 0)
            {
                messageToWrite += "CA";
            }
        }
        
        Console.WriteLine(messageToWrite);
    }

    private void Exo2()
    {
        while (inputValue != "stop")
        {
            Console.WriteLine("input seconds for conversion (stop for ending process) : ");
            
            inputValue = Console.ReadLine();

            if (!int.TryParse(inputValue, out userInt))
            {
                Console.Write("value incorrect ! \n");
            }
            else
            {
                messageToWrite += "value entered equals : \n \n";
                
                messageToWrite += userInt / 60 + " minutes\n";
                messageToWrite += userInt / 60 / 60 + " hours\n";
                messageToWrite += userInt / 60 / 60 / 24 + " days\n";
                messageToWrite += userInt / 60 / 60 / 24 / 7 + " weeks\n";
                messageToWrite += userInt / 60 / 60 / 24 / 365 + " years\n";
            
                Console.WriteLine(messageToWrite + "enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    private void ExoTabloRigolo()
    {
        var rndm = new Random();
        int[] table = new int[1500];

        for (int i = 0; i < 1500; i++)
        {
            table[i] = rndm.Next(0,10);
        }

        for (int i = 1499; i > 0; i--)
        {
            if (table[i] == 3)
            {
                threeCount++;
            }
        }
        
        int[] tableWoThrees = new int[1500 - threeCount];
        int j = 0;
        
        for (int i = 1499; i > 0; i--)
        {
            if (table[i] != 3)
            {
                tableWoThrees[j] = table[i];
                j++;
            }
        }

        Console.Write($"number of 3 in table equals {threeCount}\n");
        Console.Write($"table one : \n {table.Length}\n");
        Console.Write($"table without 3s : \n {tableWoThrees.Length}");
    }
}
