public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] arr = nums;
        int i, j;
        int maxlength = arr.Length;
        for (i = 0; i < maxlength; i++) {
            for (j = i + 1; j < maxlength; j++) {
                if (arr[i] + arr[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
}