using App;
using FluentAssertions;

namespace UnitTests;

public class PalindromeNumberChallengeTests
{
    private PalindromeNumberChallenge _palindromeNumberChallenge;
    public PalindromeNumberChallengeTests()
    {
        _palindromeNumberChallenge = new PalindromeNumberChallenge();
    }

    [Theory]
    [InlineData(121,true)]
    [InlineData(-121,false)]
    [InlineData(10,false)]
    public void ShouldValidatePalindromeNumber(int palindrome, bool isPalindrome)
    {
        var isPalindromeResult = _palindromeNumberChallenge.IsPalindrome(palindrome);
        isPalindromeResult.Should().Be(isPalindrome);
    }

}
