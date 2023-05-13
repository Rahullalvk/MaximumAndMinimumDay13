namespace MaximumAndMinimum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter values separated by spaces:");
            string input = Console.ReadLine();

            string[] inputValues = input.Split(' ');
            string max = Maximum<string>.GetMax(inputValues);

            Console.WriteLine("The maximum value is: " + max);
        }
    }
}