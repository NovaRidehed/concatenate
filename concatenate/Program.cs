namespace concatenate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));
        }
        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] newwords = new string[part1.Length + part2.Length];
            int i = 0;
            foreach(string word in part1)
            {
                newwords[i] = word;
                i++;
            }
            foreach(string word in part2)
            {
                newwords[i] = word;
                i++;
            }
            return newwords;
        }
    }
}