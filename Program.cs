namespace _260._Single_Number_III
{
    internal class Program
    {
        public static int[] SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>(nums.Length / 2 + 1);
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num)) dict.Add(num, 1);
                else
                {
                    dict[num]++;
                }
            }
            return dict.Where(p => p.Value == 1).Select(p => p.Key).ToArray();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}