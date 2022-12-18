namespace Calorie_Counter
{
    public class AdventofCodeDay10
    {
        public static void CathodeRayTube()
        {
            var signals = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day10.txt");
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
