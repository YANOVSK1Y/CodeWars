using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Solutions._4kyu
{
    public static class Path_Finder_1_Сan_you_reach_the_exit
    {
        private static bool PathFinder(int[][] maze, int x = 0, int y = 0) =>
        (x >= 0 && x < maze[0].Length) &&
        (y >= 0 && y < maze.Length) &&
        (maze[y][x] == 0) && (
        (x + 1 == maze[0].Length && y + 1 == maze.Length) ||
        (maze[y][x] = -1) == -1 && (
            PathFinder(maze, x + 1, y) ||
            PathFinder(maze, x - 1, y) ||
            PathFinder(maze, x, y + 1) ||
            PathFinder(maze, x, y - 1)));

        public static bool PathFinder(string maze) =>
            PathFinder(maze.Split('\n').Select(
                line => line.Select(c => '.' - c).ToArray()
            ).ToArray());
        
    }
}
