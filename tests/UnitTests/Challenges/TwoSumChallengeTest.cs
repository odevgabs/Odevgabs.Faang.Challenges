using App;
using FluentAssertions;

namespace UnitTests;

public class TwoSumChallengeTest
{
    private TwoSumChallenge _twoSumChallenge;
    public TwoSumChallengeTest()
    {
         _twoSumChallenge= new TwoSumChallenge();
    }

    [Theory]
    [InlineData(new int[]{2,7,11,15},9, new int[]{0,1})]
    [InlineData(new int[]{3,2,4},6, new int[]{1,2})]
    [InlineData(new int[]{3,3},6, new int[]{0,1})]
    public void ShouldSumTwoNumbers(int[] input, int target, int[] output)
    {
       int[] result = _twoSumChallenge.TwoSum(input, target);

       result[0].Should().Be(output[0]);
       result[1].Should().Be(output[1]);
    }
}
