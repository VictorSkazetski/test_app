namespace test_app.task_4_problem_solving
{
    public class ProblemSolving
    {
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            string reversedString = "";
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            return reversedString;
        }

        public bool IsPalindrome(string str)
        {
            return this.ReverseString(str) == str;
        }

        public IEnumerable<int> MissingElements(int[] arr)
        {
            var missingElements = new List<List<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var range = Enumerable.Range(
                    arr[i],
                    (arr[i + 1] - arr[i]) - 1);
                missingElements.Add(range.Select(x => x + 1)
                    .ToList());
            }

            return missingElements.SelectMany(x => x)
                .ToArray();
        }
    }
}
