public class Solution {
    public bool IsValid(string s) {
        int i, top=-1;
        char[] stack = new char[s.Length];
        for(i=0;i<s.Length;i++){
            char ch=s[i];
            Console.Write(ch);
            if(ch=='(' || ch=='{' || ch=='['){
                top++;
                stack[top]=ch;
            }else{
                if(top==-1){
                    return false;
                }
                char last = stack[top];
                if((last=='(' && ch==')')|| last=='[' && ch==']'|| last=='{' && ch=='}'){
                    top--;
                }else{
                    return false;
                }
            }
        }
        if(top==-1){
            return true;
        }else{
            return false;
        }
    }
}