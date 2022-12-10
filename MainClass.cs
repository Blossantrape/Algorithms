namespace Algorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AddClass search = new AddClass();
            
            List<int> numbers = new List<int>() {1, 3, 5, 7, 9};
            
            Console.Write("Ведите значение для поиска: ");
            string? inputNumberToConvert = Console.ReadLine();
            int inputNumber = Convert.ToInt32(inputNumberToConvert);
            
            Console.WriteLine($"Элемент {inputNumber} под индексом {search.BinarySearch(numbers, inputNumber) }");
        }
    }
}