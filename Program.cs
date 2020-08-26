using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;
using System.Diagnostics;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            SortArray s = new SortArray();
            Stopwatch stopWatch = new Stopwatch();
            
            WriteLine("Please enter the size of an array that you want to sort:");
            int n = int.Parse(ReadLine());         
            int[] a = new int[n];
          
             for (int i=0; i < a.Length; i++)
            {
                a[i] = rd.Next(1, 100);
                Write(a[i]+"\t");
            }
            WriteLine();
          WriteLine("Select which algorithm you want to perform: \n 1. Insertion sort \n 2. Bubble sort \n 3. Quick sort \n 4. Heap sort \n ");
            int b = int.Parse(ReadLine());
            switch (b)
            {
                case 1:
                    WriteLine("Insertion Sort");
                    s.InsertionSort(a);
                    for (int i = 0; i < a.Length; i++)
                    {
                        Write(a[i] + "\t");
                    }
                    WriteLine();
                    stopWatch.Start();
                    s.InsertionSort(a);
                    stopWatch.Stop();
                    WriteLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Time InsertionSor : {0}", stopWatch.Elapsed);
                    ResetColor();
                    WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                    break;
                case 2:
                    WriteLine("Bubble Sort");
                    s.bubbleSort(a);
                    for (int i = 0; i < a.Length; i++)
                    {
                        Write(a[i] + "\t");
                    }
                    WriteLine();
                    stopWatch.Start();
                    s.bubbleSort(a);
                    stopWatch.Stop();
                    WriteLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Time bubbleSort: {0}", stopWatch.Elapsed);
                    ResetColor();
                    WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                    break;
                case 3:
                    WriteLine("Quick Sort");

                    s.quickSort(a, 0, a.Length-1);
                    for (int i = 0; i < a.Length; i++)
                    {
                        Write(a[i] + "\t");
                    }
                    stopWatch.Start();
                    s.bubbleSort(a);
                    stopWatch.Stop();
                    WriteLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Time quickSort : {0}", stopWatch.Elapsed);
                    ResetColor();

                    WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
                    break;
                case 4:
                    WriteLine("Heap Sort");

                    s.HeapSort(a, a.Length, a.Length);
                    
                        for (int j = 0; j < a.Length; j++)
                        {
                            Write(a[j] + "\t");
                        }
                    stopWatch.Start();
                    s.bubbleSort(a);
                    stopWatch.Stop();
                    WriteLine();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Time HeapSort : {0}", stopWatch.Elapsed);
                    ResetColor();
                    WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

                    break;

                default:
                    WriteLine("Error value");
                    break;
            }
           
        }



    }
    }

