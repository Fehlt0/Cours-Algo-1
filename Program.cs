public class Program
{
    private const int maxValue = 874;
    private const int minValue = 6;
    private static string inputStr;
    
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Exo1();
    }
    
    public void Exo1()
    {
        Console.Write("enter value : \n ");
        inputStr = Console.ReadLine();
        Console.Clear();
        
        if (int.TryParse(inputStr, out int userInt)) return ;
        if (userInt < minValue || userInt > maxValue) return;
        
        Console.Write("value is valid \n");
    }
}