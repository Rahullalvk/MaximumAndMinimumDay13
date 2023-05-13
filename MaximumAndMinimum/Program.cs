namespace MaximumAndMinimum 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int num3 = int.Parse(Console.ReadLine());

            int max = Maximum.GetMax(num1, num2, num3);
            Console.WriteLine("The maximum value is: " + max);
        }
    }
}