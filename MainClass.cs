namespace Algorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BianrySearchClass binarySearch = new BianrySearchClass();
            SortingByChoiceClass sortingByChoiceClass = new SortingByChoiceClass();
            
            List<int> numbers = new List<int>() {1, 3, 5, 7, 9};

            Console.WriteLine("Какой Алгоритм?");
            string? whichAlgorithm = Console.ReadLine();

            switch (whichAlgorithm)
            {
                case "1":
                    Console.Write("Ведите значение для поиска: ");
                    string? inputNumberToConvert = Console.ReadLine();
                    int inputNumber = Convert.ToInt32(inputNumberToConvert);
                    
                    Console.WriteLine($"Элемент {inputNumber} под индексом {binarySearch.BinarySearch(numbers, inputNumber) }");
                    break;
                
                case "2":
                    sortingByChoiceClass.ViewAllMusic();
                    break;
            }
        }
    }
}