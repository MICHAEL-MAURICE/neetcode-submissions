public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set1= new HashSet<int>(nums1);
        set1.IntersectWith(nums2);
             
        return set1.ToArray();
    }
}