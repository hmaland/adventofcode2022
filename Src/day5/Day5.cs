namespace adventofcode2022
{
    public class Day5 : PuzzleBase
    {
        private Dictionary<string, Stack<string>>? _stacks;
        public Day5(string file) : base(file) { }
        public Day5(string[] lines) : base(lines) { }

        public string Part1()
        {
            _stacks = ParseStacks();
            foreach (var line in Lines)
            {
                var def = MoveDef.Parse(line);
                if (def == null) continue;
                for (var i = 0; i < def.Count; i++)
                    _stacks[def.To].Push(_stacks[def.From].Pop());
            }
            return PrintResult();
        }

        public string Part2()
        {
            _stacks = ParseStacks();
            foreach (var line in Lines)
            {
                var def = MoveDef.Parse(line);
                if (def == null) continue;
                var tempStack = new Stack<string>();
                for (var i = 0; i < def.Count; i++)
                    tempStack.Push(_stacks[def.From].Pop());
                for (var i = 0; i < def.Count; i++)
                    _stacks[def.To].Push(tempStack.Pop());
            }
            return PrintResult();
        }


        private Dictionary<string, Stack<string>> ParseStacks()
        {
            var stacks = new Dictionary<string, Stack<string>>();
            var numberOfStacks = (Lines[0].Length + 1) / 4;
            for (var i = 1; i <= numberOfStacks; i++)
                stacks.Add((i).ToString(), new Stack<string>());

            var headerLength = 0;
            foreach (var line in Lines)
            {
                if (string.IsNullOrEmpty(line))
                    break;
                headerLength++;
            }

            for (var i = headerLength - 2; i >= 0; i--)// (var line in Lines)
            {
                var line = Lines[i];
                for (var j = 1; j <= numberOfStacks; j++)
                {
                    var crate = line.Substring(1 + ((j - 1) * 4), 1);
                    if (string.IsNullOrWhiteSpace(crate))
                        continue;
                    stacks[j.ToString()].Push(crate);
                }
            }
            return stacks;
        }

        private string PrintResult()
        {
            var result = "";
            foreach (var k in _stacks.Keys)
                result += _stacks[k].Peek();
            return result;
        }
    }

    internal class MoveDef
    {
        public static MoveDef Parse(string line)
        {
            // E.g. "move 1 from 2 to 1"
            if (string.IsNullOrEmpty(line) || !line.StartsWith("move"))
                return null;

            var p = line.Split(' ');
            return new MoveDef
            {
                Count = int.Parse(p[1]),
                From = p[3],
                To = p[5]
            };
        }
        public int Count { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
