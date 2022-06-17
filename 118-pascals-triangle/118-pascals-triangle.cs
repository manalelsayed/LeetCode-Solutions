public class Solution {
    public IList<IList<int>> Generate(int numRows) {
       IList<IList<int>> res = new List<IList<int>>();
        
         res.Add(new List<int>(){1});
        for(int i=1;i<numRows;i++){
             res.Add(new List<int>());
             
                int term=1;
                res[i].Add(term);
           
            for(int a=1;a<i;a++){
             term = term*  1 * (i - a + 1)
                                / (a * 1);
 
            res[i].Add(term);
               
            }
           res[i].Add(1);
        }
        
    return res;
    }
}