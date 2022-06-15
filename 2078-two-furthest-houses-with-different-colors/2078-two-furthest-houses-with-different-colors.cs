public class Solution {
    public int MaxDistance(int[] colors) {
        int Furthest=0;
        //1 1 1 6 1 1 1 
        for(int i=0;i<colors.Length;i++){
            int tst1=0;
            int tst2=0;
            for(int a=0;a<i;a++){//1 1 1 6 -->
                if(colors[i]!=colors[a]){
                    tst1=Math.Abs(i-a);
                    break;}
            }
            
            for(int a=colors.Length-1;a<i;a--){//      6 1 1 1 <--
                 if(colors[i]!=colors[a]){
                    tst2=Math.Abs(i-a);
                    break;}
            }
            
            if(Math.Max(tst1,tst2)>Furthest) Furthest=Math.Max(tst1,tst2);
            
        }
        
        return Furthest;
        
    }
}