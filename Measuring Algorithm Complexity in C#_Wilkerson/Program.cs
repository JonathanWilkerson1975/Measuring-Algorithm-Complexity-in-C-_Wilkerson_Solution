using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // test arrays
        int[] arr1 = new int[1000];
        int[] arr2 = new int[10000];
        int[] arr3 = new int[100000];

        // fill arrays with dummy data
        Random rand = new Random();
        for (int i = 0; i < arr1.Length; i++) arr1[i] = rand.Next(1, 100);
        for (int i = 0; i < arr2.Length; i++) arr2[i] = rand.Next(1, 100);
        for (int i = 0; i < arr3.Length; i++) arr3[i] = rand.Next(1, 100);

        // stopwatch object
        Stopwatch sw = new Stopwatch();

        // ---- O(1) test ----
        sw.Restart();
        O1(arr1);
        sw.Stop();
        Console.WriteLine($"O(1) with 1,000 items: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        O1(arr2);
        sw.Stop();
        Console.WriteLine($"O(1) with 10,000 items: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        O1(arr3);
        sw.Stop();
        Console.WriteLine($"O(1) with 100,000 items: {sw.ElapsedMilliseconds} ms");

        // ---- O(n) test ----
        sw.Restart();
        SumArray(arr1);
        sw.Stop();
        Console.WriteLine($"O(n) with 1,000 items: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        SumArray(arr2);
        sw.Stop();
        Console.WriteLine($"O(n) with 10,000 items: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        SumArray(arr3);
        sw.Stop();
        Console.WriteLine($"O(n) with 100,000 items: {sw.ElapsedMilliseconds} ms");

        // ---- O(n^2) test ----
        sw.Restart();
        CheckPairs(arr1);
        sw.Stop();
        Console.WriteLine($"O(n^2) with 1,000 items: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        CheckPairs(arr2);
        sw.Stop();
        Console.WriteLine($"O(n^2) with 10,000 items: {sw.ElapsedMilliseconds} ms");

        // ⚠️ Warning: O(n²) with 100,000 items will take forever (10^10 loops!)
        // Uncomment below if you really want to see it run, but be careful:
        // sw.Restart();
        // CheckPairs(arr3);
        // sw.Stop();
        // Console.WriteLine($"O(n^2) with 100,000 items: {sw.ElapsedMilliseconds} ms");
    }

    // O(1)
    static int O1(int[] arr)
    {
        return arr[0];
    }

    // O(n)
    static int SumArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    // O(n^2)
    static void CheckPairs(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int result = arr[i] + arr[j]; // dummy operation
            }
        }
    }
}
