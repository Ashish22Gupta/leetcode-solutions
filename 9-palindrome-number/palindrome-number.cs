public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) {
            return false;
        }

        int i, temp, j=0;
        for(i=x;i!=0;i/=10) {
            temp=i%10;
            j=j*10+temp;
        }

        if(x==j) {
            return true;
        }else{
            return false;
        }
    }
}