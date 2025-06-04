public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = (left + right) / 2;
        while (left < right)
        {
            if ( nums[mid] < target )
            {
                left = mid + 1;
            }
            else if (nums[mid] > target )
            {
                right = mid - 1;
            }
            else
                return mid;
            mid = ( left + right ) / 2;
        }
        if (nums[left] > target)
        {
            return left;
        }
        else if (nums[left] < target)
        {
            return left + 1;
        }
        return left;
    }
}
