public class Solution {
    public int MaxDistance(int[] colors) {
        int Furthest=0;
        //1 1 1 6 1 1 1 
        for(int i=0;i<colors.Length;i++){
            int LeftSide=0;
            int RightSide=0;
            for(int a=0;a<i;a++){//1 1 1 6 -->
                if(colors[i]!=colors[a]){ //
                    LeftSide=Math.Abs(i-a);
                    break;}
            }
            
            for(int a=colors.Length-1;a<i;a--){//      6 1 1 1 <--
                 if(colors[i]!=colors[a]){
                    RightSide=Math.Abs(i-a);
                    break;}
            }
            
            if(Math.Max(LeftSide,RightSide)>Furthest) Furthest=Math.Max(LeftSide,RightSide);
            
        }
        
        return Furthest;
        
    }
}