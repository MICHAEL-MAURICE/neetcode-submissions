public class Solution
{
    public string MinWindow(string s, string t)
    {
        int[] count = new int[128];

        foreach (char c in t)
            count[c]++;

        int left = 0;
        int need = t.Length;

        int start = 0;
        int minLength = int.MaxValue;

        for (int right = 0; right < s.Length; right++)
        {
            if (count[s[right]] > 0)
                need--;

            count[s[right]]--;

            while (need == 0)
            {
                if (right - left + 1 < minLength)
                {
                    minLength = right - left + 1;
                    start = left;
                }

                count[s[left]]++;

                if (count[s[left]] > 0)
                    need++;

                left++;
            }
        }

        return minLength == int.MaxValue
            ? ""
            : s.Substring(start, minLength);
    }
}