namespace LabModuleEndQues1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Hello World";
            double averageLength = CalculateAverageWordLength(sentence);
            Console.WriteLine($"Average word length: {averageLength:F3}");
        }
        static double CalculateAverageWordLength(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int totalLength = 0;

            foreach (string word in words)
            {
                totalLength += word.Length;
            }

            double averageLength = (double)totalLength / words.Length;
            return Math.Ceiling(averageLength * 1000) / 1000; // Round up to three decimal places
        }
    }
}