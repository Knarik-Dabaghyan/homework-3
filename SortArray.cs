using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class SortArray
    {
    

       public void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

        }
       public void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {                      
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
       public int partition(int[] arr, int low,
                                   int high)
        {
            int pivot = arr[high];

            
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                
                if (arr[j] < pivot)
                {
                    i++;

                 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
       public void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            { int pi = partition(arr, low, high);              
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        public void sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                HeapSort(arr, n, i);          
            for (int i = n - 1; i > 0; i--)
            {
               
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                HeapSort(arr, i, 0);
            }
        }

       
       public void HeapSort(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 
            
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;          
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                HeapSort(arr, n, largest);
            }
        }





    }
}
