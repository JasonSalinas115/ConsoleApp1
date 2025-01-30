namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write("\n");

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.Write("\n");

            string output = "#";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }
        }
    }
}