public class Solution {
    public bool IsPalindrome(int x) {
        if ( x < 0 )
            return false;
        if ( x == 0 )
            return true;
        int newNumber = 0;
        int xCopy = x;
        while ( x > 0 )
        {
            newNumber *= 10;
            newNumber += (x % 10);
            x /= 10;
        }
        return newNumber == xCopy;
    }
}
