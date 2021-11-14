// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] arreglo = new int[] { 4, 5, -2, 3, 1, 2, 6, 6 };
Console.WriteLine(LargestFour(arreglo));


 static int DistinctList(int[] arr)
{

    // code goes here  
    Dictionary<int, int> dictionaryCounter = new Dictionary<int, int>();
    int counterResult = 0;

    foreach (int numero in arr)
    {
        if (dictionaryCounter.TryGetValue(numero, out int search))
        {
            ++dictionaryCounter[numero];
        }
        else
        {
            dictionaryCounter.Add(numero, 1);
        }
    }
    foreach (KeyValuePair<int, int> numeroCounter in dictionaryCounter)
    {
        if (numeroCounter.Value > 1)
        {
            counterResult += numeroCounter.Value - 1;
        }
    }
    return counterResult;
}
static int LargestFour(int[] arr)
{
    
    Array.Sort(arr);
    Array.Reverse(arr);


    int numberSum = 0;

    for (int i = 0; i < 4; i++)
    {
        numberSum += arr[i];
    }
    
    // code goes here  
    return numberSum;

}