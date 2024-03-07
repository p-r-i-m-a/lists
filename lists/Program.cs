namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <int> numbers = new List<int>();
            Random generator = new Random();  

            for (int i = 0; i <= 25; i++)
            {
                numbers.Add(generator.Next(1, 25));

                Console.WriteLine(numbers[i]);
            }


        }
    }
}