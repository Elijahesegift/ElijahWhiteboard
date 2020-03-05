using System;

namespace DistinctArrayElements
{
    public class ArrayElements
    {
        public static int CountDistinctElements(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isNew = true;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                        isNew = false;
                }

                if (isNew) count++;
            }
            return count;
        }
        public static int CountEachDistinctElements(int[] numbers)
        {
            int count = 0;

            //for (int i = 0; i < numbers.Length; i++)
            foreach (var num in numbers)
            {
                bool isNew = true;
                for (int j = 0; j < count; j++)
                {
                    if (num == numbers[j])
                        isNew = false;
                }

                if (isNew) count++;
            }
            return count;
        }
    }
}