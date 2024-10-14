using System;
using System.Linq;
 
class Program
{
    static void Main()
    {
        int[] arr = { 16, 17, 15, 0, 20, 1, 1, 2 };
        int n = arr.Length; // Size of the array
        int max_load = 0, load = 0, diff = 0;
 
        load = arr.Sum();
 
        if (load % n != 0)
        {
            Console.WriteLine(-1);
            return;
        }
 
        load /= n; // Calculate the average load
 
        for (int i = 0; i < n; i++)
        {
            diff += arr[i] - load; // Calculate the difference
 
            max_load = Math.Max(max_load, Math.Abs(diff));
        }
 
        Console.WriteLine(max_load);
    }
}