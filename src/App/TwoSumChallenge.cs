namespace App;

public class TwoSumChallenge
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sumNumbers = nums[i] + nums[j];

                if (IsTargetNumber(sumNumbers, target))
                {
                    int[] positions = new int[] { i, j };
                    return positions;
                }
            }
        }
        return new int [0];
    }

    private bool IsTargetNumber(int numberCount, int target)
    {
        if (numberCount == target)
        {
            return true;
        }
        return false;
    }

}
