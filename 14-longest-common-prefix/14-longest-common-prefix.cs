public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length==1) return strs[0];
        string firstString=strs[0];
        List<char> perfix=new List<char>();
        for(int i=0;i<firstString.Length;i++){
            
             for(int a=1;a<strs.Length;a++){
                   
            if((strs[a].Length-1 <i)||(strs[a][i] != firstString[i]))
                return new string(perfix.ToArray());
        }
        perfix.Add(firstString[i]);      
        }
      
         return new string(perfix.ToArray());
        
    }
   
}