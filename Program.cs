using System;
using System.Collections.Generic;

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
