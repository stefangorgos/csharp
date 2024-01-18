namespace Task1
{
    internal class Program
    {
        static string GetSubsequences(string sequence)
        {
            int start = 0;
            int end = start + 1;
            List<string> ssequence = new List<string>();
            while (start < sequence.Length)
            {
                if (end < sequence.Length && sequence[end - 1] != sequence[end])
                {
                    ssequence.Add(sequence.Substring(start, end - start + 1));
                    end++;
                }
                else
                {
                    start++;
                    end = start + 1;
                }
            }
            return String.Join(", ", ssequence.ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your character sequence");
            string seq = Console.ReadLine();
            string result = GetSubsequences(seq);
            Console.WriteLine(result);
        }
    }
}