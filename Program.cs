public class Program
{
    private const int maxValue = 874;
    private const int minValue = 6;
    private static string inputStr;
    private static string messageToWrite;
    
    public static void Main(string[] args)
    {
        Console.Clear();
        Program program = new Program();
        program.Exo1();
    }
    
    public void Exo1()
    {
        Console.Write("enter value : ");
        inputStr = Console.ReadLine();
        
        if (!int.TryParse(inputStr, out int userInt)) return ;
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
}
