using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("insert the array to be sorted: ");
      int[] Unsorted = StringToIntArray(Console.ReadLine());
      int[] SortedBySelection = SelectionSort(Unsorted);
      int[] SortedByInsertion = InsertionSort(Unsorted);
    }
    // this function takes in a string that is the expected input of the user and changes it into an array of intergers
    public static int[] StringToIntArray(string NumbersAsString) 
    {
      char[] seperator = new char[] { ' ', '.', ',' };
      string[] unsortedStringArray = NumbersAsString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
      int[] intergerArray = new int[unsortedStringArray.Count()];
      for (int i = 0; i < unsortedStringArray.Length; i++)
      {
        intergerArray[i] = Int32.Parse(unsortedStringArray[i]);
      }
        return intergerArray;
    }
    // this function prints out a sorted version of the array given to it as well as return the newly sorted array using selection sort
    public static int[] SelectionSort(int[] toBeSorted)
    {
      Console.Write("Selection sort result: ");
      for (int i = 0; i < toBeSorted.Length; i++)
      {
        int max_index = i;
        for (int j = i + 1; j < toBeSorted.Length; j++)
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
      return toBeSorted;
    }
    public static int[] InsertionSort(int[] toBeSorted)
    {
      // insertion sort
      Console.Write("\nInsertion sort result: ");
      for (int i = 0; i < toBeSorted.Length; i++)
      {
      int j = i + 1;
        while (j < toBeSorted.Length && toBeSorted[j] > toBeSorted[j - 1])
        {
          int temprary = toBeSorted[j - 1];
          toBeSorted[j - 1] = toBeSorted[j];
          toBeSorted[j] = temprary;
        }
        Console.Write(toBeSorted[i] + " ");
      }
      return toBeSorted;
    }
  }
}

