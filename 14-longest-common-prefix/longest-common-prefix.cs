public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int i, j, templength=0, prefixLength=strs[0].Length;
        string name;
        char[] arr = new char[strs[0].Length];
        
        for(i=0;i<arr.Length;i++){
            arr[i]=strs[0][i];
        }

        for(i=1;i<strs.Length;i++){
            name = strs[i];
            if(name.Length<prefixLength){
                templength = name.Length;
            }else{
                templength = prefixLength;
            }

            for(j=0;j<templength;j++){
                if(arr[j]!=strs[i][j]){
                    break;
                }
            }

            prefixLength=j;
            if(prefixLength==0){
                return "";
            }
        }
        return new string(arr, 0, prefixLength);
    }
}