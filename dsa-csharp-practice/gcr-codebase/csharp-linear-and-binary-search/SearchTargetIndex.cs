using System;

class SearchTargetIndex
{
    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int target = 7;

        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                Console.WriteLine("Found at index: " + mid);
                return;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine("-1");
    }
}
