using System;

using System;

namespace SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 9, 8, 6, 5 };

            Console.WriteLine(smallestNumber(nums));

            Console.WriteLine("Second smallest number is : {0}", secondSmallestNumber(nums));
        }

        public static int smallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for(int i =1;i<numbers.Length;i++)
            {
                if (smallest > numbers[i])
                    smallest = numbers[i];
            }
            return smallest;
        }

        public static int secondSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            int secondSmallest = numbers[1];
            if (smallest > secondSmallest)
            {
                int temp = secondSmallest;
                secondSmallest = smallest;
                smallest = temp;
            }
            for(int i=2;i<numbers.Length;i++)
            {
                if (secondSmallest > numbers[i] && smallest < numbers[i])
                    secondSmallest = numbers[i];
                if (smallest > numbers[i]) {
                    secondSmallest = smallest;
                    smallest = numbers[i];
                }
            }
            return secondSmallest; 
        }
    }
}
