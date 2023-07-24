namespace test
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // System.Console.WriteLine("..");
            // PlusOne(new int[] { 1, 9, 2, 9 });

            string ab = "ab01";
            var index1 = ab.Length > 3 ? ab[2] - '0' : 0;
            var index2 = ab.Length > 3 ? ab[2] - '0' : 0;
            System.Console.WriteLine(index1);
            System.Console.WriteLine(index2);
            System.Console.WriteLine(index1 + index2);

        }


        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; --i)
            {
                System.Console.WriteLine("i_" + i);
                System.Console.WriteLine("digits[i]_" + digits[i]);
                if (digits[i] != 9)
                {
                    ++digits[i]; //4

                    System.Console.WriteLine("digits[i]__" + digits[i]);

                    for (int j = i + 1; j < n; ++j)
                    {
                        digits[j] = 0;
                        System.Console.WriteLine("j_" + j);
                        System.Console.WriteLine("digits[j]_" + digits[j]);
                    }
                    return digits;
                }
            }

            // digits 中所有的元素均为 9
            int[] ans = new int[n + 1];
            ans[0] = 1;
            return ans;
        }
    }
}