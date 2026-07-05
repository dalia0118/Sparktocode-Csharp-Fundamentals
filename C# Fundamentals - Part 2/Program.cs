namespace C__Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Countdown Timer
            Console.WriteLine("Enter a starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
            Console.Write("\n");


        }
    }
}
