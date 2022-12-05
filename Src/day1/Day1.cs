namespace adventofcode2022
{
    public class Day1 : PuzzleBase
    {
        public Day1(string file) : base(file) { }
        public Day1(string[] lines) : base(lines) { }

        public int Part1_Max()
        {
            var max = 0;
            var sum = 0;
            foreach(var line in Lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    max = Math.Max(max, sum);
                    sum = 0;
                }
                else
                {
                    sum += int.Parse(line);
                }
            }
            return max;
        }

        public int Part2_Top3()
        {
            var elfCalories = new List<int>();
            int sum = 0;
            foreach (var line in Lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    elfCalories.Add(sum);
                    sum = 0;
                }
                else
                {
                    sum += int.Parse(line);
                }
            }
            if (sum != 0)
                elfCalories.Add(sum);
            return elfCalories.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
