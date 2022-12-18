using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    public class AdventofCodeDay14
    {
        public static void RegalithReservoir()
        {
            string[] day14Input = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day14.txt");
            Dictionary<Point, string> map = new();
            map.Add(new Point(500, 0), "+");
            int unitsOfSand = 0;
            bool sandFlowing = true;
            foreach (string day14 in day14Input)
            {
                string[] rocklines = day14.Split(" -> ");
                for (int i = 0; i < rocklines.Length-1; i++)
                {
                    string[] xAndY = rocklines[i].Split(",");
                    int startingX = Int32.Parse(xAndY[0]);
                    int startingY = Int32.Parse(xAndY[1]);
                    int comparisonX = Int32.Parse(rocklines[i + 1].Substring(0, 3));
                    int comparisonY = Int32.Parse(rocklines[i + 1].Substring(4));
                    // Adding rock points to our map
                    if (startingX < comparisonX)
                    {
                        for (int j = startingX; j <= comparisonX; j++)
                        {
                            Point point = new Point(j, startingY);
                            if (!map.ContainsKey(point))
                                map.Add(point, "#");
                        }
                    }
                    else if (startingX > comparisonX)
                    {
                        for (int j = startingX; j >= comparisonX; j--)
                        {
                            Point point = new Point(j, startingY);
                            if (!map.ContainsKey(point))
                                map.Add(point, "#");
                        }
                    }
                    else if (startingY < comparisonY)
                    {
                        for (int j = startingY; j <= comparisonY; j++)
                        {
                            Point point = new Point(startingX, j);
                            if (!map.ContainsKey(point))
                                map.Add(point, "#");
                        }
                    }
                    else
                    {
                        for (int j = startingY; j >= comparisonY; j--)
                        {
                            Point point = new Point(startingX, j);
                            if (!map.ContainsKey(point))
                                map.Add(point, "#");
                        }
                    }
                }               
            }
            for (int i = 0; i <= 700; i++)
                map.Add(new Point(i, 173), "#");
            while (sandFlowing)
            {
                Point point = new Point(500, 0);
                point = SandMovement(map,point);
                if (point.X == 500 && point.Y == 0)
                    sandFlowing = false;
                if(sandFlowing)
                    map.Add(point, "o");
            }
            for (int i = 0; i <= 173; i++)
            {
                for (int j = 325; j <= 672; j++)
                {
                    Point point = new Point(j, i);
                    if (map.ContainsKey(point))
                    {
                        Console.Write(map[point]);
                        if (map[point] == "o")
                            unitsOfSand++;
                    }                        
                    else Console.Write(".");                        
                }
                Console.Write("\n");
            }    
            Console.WriteLine($"The number of units of sand at rest is {unitsOfSand+1}.");
            Console.ReadLine();
        }

        public static Point SandMovement(Dictionary<Point,string> map,Point point)
        {
            Point down = new Point(point.X, point.Y+1);
            Point left = new Point(point.X-1, point.Y+1);
            Point right = new Point(point.X+1, point.Y+1);
            if (!map.ContainsKey(down))
            {
                if (point.Y >= 172)
                    return point;
                point = SandMovement(map, down);
            }               
            else if (!map.ContainsKey(left))
                point = SandMovement(map,left);
            else if (!map.ContainsKey(right))
                point = SandMovement(map,right);
            else
                return point;
            return point;
        }
    }
}
