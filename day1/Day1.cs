namespace adventofcode2022
{
    internal class Day1
    {
        public int Part1_Max()
        {
            var input = File.ReadAllLines(@"day1\input.txt");
            var max = 0;
            var sum = 0;
            foreach(var line in input)
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
            var input = File.ReadAllLines(@"day1\input.txt");
            var elfCalories = new List<int>();
            int sum = 0;
            foreach (var line in input)
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
            return elfCalories.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
