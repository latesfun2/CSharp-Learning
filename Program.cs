using System;

public class MainClass
{
    public static void Main()
    {
        int hourHandAmount = 1468;
        int[] vasyaArray = { 27, -15, 2, 22, 12, -55, 11 };
        AhShitHereWeGoAgain(vasyaArray, hourHandAmount);

    }
    public static void AhShitHereWeGoAgain(int[] vasyaArray, int hourHandAmount)
    {
        int[] result = new int[vasyaArray.Length+1];
        result[0] = hourHandAmount;
        int resultLength = result.Length;
        for (int i = 1; i < resultLength; i++)
            result[i] = vasyaArray[i-1] + result[i-1];

        int minValue = result[0];
        for (int i = 1; i < result.Length; i++)
            if (result[i] < minValue)
                minValue = result[i];
        
        int shift = hourHandAmount - minValue;

        foreach (int x in result)
            Console.Write((x + shift) + " ");
    }
}