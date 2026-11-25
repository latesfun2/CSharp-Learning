/*
 * Task: Delta Decoding Utility
 * 
 * [EN] Reconstructs an original numerical sequence from its delta-encoded representation.
 * The initial value is not known, but the minimum value of the original sequence is provided.
 * 
 * [RU] Восстанавливает исходную числовую последовательность из дельта-кодированного представления.
 * Начальное значение неизвестно, но дано минимальное значение исходной последовательности.
 * 
 * Input: an array of deltas (originalArray) and the minimum value (minNumbers).
 * Output: the reconstructed sequence printed to the console.
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
