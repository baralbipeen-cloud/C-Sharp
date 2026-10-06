namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            string userName = "Bipeen";
            int luckyNumber = 18;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants ----
            Circle circle = new Circle();
            Console.WriteLine($"PI = {Circle.PI}");

            
            // ---- Task 3: data types and type conversion ----
            byte tiny = 200;
            short small = 30000;
            int whole = 42;
            long big = 1234567890123L;
            float decimalFloat = 3.5f;
            double precise = 3.14159;
            decimal money = 19.99m;
            char letter = 'A';
            bool isReady = true;

            string fortyTwoText = whole.ToString();
            double piTextToDouble = double.Parse("3.14");

            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");
            Console.WriteLine($"int    = {whole}     (type: int)");
            Console.WriteLine($"long   = {big}       (type: long)");
            Console.WriteLine($"float  = {decimalFloat} (type: float)");
            Console.WriteLine($"double = {precise}    (type: double)");
            Console.WriteLine($"decimal= {money}     (type: decimal)");
            Console.WriteLine($"char   = {letter}      (type: char)");
            Console.WriteLine($"bool   = {isReady}     (type: bool)");
            Console.WriteLine($"string = {fortyTwoText}     (type: string)");
            Console.WriteLine($"double = {piTextToDouble}     (type: double)");

            // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };
            Console.WriteLine($"Original : {string.Join(", ", numbers)}");
            Array.Sort(numbers);
            Console.WriteLine($"Sorted   : {string.Join(", ", numbers)}");
            Array.Reverse(numbers);
            Console.WriteLine($"Reversed : {string.Join(", ", numbers)}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] = {numbers[i]}");
            }

            Console.WriteLine($"IndexOf(19)  = {Array.IndexOf(numbers, 19)}");
            Console.WriteLine($"IndexOf(100) = {Array.IndexOf(numbers, 100)}");

            // ---- Task 5: DateTime and TimeSpan ----
            DateTime birthDate = new DateTime(2004, 04, 04);
            DateTime today = DateTime.Now;
            TimeSpan ageSpan = today - birthDate;
            int years = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
            Console.WriteLine($"Total days : {ageSpan.TotalDays}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----
            List<string> fruits = new() { "Apple", "Mango", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Mango");

            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  {fruit}");
            }

            Dictionary<int, string> byId = new()
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" }
            };

            byId.Add(4, "Orange");

            foreach (KeyValuePair<int, string> pair in byId)
            {
                Console.WriteLine($"  {pair.Key} -> {pair.Value}");
            }
        }
    }
}
