public class Solution {
    public int RomanToInt(string s) {
        int i, temp=0, num1=0, num2=0;
        char number;
        char[] arr = new char[s.Length];
        for(i=0;i<s.Length;i++){
            number=s[i];
            if(number=='I'){
                num1=1;
            }else if(number=='V'){
                num1=5;
            }else if(number=='X'){
                num1=10;
            }else if(number=='L'){
                num1=50;
            }else if(number=='C'){
                num1=100;
            }else if(number=='D'){
                num1=500;
            }else if(number=='M'){
                num1=1000;
            }

            if(i+1<s.Length){
                if(s[i+1]=='I'){
                    num2 = 1;
                }else if(s[i+1]=='V'){
                    num2 = 5;
                }else if(s[i+1]=='X'){
                    num2 = 10;
                }else if(s[i+1]=='L'){
                    num2 = 50;
                }else if(s[i+1]=='C'){
                    num2 = 100;
                }else if(s[i+1]=='D'){
                    num2 = 500;
                }else if(s[i+1]=='M'){
                    num2 = 1000;
                }
            }

            if(num1<num2){
                temp-=num1;
            }else{
                temp+=num1;
            }
        }
        return temp;
    }
}