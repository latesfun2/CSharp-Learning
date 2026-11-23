using System;
using System.Collections.Generic;

/*
 * Problem: 
 * Find all ways to represent a given number as a * b + c.
 * The numbers a, b, and c must consist ONLY of the digits: 2, 3, and 7.
 * Only addition (+) and multiplication (*) operations are allowed.
 * 
 * Output requirements:
 * - Print combinations in ascending order of the first multiplier (a).
 * - If 'a' is equal, sort by the second multiplier (b) in ascending order.
 * - Do not output permutations (e.g., if a * b is printed, do not print b * a).
 */

public class MainClass
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(number);
    }

    public static void VasyaStyle(int number)
    {
        List<int> list = Generated(number);

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                int c = number - (list[i] * list[j]);
                if (((list[i] * list[j] + c) == number) && list.Contains(c) && (list[i] <= list[j]))
                    Console.WriteLine($"{number} = {list[i]} * {list[j]} + {c}");
            }
        }
    }

    public static List<int> Generated(int numbers)
    {
        List<int> list = new List<int>() { 2, 3, 7 };

        int count = numbers.ToString().Length;

        for (int step = 0; step < count; step++)
        {
            int maxdigit = list.Count;
            
            for (int i = 0; i < maxdigit; i++)
            {
                if ((list[i] * 10 + 2) <= numbers && !list.Contains(list[i] * 10 + 2)) 
                    list.Add(list[i] * 10 + 2);
                if ((list[i] * 10 + 3) <= numbers && !list.Contains(list[i] * 10 + 3))
                    list.Add(list[i] * 10 + 3);
                if ((list[i] * 10 + 7) <= numbers && !list.Contains(list[i] * 10 + 7))
                    list.Add(list[i] * 10 + 7);
            }
        }
        return list;
    }
}

