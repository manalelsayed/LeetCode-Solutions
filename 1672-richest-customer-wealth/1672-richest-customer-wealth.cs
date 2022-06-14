public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int richest=0;
        
            for(int i=0;i<accounts.Length;i++){
                int sum=accounts[i].Sum();
                if(sum>richest) richest=sum;
            
        }
        return richest;
        
    }
}