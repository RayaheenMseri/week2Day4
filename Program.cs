class Program
{
    static void Main()
    {

        //Print an Array (Looping Basics)
        Console.WriteLine("Print an Array");
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        //Find the Maximum in an Array
        Console.WriteLine("\nFind the Maximum in an Array");
        int[] numbers1 = { 15, 42, 7, 89, 23 };
        int max = numbers1[0];

        for (int i = 0; i < numbers1.Length; i++)
        {
            if (numbers1[i] > max)
                max = numbers1[i];
        }

        Console.WriteLine($"Largest number is {max}");

        //Reverse an Array
        Console.WriteLine("Reversed array: ");
        int[] numbers2 = { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers2);
        foreach (int num in numbers2)
        {
            Console.Write(num + " ");
        }

        // Count Even and Odd Numbers
        Console.WriteLine("\nCount Even and Odd Numbers");
        int[] numbers3 = { 3, 6, 9, 12, 15, 18 };
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < numbers3.Length; i++)
        {
            if (numbers3[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");


        // Sum of All Elements in an Array
        Console.WriteLine("Sum of All Elements in an Array");
        int[] numbers4 = { 5, 10, 15, 20 };
        int sum = 0;
        for (int i = 0; i < numbers4.Length; i++)
        {
            sum += numbers4[i];
        }

        Console.WriteLine($"Sum of array elements {sum}");
    }
}

