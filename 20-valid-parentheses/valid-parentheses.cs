public class Solution {
    public bool IsValid(string s) {
        int i;
        Stack<Char> stack = new Stack<Char>();
        for(i=0;i<s.Length;i++){
            char ch=s[i];
            Console.Write(ch);
            if(ch=='(' || ch=='{' || ch=='['){
                stack.Push(ch);
            }

            if(ch==')' || ch=='}' || ch==']'){
                if(stack.Count==0){
                    return false;
                }
                else{
                    char top = stack.Peek();
                    if ((top == '(' && ch == ')') ||
                        (top == '{' && ch == '}') ||
                        (top == '[' && ch == ']'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        if(stack.Count==0){
            return true;
        }else{
            return false;
        }
    }
}