/// <summary>
/// Класс отвечающий за создание массива.
/// </summary>
public static class ArrayCreator
{
    public static int[] Create(this int n)
        {
          return new int[n];  
        }

    public static string ConvertToStringAndPrintToTerminal(this int[] array)
            {
                string str = $"[{string.Join("  ", array)}]";
                System.Console.WriteLine(str);
                return str;    
            }

    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
                {
                    Random random = seed == 0? random = new Random() : random = new Random(seed);
                    return array = array.Select(item => random.Next(min, max)).ToArray();
                }
}