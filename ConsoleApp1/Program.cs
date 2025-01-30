namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter any whole number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("The number you entered is zero");
            }
            else if (num < 0)
            {
                Console.WriteLine("I don't like evaluating negative numbers.");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number you entered is Even");
            }
            else 
            {
                Console.WriteLine("The number you entered is Odd");
            }


           



            



            
           
            
        }
    }
}