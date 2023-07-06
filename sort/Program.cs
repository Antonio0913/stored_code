// See https://aka.ms/new-console-template for more information
Console.Write("insert the array to be sorted: ");
char[] seperator = new char[] { ' ', '.', ',' };
string[] Sarr = Console.ReadLine().Split(seperator, StringSplitOptions.RemoveEmptyEntries);
int[] arr = new int[Sarr.Count()];
for (int i = 0; i < Sarr.Length; i++)
{
    arr[i] = Int32.Parse(Sarr[i]);
}

//selection sort
Console.Write("Selection sort result: ");
for(int i = 0;i < arr.Length; i++)
{
    int max_index = i;
    for(int j = i+1; j<arr.Length; j++)
    {
        if (arr[j] > arr[max_index])
            max_index = j;
    }
    int temp = arr[i];
    arr[i] = arr[max_index];
    arr[max_index] = temp;
    Console.Write(arr[i] + " ");
}


// insertion sort
Console.Write("\nInsertion sort result: ");
for(int i = 0; i<arr.Length ; i++)
{
    int j = i + 1;
    while(j<arr.Length&&arr[j]> arr[j-1]) 
    {
        int temp = arr[j-1];
        arr[j-1] = arr[j];
        arr[j] = temp;
    }
    Console.Write(arr[i]+" ");
}