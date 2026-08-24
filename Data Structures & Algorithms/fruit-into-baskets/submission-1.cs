public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        Dictionary<int, int> count = new();

        int left = 0;
        int res = 0;

        for (int right = 0; right < fruits.Length; right++)
        {
            if (count.ContainsKey(fruits[right]))
                count[fruits[right]]++;
            else
                count[fruits[right]] = 1;

            while (count.Count > 2)
            {
                count[fruits[left]]--;

                if (count[fruits[left]] == 0)
                    count.Remove(fruits[left]);

                left++;
            }

            res = Math.Max(res, right - left + 1);
        }

        return res;
    }
}