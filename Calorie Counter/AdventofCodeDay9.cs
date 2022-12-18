using System.Drawing;

namespace Calorie_Counter
{
    public class AdventofCodeDay9
    {
        static Point posPos1 = new(1,2), posPos2 = new(2, 1), posPos3 = new(2, 2);
        static Point negPos1 = new(-1, 2), negPos2 = new(-2, 1), negPos3 = new(-2, 2);
        static Point posNeg1 = new(1,-2), posNeg2 = new(2, -1), posNeg3 = new(2, -2);
        static Point negNeg1 = new(-1,-2), negNeg2 = new(-2, -1), negNeg3 = new(-2, -2);
        public static void RopeBridge()
        {
            var movements = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day9.txt");
            int totalMovements = 0,arrPos = 0;
            foreach(string movement in movements)
            {
                totalMovements += Int32.Parse(movement.Substring(2));
            }
            Point[] snake = new Point[10];
            snake[0] = new Point(0,0);
            for (int i = 1; i < snake.Length;i++ )
                snake[i] = snake[0];
            Point[] visited2 = new Point[totalMovements];
            Point[] visited10 = new Point[totalMovements];
            foreach (string movement in movements)
            {
                for (int i = 0; i < Int32.Parse(movement.Substring(2)); i++)
                {
                    // Head Movement
                    switch (movement[0])
                    {
                        case 'U':
                            snake[0].Y++;
                            break;
                        case 'L':
                            snake[0].X--;
                            break;
                        case 'R':
                            snake[0].X++;
                            break;
                        case 'D':
                            snake[0].Y--;
                            break;
                    }
                    //Connection Movements
                    for (int j = 1; j < snake.Length; j++)              //Calculating ten connection Points
                        snake[j] = TailMovement(snake[j - 1], snake[j]);                    
                    visited2[arrPos] = snake[1];
                    visited10[arrPos] = snake[9];
                    arrPos++;
                }
            }
            int uniqueVisited2 = 0, uniqueVisited10 = 0;
            foreach (Point point in visited2.Distinct())
                uniqueVisited2++;
            foreach (Point point in visited10.Distinct())
                uniqueVisited10++;
            Console.WriteLine($"The amount of unique visited points on a two point rope is {uniqueVisited2}.");
            Console.WriteLine($"The amount of unique visited points on a ten point rope is {uniqueVisited10}.");
            Console.ReadKey();            
        }
        public static Point TailMovement(Point head, Point tail)
        {
            Point diff = new(head.X - tail.X,head.Y-tail.Y);
            // Diagonal Check
            if (Math.Abs(diff.Y) >=1 && Math.Abs(diff.X) >= 1 && diff.X != diff.Y || (Math.Abs(diff.Y) > 1 && Math.Abs(diff.X) > 1))
            {
                //Diag Up-Right
                if (diff.Equals(posPos1) || diff.Equals(posPos2) || diff.Equals(posPos3))
                    tail.Offset(new Point(1, 1));
                //Diag Up-Left
                else if (diff.Equals(negPos1) || diff.Equals(negPos2) || diff.Equals(negPos3))
                    tail.Offset(new Point(-1, 1));
                //Diag Down-Left
                else if (diff.Equals(negNeg1) || diff.Equals(negNeg2) || diff.Equals(negNeg3))
                    tail.Offset(new Point(-1, -1));
                //Diag Down-Right
                else if (diff.Equals(posNeg1) || diff.Equals(posNeg2) || diff.Equals(posNeg3))
                    tail.Offset(new Point(1, -1));
            }
            // Vertical Check
            else if (Math.Abs(diff.Y) > 1)
            {
                switch(diff.Y)
                {
                    default:
                        Console.WriteLine("Error");
                        break;
                    case -2:
                        tail.Y--;
                        break;
                    case 2:
                        tail.Y++;
                        break;
                }
            }
            // Horizontal Check
            else if (Math.Abs(diff.X) > 1)
            {
                switch (diff.X)
                {
                    default:
                        Console.WriteLine("Error");
                        break;
                    case -2:
                        tail.X--;
                        break;
                    case 2:
                        tail.X++;
                        break;
                }
            }
            return tail;
        }
    }
}
