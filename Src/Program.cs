﻿// See https://aka.ms/new-console-template for more information

using adventofcode2022;

Console.WriteLine("hmaland's Advent of Code 2022 answers");

Console.WriteLine("Day 1: Calorie Counting - 1: " + new Day1(@"day1\input.txt").Part1_Max());
Console.WriteLine("Day 1: Calorie Counting - 2: " + new Day1(@"day1\input.txt").Part2_Top3());

Console.WriteLine("Day 2: Rock Paper Scissor - 1: " + new Day2(@"day2\input.txt").Part1());
Console.WriteLine("Day 2: Rock Paper Scissor - 2: " + new Day2(@"day2\input.txt").Part2());

Console.WriteLine("Day 3: Rucksack Reorganization - 1: " + new Day3(@"day3\input.txt").Part1());
Console.WriteLine("Day 3: Rucksack Reorganization - 2: " + new Day3(@"day3\input.txt").Part2());

Console.WriteLine("Day 4: Camp Cleanup - 1: " + new Day4(@"day4\input.txt").Part1());
Console.WriteLine("Day 4: Camp Cleanup - 2: " + new Day4(@"day4\input.txt").Part2());

Console.ReadLine();


