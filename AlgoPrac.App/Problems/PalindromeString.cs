namespace AlgoPrac.Problems
{
    public static class PalindromeString
    {
        // Average: O(n) time | O(n) space
        public static bool IsPalindrome(string str)
        {
            if (str.Length == 1) return true;

            var array = str.ToCharArray();
            var start = 0;
            var end = array.Length - 1;

            while (start <= end)
            {
                var tmp = array[start];
                array[start] = array[end];
                array[end] = tmp;
                start++;
                end--;
            }

            return new string(array) == str;
        }

        // Average: O(n) time | O(1) space
        public static bool IsPalindromeV2(string str)
        {
            var start = 0;
            var end = str.Length - 1;

            while (start < end)
            {
                if (str[start] != str[end]) return false;

                start++;
                end--;
            }

            return true;
        }

        // Average: O(n) time | O(n) space (could be O(1) space if compiler optimizes tail calls)
        public static bool IsPalindromeRecursive(string str, int i = 0)
        {
            var j = str.Length - 1 - i;

            if (i >= j) return true;

            return str[i] == str[j] && IsPalindromeRecursive(str, ++i);
        }
    }
}