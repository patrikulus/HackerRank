using System;

class Solution
{
    public static void Main(String[] args)
    {
        string time = Console.ReadLine();
        DateTime date = DateTime.Parse(time);
        Console.Write(date.ToString("HH:mm:ss"));
    }
}
