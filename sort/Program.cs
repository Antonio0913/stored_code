// See https://aka.ms/new-console-template for more information
Console.Write("insert the array to be sorted: ");
char[] seperator = new char[] { ' ', '.', ',' };
string[] unsortedStringArray = Console.ReadLine().Split(seperator, StringSplitOptions.RemoveEmptyEntries);
int[] toBeSorted = new int[unsortedStringArray.Count()];
for (int i = 0; i < unsortedStringArray.Length; i++)
{
  toBeSorted[i] = Int32.Parse(unsortedStringArray[i]);
}
// selection sort
Console.Write("Selection sort result: ");
for(int i = 0;i < toBeSorted.Length; i++)
{
  int max_index = i;
  for(int j = i+1; j< toBeSorted.Length; j++)
  {
    if (toBeSorted[j] > toBeSorted[max_index])
    {
        max_index = j;
    }
  }
  int temprary = toBeSorted[i];
  toBeSorted[i] = toBeSorted[max_index];
  toBeSorted[max_index] = temprary;
  Console.Write(toBeSorted[i] + " ");
}
// insertion sort
Console.Write("\nInsertion sort result: ");
for(int i = 0; i< toBeSorted.Length ; i++)
{
  int j = i + 1;
  while(j< toBeSorted.Length&& toBeSorted[j]> toBeSorted[j-1]) 
  {
    int temprary = toBeSorted[j-1];
    toBeSorted[j-1] = toBeSorted[j];
    toBeSorted[j] = temprary;
  }
    Console.Write(toBeSorted[i]+" ");
}
