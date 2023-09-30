namespace App;

public class PalindromeNumberChallenge
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        string normal = x.ToString();

        string reverse = string.Empty;
        for (int i = normal.Length - 1; i >= 0; i--)
        {
            reverse = reverse + normal[i];
        }

        if (reverse == normal)
        {
            return true;
        }
        return false;
    }
}

