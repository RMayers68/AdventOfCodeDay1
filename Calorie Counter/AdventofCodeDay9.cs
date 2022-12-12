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
            string day9Input = "D 2\r\nU 2\r\nL 2\r\nR 1\r\nL 1\r\nU 1\r\nL 2\r\nD 1\r\nL 2\r\nD 1\r\nL 2\r\nD 2\r\nL 1\r\nR 2\r\nU 1\r\nR 1\r\nU 2\r\nR 1\r\nU 2\r\nD 1\r\nL 2\r\nU 1\r\nD 1\r\nL 1\r\nD 1\r\nU 1\r\nR 2\r\nD 2\r\nL 1\r\nR 1" +
                "\r\nL 2\r\nD 1\r\nR 2\r\nD 1\r\nU 2\r\nD 2\r\nR 2\r\nL 2\r\nU 2\r\nR 2\r\nL 1\r\nD 1\r\nR 1\r\nU 1\r\nR 2\r\nL 1\r\nD 1\r\nR 1\r\nL 2\r\nD 2\r\nU 1\r\nL 1\r\nR 1\r\nU 1\r\nL 2\r\nD 2\r\nL 2\r\nU 1\r\nL 2\r\nR 1\r\nL 1" +
                "\r\nR 1\r\nD 1\r\nR 2\r\nD 1\r\nR 1\r\nD 1\r\nU 1\r\nL 1\r\nR 1\r\nL 1\r\nR 1\r\nD 2\r\nL 1\r\nD 2\r\nR 1\r\nD 1\r\nU 2\r\nR 2\r\nU 2\r\nL 1\r\nU 1\r\nR 1\r\nL 2\r\nD 2\r\nR 1\r\nU 1\r\nL 1\r\nU 2\r\nL 1\r\nD 2\r\nR 1" +
                "\r\nU 1\r\nR 1\r\nU 2\r\nR 1\r\nU 2\r\nL 1\r\nR 1\r\nU 2\r\nR 2\r\nU 1\r\nL 2\r\nR 1\r\nL 2\r\nU 2\r\nL 2\r\nU 2\r\nR 2\r\nD 1\r\nU 2\r\nL 2\r\nD 3\r\nU 1\r\nL 1\r\nR 1\r\nD 3\r\nU 1\r\nL 3\r\nR 1\r\nU 1\r\nR 3\r\nD 2" +
                "\r\nU 1\r\nR 2\r\nL 2\r\nU 1\r\nD 1\r\nU 1\r\nD 1\r\nL 2\r\nU 2\r\nR 3\r\nD 2\r\nL 2\r\nD 2\r\nU 3\r\nD 3\r\nU 2\r\nL 1\r\nU 2\r\nR 3\r\nD 2\r\nR 2\r\nD 1\r\nU 3\r\nL 3\r\nD 1\r\nU 3\r\nR 3\r\nD 1\r\nL 1\r\nD 3\r\nU 3" +
                "\r\nD 1\r\nU 2\r\nR 1\r\nD 2\r\nU 3\r\nD 1\r\nR 2\r\nD 3\r\nL 3\r\nR 1\r\nD 3\r\nL 2\r\nD 3\r\nU 3\r\nR 1\r\nU 3\r\nL 2\r\nU 2\r\nL 2\r\nD 3\r\nL 3\r\nU 2\r\nR 2\r\nL 3\r\nR 2\r\nU 3\r\nR 3\r\nL 1\r\nU 3\r\nD 3\r\nL 2" +
                "\r\nD 2\r\nU 2\r\nD 3\r\nL 3\r\nD 2\r\nL 1\r\nU 3\r\nD 2\r\nR 3\r\nL 3\r\nR 1\r\nU 1\r\nD 1\r\nR 2\r\nL 3\r\nU 2\r\nD 1\r\nR 3\r\nL 1\r\nR 1\r\nL 2\r\nR 1\r\nU 3\r\nR 2\r\nU 1\r\nL 1\r\nR 3\r\nD 3\r\nU 2\r\nR 2\r\nD 1" +
                "\r\nR 3\r\nD 2\r\nL 3\r\nR 1\r\nU 3\r\nR 2\r\nU 4\r\nL 2\r\nD 1\r\nU 1\r\nR 4\r\nU 2\r\nR 2\r\nU 3\r\nR 1\r\nL 3\r\nU 3\r\nR 3\r\nU 4\r\nR 4\r\nD 1\r\nU 2\r\nR 1\r\nL 1\r\nR 2\r\nU 4\r\nL 1\r\nU 2\r\nL 1\r\nR 3\r\nL 2" +
                "\r\nD 4\r\nR 4\r\nD 3\r\nR 4\r\nU 1\r\nD 4\r\nR 2\r\nD 1\r\nR 4\r\nU 3\r\nR 4\r\nL 1\r\nU 4\r\nD 2\r\nL 1\r\nD 3\r\nL 1\r\nR 2\r\nL 2\r\nD 4\r\nU 3\r\nD 1\r\nL 3\r\nD 3\r\nU 3\r\nL 4\r\nR 3\r\nU 1\r\nR 2\r\nD 1\r\nU 4" +
                "\r\nD 4\r\nR 4\r\nU 2\r\nR 4\r\nL 4\r\nD 2\r\nL 4\r\nD 2\r\nU 3\r\nD 2\r\nU 4\r\nR 1\r\nU 1\r\nL 1\r\nU 1\r\nL 1\r\nD 3\r\nU 4\r\nL 3\r\nU 1\r\nL 4\r\nR 4\r\nL 3\r\nR 2\r\nU 2\r\nL 3\r\nD 2\r\nU 1\r\nD 1\r\nU 4\r\nR 2" +
                "\r\nL 2\r\nD 1\r\nL 4\r\nD 3\r\nU 3\r\nL 2\r\nU 4\r\nR 4\r\nL 2\r\nR 3\r\nL 1\r\nD 4\r\nU 1\r\nL 2\r\nD 4\r\nL 2\r\nD 3\r\nU 4\r\nR 4\r\nU 2\r\nR 2\r\nU 4\r\nD 3\r\nU 3\r\nL 4\r\nD 2\r\nR 1\r\nU 4\r\nR 1\r\nU 1\r\nD 3" +
                "\r\nU 1\r\nL 5\r\nU 5\r\nR 2\r\nD 3\r\nU 5\r\nD 5\r\nU 1\r\nD 2\r\nL 2\r\nU 5\r\nL 1\r\nR 5\r\nL 1\r\nD 5\r\nL 4\r\nD 4\r\nR 4\r\nL 1\r\nR 1\r\nU 1\r\nR 4\r\nU 2\r\nR 5\r\nL 4\r\nR 3\r\nU 4\r\nR 2\r\nU 4\r\nL 4\r\nU 3" +
                "\r\nL 3\r\nU 1\r\nL 4\r\nR 1\r\nU 3\r\nR 3\r\nL 5\r\nU 5\r\nL 4\r\nD 1\r\nL 2\r\nU 1\r\nD 2\r\nL 1\r\nU 5\r\nD 4\r\nU 1\r\nR 2\r\nD 2\r\nU 5\r\nR 5\r\nU 1\r\nL 3\r\nU 5\r\nL 4\r\nR 3\r\nU 4\r\nL 2\r\nR 4\r\nD 2\r\nL 2" +
                "\r\nR 4\r\nU 2\r\nD 4\r\nR 3\r\nD 4\r\nU 1\r\nL 3\r\nR 4\r\nL 3\r\nU 1\r\nR 2\r\nU 3\r\nL 3\r\nD 2\r\nU 4\r\nR 1\r\nL 3\r\nD 4\r\nL 1\r\nR 1\r\nD 5\r\nR 1\r\nU 2\r\nD 1\r\nU 4\r\nL 2\r\nU 2\r\nR 4\r\nU 3\r\nR 3\r\nD 2" +
                "\r\nR 5\r\nD 2\r\nU 5\r\nD 5\r\nU 2\r\nD 1\r\nR 5\r\nU 3\r\nL 3\r\nU 1\r\nR 5\r\nL 4\r\nD 6\r\nL 1\r\nU 2\r\nD 4\r\nU 6\r\nD 6\r\nR 1\r\nU 3\r\nL 5\r\nR 5\r\nU 2\r\nR 2\r\nL 5\r\nD 4\r\nL 3\r\nR 1\r\nU 4\r\nD 3\r\nL 2" +
                "\r\nD 5\r\nL 3\r\nR 3\r\nD 2\r\nL 1\r\nU 5\r\nL 5\r\nD 6\r\nU 3\r\nR 5\r\nL 5\r\nU 2\r\nL 3\r\nU 5\r\nD 6\r\nR 4\r\nL 5\r\nU 6\r\nL 2\r\nR 1\r\nL 1\r\nU 5\r\nD 3\r\nU 2\r\nR 1\r\nU 2\r\nR 2\r\nD 5\r\nR 1\r\nD 5\r\nR 5" +
                "\r\nU 2\r\nL 3\r\nR 1\r\nU 5\r\nD 5\r\nR 2\r\nL 5\r\nD 6\r\nL 1\r\nU 1\r\nD 6\r\nU 4\r\nD 5\r\nL 5\r\nD 3\r\nL 4\r\nD 1\r\nL 4\r\nD 6\r\nR 5\r\nD 6\r\nU 6\r\nD 2\r\nL 3\r\nD 3\r\nR 5\r\nU 6\r\nD 2\r\nU 4\r\nL 1\r\nU 6" +
                "\r\nL 2\r\nU 4\r\nD 6\r\nR 1\r\nD 1\r\nU 2\r\nL 3\r\nD 3\r\nR 2\r\nL 6\r\nU 3\r\nD 5\r\nU 3\r\nL 4\r\nU 5\r\nL 5\r\nU 6\r\nL 3\r\nR 1\r\nU 3\r\nR 1\r\nU 4\r\nL 4\r\nD 5\r\nL 6\r\nR 1\r\nL 3\r\nD 4\r\nL 3\r\nR 1\r\nL 4" +
                "\r\nR 3\r\nD 3\r\nL 1\r\nU 4\r\nD 2\r\nU 5\r\nL 3\r\nD 6\r\nU 2\r\nR 3\r\nD 5\r\nL 1\r\nD 1\r\nL 3\r\nU 2\r\nR 3\r\nL 3\r\nU 7\r\nR 2\r\nD 1\r\nL 3\r\nR 4\r\nD 2\r\nR 5\r\nL 1\r\nD 5\r\nL 2\r\nR 2\r\nU 7\r\nL 7\r\nD 2" +
                "\r\nL 7\r\nD 5\r\nU 2\r\nL 2\r\nU 2\r\nD 4\r\nU 1\r\nD 4\r\nL 1\r\nD 2\r\nR 5\r\nD 3\r\nL 2\r\nU 4\r\nR 7\r\nD 4\r\nR 3\r\nU 2\r\nR 4\r\nL 1\r\nU 4\r\nL 4\r\nU 7\r\nR 1\r\nL 6\r\nD 5\r\nR 5\r\nL 1\r\nR 4\r\nL 1\r\nU 3" +
                "\r\nL 7\r\nR 7\r\nD 4\r\nL 3\r\nR 3\r\nD 1\r\nU 7\r\nR 3\r\nD 2\r\nU 4\r\nD 2\r\nR 3\r\nD 1\r\nR 3\r\nD 3\r\nU 1\r\nR 6\r\nL 2\r\nD 2\r\nU 4\r\nD 5\r\nL 7\r\nR 1\r\nL 7\r\nU 6\r\nD 2\r\nR 3\r\nD 5\r\nU 1\r\nL 7\r\nD 6" +
                "\r\nU 3\r\nD 6\r\nL 1\r\nR 2\r\nL 6\r\nD 7\r\nR 5\r\nU 1\r\nL 7\r\nU 2\r\nD 2\r\nL 5\r\nR 7\r\nD 4\r\nU 3\r\nR 7\r\nL 4\r\nU 8\r\nD 8\r\nR 2\r\nU 2\r\nR 7\r\nU 1\r\nD 7\r\nR 1\r\nL 7\r\nR 7\r\nL 8\r\nD 3\r\nR 5\r\nL 4" +
                "\r\nD 3\r\nL 6\r\nR 6\r\nD 6\r\nL 3\r\nD 5\r\nR 1\r\nU 5\r\nD 7\r\nR 8\r\nU 3\r\nD 5\r\nU 8\r\nL 8\r\nR 6\r\nD 8\r\nU 5\r\nR 1\r\nD 1\r\nR 5\r\nU 2\r\nR 8\r\nD 7\r\nL 3\r\nD 3\r\nU 7\r\nD 3\r\nU 7\r\nR 7\r\nL 4\r\nD 7" +
                "\r\nU 2\r\nL 3\r\nU 7\r\nL 1\r\nD 3\r\nL 1\r\nR 4\r\nD 8\r\nL 5\r\nU 5\r\nD 3\r\nL 5\r\nD 6\r\nL 1\r\nR 5\r\nU 4\r\nR 4\r\nD 1\r\nR 6\r\nL 1\r\nD 7\r\nR 4\r\nL 2\r\nR 3\r\nU 4\r\nL 8\r\nD 1\r\nR 6\r\nL 6\r\nR 8\r\nD 8" +
                "\r\nU 4\r\nR 1\r\nD 2\r\nR 5\r\nD 1\r\nU 8\r\nL 5\r\nD 5\r\nU 5\r\nR 8\r\nL 6\r\nR 4\r\nU 1\r\nR 5\r\nU 8\r\nD 1\r\nU 1\r\nD 5\r\nL 7\r\nR 6\r\nL 3\r\nR 1\r\nU 2\r\nL 6\r\nR 5\r\nD 4\r\nR 6\r\nD 4\r\nR 2\r\nL 7\r\nR 8" +
                "\r\nL 6\r\nD 2\r\nL 8\r\nU 4\r\nR 4\r\nU 3\r\nD 8\r\nU 8\r\nL 8\r\nD 5\r\nR 2\r\nD 5\r\nU 7\r\nL 9\r\nR 8\r\nU 9\r\nR 9\r\nU 6\r\nL 6\r\nD 1\r\nU 3\r\nL 1\r\nD 7\r\nR 6\r\nL 6\r\nD 7\r\nU 1\r\nR 9\r\nD 7\r\nU 8\r\nR 6" +
                "\r\nU 1\r\nD 5\r\nU 5\r\nD 1\r\nL 1\r\nD 9\r\nU 1\r\nR 6\r\nU 9\r\nR 6\r\nU 6\r\nD 7\r\nR 1\r\nL 1\r\nD 8\r\nL 3\r\nD 7\r\nU 8\r\nL 7\r\nD 2\r\nU 6\r\nD 4\r\nL 8\r\nU 3\r\nD 1\r\nU 6\r\nD 3\r\nR 8\r\nL 9\r\nR 3\r\nL 6" +
                "\r\nU 9\r\nD 9\r\nL 3\r\nU 1\r\nD 2\r\nR 4\r\nL 5\r\nR 2\r\nU 3\r\nD 5\r\nR 5\r\nL 4\r\nU 3\r\nL 7\r\nU 5\r\nD 9\r\nU 6\r\nR 5\r\nD 3\r\nU 8\r\nL 6\r\nD 5\r\nR 9\r\nU 8\r\nL 5\r\nD 1\r\nR 8\r\nL 4\r\nR 2\r\nL 3\r\nR 9" +
                "\r\nD 9\r\nR 7\r\nD 5\r\nR 6\r\nU 2\r\nD 4\r\nL 8\r\nD 2\r\nL 1\r\nD 2\r\nU 3\r\nL 2\r\nR 3\r\nD 9\r\nU 3\r\nR 4\r\nD 1\r\nL 8\r\nR 3\r\nU 4\r\nL 4\r\nR 3\r\nL 5\r\nD 4\r\nR 2\r\nD 4\r\nR 4\r\nU 4\r\nR 7\r\nL 6\r\nR 9" +
                "\r\nD 1\r\nR 8\r\nL 5\r\nU 4\r\nD 10\r\nL 6\r\nD 3\r\nR 2\r\nU 1\r\nD 5\r\nR 2\r\nU 6\r\nL 9\r\nU 7\r\nL 10\r\nU 4\r\nL 8\r\nD 3\r\nU 7\r\nD 7\r\nU 9\r\nL 2\r\nR 6\r\nU 4\r\nR 9\r\nL 5\r\nU 3\r\nL 4\r\nR 1\r\nD 8\r\nU 10" +
                "\r\nD 10\r\nR 3\r\nU 3\r\nD 2\r\nL 5\r\nU 3\r\nD 4\r\nU 1\r\nR 9\r\nL 3\r\nD 8\r\nL 5\r\nU 8\r\nR 3\r\nU 10\r\nL 10\r\nR 4\r\nD 5\r\nU 9\r\nR 8\r\nL 5\r\nU 9\r\nL 6\r\nU 10\r\nD 8\r\nU 2\r\nL 8\r\nD 7\r\nU 2\r\nD 5" +
                "\r\nU 8\r\nL 2\r\nD 3\r\nU 8\r\nR 8\r\nD 10\r\nR 3\r\nL 3\r\nU 4\r\nR 3\r\nU 4\r\nL 6\r\nU 4\r\nR 3\r\nD 9\r\nL 9\r\nU 5\r\nD 1\r\nR 3\r\nD 2\r\nL 9\r\nU 9\r\nR 9\r\nU 6\r\nR 7\r\nL 8\r\nU 2\r\nL 4\r\nD 10\r\nL 4\r\nD 9" +
                "\r\nL 9\r\nR 10\r\nL 3\r\nR 7\r\nU 2\r\nL 3\r\nR 1\r\nD 4\r\nL 2\r\nR 10\r\nD 5\r\nL 2\r\nD 2\r\nL 4\r\nU 6\r\nD 9\r\nR 6\r\nU 9\r\nD 4\r\nL 6\r\nU 8\r\nD 1\r\nR 1\r\nL 10\r\nU 4\r\nR 6\r\nU 11\r\nR 8\r\nU 1\r\nD 5\r\nR 7" +
                "\r\nD 8\r\nL 5\r\nR 6\r\nU 5\r\nR 1\r\nU 7\r\nL 4\r\nD 6\r\nU 8\r\nR 10\r\nD 1\r\nL 8\r\nR 3\r\nU 7\r\nR 2\r\nU 9\r\nD 9\r\nR 9\r\nL 3\r\nR 4\r\nU 10\r\nL 7\r\nR 1\r\nL 5\r\nD 11\r\nR 4\r\nU 10\r\nR 10\r\nL 3\r\nD 2\r\nL 4" +
                "\r\nU 9\r\nL 1\r\nD 10\r\nL 7\r\nR 11\r\nD 5\r\nU 3\r\nD 10\r\nU 5\r\nL 2\r\nR 9\r\nD 10\r\nU 1\r\nR 10\r\nU 1\r\nL 11\r\nR 10\r\nL 8\r\nD 10\r\nL 5\r\nR 2\r\nL 3\r\nU 4\r\nL 10\r\nR 3\r\nD 5\r\nR 8\r\nL 2\r\nU 1\r\nD 7" +
                "\r\nU 7\r\nL 1\r\nU 11\r\nD 2\r\nL 2\r\nD 11\r\nL 6\r\nR 9\r\nU 10\r\nR 7\r\nL 11\r\nR 7\r\nD 1\r\nR 3\r\nU 6\r\nR 7\r\nD 8\r\nU 3\r\nL 1\r\nD 11\r\nU 7\r\nR 1\r\nL 7\r\nR 2\r\nL 7\r\nD 3\r\nU 10\r\nD 9\r\nU 10\r\nR 5" +
                "\r\nD 4\r\nU 7\r\nL 11\r\nU 1\r\nL 12\r\nR 10\r\nU 7\r\nR 3\r\nL 2\r\nU 11\r\nR 6\r\nU 8\r\nD 2\r\nR 2\r\nL 8\r\nU 7\r\nD 10\r\nU 3\r\nD 1\r\nU 8\r\nR 2\r\nD 9\r\nL 8\r\nR 10\r\nL 1\r\nU 8\r\nR 11\r\nU 8\r\nR 12\r\nD 10" +
                "\r\nL 5\r\nU 6\r\nL 11\r\nD 12\r\nL 5\r\nU 4\r\nL 8\r\nU 11\r\nD 2\r\nU 4\r\nL 6\r\nR 1\r\nL 4\r\nU 2\r\nL 5\r\nR 2\r\nD 7\r\nL 12\r\nR 4\r\nL 1\r\nD 7\r\nL 11\r\nU 3\r\nD 9\r\nR 12\r\nU 10\r\nD 9\r\nU 10\r\nL 6\r\nR 6" +
                "\r\nD 10\r\nR 10\r\nD 5\r\nU 9\r\nR 2\r\nD 4\r\nL 9\r\nU 2\r\nR 5\r\nL 8\r\nR 1\r\nD 9\r\nL 7\r\nD 11\r\nR 3\r\nL 8\r\nU 3\r\nD 7\r\nU 3\r\nR 8\r\nU 7\r\nL 1\r\nU 10\r\nD 8\r\nR 11\r\nU 10\r\nD 11\r\nU 8\r\nR 12\r\nU 9" +
                "\r\nD 12\r\nU 4\r\nD 11\r\nR 8\r\nD 1\r\nL 4\r\nR 9\r\nL 7\r\nU 8\r\nR 6\r\nD 5\r\nR 8\r\nD 2\r\nR 6\r\nL 4\r\nD 7\r\nL 3\r\nU 11\r\nR 2\r\nL 10\r\nD 13\r\nR 2\r\nD 10\r\nU 9\r\nD 5\r\nU 5\r\nD 5\r\nL 11\r\nU 3\r\nR 5" +
                "\r\nU 7\r\nL 6\r\nD 4\r\nL 3\r\nR 2\r\nD 9\r\nU 7\r\nD 9\r\nU 1\r\nD 8\r\nL 11\r\nD 7\r\nU 7\r\nR 3\r\nL 6\r\nD 6\r\nR 5\r\nL 6\r\nR 3\r\nU 10\r\nL 13\r\nU 9\r\nR 11\r\nL 13\r\nR 9\r\nD 3\r\nU 3\r\nL 12\r\nU 4\r\nL 3" +
                "\r\nD 12\r\nR 13\r\nD 7\r\nU 6\r\nL 11\r\nU 4\r\nL 2\r\nD 7\r\nL 8\r\nR 10\r\nU 13\r\nR 9\r\nU 8\r\nR 11\r\nU 8\r\nR 7\r\nU 11\r\nL 8\r\nD 3\r\nL 4\r\nU 6\r\nD 12\r\nR 13\r\nU 10\r\nL 4\r\nR 12\r\nU 13\r\nL 11\r\nR 10" +
                "\r\nL 8\r\nU 6\r\nL 1\r\nD 11\r\nU 12\r\nL 8\r\nU 2\r\nL 6\r\nU 2\r\nL 1\r\nU 3\r\nD 5\r\nU 2\r\nD 10\r\nU 11\r\nL 9\r\nD 9\r\nR 7\r\nL 3\r\nU 3\r\nD 2\r\nU 2\r\nR 10\r\nD 1\r\nR 5\r\nL 1\r\nD 3\r\nR 8\r\nU 4\r\nR 1" +
                "\r\nD 13\r\nL 12\r\nU 1\r\nD 13\r\nR 4\r\nD 3\r\nR 8\r\nD 2\r\nU 3\r\nD 8\r\nL 3\r\nU 9\r\nR 4\r\nD 8\r\nU 9\r\nD 3\r\nL 8\r\nD 11\r\nL 8\r\nU 1\r\nD 13\r\nU 14\r\nD 10\r\nU 9\r\nR 4\r\nD 14\r\nL 10\r\nD 10\r\nU 6\r\nD 7" +
                "\r\nR 8\r\nU 5\r\nL 8\r\nR 9\r\nD 12\r\nL 9\r\nD 8\r\nR 13\r\nL 7\r\nU 11\r\nR 8\r\nD 5\r\nU 14\r\nD 5\r\nU 9\r\nL 7\r\nD 12\r\nR 2\r\nL 14\r\nU 1\r\nR 9\r\nU 10\r\nR 4\r\nU 4\r\nR 14\r\nD 10\r\nL 3\r\nR 4\r\nL 13\r\nU 3" +
                "\r\nR 6\r\nL 2\r\nU 6\r\nR 2\r\nD 10\r\nU 4\r\nL 10\r\nU 8\r\nL 6\r\nD 2\r\nR 1\r\nD 5\r\nU 14\r\nL 4\r\nD 5\r\nL 5\r\nU 10\r\nD 5\r\nR 13\r\nD 14\r\nU 14\r\nR 4\r\nD 13\r\nU 10\r\nR 13\r\nD 12\r\nR 10\r\nL 12\r\nU 8" +
                "\r\nD 10\r\nU 12\r\nD 5\r\nL 11\r\nD 13\r\nR 8\r\nD 10\r\nR 13\r\nL 13\r\nD 1\r\nU 10\r\nL 4\r\nU 14\r\nD 12\r\nU 4\r\nD 5\r\nR 10\r\nL 8\r\nR 13\r\nD 13\r\nU 5\r\nD 4\r\nL 1\r\nD 9\r\nL 14\r\nU 14\r\nR 3\r\nU 6\r\nR 14" +
                "\r\nL 4\r\nR 7\r\nD 3\r\nR 8\r\nD 5\r\nL 2\r\nU 5\r\nD 8\r\nU 3\r\nR 7\r\nD 13\r\nU 14\r\nR 11\r\nU 6\r\nL 15\r\nR 4\r\nU 12\r\nR 1\r\nL 8\r\nU 15\r\nR 5\r\nL 2\r\nD 1\r\nR 12\r\nD 1\r\nR 12\r\nD 1\r\nL 1\r\nR 9\r\nU 11" +
                "\r\nD 2\r\nU 12\r\nD 3\r\nU 6\r\nD 12\r\nU 11\r\nR 6\r\nD 11\r\nL 5\r\nR 3\r\nD 1\r\nU 7\r\nL 10\r\nD 4\r\nL 7\r\nR 2\r\nU 8\r\nD 11\r\nL 12\r\nR 6\r\nL 7\r\nD 13\r\nU 11\r\nR 5\r\nD 1\r\nL 11\r\nD 2\r\nU 15\r\nL 11" +
                "\r\nR 3\r\nL 9\r\nD 12\r\nU 8\r\nD 9\r\nL 14\r\nD 10\r\nL 12\r\nR 13\r\nD 3\r\nL 9\r\nD 13\r\nR 8\r\nD 15\r\nU 14\r\nR 9\r\nU 12\r\nR 2\r\nD 3\r\nU 5\r\nL 3\r\nR 7\r\nU 15\r\nR 10\r\nL 6\r\nR 6\r\nD 12\r\nR 14\r\nL 7" +
                "\r\nU 8\r\nL 11\r\nR 13\r\nU 8\r\nL 8\r\nR 5\r\nD 3\r\nU 8\r\nD 4\r\nL 1\r\nD 11\r\nU 15\r\nL 14\r\nR 8\r\nL 1\r\nR 13\r\nL 2\r\nR 13\r\nU 9\r\nD 12\r\nL 14\r\nR 13\r\nL 5\r\nR 7\r\nD 13\r\nU 15\r\nR 2\r\nL 12\r\nD 12" +
                "\r\nR 13\r\nU 2\r\nD 4\r\nR 14\r\nL 1\r\nU 12\r\nD 3\r\nU 6\r\nR 6\r\nL 6\r\nU 9\r\nL 16\r\nU 16\r\nD 8\r\nR 8\r\nU 1\r\nD 14\r\nR 13\r\nD 3\r\nU 14\r\nR 7\r\nU 7\r\nR 7\r\nD 12\r\nU 1\r\nD 2\r\nU 2\r\nR 7\r\nD 11\r\nU 4" +
                "\r\nR 13\r\nU 2\r\nL 16\r\nU 12\r\nL 15\r\nD 10\r\nU 11\r\nL 1\r\nD 1\r\nL 3\r\nD 15\r\nL 12\r\nR 2\r\nD 12\r\nU 16\r\nR 16\r\nU 11\r\nD 15\r\nR 11\r\nU 13\r\nL 3\r\nR 15\r\nD 16\r\nR 9\r\nD 1\r\nL 3\r\nU 9\r\nD 12\r\nU 11" +
                "\r\nL 13\r\nR 10\r\nD 4\r\nU 12\r\nL 2\r\nR 8\r\nL 1\r\nU 9\r\nL 1\r\nD 7\r\nR 14\r\nU 12\r\nL 9\r\nR 5\r\nD 7\r\nR 10\r\nD 14\r\nL 2\r\nU 2\r\nL 4\r\nD 15\r\nU 7\r\nD 9\r\nL 4\r\nR 1\r\nL 8\r\nD 14\r\nU 9\r\nD 1\r\nR 15" +
                "\r\nU 9\r\nR 10\r\nD 11\r\nL 14\r\nR 12\r\nL 12\r\nU 13\r\nR 12\r\nL 1\r\nR 10\r\nD 14\r\nR 3\r\nU 5\r\nD 10\r\nL 13\r\nU 11\r\nR 16\r\nL 14\r\nU 6\r\nD 5\r\nR 16\r\nD 7\r\nL 16\r\nU 12\r\nR 14\r\nU 7\r\nR 6\r\nU 17" +
                "\r\nR 3\r\nU 15\r\nR 17\r\nU 3\r\nR 4\r\nU 6\r\nD 13\r\nU 7\r\nR 12\r\nU 10\r\nR 7\r\nL 13\r\nU 16\r\nD 13\r\nU 2\r\nL 13\r\nR 2\r\nD 1\r\nU 10\r\nR 6\r\nD 11\r\nR 10\r\nD 6\r\nR 2\r\nL 1\r\nR 1\r\nL 5\r\nD 16\r\nU 1" +
                "\r\nL 13\r\nU 3\r\nR 9\r\nL 10\r\nD 12\r\nR 9\r\nU 17\r\nR 10\r\nU 1\r\nD 13\r\nL 13\r\nR 6\r\nL 5\r\nD 5\r\nR 15\r\nD 15\r\nL 7\r\nU 11\r\nD 1\r\nU 11\r\nL 17\r\nR 5\r\nL 11\r\nR 15\r\nU 16\r\nD 2\r\nL 5\r\nD 9\r\nR 13" +
                "\r\nD 14\r\nU 6\r\nL 10\r\nU 15\r\nD 15\r\nR 5\r\nD 4\r\nL 13\r\nR 11\r\nD 15\r\nU 13\r\nR 8\r\nU 6\r\nR 8\r\nU 3\r\nR 12\r\nU 11\r\nL 6\r\nU 9\r\nD 6\r\nL 1\r\nU 4\r\nL 6\r\nR 4\r\nD 2\r\nL 6\r\nU 11\r\nL 1\r\nU 10\r\nR 2" +
                "\r\nU 6\r\nR 1\r\nU 7\r\nR 16\r\nL 12\r\nU 9\r\nD 9\r\nU 6\r\nR 13\r\nU 8\r\nL 6\r\nU 2\r\nR 17\r\nL 6\r\nU 5\r\nD 14\r\nR 15\r\nD 13\r\nL 5\r\nU 18\r\nR 9\r\nL 10\r\nR 9\r\nD 6\r\nL 8\r\nU 3\r\nD 8\r\nR 17\r\nL 4\r\nR 9" +
                "\r\nL 13\r\nU 3\r\nR 12\r\nD 4\r\nR 11\r\nU 13\r\nL 15\r\nR 13\r\nD 18\r\nR 8\r\nL 7\r\nR 10\r\nD 11\r\nU 8\r\nR 4\r\nL 7\r\nU 15\r\nL 3\r\nD 15\r\nR 3\r\nU 6\r\nL 17\r\nD 17\r\nL 12\r\nD 16\r\nR 14\r\nL 1\r\nR 7\r\nD 15" +
                "\r\nU 2\r\nL 5\r\nU 16\r\nD 7\r\nL 11\r\nU 1\r\nR 2\r\nD 4\r\nL 13\r\nU 17\r\nR 5\r\nD 17\r\nR 14\r\nL 1\r\nD 11\r\nU 11\r\nR 8\r\nU 12\r\nD 12\r\nU 17\r\nR 15\r\nL 4\r\nD 7\r\nU 8\r\nR 4\r\nL 14\r\nU 11\r\nL 3\r\nR 1" +
                "\r\nL 14\r\nU 3\r\nL 3\r\nD 15\r\nL 14\r\nD 7\r\nR 2\r\nL 6\r\nU 6\r\nR 12\r\nU 17\r\nD 1\r\nR 15\r\nD 1\r\nU 14\r\nD 6\r\nU 4\r\nR 4\r\nL 3\r\nU 14\r\nL 1\r\nR 4\r\nU 13\r\nD 18\r\nL 11\r\nU 4\r\nD 9\r\nR 10\r\nU 17" +
                "\r\nR 8\r\nD 12\r\nR 9\r\nL 5\r\nD 6\r\nL 9\r\nR 9\r\nL 17\r\nD 9\r\nR 2\r\nL 4\r\nR 8\r\nD 8\r\nR 8\r\nD 13\r\nR 12\r\nL 13\r\nU 8\r\nD 8\r\nL 16\r\nD 15\r\nU 11\r\nL 8\r\nR 7\r\nD 2\r\nR 6\r\nU 19\r\nD 4\r\nU 7\r\nL 17" +
                "\r\nR 9\r\nU 18\r\nD 4\r\nR 19\r\nL 14\r\nU 8\r\nD 19\r\nL 12\r\nR 14\r\nU 13\r\nD 3\r\nL 8\r\nD 4\r\nR 9\r\nU 18\r\nD 1\r\nU 2\r\nL 16\r\nU 2\r\nD 12\r\nU 5\r\nL 4\r\nD 6\r\nU 14\r\nR 1\r\nL 7\r\nD 7\r\nL 19\r\nD 5\r\nU 16" +
                "\r\nD 15\r\nR 14\r\nU 19\r\nD 19\r\nL 6\r\nR 3\r\nL 14\r\nR 16\r\nL 1\r\nU 4\r\nR 19\r\nU 2\r\nL 3\r\nD 19\r\nL 17\r\nU 13\r\nD 5\r\nL 10\r\nU 18\r\nR 13\r\nD 6\r\nL 17\r\nD 9\r\nR 10\r\nD 8\r\nR 19\r\nL 6\r\nD 7\r\nR 18" +
                "\r\nU 8\r\nL 6\r\nU 18\r\nL 18\r\nD 16\r\nR 8\r\nL 10\r\nR 6\r\nD 1\r\nL 6\r\nU 8\r\nL 19\r\nD 18\r\nU 3\r\nD 17\r\nU 9\r\nR 13\r\nD 18\r\nR 2\r\nL 10\r\nD 17\r\nL 17\r\nU 8\r\nL 13\r\nD 5\r\nL 1\r\nU 10\r\nL 3\r\nR 3" +
                "\r\nD 12\r\nU 11\r\nL 15\r\nD 15";

            string[] movements = day9Input.Split("\r\n");
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
