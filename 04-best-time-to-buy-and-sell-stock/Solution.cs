public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int lowestPrice = int.MaxValue;
        int maximumProfit = 0;

        foreach (int price in prices)
        {
            if (price < lowestPrice)
            {
                lowestPrice = price;
            }

            int currentProfit = price - lowestPrice;

            if (currentProfit > maximumProfit)
            {
                maximumProfit = currentProfit;
            }
        }

        return maximumProfit;
    }
}
