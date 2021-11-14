// See https://aka.ms/new-console-template for more information

//istinct List
//Have the function DistinctList(arr) take the array of numbers stored in arr and determine the total number of duplicate entries. For example if the input is [1, 2, 2, 2, 3] then your program should output 2 because there are two duplicates of one of the elements.
//Examples
//Input: new int[] { 0, -2, -2, 5, 5, 5 }
//Output: 3
//Input: new int[] { 100, 2, 101, 4 }
//Output: 0
Console.WriteLine("Hello, World!");
int[] arreglo = new int[] { 4, 5, -2, 3, 1, 2, 6, 6 };
Console.WriteLine(LargestFour(arreglo));


static int DistinctList(int[] arr)
{
    Dictionary<int, int> dictionaryCounter = new Dictionary<int, int>();
    int count = 0;

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
            count += numeroCounter.Value - 1;
        }

    }
    return count;
}
 static int DistinctList2(int[] arr)
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
    List<int> numberList = new List<int>(arr.ToList());
    numberList.Sort();
    numberList.Reverse();

    int numberSum = 0;

    for (int i = 0; i < 4; i++)
    {
        numberSum += numberList[i];
    }
    
    // code goes here  
    return numberSum;

}