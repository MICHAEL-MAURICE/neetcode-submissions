public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Handle null or empty strings
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return false;

        // Lengths must be equal
        if (s.Length != t.Length)
            return false;

        // Assuming only lowercase English letters a-z
        int[] counter = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;  // count char from s
            counter[t[i] - 'a']--;  // remove char from t
        }

        // All counts must be zero if it's an anagram
        for (int i = 0; i < 26; i++)
        {
            if (counter[i] != 0)
                return false;
        }

        return true;
    }
}
