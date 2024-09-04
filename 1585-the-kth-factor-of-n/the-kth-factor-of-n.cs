public class Solution {
    public int KthFactor(int n, int k) {
        if(k==1)
            return 1;
        
//         var digitSum = 0;
//         var num = n;
//         while(num != 0)
//         {
//             digitSum += num%10;
//             num = num/10;
//         }
        
//         if(digitSum % 3 != 0 && n % 10 != 0)
//         {
//             return (k==2) ? n : -1;
//         }
        
        var FacList = new List<int>();
        
        for(int i=1; i<=n; i++)
        {
            if(n % i == 0)
                FacList.Add(i);
        }
        
        if(FacList.Count < k)
            return -1;
        else 
            return FacList[k-1];
        
    }
}