using System;

namespace RichestCustomerWealth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1672.
            //int[][] accounts = new int[][]
            //{
            //    new int[] { 1, 2, 3 },
            //    new int[] { 3, 2, 1 }
            //};
            //int[][] accounts = new int[][]
            //{
            //    new int[] { 1, 5 },
            //    new int[] { 7, 3 },
            //    new int[] { 3, 5 }
            //};
            //int[][] accounts = new int[][]
            //{
            //    new int[] { 2, 8, 7 },
            //    new int[] { 7, 1, 3 },
            //    new int[] { 1, 9, 5 }
            //};
            Console.Write("What is the number of accounts: ");
            int accountsLength = int.Parse(Console.ReadLine());
            Console.Write("What is the number of values: ");
            int valuesLength = int.Parse(Console.ReadLine());
            int[][] accounts = new int[accountsLength][];
            for(int i = 0; i < accountsLength; i++)
            {
                accounts[i] = new int[valuesLength];
                for(int j = 0; j < valuesLength; j++)
                {
                    Console.Write($"Enter account[{i + 1}][{j + 1}] value: ");
                    accounts[i][j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = Solution.MaximumWealth(accounts);
            Console.WriteLine(sum);

            Console.WriteLine("Done processing.");
            Console.ReadLine();
        }
    }
}
