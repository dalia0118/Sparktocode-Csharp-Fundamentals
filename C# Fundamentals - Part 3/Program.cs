namespace C__Fundamentals___Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Absolute Difference

            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double difference = Math.Abs(num1 - num2);
            Console.WriteLine("The absolute difference is " + difference);


            
        }
    }
}
