using App;
using FluentAssertions;

namespace UnitTests;

public class _132PatternTests
{
    private _132Pattern __132Pattern;

    public _132PatternTests()
    {
        __132Pattern = new _132Pattern();
    }

    [Theory]
    [InlineData(new int[]{1,2,3,4}, false)]
    [InlineData(new int[]{3,1,4,2}, true)]
    [InlineData(new int[]{-1,3,2,0}, true)]
    private void ShouldValidatePattern(int[] input, bool isPattern)
    {
        bool isPatternResult = __132Pattern.Find132pattern(input);
        isPatternResult.Should().Be(isPattern);
    }
}
