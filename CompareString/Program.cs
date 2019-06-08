using System;

namespace MKL
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "HelLo";
            Console.WriteLine(compareStr_NC(str1, str2));
            
            int[] nums = { 3, 1, 9, 8, 6, 5 };

            Console.WriteLine(smallestNumber(nums));

            Console.WriteLine("Second smallest number is : ", secondSmallestNumber(nums));
        }

        public static bool compareStr_NC(string str1, string str2)
        {
            return (string.Compare(str1.ToUpper(), str2.ToUpper())==0)?true:false ;
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
                if (smallest > numbers[i])
                    secondSmallest = smallest;
                    smallest = numbers[i];
            }
            return secondSmallest; 
        }
    }
}
