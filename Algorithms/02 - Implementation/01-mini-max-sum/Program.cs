using System;

public class Solution
{
    public static void Main(String[] args)
    {
        string[] array_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(array_temp, Int32.Parse);
        Array.Sort(array);

        long min = 0, max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int value = array[i];
            if (i != 0) max += value;
            if (i != array.Length - 1) min += value;
        }

        Console.WriteLine($"{min} {max}");
    }
}