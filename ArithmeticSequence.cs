using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int[] arr = new int[count];
            int sum = 0;
            for(int i=0;i<count;i++)
            {
                arr[i] = number + add * i;
                sum += arr[i];
            }
            return sum;
        }
    }
}
