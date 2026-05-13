
public class Solution {
    public bool hasDuplicate(int[] nums) {
        // find min and max
        if(!nums.Any()) return false;
        int minValue = nums.Min();
        int maxValue = nums.Max();

        // size of counter list = range of numbers
        int size = maxValue - minValue + 1;
        var counterList = new List<int>(new int[size]); // filled with zeros

        foreach (var num in nums) {
            int index = num - minValue; // shift to be >= 0

            if (counterList[index] > 0)
                return true;
            else
                counterList[index] += 1;
        }

        return false;
    }
}
