﻿using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Advent2015Day4Part1();
        }

        static void Advent2015Day4Part1()
        {
            //282749 (correct answer)
            //000002c655df7738246e88f6c1c43eb7
            //282750
            bool match = false;

            string regex = "^[0]{5}.*";
            string input = "yzbqklnj";
            int number = 0;

            Console.WriteLine(input+number);

          
         
            
            while (!match)
            {
                number++;
                using (MD5 md5 = MD5.Create())
                {


                    byte[] inputBytes = Encoding.ASCII.GetBytes(input + number);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("x2"));
                    }

                    string hashedResult = sb.ToString();
                  
                    match = Regex.IsMatch(hashedResult, regex);
                    
                }
            }

            Console.WriteLine(number);
           

        }
        static void Advent2015Day3Part2()
        {
            //2360 Third Attempt (Correct Answer)
            //5215 Second Attempt
            //5443

            bool santa = true;
            string pattern = ">^^v^<>v<<<v<v^>>v^^^<v<>^^><^<<^vv>>>^<<^>><vv<<v^<^^><>>><>v<><>^^<^^^<><>>vv>vv>v<<^>v<>^>v<v^<>v>><>^v<<<<v^vv^><v>v^>>>vv>v^^^<^^<>>v<^^v<>^<vv^^<^><<>^>><^<>>><><vv><>v<<<><><>v><<>^^^^v>>^>^<v<<vv^^<v<^<^>^^v^^^^^v<><^v><<><^v^>v<<>^<>^^v^<>v<v^>v>^^<vv^v><^<>^v<><^><v^><><><<<<>^vv^>^vvvvv><><^<vv^v^v>v<<^<^^v^<>^<vv><v<v^v<<v<<^^>>^^^v^>v<><^vv<<^<>v<v><><v^^><v<>^^>^^>v^>^<<<<v><v<<>v><^v>^>><v^^<^>v<vvvv<>>>>>^v^^>v<v<^<vv>^>^vv^>vv^^v<<^<^^<>v>vv^v>><>>>v^>^>^^v<>^<v<<>^vv>v^<<v>v<<><v>^vvv<v<vvv^v<vv<v^^^>v><<^<>><v^^>^v^>>^v<^<><v<>>v^<>>v<>>v^^^><^>>vvvv>^v<^><<>>^<>^>vv><v<<>>^^>v^^^><^<<^^v>v<^<<>v>^^vvv^v^>v^<>^^<>v^v>v>v<v^>vv>^^v<>v>>^<>><>v>v^<<vvvv<vvv><v^<^>^v<>>^><v>><>^<v>v<v>vv^>>vvv<>v>v<v^>>^>>v<<>^<>^<>>>^v<<<^<^v>vv^>><<><v^>^v^^^v<>^^vv><>><>>^>v^<v<>v<>>^<<^v>^^^<>^v^><>v<<v>vv^>vv<<>>><<^v^<>v<vv>>>^^<>^><<^>vv>>^<<v^^vv<>>><v>v><^<v<<>>>^^<>>^<^v><>vv^^^v>vvv>^><<>^^>^<<v^<v<^v<<>vvv<^<<>^>^v<vv<^>vvv>v>vv^<v^><>>^vv<^^^vv><^vv<v^<><v^vvv><<^>^^><v<<vv^>v<vv<v>^<>^v<<>v<v^v^>^>^>v<<^vvv<<<v>^^>^<<<<>vv>>^<>^>>>v<v>^^<v^<v<>>>vv>^^v<<>>>^^v><<<v<v<^v<>^^><v<^v<<v^><><^<><v<^^v>>><v^^v<<v^><^<><<v^>><^<>v>v^<><^<v>^v^>^>^vv^>^^<<vv^>vv<^vvv<>>^^<^>v^>^>^<v^><v<v>>>v<<<><^v<<><^<vv^v^^^>v<^^<v^vvv<v<><v<vv<^vv<>vv<v^<>>vvvvv<<>^v^v>vv>>>vvv^^<^<^<><>v<v>><^v><^<<<>><<<v>^>v<>^>^v>>^<>v^<^>><<>^<v>^>^^^>^^<v>>>><>^v^v><<<<vv^<vv<>vv>v<>v^<v^>v><>>>v^<><^vvv>vv^<^<<^<^^v>^>>>v<^<^v^^<^<^>>><v>vv>^<<><>^>>v>^<<>><^<>v<>vv^^>^>vvv^v<<^<^^<vv<>^vvv<^^v^vv^>>v<^>^^<v^<>v<^<^vv>v<<vv>vv>^>vvv>>>^^>v<>^v>v^<^>>v>^^v>>>>v^<v>v<^>v<v<<>>^v<^^<v><^<>>^<<vv^>>v<<v>^v<>><^>vv<v<^>>^^<vvvvvvvvv>>>v<v<>v^<>>^vv<v^^v<<^vvv^<<^><>vv<><<>>v>vv^><>>^^v^>>v^v^><<<>>^^<^v<<^<>>>>^<^>v^><<^>v<^v<^>>^^<<<<><^<^v^v<>>^v<^<<vv^<><^^vv><v^v^v>^>>^>^vv^>^v<v^v<<vvv^><>>^v^^><>v>vv><^>>vv<vvv<<<<^<>vvv^v<v>^<v<^>^<^<v<><>v^^^^<<vv<^^vv<v>><<v^><>>><v^>^v><^>^><vv^<><^<v>><<^vv<>>v^<<v<>v><v<><><vv>^>>v^<^<v>^><>>><^><v^v<>>>^^<^>v<v>vvv<>^<<><v^^>^>>v<^v>^>v>>>vv>v>>v^^^<^<vvv^<>^>^<v^<v^v>v>^>vv>vvv<>v<^>v>^^>>^<vv^^v>v^^^^^v^vv><^<><>^>vv<^>>^vvvv^^^>^<vv>^v<<^><^^>^<>^^>^<<v<^>>>^><<^^>v^v>>^>vvvv>^^v><v>>vv><<<vv<^>v>^^^<v>v^vvv<^><<^>^<>^><<<<<v^<<vv^v>^<>v<v>^>^>><>v^v<^vv^^>vv<<v^v>vv^vvv<<<<>^v<v^^v^v>v<<v>^^<>^vv^^>^>^v^vv^>>v^vv^^<vv><<v^v^^v><vv<^vvv<vv^^<<v>v^v^^^^v<^<^>v>^>v>^vv^v^^<v<^vvvv<<<>^<^^^<^^<>^<><vv<^^<<^>>><v^vvvv>^<>>^^>v^^v^<<v^^^<<<><^<v^v^^v<v^<>v><<v<>^v>v<^><^>vv^^<vvv<^v>>v>^<><v^><^^^<v^>>vv<<<<<^<>^v^v>^vv^<>v>v<^>vv<<^vv>vv<v<><>>v>><v<^<^^>><<v^v<<^><v<^<vv<v<<vv^>^<<><^^>^<^>>^<vv>><v<<vvv<^^v^>^^<^v>^v<v<>v><v^v^<<^<><<v<<^v>v<<>>^>v>>v>>v<^<<^<^>>>v>^^^v><^>^^>>v<<>^v><v>vvv^vv<<<>vvv<<>^>>>v<v<v^<^<^>^<^>v^^v<^^<v<>v<>>^^>^v^>v<<<<^<>v^><<<v>>>><<v^<^vv>v>><>>^<<<^<^^>v<>>v<>vv<<^<<><<^>v^^^vv^>vvvv>>v>v^><<v<>vv^<<><<vvv>^>>>^<<<^<^<<v>^>v<>>v>>vv^^><<<<^^^v>><<^><v><v^^><v<<v^^v^^v>>v<><><<>^><v><^<vv>><^v<>v<vvv<>^>><v>>v<^><<v>^<>^v><^><^^<v>^><^^v^<<><>>^>v^<^v^vv<><^>vv^>v^vvv^<>>^><^<^<>^<<v^v<^v><>^v<v>>^>>^v^vv>><vv><v^^<<^v^<>^v<<>^><^>><v>>v<<<v^^vv<>^^v>>><><><<v^<<<v^<^^><v^>v^^vv<v^<>>vv^<^v<>^v>>v^v>v<^^vv><>^v<<>v^<>v^>>v>vvv<^><><^^>^vv^>>v^>^<^^<><>><<>^^^><^v^v><<<><<^v^vv>v>><^>>><v^>v<v><><v^v<>v^^>>v<<>v>v<v<v<^^<><>v^^<>>v<^v<v>v<><v<v>^<<>v>vv^^<>>^^^<>^^>^v>v>>>^v^v><v^^<><v>^^v^v<^<^^><<v<^<^<>^<>><<>^>>^>^^><v><>v<><>><<<>>>>vv>>>^>>^v<^>v^^^v<<vv>><<<^<<<>>>>>^>vv<^v^<>^<v^>^v><v>vvv<>>>^v^^^v<<<<>>^^<vv<^<^^>^<>v<^<<<>><>>v<^<>^<vvv<^<>><><<v>^^^>^^<<v<v^>^^v^>><<^vv><v>^v>>^<v>v>^^>^v>^vvv<>v^v^^<><vv>vv^>>><>v<^><v<v^<><<<>^v>^v<<<^>^>^>v^v<<><vvv<<v^^<><v>^>>><vv>><v>>v^<vv>>vv<<^v^v<<><^v<vv>>>vv<>>>>^vv>v^<>vv>v^v<v^><v<^^^^^>vv<><<vvv^<v><^<vv><^^^vv^<>^^^^<^><^<>v^<v^v<<^v<<^^<>>^<v^^>>>vv<vvv<>v<<>><^vvv^<<^^<<>>>^<>>>v^^><>><<>><v^v>>>>>><>>><v^<<vvv^>v<>>v^<>vv<><^^^^v^<<^<v^vv><<^^>v<^vvv^v>>v>^>>v>^^><<v^<>v<>vv<^v^vv><v><<vv^v>>v^>>v<^^^>^><<v<>^><>v>>>vvv<v<vv<^>>^v<v>^<^^^^^v><>v><>v^v^v<v^vv^v>vvvv<>vv<<<vv<v<<>^<^>^^v^<<>^<v><^><v<v<><<>v^<<^<><vv>v<<^v>>^v<><v>^>>^^><>v^<^<vvv^>^>^<<<<>vv>^v^v<^^^<vv>><>^^<<v<^<^^>>>v^v<<^^^<v<v<^<>^v<v><v^vv^^v^^v^^<vv<>^<><vv^<^v^<<^><<vvv>^^<^^^<^v>^>^vv><<<^v<v>vv>v<>v^v<v^>v^>>>v^v<>^v<<>^vv>v>v>v^<^>v^^<^>^^^^vv>^^><^>vv^>>^^v>><<<<^><>v<>^<v<vv^>^^><<^><v>v^>^^<^>>><>><v^v<v^<v<vv^v^<<^<vvv>>><vv<^^>>^>^><<v^<>>v>v^v^^><<>vv^v>v^<v><^<>^^<^>v>^<><<<v>^<^<^>^>^>^^v^<<^^v^^<^<>><^>v>>^^<>^^^<<<<v^>^v<^vv>^<<<v<><<v<>vv>>>v><>>><>>v<<<vv><>^v>v<^>><^><><v<>^v^>^v>^v<<><<^<>>v>^><>^>><>><^<v^><v^^<><v><^^>^v^^<>v^<v^<^v<v^^^^^v^<<^>^^^<^v><>^^<<<><<<<<^^>v^vvvv>v<>>vv<^>^v^>v<^vv^v<<><<v>v^v>^^><><^<v^>v><vv><>>><<>^vv<>v>>v<^v>>>v<v>v>v>^vv<<>^^vv<v<^v^<v<v>vv<>^<^<vv<v^<^v^^><<>^>><^v>vv^^v<<^^><<>v^^<><><v^^<v^v>^>^>^>v<^<v>^v^^>v<>vvv<^v<v^v><<v^><<^^><^<<v^v^>v<>^>v><><v>^<v<v>^<^^^>^v<<><<><>vv>v^<>v^><v^v<v><><<v>v<vv><<v>>v>^<<<>vv>>vvv>^^vv^v^^<^^<>v^^<>v>>^^>^>^>v>><^>><>>^<<>><^>v<<<<<<<^v^v<v^<v^^>^<><<v<^>v^>v^vv<<^^vv^>>>>^<>v<^v<>v<vv<^>>v^vv>vv><vv<<^>v>><vv>>>vv^<<<<vv^>v<<<<^^>^^v^><<^<v^>v^>^^<v<>vvv^>^<>vvv<v<^^>v^<<v>><>v<v<>^^<vvv>^>vv><><<<^^vv<v^<v<>v<>><<v><^vv^>^<^>^^^<<<v>vv^<^<<>^>^<vv>v><v<<^><^>^^<vv^v^^>>>>vv^><^^vv><>^<v^v>v<vv>v><<<v>v<v>^><v^^><v>v<^v^>>^^<v^>^^>vv>>vv^><^vv^vv<<^>vv>^v<v><vv><v<vvvvv>^^v^v><v>>>^vv<>v>^^^^<^>><>^v^^^>v<^^<<^^v<vv<>vvv<^>><><^>>^><^<>v<v<<><<v><v^v<>><^>v><<v^<v>v<^<vv^v^v^>vvv^^>v>^<vv^>v^v^<>v>^>>vv>><^^<v<<>^vv<><><<^v<v>v<<vv><>><^v<v>>v^>vvv^v^<<^><v<>^vv^>v^<v<^>>v<v><v><v>>^<<<v^<><<>v>^>^^<v<>>^<>^>^><<<^<<^<<^>^v>>><vvv>><<<<v>>>>>>>^<^v<^>v<>vv<><>v>>^>>^>vv^^><<^<v<v>>^^<<^>v<^>>vv>^<>v><^>v<vv>>>>>>^v<^<<<v^><vv<<>>vv<<><v<><<<v<^<v<>>v<^^^^v^^<^^^<^<vv><<^>><>v<<>v<v<>>>><>v^vv>^>^>>vv^v<v<<><^v>vv^><v<<>v^v<^>vv<<^^v><^>>^^vv<^<>>v^^>><v>^v>>>^>>v>v<>v<^vv><>^<<^>vv>>><><>v^><>v^>v>v><^v<><v<v>^v<<^vv^><^^>><^^^<<<^>v>^v>>><^>><^>>>^^^<^>vv<><<<v^>^<^^>>^^^v^v^v>v<v>>>><^>>>v>^vv<<^^^<^^vv>v<<><v<<^^>v>><<v^^><^>^<^>^v^>v><^<^vv>v>><>^<<vv<<v>v<vv<v>^>^>><^^<v>^v^v<><<>vvv<^<v>^><>^>vvv>>>^><<>><v^^<^<<^v>>^v<v<vv>vv^v^>v<<vvv<^^v^v>^<^>>^>v<^>^v<<><<<^>^<^^^>vv<^^^^vv<v<^^v<<<<v<^v^<><v<<^><<>vv>>><^<^<>>>^>^>>^<<<<<^^v>^>^<>vvv^^<^><^>^^v>^vv^><v^<^<<v^<vvv<<^v<><^><^>>>v>^v>^>^v<vv^v>><v><^><v^^>v^>^<><<><>v<v^>vvv^>^>>v<>^><^>^><vvv>^^v^v>v<>^v^><^>>v>v^><<<^>>^<>^<>>v><>>v^>^>^^<>>v^>^<vvvv<^vvvv^>>vv^<v^v>^vv<>v<>^<v<v>v>^^><^>vv^<^v^<<^<^<><vv<^v<^v><>>>^v^<<^><^>vv<v>v<^>vv^>v<<<>^<><v<^^^>v><^^<>^<^<v^vv^<<^>><<v^v<^vvv<<<>>vvvv^v^^^>v<>>><<>vvv<<^^^>v>v>>v<<v<v^v^>^^v>^><^<><<v^<v<v^^^><>v^^^<v>vv<>^>^^vv>^<<^v<^v><v>>>^>>><^<<>^v>>^>vv<<<v<>^<v><v^<^<>v>v^^v^>><<^v<<<<>v>v>v^^<^><>^^<<<v>vv<>>>^>>v<><v^>^<><vv>v>v^v<v^<^>>^>><<^^<^^v<vv<>><<<v<^<<^^^>vvv^<vvv<^>vv><>><<<^<v^v^^<<^vvv^^<^<><<>^<^<>>vvv<>^<>v^v<><>>v^v><<>>>vvv>v<>^>>^><^>vv<<>>v<<^><>v>>^^<v>^>^<<>><^<<vv<^<vv^vv><>>>><^<v>^>vv<v><>^<>vvvvv^vv<<v<>>>^<<><>^^vvv>>>vv<<^^><^v^^v<>^^>^><^>v^^^^v<^<<vv<vv<>vv^^>v^vv>v><>>vv>^<^<v^v^>>v^v^^v>^>vv^>v<vvvv<^v<^v>^v>^^v<<^>^^<<>^><^v>>>vv^>^^>vvvv>>v<^<v>^>>>v^<><^<^^<v>vv^^><v>v^<>^^^>>><^^v>v>^<<>^<v^>vvv^>^^^><v<^>>v<v>>^v><<><<>v<^<<>^><>^>vv>^<v>^^v<<^v^vvv^^>^vv^<^>^>^^v>v^>^<<><<^>v>>vv^vv><v>>^<<^<v^^<^<v^^vv^><^^<^^><v^^>v^^^<^<>^<>>^v<^vvv^^v^<><^>>>>>v><><<<>vv<^v>><<>vvv<><<vv<<<^>v^^>>^>^v>><><^^v<>><>>v^>^<vv><<<>><><<v>^^<>>v<><^<vv>vv<^v>^<<<<v<^<<^^>>^<><^>><<>^>v>^^^v>>^<^^v><v^v>^><<><>>^>>^<<v<>^v<>^>^<v>>vv>^vvv<<v<<^>^>^<<^^<>^^^^vvv<>^vv<vvvvv^^>^^<^>>><>v^<><^<<^>v^^v<>>^vv<>v^^<>>v^vvvvv<<v^<v^^>>><vvvvv>><^>vv>v^v^<v<^>^^><^>^^^^v<><^v<<>v^>v>>vv<<>^<v^^>vvv>^^<v^<>vv^><>><v^^v<>^>>^>v><>>^^v>^>^>>>^>v<^v>v>^<^^^^^>>v<v<>>v<<^>^<v<<>^^>><<^><>v<>^^^vv<>^^>><<^^>v>vv>vv>v^>^v>v^^<>>><<v><v<<>>v><>vvv^^v>^^>^vvvv^>^<>^vvvv><v><v<>>><>^<^vv<>^v<^v<>^vvv<<>><vvv^>>^><<vv^<v^>^<v<<^^>^^<^^v^>v<>v^v><>><v^^>>^vvv><^vv>v^<^<^v>>v^^>^vvv^<v^^v^^>v<^<>>^<>>>^^<><^^vv<>^vv^<>>>>^^<<^^<>vv^^><>^^<v<<v>^<v^^>^v<><><>vvv>^v^>>vv<<^v<<>><v>^><^>>>^<^<^^>vv^<<^<>>^^><><<v>^^<v>>v<<vvvv>^v^vv>><^^<<^>>v>v<^^^<^><^^vv>^vv<^<vv<>v><^<><v><^^^>>^<><^<v>>>>v^<v>>>>>v<><^^>v<^<^>><v<>^>vv>^^v^v^<<v<><<<^v^><<^<><<<<v<^>><<<>v>>vv><vv<><<^<^<><vv>^^^^<>v<<<<v>vv<>vv^^^>><>vv^><>>^vv<<><^^vv<>v^>>^<<>^<v^<^>v<";
            int[,] grid = new int[5000, 5000];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = 1;
                }
            }
            int roboSantasPosRow = 2500;
            int roboSantasPosCol = 2500;

            int santasPosRow = 2500;
            int santasPosCol = 2500;

            int uniqueHouses = 1;

            grid[santasPosRow, roboSantasPosCol] = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '^')
                {
                    if (santa)
                    {
                        santasPosRow = santasPosRow - 1;
                        if (grid[santasPosRow, santasPosCol] == 1)
                        {
                            grid[santasPosRow, santasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = false;
                    }
                    else if (!santa) 
                    {
                        roboSantasPosRow = roboSantasPosRow - 1;
                        if (grid[roboSantasPosRow, roboSantasPosCol] == 1)
                        {
                            grid[roboSantasPosRow, roboSantasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = true;
                    }
                }
                else if (pattern[i] == '>')
                {
                    if (santa)
                    {
                        santasPosCol = santasPosCol + 1;
                        if (grid[santasPosRow, santasPosCol] == 1)
                        {
                            grid[santasPosRow, santasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = false;
                    }
                    else if (!santa)
                    {
                        roboSantasPosCol = roboSantasPosCol + 1;
                        if (grid[roboSantasPosRow, roboSantasPosCol] == 1)
                        {
                            grid[roboSantasPosRow, roboSantasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = true;
                    }
                }
                else if (pattern[i] == 'v')
                {
                    if (santa)
                    {
                        santasPosRow = santasPosRow + 1;
                        if (grid[santasPosRow, santasPosCol] == 1)
                        {
                            grid[santasPosRow, santasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = false;
                    }
                    else if (!santa)
                    {
                        roboSantasPosRow = roboSantasPosRow + 1;
                        if (grid[roboSantasPosRow, roboSantasPosCol] == 1)
                        {
                            grid[roboSantasPosRow, roboSantasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = true;
                    }
                }
                else if (pattern[i] == '<')
                {
                    if (santa)
                    {
                        santasPosCol = santasPosCol - 1;
                        if (grid[santasPosRow, santasPosCol] == 1)
                        {
                            grid[santasPosRow, santasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = false;
                    }
                    else if (!santa)
                    {
                        roboSantasPosCol = roboSantasPosCol - 1;
                        if (grid[roboSantasPosRow, roboSantasPosCol] == 1)
                        {
                            grid[roboSantasPosRow, roboSantasPosCol] = 0;
                            uniqueHouses += 1;
                        }
                        santa = true;
                    }
                }
            }

            Console.WriteLine(uniqueHouses);
        }
        static void Advent2015Day3Part1()
        {

            string pattern = ">^^v^<>v<<<v<v^>>v^^^<v<>^^><^<<^vv>>>^<<^>><vv<<v^<^^><>>><>v<><>^^<^^^<><>>vv>vv>v<<^>v<>^>v<v^<>v>><>^v<<<<v^vv^><v>v^>>>vv>v^^^<^^<>>v<^^v<>^<vv^^<^><<>^>><^<>>><><vv><>v<<<><><>v><<>^^^^v>>^>^<v<<vv^^<v<^<^>^^v^^^^^v<><^v><<><^v^>v<<>^<>^^v^<>v<v^>v>^^<vv^v><^<>^v<><^><v^><><><<<<>^vv^>^vvvvv><><^<vv^v^v>v<<^<^^v^<>^<vv><v<v^v<<v<<^^>>^^^v^>v<><^vv<<^<>v<v><><v^^><v<>^^>^^>v^>^<<<<v><v<<>v><^v>^>><v^^<^>v<vvvv<>>>>>^v^^>v<v<^<vv>^>^vv^>vv^^v<<^<^^<>v>vv^v>><>>>v^>^>^^v<>^<v<<>^vv>v^<<v>v<<><v>^vvv<v<vvv^v<vv<v^^^>v><<^<>><v^^>^v^>>^v<^<><v<>>v^<>>v<>>v^^^><^>>vvvv>^v<^><<>>^<>^>vv><v<<>>^^>v^^^><^<<^^v>v<^<<>v>^^vvv^v^>v^<>^^<>v^v>v>v<v^>vv>^^v<>v>>^<>><>v>v^<<vvvv<vvv><v^<^>^v<>>^><v>><>^<v>v<v>vv^>>vvv<>v>v<v^>>^>>v<<>^<>^<>>>^v<<<^<^v>vv^>><<><v^>^v^^^v<>^^vv><>><>>^>v^<v<>v<>>^<<^v>^^^<>^v^><>v<<v>vv^>vv<<>>><<^v^<>v<vv>>>^^<>^><<^>vv>>^<<v^^vv<>>><v>v><^<v<<>>>^^<>>^<^v><>vv^^^v>vvv>^><<>^^>^<<v^<v<^v<<>vvv<^<<>^>^v<vv<^>vvv>v>vv^<v^><>>^vv<^^^vv><^vv<v^<><v^vvv><<^>^^><v<<vv^>v<vv<v>^<>^v<<>v<v^v^>^>^>v<<^vvv<<<v>^^>^<<<<>vv>>^<>^>>>v<v>^^<v^<v<>>>vv>^^v<<>>>^^v><<<v<v<^v<>^^><v<^v<<v^><><^<><v<^^v>>><v^^v<<v^><^<><<v^>><^<>v>v^<><^<v>^v^>^>^vv^>^^<<vv^>vv<^vvv<>>^^<^>v^>^>^<v^><v<v>>>v<<<><^v<<><^<vv^v^^^>v<^^<v^vvv<v<><v<vv<^vv<>vv<v^<>>vvvvv<<>^v^v>vv>>>vvv^^<^<^<><>v<v>><^v><^<<<>><<<v>^>v<>^>^v>>^<>v^<^>><<>^<v>^>^^^>^^<v>>>><>^v^v><<<<vv^<vv<>vv>v<>v^<v^>v><>>>v^<><^vvv>vv^<^<<^<^^v>^>>>v<^<^v^^<^<^>>><v>vv>^<<><>^>>v>^<<>><^<>v<>vv^^>^>vvv^v<<^<^^<vv<>^vvv<^^v^vv^>>v<^>^^<v^<>v<^<^vv>v<<vv>vv>^>vvv>>>^^>v<>^v>v^<^>>v>^^v>>>>v^<v>v<^>v<v<<>>^v<^^<v><^<>>^<<vv^>>v<<v>^v<>><^>vv<v<^>>^^<vvvvvvvvv>>>v<v<>v^<>>^vv<v^^v<<^vvv^<<^><>vv<><<>>v>vv^><>>^^v^>>v^v^><<<>>^^<^v<<^<>>>>^<^>v^><<^>v<^v<^>>^^<<<<><^<^v^v<>>^v<^<<vv^<><^^vv><v^v^v>^>>^>^vv^>^v<v^v<<vvv^><>>^v^^><>v>vv><^>>vv<vvv<<<<^<>vvv^v<v>^<v<^>^<^<v<><>v^^^^<<vv<^^vv<v>><<v^><>>><v^>^v><^>^><vv^<><^<v>><<^vv<>>v^<<v<>v><v<><><vv>^>>v^<^<v>^><>>><^><v^v<>>>^^<^>v<v>vvv<>^<<><v^^>^>>v<^v>^>v>>>vv>v>>v^^^<^<vvv^<>^>^<v^<v^v>v>^>vv>vvv<>v<^>v>^^>>^<vv^^v>v^^^^^v^vv><^<><>^>vv<^>>^vvvv^^^>^<vv>^v<<^><^^>^<>^^>^<<v<^>>>^><<^^>v^v>>^>vvvv>^^v><v>>vv><<<vv<^>v>^^^<v>v^vvv<^><<^>^<>^><<<<<v^<<vv^v>^<>v<v>^>^>><>v^v<^vv^^>vv<<v^v>vv^vvv<<<<>^v<v^^v^v>v<<v>^^<>^vv^^>^>^v^vv^>>v^vv^^<vv><<v^v^^v><vv<^vvv<vv^^<<v>v^v^^^^v<^<^>v>^>v>^vv^v^^<v<^vvvv<<<>^<^^^<^^<>^<><vv<^^<<^>>><v^vvvv>^<>>^^>v^^v^<<v^^^<<<><^<v^v^^v<v^<>v><<v<>^v>v<^><^>vv^^<vvv<^v>>v>^<><v^><^^^<v^>>vv<<<<<^<>^v^v>^vv^<>v>v<^>vv<<^vv>vv<v<><>>v>><v<^<^^>><<v^v<<^><v<^<vv<v<<vv^>^<<><^^>^<^>>^<vv>><v<<vvv<^^v^>^^<^v>^v<v<>v><v^v^<<^<><<v<<^v>v<<>>^>v>>v>>v<^<<^<^>>>v>^^^v><^>^^>>v<<>^v><v>vvv^vv<<<>vvv<<>^>>>v<v<v^<^<^>^<^>v^^v<^^<v<>v<>>^^>^v^>v<<<<^<>v^><<<v>>>><<v^<^vv>v>><>>^<<<^<^^>v<>>v<>vv<<^<<><<^>v^^^vv^>vvvv>>v>v^><<v<>vv^<<><<vvv>^>>>^<<<^<^<<v>^>v<>>v>>vv^^><<<<^^^v>><<^><v><v^^><v<<v^^v^^v>>v<><><<>^><v><^<vv>><^v<>v<vvv<>^>><v>>v<^><<v>^<>^v><^><^^<v>^><^^v^<<><>>^>v^<^v^vv<><^>vv^>v^vvv^<>>^><^<^<>^<<v^v<^v><>^v<v>>^>>^v^vv>><vv><v^^<<^v^<>^v<<>^><^>><v>>v<<<v^^vv<>^^v>>><><><<v^<<<v^<^^><v^>v^^vv<v^<>>vv^<^v<>^v>>v^v>v<^^vv><>^v<<>v^<>v^>>v>vvv<^><><^^>^vv^>>v^>^<^^<><>><<>^^^><^v^v><<<><<^v^vv>v>><^>>><v^>v<v><><v^v<>v^^>>v<<>v>v<v<v<^^<><>v^^<>>v<^v<v>v<><v<v>^<<>v>vv^^<>>^^^<>^^>^v>v>>>^v^v><v^^<><v>^^v^v<^<^^><<v<^<^<>^<>><<>^>>^>^^><v><>v<><>><<<>>>>vv>>>^>>^v<^>v^^^v<<vv>><<<^<<<>>>>>^>vv<^v^<>^<v^>^v><v>vvv<>>>^v^^^v<<<<>>^^<vv<^<^^>^<>v<^<<<>><>>v<^<>^<vvv<^<>><><<v>^^^>^^<<v<v^>^^v^>><<^vv><v>^v>>^<v>v>^^>^v>^vvv<>v^v^^<><vv>vv^>>><>v<^><v<v^<><<<>^v>^v<<<^>^>^>v^v<<><vvv<<v^^<><v>^>>><vv>><v>>v^<vv>>vv<<^v^v<<><^v<vv>>>vv<>>>>^vv>v^<>vv>v^v<v^><v<^^^^^>vv<><<vvv^<v><^<vv><^^^vv^<>^^^^<^><^<>v^<v^v<<^v<<^^<>>^<v^^>>>vv<vvv<>v<<>><^vvv^<<^^<<>>>^<>>>v^^><>><<>><v^v>>>>>><>>><v^<<vvv^>v<>>v^<>vv<><^^^^v^<<^<v^vv><<^^>v<^vvv^v>>v>^>>v>^^><<v^<>v<>vv<^v^vv><v><<vv^v>>v^>>v<^^^>^><<v<>^><>v>>>vvv<v<vv<^>>^v<v>^<^^^^^v><>v><>v^v^v<v^vv^v>vvvv<>vv<<<vv<v<<>^<^>^^v^<<>^<v><^><v<v<><<>v^<<^<><vv>v<<^v>>^v<><v>^>>^^><>v^<^<vvv^>^>^<<<<>vv>^v^v<^^^<vv>><>^^<<v<^<^^>>>v^v<<^^^<v<v<^<>^v<v><v^vv^^v^^v^^<vv<>^<><vv^<^v^<<^><<vvv>^^<^^^<^v>^>^vv><<<^v<v>vv>v<>v^v<v^>v^>>>v^v<>^v<<>^vv>v>v>v^<^>v^^<^>^^^^vv>^^><^>vv^>>^^v>><<<<^><>v<>^<v<vv^>^^><<^><v>v^>^^<^>>><>><v^v<v^<v<vv^v^<<^<vvv>>><vv<^^>>^>^><<v^<>>v>v^v^^><<>vv^v>v^<v><^<>^^<^>v>^<><<<v>^<^<^>^>^>^^v^<<^^v^^<^<>><^>v>>^^<>^^^<<<<v^>^v<^vv>^<<<v<><<v<>vv>>>v><>>><>>v<<<vv><>^v>v<^>><^><><v<>^v^>^v>^v<<><<^<>>v>^><>^>><>><^<v^><v^^<><v><^^>^v^^<>v^<v^<^v<v^^^^^v^<<^>^^^<^v><>^^<<<><<<<<^^>v^vvvv>v<>>vv<^>^v^>v<^vv^v<<><<v>v^v>^^><><^<v^>v><vv><>>><<>^vv<>v>>v<^v>>>v<v>v>v>^vv<<>^^vv<v<^v^<v<v>vv<>^<^<vv<v^<^v^^><<>^>><^v>vv^^v<<^^><<>v^^<><><v^^<v^v>^>^>^>v<^<v>^v^^>v<>vvv<^v<v^v><<v^><<^^><^<<v^v^>v<>^>v><><v>^<v<v>^<^^^>^v<<><<><>vv>v^<>v^><v^v<v><><<v>v<vv><<v>>v>^<<<>vv>>vvv>^^vv^v^^<^^<>v^^<>v>>^^>^>^>v>><^>><>>^<<>><^>v<<<<<<<^v^v<v^<v^^>^<><<v<^>v^>v^vv<<^^vv^>>>>^<>v<^v<>v<vv<^>>v^vv>vv><vv<<^>v>><vv>>>vv^<<<<vv^>v<<<<^^>^^v^><<^<v^>v^>^^<v<>vvv^>^<>vvv<v<^^>v^<<v>><>v<v<>^^<vvv>^>vv><><<<^^vv<v^<v<>v<>><<v><^vv^>^<^>^^^<<<v>vv^<^<<>^>^<vv>v><v<<^><^>^^<vv^v^^>>>>vv^><^^vv><>^<v^v>v<vv>v><<<v>v<v>^><v^^><v>v<^v^>>^^<v^>^^>vv>>vv^><^vv^vv<<^>vv>^v<v><vv><v<vvvvv>^^v^v><v>>>^vv<>v>^^^^<^>><>^v^^^>v<^^<<^^v<vv<>vvv<^>><><^>>^><^<>v<v<<><<v><v^v<>><^>v><<v^<v>v<^<vv^v^v^>vvv^^>v>^<vv^>v^v^<>v>^>>vv>><^^<v<<>^vv<><><<^v<v>v<<vv><>><^v<v>>v^>vvv^v^<<^><v<>^vv^>v^<v<^>>v<v><v><v>>^<<<v^<><<>v>^>^^<v<>>^<>^>^><<<^<<^<<^>^v>>><vvv>><<<<v>>>>>>>^<^v<^>v<>vv<><>v>>^>>^>vv^^><<^<v<v>>^^<<^>v<^>>vv>^<>v><^>v<vv>>>>>>^v<^<<<v^><vv<<>>vv<<><v<><<<v<^<v<>>v<^^^^v^^<^^^<^<vv><<^>><>v<<>v<v<>>>><>v^vv>^>^>>vv^v<v<<><^v>vv^><v<<>v^v<^>vv<<^^v><^>>^^vv<^<>>v^^>><v>^v>>>^>>v>v<>v<^vv><>^<<^>vv>>><><>v^><>v^>v>v><^v<><v<v>^v<<^vv^><^^>><^^^<<<^>v>^v>>><^>><^>>>^^^<^>vv<><<<v^>^<^^>>^^^v^v^v>v<v>>>><^>>>v>^vv<<^^^<^^vv>v<<><v<<^^>v>><<v^^><^>^<^>^v^>v><^<^vv>v>><>^<<vv<<v>v<vv<v>^>^>><^^<v>^v^v<><<>vvv<^<v>^><>^>vvv>>>^><<>><v^^<^<<^v>>^v<v<vv>vv^v^>v<<vvv<^^v^v>^<^>>^>v<^>^v<<><<<^>^<^^^>vv<^^^^vv<v<^^v<<<<v<^v^<><v<<^><<>vv>>><^<^<>>>^>^>>^<<<<<^^v>^>^<>vvv^^<^><^>^^v>^vv^><v^<^<<v^<vvv<<^v<><^><^>>>v>^v>^>^v<vv^v>><v><^><v^^>v^>^<><<><>v<v^>vvv^>^>>v<>^><^>^><vvv>^^v^v>v<>^v^><^>>v>v^><<<^>>^<>^<>>v><>>v^>^>^^<>>v^>^<vvvv<^vvvv^>>vv^<v^v>^vv<>v<>^<v<v>v>^^><^>vv^<^v^<<^<^<><vv<^v<^v><>>>^v^<<^><^>vv<v>v<^>vv^>v<<<>^<><v<^^^>v><^^<>^<^<v^vv^<<^>><<v^v<^vvv<<<>>vvvv^v^^^>v<>>><<>vvv<<^^^>v>v>>v<<v<v^v^>^^v>^><^<><<v^<v<v^^^><>v^^^<v>vv<>^>^^vv>^<<^v<^v><v>>>^>>><^<<>^v>>^>vv<<<v<>^<v><v^<^<>v>v^^v^>><<^v<<<<>v>v>v^^<^><>^^<<<v>vv<>>>^>>v<><v^>^<><vv>v>v^v<v^<^>>^>><<^^<^^v<vv<>><<<v<^<<^^^>vvv^<vvv<^>vv><>><<<^<v^v^^<<^vvv^^<^<><<>^<^<>>vvv<>^<>v^v<><>>v^v><<>>>vvv>v<>^>>^><^>vv<<>>v<<^><>v>>^^<v>^>^<<>><^<<vv<^<vv^vv><>>>><^<v>^>vv<v><>^<>vvvvv^vv<<v<>>>^<<><>^^vvv>>>vv<<^^><^v^^v<>^^>^><^>v^^^^v<^<<vv<vv<>vv^^>v^vv>v><>>vv>^<^<v^v^>>v^v^^v>^>vv^>v<vvvv<^v<^v>^v>^^v<<^>^^<<>^><^v>>>vv^>^^>vvvv>>v<^<v>^>>>v^<><^<^^<v>vv^^><v>v^<>^^^>>><^^v>v>^<<>^<v^>vvv^>^^^><v<^>>v<v>>^v><<><<>v<^<<>^><>^>vv>^<v>^^v<<^v^vvv^^>^vv^<^>^>^^v>v^>^<<><<^>v>>vv^vv><v>>^<<^<v^^<^<v^^vv^><^^<^^><v^^>v^^^<^<>^<>>^v<^vvv^^v^<><^>>>>>v><><<<>vv<^v>><<>vvv<><<vv<<<^>v^^>>^>^v>><><^^v<>><>>v^>^<vv><<<>><><<v>^^<>>v<><^<vv>vv<^v>^<<<<v<^<<^^>>^<><^>><<>^>v>^^^v>>^<^^v><v^v>^><<><>>^>>^<<v<>^v<>^>^<v>>vv>^vvv<<v<<^>^>^<<^^<>^^^^vvv<>^vv<vvvvv^^>^^<^>>><>v^<><^<<^>v^^v<>>^vv<>v^^<>>v^vvvvv<<v^<v^^>>><vvvvv>><^>vv>v^v^<v<^>^^><^>^^^^v<><^v<<>v^>v>>vv<<>^<v^^>vvv>^^<v^<>vv^><>><v^^v<>^>>^>v><>>^^v>^>^>>>^>v<^v>v>^<^^^^^>>v<v<>>v<<^>^<v<<>^^>><<^><>v<>^^^vv<>^^>><<^^>v>vv>vv>v^>^v>v^^<>>><<v><v<<>>v><>vvv^^v>^^>^vvvv^>^<>^vvvv><v><v<>>><>^<^vv<>^v<^v<>^vvv<<>><vvv^>>^><<vv^<v^>^<v<<^^>^^<^^v^>v<>v^v><>><v^^>>^vvv><^vv>v^<^<^v>>v^^>^vvv^<v^^v^^>v<^<>>^<>>>^^<><^^vv<>^vv^<>>>>^^<<^^<>vv^^><>^^<v<<v>^<v^^>^v<><><>vvv>^v^>>vv<<^v<<>><v>^><^>>>^<^<^^>vv^<<^<>>^^><><<v>^^<v>>v<<vvvv>^v^vv>><^^<<^>>v>v<^^^<^><^^vv>^vv<^<vv<>v><^<><v><^^^>>^<><^<v>>>>v^<v>>>>>v<><^^>v<^<^>><v<>^>vv>^^v^v^<<v<><<<^v^><<^<><<<<v<^>><<<>v>>vv><vv<><<^<^<><vv>^^^^<>v<<<<v>vv<>vv^^^>><>vv^><>>^vv<<><^^vv<>v^>>^<<>^<v^<^>v<";
            int[,] grid = new int[500, 500];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = 1;
                }
            }
            int santasPosRow = 250;
            int santasPosCol = 250;
            int uniqueHouses = 1;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '^')
                {
                    santasPosRow = santasPosRow - 1;
                    if (grid[santasPosRow, santasPosCol] == 1)
                    {
                        grid[santasPosRow, santasPosCol] = 0;
                        uniqueHouses += 1;
                    }
                }
                else if (pattern[i] == '>')
                {
                    santasPosCol = santasPosCol + 1;
                    if (grid[santasPosRow, santasPosCol] == 1)
                    {
                        grid[santasPosRow, santasPosCol] = 0;
                        uniqueHouses += 1;
                    }
                }
                else if (pattern[i] == 'v')
                {
                    santasPosRow = santasPosRow + 1;
                    if (grid[santasPosRow, santasPosCol] == 1)
                    {
                        grid[santasPosRow, santasPosCol] = 0;
                        uniqueHouses += 1;
                    }
                }
                else if (pattern[i] == '<')
                {
                    santasPosCol = santasPosCol - 1;
                    if (grid[santasPosRow, santasPosCol] == 1)
                    {
                        grid[santasPosRow, santasPosCol] = 0;
                        uniqueHouses += 1;
                    }
                }
            }

            Console.WriteLine(uniqueHouses);
        }
        static void Advent2015Day2Part1()
        {

            //1606483 Correct Answer
            string numbers = "20x3x11\r\n15x27x5\r\n6x29x7\r\n30x15x9\r\n19x29x21\r\n10x4x15\r\n1x26x4\r\n1x5x18\r\n10x15x23\r\n10x14x20\r\n3x5x18\r\n29x23x30\r\n7x4x10\r\n22x24x29\r\n30x1x2\r\n19x2x5\r\n11x9x22\r\n23x15x10\r\n11x11x10\r\n30x28x5\r\n22x5x4\r\n6x26x20\r\n16x12x30\r\n10x20x5\r\n25x14x24\r\n16x17x22\r\n11x28x26\r\n1x11x10\r\n1x24x15\r\n13x17x21\r\n30x3x13\r\n20x25x17\r\n22x12x5\r\n22x20x24\r\n9x2x14\r\n6x18x8\r\n27x28x24\r\n11x17x1\r\n1x4x12\r\n5x20x13\r\n24x23x23\r\n22x1x25\r\n18x19x5\r\n5x23x13\r\n8x16x4\r\n20x21x9\r\n1x7x11\r\n8x30x17\r\n3x30x9\r\n6x16x18\r\n22x25x27\r\n9x20x26\r\n16x21x23\r\n5x24x17\r\n15x17x15\r\n26x15x10\r\n22x16x3\r\n20x24x24\r\n8x18x10\r\n23x19x16\r\n1x21x24\r\n23x23x9\r\n14x20x6\r\n25x5x5\r\n16x3x1\r\n29x29x20\r\n11x4x26\r\n10x23x24\r\n29x25x16\r\n27x27x22\r\n9x7x22\r\n6x21x18\r\n25x11x19\r\n14x13x3\r\n15x28x17\r\n14x3x12\r\n29x8x19\r\n30x14x20\r\n20x23x4\r\n8x16x5\r\n4x11x18\r\n20x8x24\r\n21x13x21\r\n14x26x29\r\n27x4x17\r\n27x4x25\r\n5x28x6\r\n23x24x11\r\n29x22x5\r\n30x20x6\r\n23x2x10\r\n11x4x7\r\n27x23x6\r\n10x20x19\r\n8x20x22\r\n5x29x22\r\n16x13x2\r\n2x11x14\r\n6x12x4\r\n3x13x6\r\n16x5x18\r\n25x3x28\r\n21x1x5\r\n20x16x19\r\n28x30x27\r\n26x7x18\r\n25x27x24\r\n11x19x7\r\n21x19x17\r\n2x12x27\r\n20x5x14\r\n8x5x8\r\n6x24x8\r\n7x28x20\r\n3x20x28\r\n5x20x30\r\n13x29x1\r\n26x29x5\r\n19x28x25\r\n5x19x11\r\n11x20x22\r\n4x23x1\r\n19x25x12\r\n3x10x6\r\n3x14x10\r\n28x16x12\r\n23x12x2\r\n23x12x19\r\n20x28x10\r\n9x10x25\r\n16x21x16\r\n1x18x20\r\n9x4x26\r\n3x25x8\r\n17x16x28\r\n9x28x16\r\n27x3x12\r\n17x24x12\r\n13x21x10\r\n7x17x13\r\n6x10x9\r\n7x29x25\r\n11x19x30\r\n1x24x5\r\n20x16x23\r\n24x28x21\r\n6x29x19\r\n25x2x19\r\n12x5x26\r\n25x29x12\r\n16x28x22\r\n26x26x15\r\n9x13x5\r\n10x29x7\r\n1x24x16\r\n22x2x2\r\n6x16x13\r\n3x12x28\r\n4x12x13\r\n14x27x21\r\n14x23x26\r\n7x5x18\r\n8x30x27\r\n15x9x18\r\n26x16x5\r\n3x29x17\r\n19x7x18\r\n16x18x1\r\n26x15x30\r\n24x30x21\r\n13x20x7\r\n4x12x10\r\n27x20x11\r\n28x29x21\r\n20x14x30\r\n28x12x3\r\n19x1x8\r\n4x8x6\r\n21x14x2\r\n27x19x21\r\n17x24x14\r\n15x18x11\r\n18x7x26\r\n25x28x29\r\n27x26x9\r\n18x12x17\r\n24x28x25\r\n13x24x14\r\n26x9x28\r\n9x3x30\r\n9x2x9\r\n8x1x29\r\n18x30x10\r\n18x14x5\r\n26x8x30\r\n12x1x1\r\n30x5x28\r\n26x17x21\r\n10x10x10\r\n20x7x27\r\n13x17x6\r\n21x13x17\r\n2x16x8\r\n7x9x9\r\n15x26x4\r\n11x28x25\r\n10x6x19\r\n21x6x29\r\n15x5x6\r\n28x9x16\r\n14x3x10\r\n12x29x5\r\n22x19x19\r\n25x15x22\r\n30x6x28\r\n11x23x13\r\n20x25x14\r\n26x1x13\r\n6x14x15\r\n16x25x17\r\n28x4x13\r\n10x24x25\r\n4x13x10\r\n9x15x16\r\n15x24x6\r\n22x9x19\r\n11x11x8\r\n4x19x12\r\n24x5x4\r\n27x12x13\r\n7x27x16\r\n2x6x9\r\n29x27x15\r\n18x26x23\r\n19x16x15\r\n14x5x25\r\n9x16x30\r\n4x6x4\r\n13x10x10\r\n1x8x29\r\n23x5x17\r\n19x20x20\r\n11x27x24\r\n27x15x5\r\n15x11x12\r\n21x11x3\r\n1x13x22\r\n17x8x8\r\n13x14x14\r\n17x22x7\r\n9x5x8\r\n2x6x3\r\n25x9x15\r\n11x8x13\r\n9x25x12\r\n3x16x12\r\n12x16x8\r\n16x24x17\r\n4x6x26\r\n22x29x11\r\n14x17x19\r\n28x2x27\r\n24x22x19\r\n22x20x30\r\n23x28x4\r\n16x12x14\r\n22x24x22\r\n29x1x28\r\n26x29x16\r\n3x25x30\r\n27x3x13\r\n22x24x26\r\n25x3x2\r\n7x24x2\r\n10x5x3\r\n28x8x29\r\n25x6x4\r\n12x17x14\r\n24x3x5\r\n23x27x7\r\n26x23x30\r\n11x10x19\r\n23x7x11\r\n26x14x15\r\n14x3x25\r\n12x24x14\r\n2x14x12\r\n9x12x16\r\n9x2x28\r\n3x8x2\r\n22x6x9\r\n2x30x2\r\n25x1x9\r\n20x11x2\r\n14x11x12\r\n7x14x12\r\n24x8x26\r\n13x21x23\r\n18x17x23\r\n13x6x17\r\n20x20x19\r\n13x17x29\r\n7x24x24\r\n23x8x6\r\n19x10x28\r\n3x8x21\r\n15x20x18\r\n11x27x1\r\n11x24x28\r\n13x20x11\r\n18x19x22\r\n27x22x12\r\n28x3x2\r\n13x4x29\r\n26x5x6\r\n14x29x25\r\n7x4x7\r\n5x17x7\r\n2x8x1\r\n22x30x24\r\n22x21x28\r\n1x28x13\r\n11x20x4\r\n25x29x19\r\n9x23x4\r\n30x6x11\r\n25x18x10\r\n28x10x24\r\n3x5x20\r\n19x28x10\r\n27x19x2\r\n26x20x4\r\n19x21x6\r\n2x12x30\r\n8x26x27\r\n11x27x10\r\n14x13x17\r\n4x3x21\r\n2x20x21\r\n22x30x3\r\n2x23x2\r\n3x16x12\r\n22x28x22\r\n3x23x29\r\n8x25x15\r\n9x30x4\r\n10x11x1\r\n24x8x20\r\n10x7x27\r\n7x22x4\r\n27x13x17\r\n5x28x5\r\n30x15x13\r\n10x8x17\r\n8x21x5\r\n8x17x26\r\n25x16x4\r\n9x7x25\r\n13x11x20\r\n6x30x9\r\n15x14x12\r\n30x1x23\r\n5x20x24\r\n22x7x6\r\n26x11x23\r\n29x7x5\r\n13x24x28\r\n22x20x10\r\n18x3x1\r\n15x19x23\r\n28x28x20\r\n7x26x2\r\n9x12x20\r\n15x4x6\r\n1x17x21\r\n3x22x17\r\n9x4x20\r\n25x19x5\r\n9x11x22\r\n14x1x17\r\n14x5x16\r\n30x5x18\r\n19x6x12\r\n28x16x22\r\n13x4x25\r\n29x23x18\r\n1x27x3\r\n12x14x4\r\n10x25x19\r\n15x19x30\r\n11x30x4\r\n11x22x26\r\n13x25x2\r\n17x13x27\r\n11x30x24\r\n15x1x14\r\n17x18x4\r\n26x11x3\r\n16x22x28\r\n13x20x9\r\n1x18x3\r\n25x11x12\r\n20x21x1\r\n22x27x4\r\n8x28x23\r\n7x13x27\r\n17x9x26\r\n27x27x20\r\n11x20x12\r\n26x21x11\r\n29x14x12\r\n27x25x1\r\n28x29x25\r\n21x23x28\r\n5x18x18\r\n19x5x4\r\n7x6x30\r\n27x8x11\r\n12x24x12\r\n16x25x22\r\n26x11x29\r\n25x22x17\r\n15x23x23\r\n17x9x6\r\n30x10x16\r\n21x3x5\r\n18x27x2\r\n28x21x14\r\n16x18x17\r\n4x18x2\r\n9x1x14\r\n9x1x9\r\n5x27x12\r\n8x16x30\r\n3x19x19\r\n16x26x24\r\n1x6x9\r\n15x14x3\r\n11x7x19\r\n8x19x3\r\n17x26x26\r\n6x18x11\r\n19x12x4\r\n29x20x16\r\n20x17x23\r\n6x6x5\r\n20x30x19\r\n18x25x18\r\n2x26x2\r\n3x1x1\r\n14x25x18\r\n3x1x6\r\n11x14x18\r\n17x23x27\r\n25x29x9\r\n6x25x20\r\n20x10x9\r\n17x5x18\r\n29x14x8\r\n14x25x26\r\n10x15x29\r\n23x19x11\r\n22x2x2\r\n4x5x5\r\n13x23x25\r\n19x13x19\r\n20x18x6\r\n30x7x28\r\n26x18x17\r\n29x18x10\r\n30x29x1\r\n12x26x24\r\n18x17x26\r\n29x28x15\r\n3x12x20\r\n24x10x8\r\n30x15x6\r\n28x23x15\r\n14x28x11\r\n10x27x19\r\n14x8x21\r\n24x1x23\r\n1x3x27\r\n6x15x6\r\n8x25x26\r\n13x10x25\r\n6x9x8\r\n10x29x29\r\n26x23x5\r\n14x24x1\r\n25x6x22\r\n17x11x18\r\n1x27x26\r\n18x25x23\r\n20x15x6\r\n2x21x28\r\n2x10x13\r\n12x25x14\r\n2x14x23\r\n30x5x23\r\n29x19x21\r\n29x10x25\r\n14x22x16\r\n17x11x26\r\n12x17x30\r\n8x17x7\r\n20x25x28\r\n20x11x30\r\n15x1x12\r\n13x3x24\r\n16x23x23\r\n27x3x3\r\n26x3x27\r\n18x5x12\r\n12x26x7\r\n19x27x12\r\n20x10x28\r\n30x12x25\r\n3x14x10\r\n21x26x1\r\n24x26x26\r\n7x21x30\r\n3x29x12\r\n29x28x5\r\n5x20x7\r\n27x11x2\r\n15x20x4\r\n16x15x15\r\n19x13x7\r\n7x17x15\r\n27x24x15\r\n9x17x28\r\n20x21x14\r\n14x29x29\r\n23x26x13\r\n27x23x21\r\n18x13x6\r\n26x16x21\r\n18x26x27\r\n9x3x12\r\n30x18x24\r\n12x11x29\r\n5x15x1\r\n1x16x3\r\n14x28x11\r\n2x18x1\r\n19x18x19\r\n18x28x21\r\n2x3x14\r\n22x16x5\r\n28x18x28\r\n24x16x18\r\n7x4x10\r\n19x26x19\r\n24x17x7\r\n25x9x6\r\n25x17x7\r\n20x22x20\r\n3x3x7\r\n23x19x15\r\n21x27x21\r\n1x23x11\r\n9x19x4\r\n22x4x18\r\n6x15x5\r\n15x25x2\r\n23x11x20\r\n27x16x6\r\n27x8x5\r\n10x10x19\r\n22x14x1\r\n7x1x29\r\n8x11x17\r\n27x9x27\r\n28x9x24\r\n17x7x3\r\n26x23x8\r\n7x6x30\r\n25x28x2\r\n1x30x25\r\n3x18x18\r\n28x27x15\r\n14x14x1\r\n10x25x29\r\n18x12x9\r\n20x28x16\r\n26x27x22\r\n8x26x1\r\n21x2x12\r\n25x16x14\r\n21x19x5\r\n12x9x22\r\n16x5x4\r\n5x4x16\r\n25x29x3\r\n4x29x13\r\n15x16x29\r\n8x11x24\r\n30x11x20\r\n17x21x14\r\n12x24x10\r\n10x12x6\r\n3x26x30\r\n15x14x25\r\n20x12x21\r\n13x11x16\r\n15x13x3\r\n5x17x29\r\n6x3x23\r\n9x26x11\r\n30x1x8\r\n14x10x30\r\n18x30x10\r\n13x19x19\r\n16x19x17\r\n28x7x10\r\n28x29x4\r\n3x21x10\r\n4x28x24\r\n7x28x9\r\n2x4x9\r\n25x27x13\r\n6x12x15\r\n4x18x20\r\n20x1x16\r\n5x13x24\r\n11x11x10\r\n12x9x23\r\n1x9x30\r\n17x28x24\r\n9x5x27\r\n21x15x16\r\n17x4x14\r\n8x14x4\r\n13x10x7\r\n17x12x14\r\n9x19x19\r\n2x7x21\r\n8x24x23\r\n19x5x12\r\n11x23x21\r\n13x3x1\r\n5x27x15\r\n12x25x25\r\n13x21x16\r\n9x17x11\r\n1x15x21\r\n4x26x17\r\n11x5x15\r\n23x10x15\r\n12x17x21\r\n27x15x1\r\n4x29x14\r\n5x24x25\r\n10x10x12\r\n18x12x9\r\n11x24x23\r\n24x23x3\r\n28x12x15\r\n29x9x14\r\n11x25x8\r\n5x12x2\r\n26x26x29\r\n9x21x2\r\n8x8x25\r\n1x16x30\r\n17x29x20\r\n9x22x13\r\n7x18x16\r\n3x3x23\r\n26x25x30\r\n15x23x24\r\n20x23x5\r\n20x16x10\r\n23x7x8\r\n20x18x26\r\n8x27x6\r\n30x23x23\r\n7x7x24\r\n21x11x15\r\n1x30x25\r\n26x27x22\r\n30x28x13\r\n20x13x13\r\n3x1x15\r\n16x7x1\r\n7x25x15\r\n12x7x18\r\n16x9x23\r\n16x12x18\r\n29x5x2\r\n17x7x7\r\n21x17x5\r\n9x9x17\r\n26x16x10\r\n29x29x23\r\n17x26x10\r\n5x19x17\r\n1x10x1\r\n14x21x20\r\n13x6x4\r\n13x13x3\r\n23x4x18\r\n4x16x3\r\n16x30x11\r\n2x11x2\r\n15x30x15\r\n20x30x22\r\n18x12x16\r\n23x5x16\r\n6x14x15\r\n9x4x11\r\n30x23x21\r\n20x7x12\r\n7x18x6\r\n15x6x5\r\n18x22x19\r\n16x10x22\r\n26x20x25\r\n9x25x25\r\n29x21x10\r\n9x21x24\r\n7x18x21\r\n14x3x15\r\n18x19x19\r\n4x29x17\r\n14x10x9\r\n2x26x14\r\n13x3x24\r\n4x4x17\r\n6x27x24\r\n2x18x3\r\n14x25x2\r\n30x14x17\r\n11x6x14\r\n4x10x18\r\n15x4x2\r\n27x7x10\r\n13x24x1\r\n7x12x6\r\n25x22x26\r\n19x2x18\r\n23x29x2\r\n2x15x4\r\n12x6x9\r\n16x14x29\r\n9x17x3\r\n21x9x12\r\n23x18x22\r\n10x8x4\r\n29x2x7\r\n19x27x15\r\n4x24x27\r\n25x20x14\r\n8x23x19\r\n1x24x19\r\n6x20x10\r\n15x8x5\r\n18x28x5\r\n17x23x22\r\n9x16x13\r\n30x24x4\r\n26x3x13\r\n12x22x18\r\n29x17x29\r\n26x4x16\r\n15x7x20\r\n9x15x30\r\n12x7x18\r\n28x19x18\r\n11x23x23\r\n24x20x1\r\n20x3x24\r\n1x26x1\r\n14x10x6\r\n5x27x24\r\n13x21x12\r\n20x20x5\r\n6x28x9\r\n11x26x11\r\n26x29x12\r\n21x4x11\r\n20x11x17\r\n22x27x20\r\n19x11x21\r\n2x11x11\r\n13x5x7\r\n12x10x25\r\n21x28x1\r\n15x30x17\r\n28x19x1\r\n4x19x12\r\n11x4x12\r\n4x10x30\r\n11x18x5\r\n22x20x12\r\n3x7x27\r\n20x26x4\r\n13x27x26\r\n23x14x13\r\n4x19x7\r\n26x27x16\r\n20x5x20\r\n18x5x8\r\n19x21x1\r\n22x8x1\r\n29x4x1\r\n24x10x15\r\n24x9x20\r\n10x3x8\r\n29x30x3\r\n2x8x24\r\n16x7x18\r\n2x11x23\r\n23x15x16\r\n21x12x6\r\n24x28x9\r\n6x1x13\r\n14x29x20\r\n27x24x13\r\n16x26x8\r\n5x6x17\r\n21x8x1\r\n28x19x21\r\n1x14x16\r\n18x2x9\r\n29x28x10\r\n22x26x27\r\n18x26x23\r\n22x24x2\r\n28x26x1\r\n27x29x12\r\n30x13x11\r\n1x25x5\r\n13x30x18\r\n3x13x22\r\n22x10x11\r\n2x7x7\r\n18x17x8\r\n9x22x26\r\n30x18x16\r\n10x2x3\r\n7x27x13\r\n3x20x16\r\n9x21x16\r\n1x18x15\r\n21x30x30\r\n4x25x23\r\n3x11x7\r\n5x6x12\r\n27x1x20\r\n13x15x24\r\n23x29x2\r\n13x5x24\r\n22x16x15\r\n28x14x3\r\n29x24x9\r\n2x20x4\r\n30x10x4\r\n23x7x20\r\n22x12x21\r\n3x19x11\r\n4x28x28\r\n5x4x7\r\n28x12x25\r\n2x16x26\r\n23x20x7\r\n5x21x29\r\n9x21x16\r\n9x6x10\r\n9x6x4\r\n24x14x29\r\n28x11x6\r\n10x22x1\r\n21x30x20\r\n13x17x8\r\n2x25x24\r\n19x21x3\r\n28x8x14\r\n6x29x28\r\n27x10x28\r\n30x11x12\r\n17x2x10\r\n14x19x17\r\n2x11x4\r\n26x1x2\r\n13x4x4\r\n23x20x18\r\n2x17x21\r\n28x7x15\r\n3x3x27\r\n24x17x30\r\n28x28x20\r\n21x5x29\r\n13x12x19\r\n24x29x29\r\n19x10x6\r\n19x12x14\r\n21x4x17\r\n27x16x1\r\n4x17x30\r\n23x23x18\r\n23x15x27\r\n26x2x11\r\n12x8x8\r\n15x23x26\r\n30x17x15\r\n17x17x15\r\n24x4x30\r\n9x9x10\r\n14x25x20\r\n25x11x19\r\n20x7x1\r\n9x21x3\r\n7x19x9\r\n10x6x19\r\n26x12x30\r\n21x9x20\r\n15x11x6\r\n30x21x9\r\n10x18x17\r\n22x9x8\r\n8x30x26\r\n28x12x27\r\n17x17x7\r\n11x13x8\r\n5x3x21\r\n24x1x29\r\n1x28x2\r\n18x28x10\r\n8x29x14\r\n26x26x27\r\n17x10x25\r\n22x30x3\r\n27x9x13\r\n21x21x4\r\n30x29x16\r\n22x7x20\r\n24x10x2\r\n16x29x17\r\n28x15x17\r\n19x19x22\r\n9x8x6\r\n26x23x24\r\n25x4x27\r\n16x12x2\r\n11x6x18\r\n19x14x8\r\n9x29x13\r\n23x30x19\r\n10x16x1\r\n4x21x28\r\n23x25x25\r\n19x9x16\r\n30x11x12\r\n24x3x9\r\n28x19x4\r\n18x12x9\r\n7x1x25\r\n28x7x1\r\n24x3x12\r\n30x24x22\r\n27x24x26\r\n9x30x30\r\n29x10x8\r\n4x6x18\r\n10x1x15\r\n10x4x26\r\n23x20x16\r\n6x3x14\r\n30x8x16\r\n25x14x20\r\n11x9x3\r\n15x23x25\r\n8x30x22\r\n22x19x18\r\n25x1x12\r\n27x25x7\r\n25x23x3\r\n13x20x8\r\n5x30x7\r\n18x19x27\r\n20x23x3\r\n1x17x21\r\n21x21x27\r\n13x1x24\r\n7x30x20\r\n21x9x18\r\n23x26x6\r\n22x9x29\r\n17x6x21\r\n28x28x29\r\n19x25x26\r\n9x27x21\r\n5x26x8\r\n11x19x1\r\n10x1x18\r\n29x4x8\r\n21x2x22\r\n14x12x8";
            string replaced = numbers.Replace("\r\n", "x");

            string[] numbers2 = replaced.Split('x');

            var numbersInt = Array.ConvertAll(numbers2, int.Parse);

            List<int> numbersList = new List<int>();

            var sum = 0;

            for (int i = 0; i < numbersInt.Length; i += 3)
            {

                if (numbersInt[i + 2] <= numbersInt.Length)
                {

                    int firstToAdd = 2 * numbersInt[i] * numbersInt[i + 1];
                    int secondToAdd = 2 * numbersInt[i + 1] * numbersInt[i + 2];
                    int thirdToAdd = 2 * numbersInt[i] * numbersInt[i + 2];

                    var numbersForSmallest = new List<int> { firstToAdd, secondToAdd, thirdToAdd };
                    int smallestSideMath = Math.Min(firstToAdd, Math.Min(secondToAdd, thirdToAdd)) / 2;


                    var smallestSide = numbersForSmallest.Min() / 2;


                    sum += firstToAdd + secondToAdd + thirdToAdd + smallestSideMath;

                    //1606483

                }

            }
            Console.WriteLine(sum);
        }
        static void Advent2015Day2Part2()
        {
            string numbers = "20x3x11\r\n15x27x5\r\n6x29x7\r\n30x15x9\r\n19x29x21\r\n10x4x15\r\n1x26x4\r\n1x5x18\r\n10x15x23\r\n10x14x20\r\n3x5x18\r\n29x23x30\r\n7x4x10\r\n22x24x29\r\n30x1x2\r\n19x2x5\r\n11x9x22\r\n23x15x10\r\n11x11x10\r\n30x28x5\r\n22x5x4\r\n6x26x20\r\n16x12x30\r\n10x20x5\r\n25x14x24\r\n16x17x22\r\n11x28x26\r\n1x11x10\r\n1x24x15\r\n13x17x21\r\n30x3x13\r\n20x25x17\r\n22x12x5\r\n22x20x24\r\n9x2x14\r\n6x18x8\r\n27x28x24\r\n11x17x1\r\n1x4x12\r\n5x20x13\r\n24x23x23\r\n22x1x25\r\n18x19x5\r\n5x23x13\r\n8x16x4\r\n20x21x9\r\n1x7x11\r\n8x30x17\r\n3x30x9\r\n6x16x18\r\n22x25x27\r\n9x20x26\r\n16x21x23\r\n5x24x17\r\n15x17x15\r\n26x15x10\r\n22x16x3\r\n20x24x24\r\n8x18x10\r\n23x19x16\r\n1x21x24\r\n23x23x9\r\n14x20x6\r\n25x5x5\r\n16x3x1\r\n29x29x20\r\n11x4x26\r\n10x23x24\r\n29x25x16\r\n27x27x22\r\n9x7x22\r\n6x21x18\r\n25x11x19\r\n14x13x3\r\n15x28x17\r\n14x3x12\r\n29x8x19\r\n30x14x20\r\n20x23x4\r\n8x16x5\r\n4x11x18\r\n20x8x24\r\n21x13x21\r\n14x26x29\r\n27x4x17\r\n27x4x25\r\n5x28x6\r\n23x24x11\r\n29x22x5\r\n30x20x6\r\n23x2x10\r\n11x4x7\r\n27x23x6\r\n10x20x19\r\n8x20x22\r\n5x29x22\r\n16x13x2\r\n2x11x14\r\n6x12x4\r\n3x13x6\r\n16x5x18\r\n25x3x28\r\n21x1x5\r\n20x16x19\r\n28x30x27\r\n26x7x18\r\n25x27x24\r\n11x19x7\r\n21x19x17\r\n2x12x27\r\n20x5x14\r\n8x5x8\r\n6x24x8\r\n7x28x20\r\n3x20x28\r\n5x20x30\r\n13x29x1\r\n26x29x5\r\n19x28x25\r\n5x19x11\r\n11x20x22\r\n4x23x1\r\n19x25x12\r\n3x10x6\r\n3x14x10\r\n28x16x12\r\n23x12x2\r\n23x12x19\r\n20x28x10\r\n9x10x25\r\n16x21x16\r\n1x18x20\r\n9x4x26\r\n3x25x8\r\n17x16x28\r\n9x28x16\r\n27x3x12\r\n17x24x12\r\n13x21x10\r\n7x17x13\r\n6x10x9\r\n7x29x25\r\n11x19x30\r\n1x24x5\r\n20x16x23\r\n24x28x21\r\n6x29x19\r\n25x2x19\r\n12x5x26\r\n25x29x12\r\n16x28x22\r\n26x26x15\r\n9x13x5\r\n10x29x7\r\n1x24x16\r\n22x2x2\r\n6x16x13\r\n3x12x28\r\n4x12x13\r\n14x27x21\r\n14x23x26\r\n7x5x18\r\n8x30x27\r\n15x9x18\r\n26x16x5\r\n3x29x17\r\n19x7x18\r\n16x18x1\r\n26x15x30\r\n24x30x21\r\n13x20x7\r\n4x12x10\r\n27x20x11\r\n28x29x21\r\n20x14x30\r\n28x12x3\r\n19x1x8\r\n4x8x6\r\n21x14x2\r\n27x19x21\r\n17x24x14\r\n15x18x11\r\n18x7x26\r\n25x28x29\r\n27x26x9\r\n18x12x17\r\n24x28x25\r\n13x24x14\r\n26x9x28\r\n9x3x30\r\n9x2x9\r\n8x1x29\r\n18x30x10\r\n18x14x5\r\n26x8x30\r\n12x1x1\r\n30x5x28\r\n26x17x21\r\n10x10x10\r\n20x7x27\r\n13x17x6\r\n21x13x17\r\n2x16x8\r\n7x9x9\r\n15x26x4\r\n11x28x25\r\n10x6x19\r\n21x6x29\r\n15x5x6\r\n28x9x16\r\n14x3x10\r\n12x29x5\r\n22x19x19\r\n25x15x22\r\n30x6x28\r\n11x23x13\r\n20x25x14\r\n26x1x13\r\n6x14x15\r\n16x25x17\r\n28x4x13\r\n10x24x25\r\n4x13x10\r\n9x15x16\r\n15x24x6\r\n22x9x19\r\n11x11x8\r\n4x19x12\r\n24x5x4\r\n27x12x13\r\n7x27x16\r\n2x6x9\r\n29x27x15\r\n18x26x23\r\n19x16x15\r\n14x5x25\r\n9x16x30\r\n4x6x4\r\n13x10x10\r\n1x8x29\r\n23x5x17\r\n19x20x20\r\n11x27x24\r\n27x15x5\r\n15x11x12\r\n21x11x3\r\n1x13x22\r\n17x8x8\r\n13x14x14\r\n17x22x7\r\n9x5x8\r\n2x6x3\r\n25x9x15\r\n11x8x13\r\n9x25x12\r\n3x16x12\r\n12x16x8\r\n16x24x17\r\n4x6x26\r\n22x29x11\r\n14x17x19\r\n28x2x27\r\n24x22x19\r\n22x20x30\r\n23x28x4\r\n16x12x14\r\n22x24x22\r\n29x1x28\r\n26x29x16\r\n3x25x30\r\n27x3x13\r\n22x24x26\r\n25x3x2\r\n7x24x2\r\n10x5x3\r\n28x8x29\r\n25x6x4\r\n12x17x14\r\n24x3x5\r\n23x27x7\r\n26x23x30\r\n11x10x19\r\n23x7x11\r\n26x14x15\r\n14x3x25\r\n12x24x14\r\n2x14x12\r\n9x12x16\r\n9x2x28\r\n3x8x2\r\n22x6x9\r\n2x30x2\r\n25x1x9\r\n20x11x2\r\n14x11x12\r\n7x14x12\r\n24x8x26\r\n13x21x23\r\n18x17x23\r\n13x6x17\r\n20x20x19\r\n13x17x29\r\n7x24x24\r\n23x8x6\r\n19x10x28\r\n3x8x21\r\n15x20x18\r\n11x27x1\r\n11x24x28\r\n13x20x11\r\n18x19x22\r\n27x22x12\r\n28x3x2\r\n13x4x29\r\n26x5x6\r\n14x29x25\r\n7x4x7\r\n5x17x7\r\n2x8x1\r\n22x30x24\r\n22x21x28\r\n1x28x13\r\n11x20x4\r\n25x29x19\r\n9x23x4\r\n30x6x11\r\n25x18x10\r\n28x10x24\r\n3x5x20\r\n19x28x10\r\n27x19x2\r\n26x20x4\r\n19x21x6\r\n2x12x30\r\n8x26x27\r\n11x27x10\r\n14x13x17\r\n4x3x21\r\n2x20x21\r\n22x30x3\r\n2x23x2\r\n3x16x12\r\n22x28x22\r\n3x23x29\r\n8x25x15\r\n9x30x4\r\n10x11x1\r\n24x8x20\r\n10x7x27\r\n7x22x4\r\n27x13x17\r\n5x28x5\r\n30x15x13\r\n10x8x17\r\n8x21x5\r\n8x17x26\r\n25x16x4\r\n9x7x25\r\n13x11x20\r\n6x30x9\r\n15x14x12\r\n30x1x23\r\n5x20x24\r\n22x7x6\r\n26x11x23\r\n29x7x5\r\n13x24x28\r\n22x20x10\r\n18x3x1\r\n15x19x23\r\n28x28x20\r\n7x26x2\r\n9x12x20\r\n15x4x6\r\n1x17x21\r\n3x22x17\r\n9x4x20\r\n25x19x5\r\n9x11x22\r\n14x1x17\r\n14x5x16\r\n30x5x18\r\n19x6x12\r\n28x16x22\r\n13x4x25\r\n29x23x18\r\n1x27x3\r\n12x14x4\r\n10x25x19\r\n15x19x30\r\n11x30x4\r\n11x22x26\r\n13x25x2\r\n17x13x27\r\n11x30x24\r\n15x1x14\r\n17x18x4\r\n26x11x3\r\n16x22x28\r\n13x20x9\r\n1x18x3\r\n25x11x12\r\n20x21x1\r\n22x27x4\r\n8x28x23\r\n7x13x27\r\n17x9x26\r\n27x27x20\r\n11x20x12\r\n26x21x11\r\n29x14x12\r\n27x25x1\r\n28x29x25\r\n21x23x28\r\n5x18x18\r\n19x5x4\r\n7x6x30\r\n27x8x11\r\n12x24x12\r\n16x25x22\r\n26x11x29\r\n25x22x17\r\n15x23x23\r\n17x9x6\r\n30x10x16\r\n21x3x5\r\n18x27x2\r\n28x21x14\r\n16x18x17\r\n4x18x2\r\n9x1x14\r\n9x1x9\r\n5x27x12\r\n8x16x30\r\n3x19x19\r\n16x26x24\r\n1x6x9\r\n15x14x3\r\n11x7x19\r\n8x19x3\r\n17x26x26\r\n6x18x11\r\n19x12x4\r\n29x20x16\r\n20x17x23\r\n6x6x5\r\n20x30x19\r\n18x25x18\r\n2x26x2\r\n3x1x1\r\n14x25x18\r\n3x1x6\r\n11x14x18\r\n17x23x27\r\n25x29x9\r\n6x25x20\r\n20x10x9\r\n17x5x18\r\n29x14x8\r\n14x25x26\r\n10x15x29\r\n23x19x11\r\n22x2x2\r\n4x5x5\r\n13x23x25\r\n19x13x19\r\n20x18x6\r\n30x7x28\r\n26x18x17\r\n29x18x10\r\n30x29x1\r\n12x26x24\r\n18x17x26\r\n29x28x15\r\n3x12x20\r\n24x10x8\r\n30x15x6\r\n28x23x15\r\n14x28x11\r\n10x27x19\r\n14x8x21\r\n24x1x23\r\n1x3x27\r\n6x15x6\r\n8x25x26\r\n13x10x25\r\n6x9x8\r\n10x29x29\r\n26x23x5\r\n14x24x1\r\n25x6x22\r\n17x11x18\r\n1x27x26\r\n18x25x23\r\n20x15x6\r\n2x21x28\r\n2x10x13\r\n12x25x14\r\n2x14x23\r\n30x5x23\r\n29x19x21\r\n29x10x25\r\n14x22x16\r\n17x11x26\r\n12x17x30\r\n8x17x7\r\n20x25x28\r\n20x11x30\r\n15x1x12\r\n13x3x24\r\n16x23x23\r\n27x3x3\r\n26x3x27\r\n18x5x12\r\n12x26x7\r\n19x27x12\r\n20x10x28\r\n30x12x25\r\n3x14x10\r\n21x26x1\r\n24x26x26\r\n7x21x30\r\n3x29x12\r\n29x28x5\r\n5x20x7\r\n27x11x2\r\n15x20x4\r\n16x15x15\r\n19x13x7\r\n7x17x15\r\n27x24x15\r\n9x17x28\r\n20x21x14\r\n14x29x29\r\n23x26x13\r\n27x23x21\r\n18x13x6\r\n26x16x21\r\n18x26x27\r\n9x3x12\r\n30x18x24\r\n12x11x29\r\n5x15x1\r\n1x16x3\r\n14x28x11\r\n2x18x1\r\n19x18x19\r\n18x28x21\r\n2x3x14\r\n22x16x5\r\n28x18x28\r\n24x16x18\r\n7x4x10\r\n19x26x19\r\n24x17x7\r\n25x9x6\r\n25x17x7\r\n20x22x20\r\n3x3x7\r\n23x19x15\r\n21x27x21\r\n1x23x11\r\n9x19x4\r\n22x4x18\r\n6x15x5\r\n15x25x2\r\n23x11x20\r\n27x16x6\r\n27x8x5\r\n10x10x19\r\n22x14x1\r\n7x1x29\r\n8x11x17\r\n27x9x27\r\n28x9x24\r\n17x7x3\r\n26x23x8\r\n7x6x30\r\n25x28x2\r\n1x30x25\r\n3x18x18\r\n28x27x15\r\n14x14x1\r\n10x25x29\r\n18x12x9\r\n20x28x16\r\n26x27x22\r\n8x26x1\r\n21x2x12\r\n25x16x14\r\n21x19x5\r\n12x9x22\r\n16x5x4\r\n5x4x16\r\n25x29x3\r\n4x29x13\r\n15x16x29\r\n8x11x24\r\n30x11x20\r\n17x21x14\r\n12x24x10\r\n10x12x6\r\n3x26x30\r\n15x14x25\r\n20x12x21\r\n13x11x16\r\n15x13x3\r\n5x17x29\r\n6x3x23\r\n9x26x11\r\n30x1x8\r\n14x10x30\r\n18x30x10\r\n13x19x19\r\n16x19x17\r\n28x7x10\r\n28x29x4\r\n3x21x10\r\n4x28x24\r\n7x28x9\r\n2x4x9\r\n25x27x13\r\n6x12x15\r\n4x18x20\r\n20x1x16\r\n5x13x24\r\n11x11x10\r\n12x9x23\r\n1x9x30\r\n17x28x24\r\n9x5x27\r\n21x15x16\r\n17x4x14\r\n8x14x4\r\n13x10x7\r\n17x12x14\r\n9x19x19\r\n2x7x21\r\n8x24x23\r\n19x5x12\r\n11x23x21\r\n13x3x1\r\n5x27x15\r\n12x25x25\r\n13x21x16\r\n9x17x11\r\n1x15x21\r\n4x26x17\r\n11x5x15\r\n23x10x15\r\n12x17x21\r\n27x15x1\r\n4x29x14\r\n5x24x25\r\n10x10x12\r\n18x12x9\r\n11x24x23\r\n24x23x3\r\n28x12x15\r\n29x9x14\r\n11x25x8\r\n5x12x2\r\n26x26x29\r\n9x21x2\r\n8x8x25\r\n1x16x30\r\n17x29x20\r\n9x22x13\r\n7x18x16\r\n3x3x23\r\n26x25x30\r\n15x23x24\r\n20x23x5\r\n20x16x10\r\n23x7x8\r\n20x18x26\r\n8x27x6\r\n30x23x23\r\n7x7x24\r\n21x11x15\r\n1x30x25\r\n26x27x22\r\n30x28x13\r\n20x13x13\r\n3x1x15\r\n16x7x1\r\n7x25x15\r\n12x7x18\r\n16x9x23\r\n16x12x18\r\n29x5x2\r\n17x7x7\r\n21x17x5\r\n9x9x17\r\n26x16x10\r\n29x29x23\r\n17x26x10\r\n5x19x17\r\n1x10x1\r\n14x21x20\r\n13x6x4\r\n13x13x3\r\n23x4x18\r\n4x16x3\r\n16x30x11\r\n2x11x2\r\n15x30x15\r\n20x30x22\r\n18x12x16\r\n23x5x16\r\n6x14x15\r\n9x4x11\r\n30x23x21\r\n20x7x12\r\n7x18x6\r\n15x6x5\r\n18x22x19\r\n16x10x22\r\n26x20x25\r\n9x25x25\r\n29x21x10\r\n9x21x24\r\n7x18x21\r\n14x3x15\r\n18x19x19\r\n4x29x17\r\n14x10x9\r\n2x26x14\r\n13x3x24\r\n4x4x17\r\n6x27x24\r\n2x18x3\r\n14x25x2\r\n30x14x17\r\n11x6x14\r\n4x10x18\r\n15x4x2\r\n27x7x10\r\n13x24x1\r\n7x12x6\r\n25x22x26\r\n19x2x18\r\n23x29x2\r\n2x15x4\r\n12x6x9\r\n16x14x29\r\n9x17x3\r\n21x9x12\r\n23x18x22\r\n10x8x4\r\n29x2x7\r\n19x27x15\r\n4x24x27\r\n25x20x14\r\n8x23x19\r\n1x24x19\r\n6x20x10\r\n15x8x5\r\n18x28x5\r\n17x23x22\r\n9x16x13\r\n30x24x4\r\n26x3x13\r\n12x22x18\r\n29x17x29\r\n26x4x16\r\n15x7x20\r\n9x15x30\r\n12x7x18\r\n28x19x18\r\n11x23x23\r\n24x20x1\r\n20x3x24\r\n1x26x1\r\n14x10x6\r\n5x27x24\r\n13x21x12\r\n20x20x5\r\n6x28x9\r\n11x26x11\r\n26x29x12\r\n21x4x11\r\n20x11x17\r\n22x27x20\r\n19x11x21\r\n2x11x11\r\n13x5x7\r\n12x10x25\r\n21x28x1\r\n15x30x17\r\n28x19x1\r\n4x19x12\r\n11x4x12\r\n4x10x30\r\n11x18x5\r\n22x20x12\r\n3x7x27\r\n20x26x4\r\n13x27x26\r\n23x14x13\r\n4x19x7\r\n26x27x16\r\n20x5x20\r\n18x5x8\r\n19x21x1\r\n22x8x1\r\n29x4x1\r\n24x10x15\r\n24x9x20\r\n10x3x8\r\n29x30x3\r\n2x8x24\r\n16x7x18\r\n2x11x23\r\n23x15x16\r\n21x12x6\r\n24x28x9\r\n6x1x13\r\n14x29x20\r\n27x24x13\r\n16x26x8\r\n5x6x17\r\n21x8x1\r\n28x19x21\r\n1x14x16\r\n18x2x9\r\n29x28x10\r\n22x26x27\r\n18x26x23\r\n22x24x2\r\n28x26x1\r\n27x29x12\r\n30x13x11\r\n1x25x5\r\n13x30x18\r\n3x13x22\r\n22x10x11\r\n2x7x7\r\n18x17x8\r\n9x22x26\r\n30x18x16\r\n10x2x3\r\n7x27x13\r\n3x20x16\r\n9x21x16\r\n1x18x15\r\n21x30x30\r\n4x25x23\r\n3x11x7\r\n5x6x12\r\n27x1x20\r\n13x15x24\r\n23x29x2\r\n13x5x24\r\n22x16x15\r\n28x14x3\r\n29x24x9\r\n2x20x4\r\n30x10x4\r\n23x7x20\r\n22x12x21\r\n3x19x11\r\n4x28x28\r\n5x4x7\r\n28x12x25\r\n2x16x26\r\n23x20x7\r\n5x21x29\r\n9x21x16\r\n9x6x10\r\n9x6x4\r\n24x14x29\r\n28x11x6\r\n10x22x1\r\n21x30x20\r\n13x17x8\r\n2x25x24\r\n19x21x3\r\n28x8x14\r\n6x29x28\r\n27x10x28\r\n30x11x12\r\n17x2x10\r\n14x19x17\r\n2x11x4\r\n26x1x2\r\n13x4x4\r\n23x20x18\r\n2x17x21\r\n28x7x15\r\n3x3x27\r\n24x17x30\r\n28x28x20\r\n21x5x29\r\n13x12x19\r\n24x29x29\r\n19x10x6\r\n19x12x14\r\n21x4x17\r\n27x16x1\r\n4x17x30\r\n23x23x18\r\n23x15x27\r\n26x2x11\r\n12x8x8\r\n15x23x26\r\n30x17x15\r\n17x17x15\r\n24x4x30\r\n9x9x10\r\n14x25x20\r\n25x11x19\r\n20x7x1\r\n9x21x3\r\n7x19x9\r\n10x6x19\r\n26x12x30\r\n21x9x20\r\n15x11x6\r\n30x21x9\r\n10x18x17\r\n22x9x8\r\n8x30x26\r\n28x12x27\r\n17x17x7\r\n11x13x8\r\n5x3x21\r\n24x1x29\r\n1x28x2\r\n18x28x10\r\n8x29x14\r\n26x26x27\r\n17x10x25\r\n22x30x3\r\n27x9x13\r\n21x21x4\r\n30x29x16\r\n22x7x20\r\n24x10x2\r\n16x29x17\r\n28x15x17\r\n19x19x22\r\n9x8x6\r\n26x23x24\r\n25x4x27\r\n16x12x2\r\n11x6x18\r\n19x14x8\r\n9x29x13\r\n23x30x19\r\n10x16x1\r\n4x21x28\r\n23x25x25\r\n19x9x16\r\n30x11x12\r\n24x3x9\r\n28x19x4\r\n18x12x9\r\n7x1x25\r\n28x7x1\r\n24x3x12\r\n30x24x22\r\n27x24x26\r\n9x30x30\r\n29x10x8\r\n4x6x18\r\n10x1x15\r\n10x4x26\r\n23x20x16\r\n6x3x14\r\n30x8x16\r\n25x14x20\r\n11x9x3\r\n15x23x25\r\n8x30x22\r\n22x19x18\r\n25x1x12\r\n27x25x7\r\n25x23x3\r\n13x20x8\r\n5x30x7\r\n18x19x27\r\n20x23x3\r\n1x17x21\r\n21x21x27\r\n13x1x24\r\n7x30x20\r\n21x9x18\r\n23x26x6\r\n22x9x29\r\n17x6x21\r\n28x28x29\r\n19x25x26\r\n9x27x21\r\n5x26x8\r\n11x19x1\r\n10x1x18\r\n29x4x8\r\n21x2x22\r\n14x12x8";
            string replaced = numbers.Replace("\r\n", "x");

            string[] numbers2 = replaced.Split('x');

            var numbersInt = Array.ConvertAll(numbers2, int.Parse);

            List<int> numbersList = new List<int>();

            var sum = 0;

            for (int i = 0; i < numbersInt.Length; i += 3)
            {

                if (numbersInt[i + 2] <= numbersInt.Length)
                {

                    int firstSide = numbersInt[i];
                    int secondSide = numbersInt[i + 1];
                    int thirdSide = numbersInt[i + 2];

                    int smallestSideMath = Math.Min(firstSide, Math.Min(secondSide, thirdSide));
                    int secondSmallestSideMath;

                    if (smallestSideMath == firstSide)
                    {
                        secondSmallestSideMath = Math.Min(secondSide, thirdSide);
                    }

                    else if (smallestSideMath == secondSide)
                    {
                        secondSmallestSideMath = Math.Min(firstSide, thirdSide);
                    }

                    else
                    {
                        secondSmallestSideMath = Math.Min(firstSide, secondSide);
                    }

                    var ribbonLength = (smallestSideMath * 2) + (secondSmallestSideMath * 2);
                    var bow = firstSide * secondSide * thirdSide;

                    sum += ribbonLength + bow;

                    //var numbersForSmallest = new List<int> { firstSide, secondSide, thirdSide};



                    //var smallestSide = numbersForSmallest.Min() / 2;




                    //1606483

                }

            }
            Console.WriteLine(sum);

        }

    }
}
