using System.Linq.Expressions;

namespace algo1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Program exo = new Program();
            exo.Exo3();
        }

        private const int minValue = 6;
        private const int maxValue = 874;

        public void Exo1()
        {
            Console.WriteLine("rentrez une valeur entre 6 et 874");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int nombre))
            {
                {

                }
                if (nombre >= maxValue || nombre <= minValue)
                {
                    Console.WriteLine("incorrect value");
                }
                else
                {
                    if (nombre % 3 == 0 || nombre % 4 == 0)
                    {
                        Console.WriteLine("C");
                    }

                    if (nombre % 7 == 0 || nombre % 18 == 0)
                    {
                        Console.WriteLine("A");
                    }

                    if (nombre % 42 == 0)
                    {
                        Console.WriteLine("CA");
                    }
                }
            }
            else
            {
                Console.WriteLine("incorrect type");
            }
        }
        
        public void Exo2()
        {
            Console.WriteLine("number (in seconds)");
            int userInput = int.Parse(Console.ReadLine());
            int userInputToMin = userInput / 60;
            Console.WriteLine("ça fait " + userInputToMin + " minutes");
            int userInputToHrs = userInputToMin / 60;
            Console.WriteLine("ça fait " + userInputToHrs + " heures");
            int userInputToDays = userInputToHrs / 24;
            Console.WriteLine("ça fait " + userInputToDays + " jours");
            
            double userInputToDouble = (double)userInput;
            DateTime currentDate = DateTime.Now;
            currentDate = currentDate.AddSeconds(userInputToDouble);
            Console.WriteLine("la date actuelle est " + DateTime.Now);
            Console.WriteLine("la date sera " + currentDate + " dans " + userInput + " secondes");
        }

        public void Exo3()
        {
            int Min = 0;
            int Max = 10;
            int countThree = 0;
            int[] intArray = new int[1500];

            Random randNum = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = randNum.Next(Min, Max);
            }
            Console.WriteLine(string.Join(",", intArray));
            for (int i = intArray.Length-1; i > 0 ; i--)
            {
                if (intArray[i] == 3)
                {
                    countThree++;
                }
            }
            Console.WriteLine("nombre de 3 : " + countThree);
        }
    }
}
