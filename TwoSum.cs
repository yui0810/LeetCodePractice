public class TwoSum {
    public int[] TwoSum(int[] nums, int target) {
        int[] ret = new int[2];
        for(int i=0; i<nums.Length; i++){
            for(int j=0; j<nums.Length; j++){
                if(i==j) continue;
                if(nums[i]+nums[j] == target){
                    ret[0] = i;
                    ret[1] = j;
                    return ret;
                }
            }
        }
        
        return ret;
    }
}
