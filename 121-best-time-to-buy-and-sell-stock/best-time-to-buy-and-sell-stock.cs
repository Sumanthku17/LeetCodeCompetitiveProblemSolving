public class Solution {
    public int MaxProfit(int[] prices) {
        // var maxValue = 0;
        // for (int i=0; i<prices.Length; i++)
        // {
        //     for (int j=i+1; j<prices.Length; j++)
        //     {
        //         var sum = prices[j] - prices[i];
        //         if(sum>maxValue)
        //         {
        //             maxValue = sum;
        //         }
        //     }
        // }
        // return maxValue;
        
        // int min = prices[0];
        // int maxProfit = 0;
        
        // for(int i=1; i < prices.Length; i++)
        // {
        //     if(prices[i] < min)
        //     {
        //         min = prices[i];
        //     }
            
        //     else
        //     {
        //         var diff = prices[i] - min;
        //         if(diff > maxProfit)
        //         {
        //             maxProfit = diff;   
        //         }
        //     }
        // }
        // return maxProfit;

        var left =0;
        var right =1;
        var maxProfit = 0;

    while(right<prices.Length)
    {
        if(prices[left]<prices[right])
        {
            var profit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
        {
            left=right;
        }
        right++;
    }
    return maxProfit;
    }
}