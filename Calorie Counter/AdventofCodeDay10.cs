namespace Calorie_Counter
{
    public class AdventofCodeDay10
    {
        public static void CathodeRayTube()
        {
            string day10Input = "noop\r\naddx 12\r\naddx -5\r\naddx -1\r\nnoop\r\naddx 4\r\nnoop\r\naddx 1\r\naddx 4\r\nnoop\r\naddx 13\r\naddx -8\r\nnoop\r\naddx -19\r\naddx 24\r\naddx 1\r\nnoop\r\naddx 4\r\nnoop\r\naddx 1\r\naddx 5" +
                "\r\naddx -1\r\naddx -37\r\naddx 16\r\naddx -13\r\naddx 18\r\naddx -11\r\naddx 2\r\naddx 23\r\nnoop\r\naddx -18\r\naddx 9\r\naddx -8\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx -21\r\naddx 26\r\nnoop\r\naddx -15\r\naddx 20" +
                "\r\nnoop\r\naddx 3\r\nnoop\r\naddx -38\r\naddx 3\r\nnoop\r\naddx 26\r\naddx -4\r\naddx -19\r\naddx 3\r\naddx 1\r\naddx 5\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 5" +
                "\r\nnoop\r\nnoop\r\nnoop\r\naddx 3\r\nnoop\r\naddx -30\r\naddx -4\r\naddx 1\r\naddx 18\r\naddx -8\r\naddx -4\r\naddx 2\r\nnoop\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\naddx 5\r\naddx -2" +
                "\r\naddx -20\r\naddx 27\r\naddx -20\r\naddx 25\r\naddx -2\r\naddx -35\r\nnoop\r\nnoop\r\naddx 4\r\naddx 3\r\naddx -2\r\naddx 5\r\naddx 2\r\naddx -11\r\naddx 1\r\naddx 13\r\naddx 2\r\naddx 5\r\naddx 6\r\naddx -1\r\naddx -2" +
                "\r\nnoop\r\naddx 7\r\naddx -2\r\naddx 6\r\naddx 1\r\naddx -21\r\naddx 22\r\naddx -38\r\naddx 5\r\naddx 3\r\naddx -1\r\nnoop\r\nnoop\r\naddx 5\r\naddx 1\r\naddx 4\r\naddx 3\r\naddx -2\r\naddx 2\r\nnoop\r\naddx 7\r\naddx -1" +
                "\r\naddx 2\r\naddx 4\r\naddx -10\r\naddx -19\r\naddx 35\r\naddx -1\r\nnoop\r\nnoop\r\nnoop";
            string[] signals = day10Input.Split("\r\n");
            int register = 1,cycle = 0,signalStrength = 0;
            foreach(string signal in signals)
            {
                cycle = cycleDraw(cycle,register);
                signalStrength = RegisterCheck(register,cycle, signalStrength);
                switch (signal)
                {
                    default:
                        cycle = cycleDraw(cycle, register);
                        signalStrength = RegisterCheck(register, cycle, signalStrength);
                        register += Int32.Parse(signal.Substring(5));                       
                        break;
                    case "noop":
                        break;
                }
            }
            Console.WriteLine($"The sum of the signal strengths at the requested cycles is {signalStrength}.");
            Console.ReadKey();
        }       
        public static int RegisterCheck(int register,int cycle, int signalStrength)
        {
            int x = cycle / 40;
            if ((x * 40) + 20 == cycle)
                return signalStrength + (cycle * register);
            else return signalStrength;
        }
        public static int cycleDraw(int cycle,int register)
        {
            if (cycle%40 == register - 1 || cycle%40 == register + 1 || cycle%40 == register)
                Console.Write("#");
            else Console.Write(".");
            cycle++;
            if (cycle % 40 == 0)
                Console.Write("\n");
            return cycle;
        }
    }
}
