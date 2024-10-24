using System;

public class UniqueElementsCounter
{
    public static int CountUniqueElements(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }

        int count = 1; 

       
        for (int i = 1; i < numbers.Length; i++)
        {
            
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    isUnique = false;
                    break;
                }
            }

            
            if (isUnique)
            {
                count++;
            }
        }

        return count;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 228, 3, 1488, 4, 5, 1, 5, 3, 4 };

        int uniqueCount = CountUniqueElements(numbers);

        Console.WriteLine($"Количество уникальных элементов: {uniqueCount}");
    }
}

