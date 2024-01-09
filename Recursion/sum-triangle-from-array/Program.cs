namespace DictionaryIssue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var iteration = 1;
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            PrintTriangle(numbers, iteration, numbers.Length);

        }
        static void PrintTriangle(int[] initial, int iteration, int length)
        {
            if (iteration > length)
            {
                return;
            }
            int[] temp = new int[initial.Length - 1];

            for (int i = 0; i < initial.Length - 1; i++)
            {
                temp[i] = initial[i] + initial[i + 1];
            }
            //Tail recursion
            PrintTriangle(temp, ++iteration, length);
            PrintArray(initial);

        }
        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]} ");
            }
            Console.WriteLine();
        }

    }
}