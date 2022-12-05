namespace adventofcode2022
{
    public class Day3 : PuzzleBase
    {
        public Day3(string file): base(file) { }
        public Day3(string[] lines) : base(lines) { }

        public int Part1()
        {
            var sum = 0;
            foreach (var line in Lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                var half = line.Length / 2;
                var p1 = line.Substring(0, half).ToCharArray();
                var p2 = line.Substring(half).ToCharArray();
                var c = p1.Where(x => p2.Contains(x)).First();
                sum += GetPriority(c);
            }
            return sum;
        }

        public int Part2()
        {
            var sum = 0;
            for (var i = 0; i < Lines.Length; i += 3)
            {
                var l1 = Lines[i].ToCharArray();
                var l2 = Lines[i + 1].ToCharArray();
                var l3 = Lines[i + 2].ToCharArray();
                var c = l1.Where(x => l2.Contains(x) && l3.Contains(x)).First();
                sum += GetPriority(c);
            }
            return sum;
        }

        private int GetPriority(char c)
        {
            if (c > 96)  // 'a'-'z' gives 1-26
                return c - 96;
            else         // 'A'-'Z' gives 27-52
                return c - 38;
        }
    }
}
