public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res=new int[2];
        for(int i=0;i<nums.Length-1;i++ ){
        for(int a=i+1;a<nums.Length;a++){
            if(nums[i]+nums[a]==target){
                res[0]=i;
                res[1]=a;
                return res;
            }
        }
            
        }
    return res;
    }
}