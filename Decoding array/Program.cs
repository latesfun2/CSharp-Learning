/*
 * Task: Delta Decoding (Uncle Vasya's Inventory)
 * 
 * Uncle Vasya recorded only the differences between numbers (delta encoding), 
 * but forgot to write down the first initial number. 
 * He remembered the minimum number in the sequence (minNumbers).
 * 
 * This method reconstructs the original sequence from the deltas and the minimum value,
 * and outputs it to the console.
 */

public static void DecodeDelta(int[] originalArray, int minNumbers)
{
    int[] result = new int[originalArray.Length+1];
    result[0] = minNumbers;
    
    int resultLength = result.Length;
    for (int i = 1; i < resultLength; i++)
        result[i] = originalArray[i-1] + result[i-1];

    int minValue = result[0];
    for (int i = 1; i < result.Length; i++)
        if (result[i] < minValue)
            minValue = result[i];
    
    int shift = minNumbers - minValue;

    foreach (int x in result)
        Console.Write((x + shift) + " ");
}
