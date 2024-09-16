public class Solution {
    public int Fib(int n) {
//         if(n==0 || n==1)
//             return n;
        
//         return Fib(n-1) +Fib(n-2);
        
        int[] arr = new int[n+1];
        return Fibo(n, arr);
    }
    
    public int Fibo(int n, int[] arr)
    {
        if(n==0 || n==1)
            return n;
        
        if(arr[n]!=0)
            return arr[n];
        
        arr[n] = Fibo(n-1, arr) + Fibo(n-2, arr);
        
        return arr[n];
    }
}