public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int i, j, templength=0;
        string name;
        char[] arr = new char[strs[0].Length];
        
        for(i=0;i<arr.Length;i++){
            arr[i]=strs[0][i];
        }

        for(i=1;i<strs.Length;i++){
            name = strs[i];
            if(name.Length<arr.Length){
                templength = name.Length;
            }else{
                templength =arr.Length;
            }

            for(j=0;j<templength;j++){
                if(arr[j]!=strs[i][j]){
                    break;
                }
            }

            templength=j;
            if(templength<arr.Length){
                Array.Resize(ref arr, templength);
            }
        }
        return new string(arr);
    }
}