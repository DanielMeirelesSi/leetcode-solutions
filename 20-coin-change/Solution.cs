using System;

public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int unreachable = amount + 1;
        int[] minimumCoins = new int[amount + 1];
        Array.Fill(minimumCoins, unreachable);
        minimumCoins[0] = 0;

        for (int value = 1; value <= amount; value++)
        {
            foreach (int coin in coins)
            {
                if (coin <= value)
                {
                    minimumCoins[value] = Math.Min(minimumCoins[value], minimumCoins[value - coin] + 1);
                }
            }
        }

        return minimumCoins[amount] == unreachable ? -1 : minimumCoins[amount];
    }
}
