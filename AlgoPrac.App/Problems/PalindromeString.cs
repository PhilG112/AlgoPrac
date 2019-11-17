namespace AlgoPrac.Problems
{
    public static class PalindromeString
    {
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
    }
}