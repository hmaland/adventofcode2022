namespace adventofcode2022
{
    internal class Day3
    {
        
        public int Part1()
        {
            var sum = 0;
            foreach (var line in File.ReadAllLines(@"day3\input.txt"))
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
            var l = File.ReadAllLines(@"day3\input.txt");
            for (var i = 0; i < l.Length; i += 3)
            {
                var l1 = l[i].ToCharArray();
                var l2 = l[i + 1].ToCharArray();
                var l3 = l[i + 2].ToCharArray();
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
