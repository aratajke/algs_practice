using System;

namespace algs_fun1
{
   
    class Program
    {

     public static int binary_search(int[]arr, int item)
        {
            int low = 0;
            int high = arr.Length-1;
            int mid = 111;
            while (low <= high)
            {
                mid = (low + high) / 2;
                int guess = arr[mid];

                if (guess == item)
                {
                    return mid+1;                    
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return 404;

        }
        static void Main(string[] args)
        {
            int [] array = {1,2,3,4,5,6,7,8,10,120 };
            int a = binary_search(array, 120);
            Console.WriteLine("PLace: {0}", a);
            Console.WriteLine("\n{0}",array.Length);
        }
    }
}
