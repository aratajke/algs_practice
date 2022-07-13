using System;
using System.Linq;
using System.Collections.Generic;

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

        public static int find_smal(List<int> arr)
        {
            int small_index = 0;
            int small = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                    small_index = i;
                }
            }

            return small_index;
        
        }
        
        public static int[] delete_by_index(List<int> base_arr,int index)
        {
            int[] new_arr = new int[base_arr.Count];
            for (int i = 0; i < base_arr.Count; i++)
            {
                if (i != index)
                {
                    new_arr[i] = base_arr[i];
                }
            }

            return new_arr;

        }
        public static List<int> select_sort(List<int> arr)
        {

            List<int> newArr = new List<int>(arr.Count);
            int small = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                int small_index = find_smal(arr);
                small = arr[small_index];
                
                newArr[i] = small;
                arr.RemoveAt(small_index);
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            var lst = new List<int> { 11,1, 2, 7,124, 4, 10, 0,-2 };

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("\t{0}",lst[i]  );
            }
            lst = select_sort(lst);
            Console.WriteLine("================================");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("\t{0}", lst[i]);
            }



            /*int [] array = {1,2,3,4,5,6,7,8,10,120 };
            int a = binary_search(array, 120);
            Console.WriteLine("PLace: {0}", a);
            Console.WriteLine("\n{0}",array.Length);*/


        }
    }
}
