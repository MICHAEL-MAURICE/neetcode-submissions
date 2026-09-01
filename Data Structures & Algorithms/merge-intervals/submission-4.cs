public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        Stack<(int num1, int num2)> st = new();

        foreach (var item in intervals)
        {
            if (st.Count == 0)
            {
                st.Push((item[0], item[1]));
                continue;
            }

            var (start, end) = st.Pop();

            if (item[0] <= end)
            {
                st.Push((start, Math.Max(end, item[1])));
            }
            else
            {
                st.Push((start, end));
                st.Push((item[0], item[1]));
            }
        }

        return st
                 .Select(x => new int[] { x.num1, x.num2 })
                 .ToArray();
    }
}