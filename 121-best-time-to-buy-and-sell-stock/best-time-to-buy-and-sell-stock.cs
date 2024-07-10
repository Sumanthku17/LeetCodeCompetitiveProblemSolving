public class Solution {
    public int MaxProfit(int[] prices) {
        /*var maxValue = 0;
        for (int i=0; i<prices.Length; i++)
        {
            for (int j=i+1; j<prices.Length; j++)
            {
                var sum = prices[j] - prices[i];
                if(sum>maxValue)
                {
                    maxValue = sum;
                }
            }
        }
        return maxValue;*/
        
        int min = prices[0];
        int maxProfit = 0;
        
        for(int i=1; i < prices.Length; i++)
        {
            if(prices[i] < min)
            {
                min = prices[i];
            }
            else if(prices[i] - min > maxProfit)
            {
                maxProfit = prices[i] - min;
            }
        }
        return maxProfit;
    }
}