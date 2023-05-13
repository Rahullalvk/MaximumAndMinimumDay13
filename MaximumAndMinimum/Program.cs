namespace MaximumAndMinimum 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the first string:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter the third string:");
            string num3 = Console.ReadLine();

            string max = Maximum.GetMax(num1, num2, num3);
            Console.WriteLine("The maximum value is: " + max);
        }
    }
}