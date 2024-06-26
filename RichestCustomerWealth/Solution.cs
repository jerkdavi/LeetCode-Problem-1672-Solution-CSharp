using System;
using System.Collections.Generic;
using System.Text;

namespace RichestCustomerWealth
{
    public class Solution
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int sum = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int tempSum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    tempSum += accounts[i][j];
                }
                if (tempSum > sum)
                {
                    sum = tempSum;
                }
            }
            return sum;
        }
    }
}
