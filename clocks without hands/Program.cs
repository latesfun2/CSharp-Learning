using System;

/*
 * Task: Clock Angle Problem
 * 
 * Given a number `n` (number of clicks), calculate the time on a clock 
 * when the hour hand passes a certain angle.
 * 
 * The program reads `n` from the console and outputs the time in HH:MM format.
 */

public class MainClass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double angle = -195;
        int numberClick = 0;
        int time = 750;

        while (numberClick != n)
        {
            angle += 5.5;
            time += 1;

            if (angle >= 30)
            {
                numberClick += 1;

                if ((numberClick == n) && (angle > 30))
                    time -= 1;

                angle -= 360;
            }
        }

        int hours = time / 60;
        int minutes = time % 60;
        hours %= 12;

        if (minutes >= 10)
            Console.WriteLine(hours + ":" + minutes);
        else
            Console.WriteLine(hours + ":" + 0 + minutes);
    }
}
