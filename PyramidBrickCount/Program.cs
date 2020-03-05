using System;

namespace PyramidBrickCount
{
    public class CountBricks
    {
        public static int CountOfBricks(int pyramidBase, int pyramidHeight, double brickSize)
        {
            int count;

            int area = pyramidBase * pyramidHeight / 2;
            count = Convert.ToInt32(Convert.ToDouble(area) / brickSize);
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPyramidBrickCount.CountBricks.Main()");

            Console.WriteLine($"\treturned count is: {CountOfBricks(100, 30, .17)} bricks!");
            Console.WriteLine($"\treturned count is: {CountOfBricks(1, 1, 1)} bricks!");
        }
    }
}
