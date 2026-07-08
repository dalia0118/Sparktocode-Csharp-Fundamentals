namespace C__Fundamentals___Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easy: Task 1 - Fixed Grades Array
            int[] grades1 = new int[5];

            for (int i = 0; i < grades1.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nAll grades entered:");
            foreach (int grade1 in grades1)
            {
                Console.WriteLine(grade1);
            }
            Console.Write("\n");



        }
    }
}
