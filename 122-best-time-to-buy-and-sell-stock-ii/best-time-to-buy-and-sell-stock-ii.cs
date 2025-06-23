public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length==0 || prices.Length==1)
        {
            return 0;
        }

        var left =0;
        var right =1;
        var grossProfit =0;
        while(right<prices.Length)
        {
            if(prices[left]<prices[right])
            {
                grossProfit += (prices[right] - prices[left]);
                left++;
            }
            else
            {
                left=right;
            }
            right++;
        }
        return grossProfit;
    }
}