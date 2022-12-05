using System;

namespace Tests
{
    internal static class StringExtensions
    {
        public static string[] ToLines(this string input)
        {
            return input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }
}
