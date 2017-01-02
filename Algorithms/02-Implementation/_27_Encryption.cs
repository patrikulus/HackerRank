using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/encryption
    /// </summary>
    class _27_Encryption
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            var builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c != ' ')
                    builder.Append(c);
            }

            string o = builder.ToString();

            double sqlrt = Math.Sqrt(o.Length);
            int rows = (int)Math.Floor(sqlrt);
            int columns = (int)Math.Ceiling(sqlrt);

            if (rows*columns < o.Length) rows = columns;

            var table = new char[rows, columns];

            int position = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns && position < o.Length; j++)
                {
                    char c = o[position++];
                    table[i, j] = c;
                }
            }

            var r = new List<char>();
            for (int i = 0; i < columns;)
            {
                for (int j = 0; j < rows;)
                {
                    char c = table[j++, i];
                    if (c != '\0')
                    {
                        r.Add(c);
                        Console.Write(c);
                    }
                }

                i++;
                if (i != columns)
                {
                    Console.Write(' ');
                    r.Add(' ');
                }
            }
        }
    }
}
