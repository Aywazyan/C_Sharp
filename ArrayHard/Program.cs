namespace ArrayHard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            int[] ints = new int[n];
            int minNum = 0;
            int maxNum = 100;

            for (int i = 0; i < n; i++)
            {
                ints[i] = Random.Shared.Next(minNum + 1, minNum + maxNum);
                minNum = ints[i];
            }

            int[] evenArr = new int[n];
            int[] oddArr = new int[n];
            int handipelZuyg = 0;
            int handipelKent = 0;
            for (int i = 0; i < n; i++)
            {

                if (ints[i] % 2 == 0)
                {
                    evenArr[handipelZuyg] = ints[i];
                    handipelZuyg += 1;
                }
                else
                {
                    oddArr[handipelKent] = ints[i];
                    handipelKent += 1;
                }
            }

            for (int i = 0; i < handipelZuyg; i++)
            {
                System.Console.WriteLine(evenArr[i]);
            }
            System.Console.WriteLine("======");
            for (int i = 0; i < handipelKent; i++)
            {
                System.Console.WriteLine(oddArr[i]);
            }
        }
    }
}

