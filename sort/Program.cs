namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert the array to be sorted: ");
            string? input= Console.ReadLine();
            if (input != null)
            {
                int[] Unsorted = StringToIntArray(input);
                SelectionSort(Unsorted);
                InsertionSort(Unsorted);
            }
        }

        // this function takes in a string that is the expected input of the user and changes it into an array of intergers
        public static int[] StringToIntArray(string NumbersAsString)
        {
            char[] _seperator = new char[] { ' ', '.', ',' };
            string[] _unsortedStringArray = NumbersAsString.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            int[] _intergerArray = new int[_unsortedStringArray.Length];
            for (int i = 0; i < _unsortedStringArray.Length; i++)
            {
                _intergerArray[i] = int.Parse(_unsortedStringArray[i]);
            }
            return _intergerArray;
        }

        // this function prints out a sorted version of the array given to it as well as return the newly sorted array using selection sort
        public static int[] SelectionSort(int[] _toBeSorted)
        {
            Console.Write("Selection sort result: ");
            for (int i = 0; i < _toBeSorted.Length; i++)
            {
                int _maxIndex = i;
                for (int j = i + 1; j < _toBeSorted.Length; j++)
                {
                    if (_toBeSorted[j] > _toBeSorted[_maxIndex])
                    {
                        _maxIndex = j;
                    }
                }
                int _temp = _toBeSorted[i];
                _toBeSorted[i] = _toBeSorted[_maxIndex];
                _toBeSorted[_maxIndex] = _temp;
                Console.Write(_toBeSorted[i] + " ");
            }
            return _toBeSorted;
        }

        public static int[] InsertionSort(int[] _toBeSorted)
        {
            // insertion sort
            Console.Write("\nInsertion sort result: ");
            for (int i = 0; i < _toBeSorted.Length; i++)
            {
                int j = i + 1;
                while (j < _toBeSorted.Length && _toBeSorted[j] > _toBeSorted[j - 1])
                {
                    int _temp = _toBeSorted[j - 1];
                    _toBeSorted[j - 1] = _toBeSorted[j];
                    _toBeSorted[j] = _temp;
                    j -= 1;
                }
                Console.Write(_toBeSorted[i] + " ");
            }
            return _toBeSorted;
        }
    }
}

