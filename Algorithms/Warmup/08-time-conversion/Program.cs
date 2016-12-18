using System;

class Solution
{

    static void Main(String[] args)
    {
        string time = Console.ReadLine();
        DateTime date = DateTime.Parse(time);
        Console.WriteLine(date.ToString("HH:mm:ss"));
    }
}
