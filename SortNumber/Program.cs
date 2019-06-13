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

            int m = 4;
            Console.WriteLine("{0}th smallest number is: {1}", m, mthSmallestNumber(nums, m));
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

        /**
        *   3, 1, 9, 8, 6, 5
        *   3, 1, 9, 8, 6, 5
        *   loop through the array
        *       find smallest number
        */
        public static int mthSmallestNumber(int[] numbers, int m)
        {
            int[] sortedNumbers = new int[m];
            /* loop to mth position */
            int[] newNumbers = new int[numbers.Length];
            string original = numbers.ToString();
            string neww = original;
            int[] newww = neww.Split(',');
            for (int i=0; i<m; i++)
            {
                int sn = smallestNumber(newNumbers);
                sortedNumbers.SetValue(sn, i);
                int k=0;
                for (int j=0; j< numbers.Length; j++)
                {
                    if (numbers[j] != sn)
                    {
                        newNumbers[k] = numbers[j];
                    } else {
                        j++;
                    }
                    k++;
                }
            }
            return sortedNumbers[m-1];
        }
    }
}
