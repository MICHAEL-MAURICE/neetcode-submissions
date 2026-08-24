public class Solution {
    public string DecodeString(string s) {
        Stack<int> numbers = new Stack<int>();
    Stack<string> strings = new Stack<string>();

    string current = "";
    int number = 0;

    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            number = number * 10 + (c - '0');
        }
        else if (c == '[')
        {
            numbers.Push(number);
            strings.Push(current);

            number = 0;
            current = "";
        }
        else if (c == ']')
        {
            int repeat = numbers.Pop();
            string previous = strings.Pop();

            string temp = "";

            for (int i = 0; i < repeat; i++)
            {
                temp += current;
            }

            current = previous + temp;
        }
        else
        {
            current += c;
        }
    }

    return current;
    }
}