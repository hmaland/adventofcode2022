namespace adventofcode2022
{
    public class Day6 : PuzzleBase
    {
        public Day6(string file) : base(file) { }
        public Day6(string[] lines) : base(lines) { }

        public int Part1(string input=null)
        {
            return FindPattern(input, 4);
        }

        public int Part2(string input = null)
        {
            return FindPattern(input, 14);
        }

        public int FindPattern(string input, int patternLength)
        {
            if (input == null) input = Lines[0];
            // E.g. mjqjpqmgbljsphdztnvjfqwrcgsmlb
            var i = 0;
            for (i = 0; i < input.Length - (patternLength-1); i++)
            {
                var chunk = input.Substring(i, patternLength).ToCharArray();
                var distinctCharacters = chunk.Distinct();
                if (distinctCharacters.Count() == patternLength)
                    break;
            }
            return i + patternLength;
        }

    }
}
