namespace bai_tap_ham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1: Tìm từ dài nhất
            Console.WriteLine("==== Bài 1: Tìm từ dài nhất ==== ");
            string input1 = "I love programming";
            string result1 = FindLongestWord(input1);
            Console.WriteLine($"Input: \"{input1}\"");
            Console.WriteLine($"Output: \"{result1}\"\n");

            // Bài 2: Loại bỏ ký tự đặc biệt
            Console.WriteLine("==== Bài 2: Loại bỏ ký tự đặc biệt ==== ");
            input1 = "he@llo! worl#d";
            result1 = RemoveSpecialCharacters(input1);
            Console.WriteLine($"Input: \"{input1}\"");
            Console.WriteLine($"Output: \"{result1}\"\n");

            // Bài 3: Tìm từ dài nhất có chứa số
            Console.WriteLine("==== Bài 3: Tìm từ dài nhất có chứa số ==== ");
            input1 = "abc121 def45 ghi6789";
            result1 = FindLongestWordWithNumber(input1);
            Console.WriteLine($"Input: \"{input1}\"");
            Console.WriteLine($"Output: \"{result1}\"");
        }

        // Bài 1: Tìm từ dài nhất
        static string FindLongestWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "";

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        // Bài 2: Loại bỏ ký tự đặc biệt
        static string RemoveSpecialCharacters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            string result = "";

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    result += c;
                }
            }

            return result;
        }

        // Bài 3: Tìm từ dài nhất có chứa số
        static string FindLongestWordWithNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "";

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string longestWordWithNumber = "";

            foreach (string word in words)
            {
                bool containsNumber = false;
                foreach (char c in word)
                {
                    if (char.IsDigit(c))
                    {
                        containsNumber = true;
                        break;
                    }
                }

                if (containsNumber && word.Length > longestWordWithNumber.Length)
                {
                    longestWordWithNumber = word;
                }
            }

            return longestWordWithNumber;
        }
    }
}
