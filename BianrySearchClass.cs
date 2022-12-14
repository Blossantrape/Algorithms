namespace Algorithms
{
    class BianrySearchClass
    { 
        public int? BinarySearch(List<int> list, int item)
        {
            int low = 0;
            int high = list.Count - 1;
            
            while (low <= high)
            {
                int temp = (low + high) / 2;
                int mid = Convert.ToInt32(temp);
                int guess = list[mid];

                if (guess == item)
                {
                    return mid;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }
    }
}