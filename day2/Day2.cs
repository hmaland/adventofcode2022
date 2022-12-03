namespace adventofcode2022
{
    internal class Day2
    {
        enum Figure
        {
            Rock,
            Paper,
            Scissor
        }

        enum Outcome
        {
            Loss,
            Draw,
            Victory
        }
         
        public int Part1()
        {
            var input = File.ReadAllLines(@"day2\input.txt");
            var sum = 0;
            foreach(var line in input)
            {
                // A Y
                if (string.IsNullOrEmpty(line)) continue;

                var other = Map(line.Split(' ')[0]);
                var me = Map(line.Split(' ')[1]);

                sum += GetMatchPoint(other, me);
                sum += GetFigurePoint(me);
            }
            return sum;
        }

        public int Part2()
        {
            var input = File.ReadAllLines(@"day2\input.txt");
            var sum = 0;
            foreach (var line in input)
            {
                // A Y
                if (string.IsNullOrEmpty(line)) continue;

                var other = Map(line.Split(' ')[0]);
                var outcome = MapOutcome(line.Split(' ')[1]);
                var me = SelectFigure(other, outcome);
                sum += GetMatchPoint(other, me);
                sum += GetFigurePoint(me);
            }
            return sum;
        }

        private Figure SelectFigure(Figure other, Outcome outcome)
        {
            if (outcome == Outcome.Draw)
                return other;

            if(outcome == Outcome.Victory)
            {
                if (other == Figure.Rock)
                    return Figure.Paper;
                else if (other == Figure.Paper)
                    return Figure.Scissor;
                else
                    return Figure.Rock;
            }
            else // Loss
            {
                if (other == Figure.Rock)
                    return Figure.Scissor;
                else if (other == Figure.Paper)
                    return Figure.Rock;
                else
                    return Figure.Paper;
            }
        }

        private Outcome MapOutcome(string code)
        {
            if (code == "X")
                return Outcome.Loss;
            else if (code == "Y")
                return Outcome.Draw;
            else
                return Outcome.Victory;
        }

        private int GetMatchPoint(Figure other, Figure me)
        {
            if (other == me)
                return 3;
            if (me == Figure.Rock)
                return other == Figure.Paper ? 0 : 6;
            else if (me == Figure.Paper)
                return other == Figure.Scissor ? 0 : 6;
            else // Scissor
                return other == Figure.Rock ? 0 : 6;
        }

        private Figure Map(string letter)
        {
            switch (letter)
            {
                case "A":
                case "X":
                    return Figure.Rock;
                case "B":
                case "Y":
                    return Figure.Paper;
                default:
                    return Figure.Scissor;
            }
        }

        private int GetFigurePoint(Figure figure)
        {
            if (figure == Figure.Rock)
                return 1;
            else if (figure == Figure.Paper)
                return 2;
            else
                return 3;
        }
    }
}
