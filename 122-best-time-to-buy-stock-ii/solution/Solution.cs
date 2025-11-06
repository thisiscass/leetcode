namespace Solution;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var length = prices.Length;
        var minPrice = prices[0];
        var profit = 0;
        int i = 1;

        while (i < length)
        {
            var currentPrice = prices[i];

            if (currentPrice < minPrice)
            {
                minPrice = currentPrice;
                i++;
                continue;
            }

            var nextIndex = i + 1;
            var nextPrice = nextIndex == length ? -1 : prices[nextIndex];

            if (nextPrice != -1 && nextPrice < currentPrice)
            {
                profit += currentPrice - minPrice;
                minPrice = nextPrice;
                i++;
            }

            i++;

            if (minPrice < currentPrice && i == length && nextPrice == -1)
            {
                profit += currentPrice - minPrice;
            }
        }

        return profit;
    }
}