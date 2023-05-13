namespace MaximumAndMinimum 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the first float number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second float number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third float number:");
            float num3 = float.Parse(Console.ReadLine());

            float max = Maximum.GetMax(num1, num2, num3);
            Console.WriteLine("The maximum value is: " + max);
        }
    }
}