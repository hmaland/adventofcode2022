namespace adventofcode2022
{
    public class PuzzleBase
    {
        protected string[] Lines;
        public PuzzleBase(string[] lines)
        {
            Lines = lines;
        }
        public PuzzleBase(string filePath)
        {
            Lines = File.ReadAllLines(filePath);
        }
    }
}