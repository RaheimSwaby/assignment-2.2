namespace assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine($"total sum of the first 10 natural numbers are ");
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i + " ");
                sum += i;
            
            }
            Console.WriteLine("");
            
           
            
            Console.WriteLine("loop ended");


            // assignment 2.1.1

            
            Console.WriteLine("input first number");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input second number");

            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 != num2)
            {
                Console.WriteLine($"{num1} is not not equal to {num2}");
            }
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
        }
    }
}
