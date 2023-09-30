namespace App;

public class _132Pattern
{
  public bool Find132pattern(int[] nums)
  {
    for (int i = 0; i < nums.Length; i++)
    {
      for (int j = i + 1; j < nums.Length; j++)
      {
        for (int k = j + 1; k < nums.Length; k++)
        {
          if (nums[i] < nums[k])
            if (nums[k] < nums[j])
              return true;
        }
      }
    }
    return false;
  }
}
