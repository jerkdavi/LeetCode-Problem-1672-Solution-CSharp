using System;
using System.Collections.Generic;
using System.Text;

namespace RichestCustomerWealth
{
    public class Solution
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int maxAccountSum = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int currentAccountSum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentAccountSum += accounts[i][j];
                }
                if (currentAccountSum > maxAccountSum)
                {
                    maxAccountSum = currentAccountSum;
                }
            }
            return maxAccountSum;
        }
    }
}
