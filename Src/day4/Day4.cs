namespace adventofcode2022
{
    public class Day4: PuzzleBase
    {

        public Day4(string file) : base(file) { }
        public Day4(string[] lines) : base(lines) { }

        public int Part1()
        {
            var sum = 0;
            foreach (var line in Lines)
            {
                var a1 = ToList(line.Split(',')[0]);
                var a2 = ToList(line.Split(',')[1]);
                var intersect = a1.Intersect(a2);
                if (intersect.Count() == a1.Count || intersect.Count() == a2.Count)
                    sum++;
            }
            return sum;
        }

        public int Part2()
        {
            var sum = 0;
            foreach (var line in Lines)
            {
                var a1 = ToList(line.Split(',')[0]);
                var a2 = ToList(line.Split(',')[1]);
                var intersect = a1.Intersect(a2);
                if (intersect.Count()>0)
                    sum++;
            }
            return sum;
        }

        /// <summary>
        /// Returns list of integers given range formatted as "2-6"
        /// </summary>
        private List<int> ToList(string rangeString)
        {
            var range = rangeString.Split('-');
            var list = new List<int>();
            var start = int.Parse(range[0]);
            var end = int.Parse(range[1]);
            for (var i = start; i <= end; i++)
                list.Add(i);
            return list;
        }
    }
}
