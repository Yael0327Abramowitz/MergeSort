using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 1, 3, 2, 19, 7, 21, 7, 23, 9, 7 };//{ 21, 7, 23, 9, 7, 1, 3, 2, 19, 7, };//, 21, 22, 2, 16, 17, 19};
            Console.WriteLine("Given Array");
            printArray(arr);
            MergeSorting ob = new MergeSorting();
            ob.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
   
    class MergeSorting
    {
        static int x;
        public void MergeSort(int[] arr, int beg, int end)
        {
          
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                MergeSort(arr, beg, mid);
                MergeSort(arr, mid + 1, end);
                x++;
                Merge(arr, beg, mid, end);
            }

        }
        public void Merge(int[] arr, int beg, int mid, int end)
        {
            if (arr[mid] > arr[mid+1])
            {
                mid = mid + 1;
            }
            int[] temp = new int[arr.Length];
            int i = 0;
            int origMid = mid;
            int origBeg = beg;
            int origEnd = end;

            try
            {
                while ((mid != end + 1) && (beg != origMid))
                {
                    if (arr[mid] < arr[beg])
                    {
                        temp[i] = arr[mid];
                        mid++;
                        i++;
                    }
                    else if (arr[beg] < arr[mid])
                    {
                        temp[i] = arr[beg];
                        beg++;
                        i++;
                    }
                    else
                    {
                        temp[i] = arr[beg];
                        temp[i + 1] = arr[mid];
                        i = i + 2;
                        beg++;
                        mid++;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("man, that stinks!");
                Console.WriteLine(ex.Message);
            }
           
            if (mid != end + 1)
            {
                for (int j = mid; j <= end; j++)
                {
                    temp[i] = arr[j];
                    i++;
                }
            }
            else if (beg != mid + 1)
            {
                for (int j = beg; j < origMid; j++)
                {
                    temp[i] = arr[j];
                    i++;
                }
            }
            int newI = origBeg;
            foreach (var elem in temp)
            {
                if (elem != 0)
                {
                    arr[newI] = elem;
                    newI++;
                }
            }
           
        }


        public void PrintArray(int[] arr)
        {
            foreach (var elem in arr)
            {
                Console.Write(elem+ " ");
            }

        }


    }
    
  
    
}
