public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
    char[] ransomNoteArr = ransomNote.ToArray();
  
        
    char[] magazineArr = magazine.ToArray();
       
        //ransome  magazine
        int count=0;
        
        foreach(char x in ransomNoteArr ){
            
            for(int i=0;i<magazineArr.Length;i++){
                if(x==magazineArr[i]){
                    magazineArr[i]='0';
                    count++;
                    break;
                }
            } 
            
        }
        return (count==ransomNoteArr.Length);
       
     
        
    
    }

    

}