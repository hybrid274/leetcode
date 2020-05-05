public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<string> st = new Stack<string>();
        foreach (var token in tokens)
        {
            if (token == "+")
            {
                var num2 = int.Parse(st.Pop());
                var num1 = int.Parse(st.Pop());
                st.Push($"{num1 + num2}");
            }
            else if (token == "-")
            {
                var num2 = int.Parse(st.Pop());
                var num1 = int.Parse(st.Pop());
                st.Push($"{num1 - num2}");
            }
            else if (token == "*")
            {
                var num2 = int.Parse(st.Pop());
                var num1 = int.Parse(st.Pop());
                st.Push($"{num1 * num2}");
            }
            else if (token == "/")
            {
                var num2 = int.Parse(st.Pop());
                var num1 = int.Parse(st.Pop());
                st.Push($"{num1 / num2}");
            }
            else
            {
                st.Push(token);
            }
        }
        return int.Parse(st.Pop());
    }
}
