using adventofcode2022;
using Xunit;

namespace Tests
{
    public class AdventOfCodeTests
    {
        [Fact]
        public void Day1_Part1()
        {

            // Arrange
            var input =
@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000".ToLines();
            var day1 = new Day1(input);

            // Act
            var result = day1.Part1_Max();

            // Assert
            Assert.Equal(24000, result);
        }

        [Fact]
        public void Day1_Part2()
        {

            // Arrange
            var input =
@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000".ToLines();
            var day1 = new Day1(input);

            // Act
            var result = day1.Part2_Top3();

            // Assert
            Assert.Equal(45000, result);
        }

        [Fact]
        public void Day2_Part1()
        {

            // Arrange
            var input = 
@"A Y
B X
C Z
".ToLines();
            var day2 = new Day2(input);

            // Act
            var result = day2.Part1();

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Day2_Part2()
        {

            // Arrange
            var input =
@"A Y
B X
C Z
".ToLines();
            var day2 = new Day2(input);

            // Act
            var result = day2.Part2();

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Day3_Part1()
        {

            // Arrange
            var input =
@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw".ToLines();
            var day3 = new Day3(input);

            // Act
            var result = day3.Part1();

            // Assert
            Assert.Equal(157, result);
        }

        [Fact]
        public void Day3_Part2()
        {

            // Arrange
            var input =
@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw".ToLines();
            var day3 = new Day3(input);

            // Act
            var result = day3.Part2();

            // Assert
            Assert.Equal(70, result);
        }

        [Fact]
        public void Day4_Part1()
        {

            // Arrange
            var input =
@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8".ToLines();
            var puzzle = new Day4(input);

            // Act
            var result = puzzle.Part1();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Day4_Part2()
        {

            // Arrange
            var input =
@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8".ToLines();
            var puzzle = new Day4(input);

            // Act
            var result = puzzle.Part2();

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Day5_Part1()
        {

            // Arrange
            var input =
@"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2".ToLines();
            var puzzle = new Day5(input);

            // Act
            var result = puzzle.Part1();

            // Assert
            Assert.Equal("CMZ", result);
        }

        [Fact]
        public void Day5_Part2()
        {

            // Arrange
            var input =
@"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2".ToLines();
            var puzzle = new Day5(input);

            // Act
            var result = puzzle.Part2();

            // Assert
            Assert.Equal("MCD", result);
        }

    }
}