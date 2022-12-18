namespace Calorie_Counter
{
    public class AdventofCodeDay6
    {
        public static void TuningTrouble()
        {
            string day6Input = File.ReadAllText("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day6.txt");
            int index = 0;
            bool changeSignalCheck = false;
            for (int i = 0; i < day6Input.Length - 3; i++)
            {
                if (changeSignalCheck)
                {
                    string startOfMessage = day6Input.Substring(i, 14);
                    if (startOfMessage.Distinct().Count() == 14)                               // First start of message detector (14 distinct char) 
                    {
                        index = i + 14;
                        Console.WriteLine($"Signal start of message position: {index}, Signal: {startOfMessage}");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    string startOfPacket = day6Input.Substring(i, 4);
                    if (startOfPacket.Distinct().Count() == 4)                                   // First start of packet detector (4 distinct char) 
                    {
                        index = i + 4;
                        Console.WriteLine($"Signal start of packet position: {index}, Signal: {startOfPacket}");
                        changeSignalCheck = true;
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
