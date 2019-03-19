public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int? max = null, scend = null, third = null;

        for (int i = 0; i < nums.Length; i++)
        {
            if (max == null)
            {
                max = nums[i];
            }
            else if (nums[i] > max)
            {
                if (scend == null)
                {
                    scend = max;
                }
                else
                {
                    third = scend;
                    scend = max;
                }

                max = nums[i];
            }
            else if (nums[i] != max)
            {
                if (scend == null)
                {
                    scend = nums[i];
                }
                else if (nums[i] > scend)
                {
                    third = scend;
                    scend = nums[i];
                }
                else if ((third == null || nums[i] > third) && nums[i] != scend)
                {
                    third = nums[i];
                }
            }
        }

        if (third == null)
        {
            return max.Value;
        }
        else
        {
            return third.Value;
        }
    }
}
