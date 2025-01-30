namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week (1-7): ");
            string day = Console.ReadLine();

            switch (day) 
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    ; break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    Console.WriteLine("Its the weekend");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }

        }
    }
}