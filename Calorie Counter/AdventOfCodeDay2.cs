namespace Calorie_Counter
{
    public class AdventOfCodeDay2
    {
        public static void RPSChampionship()
        {
            string rockPaperScissors = "B Z\r\nA Z\r\nB Z\r\nC Z\r\nC Z\r\nB X\r\nA X\r\nC X\r\nA Z\r\nC Y\r\nC X\r\nC Y\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nB X\r\nA Z\r\nA X\r\nC Y\r\nA X\r\nB Z\r\nB Z\r\nA X\r\nC Z\r\nA Z\r\nA X\r\nB Z\r\n" +
                    "A Z\r\nA Y\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nC Y\r\nC Z\r\nC Z\r\nA Z\r\nA X\r\nA X\r\nB X\r\nA Z\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nB X\r\nC Y\r\nA X\r\nB Y\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA Y\r\nA X" +
                    "\r\nC Y\r\nA X\r\nB X\r\nA X\r\nA Z\r\nC Y\r\nA Z\r\nA X\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC Z\r\nB Z\r\nA Z\r\nC Y\r\nC Z\r\nB X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nC Z\r\nB X\r\nA X\r\nA X\r\nA Z\r\nA Y" +
                    "\r\nA X\r\nC X\r\nA Z\r\nB X\r\nC Y\r\nA X\r\nA X\r\nA X\r\nC X\r\nB Z\r\nB Z\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nC X\r\nC Y\r\nB X\r\nC Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA X\r\nA X\r\nA X\r\nA Z\r\nB X\r\nA X\r\nB X\r\nC Z\r\nA Z\r\nA Z" +
                    "\r\nA X\r\nA X\r\nA X\r\nB X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA Z\r\nC Y\r\nB Z\r\nA Z\r\nB Z\r\nA Z\r\nA X\r\nC X\r\nA X\r\nC Y\r\nC X\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA Z\r\nB X" +
                    "\r\nB Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA X\r\nA X\r\nB Z\r\nB X\r\nA Z\r\nA X\r\nA Z\r\nC Y\r\nB Y\r\nC Y\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nA Z" +
                    "\r\nA X\r\nB Z\r\nC X\r\nA X\r\nC Z\r\nC X\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA Y\r\nC Z\r\nA X\r\nA X\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA X" +
                    "\r\nA X\r\nB Y\r\nB X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nB X\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nC Z\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nB Z\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nA Z" +
                    "\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nA X\r\nB Z\r\nC Y\r\nB Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nB Z\r\nB Z\r\nA Z\r\nC X\r\nA X\r\nB Y\r\nA Y\r\nA Z\r\nC X\r\nB X" +
                    "\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nB X\r\nC Z\r\nB X\r\nA Z\r\nB Z\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nC X\r\nC Z\r\nA Z\r\nA X\r\nB Z\r\nA X" +
                    "\r\nC Y\r\nA X\r\nA Z\r\nA Y\r\nC Z\r\nA Y\r\nA Z\r\nC X\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nA X\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nB Z\r\nA X\r\nC X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nC Z\r\nA Z\r\nC Z\r\nC X" +
                    "\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nB X\r\nC Y\r\nB Z\r\nC Y\r\nA X\r\nA X\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nB X\r\nC Z\r\nA Y\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nA Y\r\nA Z\r\nB Z" +
                    "\r\nA Z\r\nA X\r\nC Z\r\nB Y\r\nC Y\r\nA X\r\nA Z\r\nC Z\r\nB Z\r\nA Z\r\nA Z\r\nA Y\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA X\r\nB Y\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nA X\r\nA Z\r\nB X\r\nA X\r\nA X\r\nA Z\r\nA Y" +
                    "\r\nA Z\r\nA X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nC X\r\nB X\r\nB Y\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nB X\r\nA X\r\nB Z\r\nA Y\r\nB Z\r\nC Z\r\nA X\r\nC Z\r\nC X\r\nA Z\r\nC Y\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nA X\r\nB X\r\nA Z" +
                    "\r\nA Y\r\nC Y\r\nB X\r\nA X\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA Y\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nB X\r\nC Y\r\nA Z\r\nB Z\r\nB Z\r\nC Z\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nA Z\r\nA Y" +
                    "\r\nC Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nB Z\r\nA X\r\nB Y\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nB X\r\nA Z\r\nC Y\r\nA Z\r\nC X\r\nC Y\r\nA X\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Z" +
                    "\r\nA Y\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA Z\r\nC Y\r\nC Y\r\nC Z\r\nC Z\r\nC Y\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC Y" +
                    "\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nB Z\r\nB X\r\nA Y\r\nC Y\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nC Y\r\nC Y\r\nA Y\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Y\r\nA Z\r\nA Z\r\nA Z" +
                    "\r\nA Z\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nA X\r\nA X\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nA Y\r\nC Y\r\nA X" +
                    "\r\nA Z\r\nC Z\r\nC Y\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nA X\r\nA Z\r\nC Y\r\nC Y\r\nA Z\r\nB X\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA Y\r\nC Y\r\nC Z\r\nB Z\r\nA Z\r\nC Y\r\nA X\r\nC Z\r\nA X\r\nC Y\r\nC Z\r\nA Z\r\nC Y\r\nC Y\r\nA Y\r\nB X" +
                    "\r\nA Z\r\nC Z\r\nB Z\r\nB Y\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nC Y\r\nA X\r\nA X\r\nC Z\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z" +
                    "\r\nA X\r\nA Z\r\nC Y\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nB X\r\nA Z\r\nA Y\r\nA X\r\nC Z\r\nB X\r\nA Z\r\nC Y\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nA Y\r\nA X\r\nA Z" +
                    "\r\nA Z\r\nC X\r\nB Z\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nC X\r\nA X\r\nC Y\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nB Z\r\nA Z\r\nA Y\r\nB Z\r\nA X\r\nC X\r\nA X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nA X\r\nA X\r\nA X\r\nC Y\r\nA X\r\nA X\r\nC X" +
                    "\r\nC Z\r\nA X\r\nB Y\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nC X\r\nC Z\r\nA X\r\nC Z\r\nC Y\r\nC Y\r\nA X\r\nA X\r\nA X\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nB Z\r\nA Y\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nA Z" +
                    "\r\nC Z\r\nA Z\r\nA X\r\nA X\r\nB Z\r\nA Z\r\nC Y\r\nC Z\r\nB Z\r\nC Y\r\nC Z\r\nA X\r\nA X\r\nC X\r\nB X\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nB Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nB Z\r\nB Z\r\nC Z\r\nA Z" +
                    "\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nA X\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nB Z\r\nC Z\r\nA Z\r\nA Y\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC X\r\nC Z\r\nB Y\r\nA X\r\nA X\r\nC Y" +
                    "\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nB Z\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nA X\r\nA Y\r\nA X\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nB Z\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Y\r\nA X" +
                    "\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nB Z\r\nC Y\r\nA X\r\nA Y\r\nB X\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nA X\r\nA X" +
                    "\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nB Z\r\nA Z\r\nB Y\r\nB Z\r\nA X\r\nA X\r\nC Z\r\nA Z\r\nC Y\r\nB Z\r\nC Z\r\nC Z\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nB X\r\nC Z\r\nB Z" +
                    "\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nB X\r\nA X\r\nB Z\r\nC Y\r\nC Y\r\nB Z\r\nC Y\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nB Z\r\nA X\r\nA Z\r\nA X\r\nB X\r\nA X\r\nC Y\r\nA X\r\nA X\r\nB Z\r\nA X\r\nB X\r\nA Z\r\nC Y\r\nB Z\r\nA X\r\nA Z" +
                    "\r\nA X\r\nA X\r\nB X\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nB Z\r\nC Z\r\nC Y\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nC Z\r\nC Z\r\nC Y\r\nA X\r\nB X\r\nB X\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nB Z\r\nA Y\r\nA X\r\nC X\r\nB X" +
                    "\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nC Y\r\nC Y\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA Y\r\nA Y\r\nC X\r\nA Y\r\nC Y\r\nC X\r\nA Z\r\nC Z" +
                    "\r\nC Y\r\nC Z\r\nA Z\r\nC X\r\nA X\r\nC Z\r\nA Z\r\nC Y\r\nB Z\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nC Z\r\nA X\r\nC Y\r\nA X\r\nA Z\r\nA X\r\nC X\r\nC Z\r\nA Z\r\nC Y\r\nA Y\r\nA Y\r\nA Z\r\nA X" +
                    "\r\nA Z\r\nA Y\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nB Z\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nC Y\r\nB X\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Y\r\nA X" +
                    "\r\nA X\r\nC Y\r\nA Y\r\nC X\r\nA X\r\nC Y\r\nA Y\r\nA Z\r\nB Y\r\nA X\r\nC Z\r\nB X\r\nA X\r\nC Z\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Y\r\nB X\r\nA X" +
                    "\r\nB X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nC Z\r\nA Z\r\nA X\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nA Z\r\nA X\r\nC Z\r\nB Y\r\nA Z\r\nA X" +
                    "\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA X\r\nC X\r\nA X\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nB X\r\nA X\r\nA Z\r\nC Y\r\nA Z\r\nB X\r\nC Y\r\nA X\r\nC Z\r\nA Z\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nA X" +
                    "\r\nC Z\r\nA X\r\nC X\r\nA Y\r\nA X\r\nA Z\r\nC X\r\nA X\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA X\r\nB Z\r\nC Z\r\nC Y\r\nB Z\r\nB Z\r\nB X\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nC Y\r\nB Z\r\nC Y\r\nA X\r\nC X\r\nA X\r\nA Z" +
                    "\r\nC Y\r\nA Z\r\nA X\r\nA Y\r\nC Y\r\nC Y\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nC Y\r\nB Y\r\nA X\r\nA X\r\nA X\r\nC Y\r\nB X\r\nA Z\r\nA Y\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB Z\r\nB X\r\nA X\r\nC Z" +
                    "\r\nA X\r\nC Y\r\nA Z\r\nC Z\r\nC Y\r\nC X\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nB Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nB X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Y\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nA Z" +
                    "\r\nB X\r\nA X\r\nC X\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nC Y\r\nC Z\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nB Z\r\nC Y\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nA X\r\nA X\r\nA X" +
                    "\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nC Y\r\nC Y\r\nC Y\r\nA Z\r\nC X\r\nB Z\r\nC Y\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nC Z\r\nA Y\r\nC Y\r\nB X\r\nC Y\r\nA X\r\nA X\r\nA Y\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X" +
                    "\r\nA Z\r\nB Z\r\nA X\r\nA X\r\nA X\r\nC Z\r\nC X\r\nA Z\r\nC Y\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nB Z\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nC Z\r\nB Z\r\nA Z\r\nB Z\r\nA X\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nA Z\r\nC X" +
                    "\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nA Z\r\nC Z\r\nB Z\r\nC Y\r\nA Z\r\nA X\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nB X\r\nC Z\r\nC Z\r\nA Y" +
                    "\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nC Z\r\nB Z\r\nA Z\r\nC X\r\nB Z\r\nC X\r\nB Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nB Z\r\nC Y\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA Z" +
                    "\r\nA Y\r\nA Z\r\nC Y\r\nC X\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nA X\r\nA Z\r\nB Z\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nC Y\r\nB X\r\nC Y\r\nA Z\r\nB Z\r\nA X\r\nB Z\r\nB Z\r\nC X\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z" +
                    "\r\nC Z\r\nB Z\r\nC Y\r\nC Z\r\nA Z\r\nC Y\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC Y\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nC X\r\nA Y\r\nA X\r\nA X\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nB Z\r\nC Y\r\nC Z\r\nA Z" +
                    "\r\nC Y\r\nB X\r\nC Z\r\nA X\r\nC X\r\nC Y\r\nC Y\r\nC Y\r\nA Z\r\nA Z\r\nB Y\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC Z\r\nA X\r\nC Z\r\nB X\r\nA X\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nB Z\r\nB Z" +
                    "\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nC Y\r\nC Z\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nC Z\r\nA X\r\nA Z\r\nA Y\r\nC Y\r\nA X\r\nA Z\r\nC Y\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Y\r\nA X\r\nB Y\r\nA X\r\nA X\r\nA X" +
                    "\r\nA X\r\nB Z\r\nA X\r\nC Y\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC Z\r\nC Z\r\nA X\r\nB Y\r\nA X\r\nC Y\r\nA X\r\nC Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nC Y\r\nA Z\r\nA Z" +
                    "\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nA Y\r\nA Z\r\nC X\r\nB X\r\nA X\r\nA Y\r\nC Z\r\nA X\r\nB Z\r\nA X\r\nA X\r\nA Y\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nC X\r\nA Y" +
                    "\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nA X\r\nC Z\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nC Y\r\nC X\r\nC Y\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nC X\r\nA Z\r\nB Z" +
                    "\r\nA Z\r\nA X\r\nC Y\r\nA X\r\nC Y\r\nC Y\r\nA X\r\nC Y\r\nA X\r\nC Y\r\nB Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nB X\r\nA Z\r\nA Y\r\nB Y\r\nA Z\r\nA X\r\nA X\r\nC Y\r\nC X" +
                    "\r\nB Z\r\nA Z\r\nC Y\r\nC X\r\nC Y\r\nA Y\r\nA Z\r\nC X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nB Z\r\nA X\r\nB Y\r\nC X\r\nA X\r\nA Y\r\nC X\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nC Z\r\nB Z\r\nA X\r\nB Z" +
                    "\r\nB Y\r\nA Z\r\nA Z\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nA X\r\nC Z\r\nC Z\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nA X\r\nB Z\r\nB X\r\nA X\r\nA X\r\nA Z\r\nB Z\r\nA X\r\nA Z\r\nC Y\r\nC Y" +
                    "\r\nB Z\r\nC Z\r\nA X\r\nB X\r\nB X\r\nA Z\r\nA X\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nB Y\r\nC Y\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nB Z\r\nA Y\r\nA Z\r\nC Y\r\nB Y\r\nA X\r\nC X\r\nA X\r\nC Z\r\nA Z\r\nA X\r\nA Z\r\nA Z" +
                    "\r\nA X\r\nB Z\r\nC Z\r\nA Z\r\nA X\r\nC X\r\nA X\r\nC Y\r\nB Z\r\nB X\r\nC Z\r\nC X\r\nA X\r\nA X\r\nA Z\r\nA X\r\nC Y\r\nB Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nB X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Y\r\nA Z\r\nC Z" +
                    "\r\nB Z\r\nA X\r\nA X\r\nA X\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nC Z\r\nC Y\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nA X\r\nB Z\r\nB Z\r\nA Z\r\nA Z\r\nC Z\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nA Z" +
                    "\r\nC Z\r\nB X\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nB Y\r\nB X\r\nA X\r\nC Y\r\nC X\r\nC Y\r\nB X\r\nA X\r\nC Y\r\nA Z\r\nB Y\r\nA Y\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nB X" +
                    "\r\nC Z\r\nA X\r\nB X\r\nA X\r\nC Y\r\nA X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA Z\r\nB Z\r\nA X" +
                    "\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nB Z\r\nA Z\r\nA X\r\nB Y\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nB Y\r\nA Y\r\nA Z\r\nC Y\r\nB Z\r\nA Z\r\nC X\r\nC Y\r\nC Z\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X" +
                    "\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nC Y\r\nA Z\r\nA X\r\nC X\r\nB Z\r\nC Z\r\nC Y\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nC X\r\nB Y\r\nA X\r\nC Z\r\nA X\r\nC X\r\nA Z\r\nA X" +
                    "\r\nA Y\r\nC Z\r\nA X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nC Y\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nB X\r\nC Z\r\nB Z\r\nA Z\r\nA X\r\nA X\r\nB Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z" +
                    "\r\nA Z\r\nA X\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nB X\r\nA X\r\nC Z\r\nA X\r\nA Y\r\nB X\r\nC X\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA X\r\nC Y\r\nA Y\r\nA Z\r\nB Z\r\nB Z\r\nB Z\r\nA Z\r\nA Z\r\nA Z\r\nA X" +
                    "\r\nB X\r\nC Y\r\nA X\r\nA Z\r\nC Z\r\nB Y\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nB Z\r\nA X\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC Z\r\nA X\r\nC Z\r\nA Z\r\nC Y\r\nA X\r\nA Z" +
                    "\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nB Z\r\nA X\r\nA X\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC Y\r\nC Y\r\nC Y\r\nC Y\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nA X\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nC Z\r\nC X" +
                    "\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nA X\r\nB Z\r\nA X\r\nB Y\r\nC X\r\nA X\r\nA Y\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA Z" +
                    "\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Y\r\nA X\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA X\r\nC Y\r\nC Z\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nC Z\r\nB Y\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA Z\r\nC Z" +
                    "\r\nC Y\r\nA Z\r\nB Y\r\nA X\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nC Y\r\nC Y\r\nA X\r\nB X\r\nC X\r\nA Y\r\nA X\r\nA Z\r\nB X\r\nA X\r\nB Z\r\nA Z\r\nA X\r\nC X\r\nA X\r\nB X\r\nA X\r\nA Z\r\nA X" +
                    "\r\nC Y\r\nA Z\r\nC Z\r\nC Y\r\nA X\r\nB X\r\nC Y\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Y\r\nA X\r\nA X\r\nA Y\r\nA Z\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nB X\r\nA X\r\nB Y\r\nC Y" +
                    "\r\nA Z\r\nB Z\r\nA Z\r\nB Y\r\nA Z\r\nC Y\r\nA Z\r\nA X\r\nA X\r\nA Z\r\nC X\r\nC Z\r\nB X\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nA Z\r\nA X\r\nC Z\r\nB Y\r\nC Y\r\nC X\r\nA X\r\nA Z\r\nA X\r\nC Y\r\nA Z\r\nC Z\r\nA X\r\nA X" +
                    "\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nA Y\r\nB Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nC Y\r\nA X\r\nA Z\r\nC Y\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nB Z\r\nA X\r\nC X\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nC Y" +
                    "\r\nC Z\r\nB Z\r\nB X\r\nA Z\r\nA X\r\nC X\r\nC Y\r\nA X\r\nB Z\r\nB Z\r\nA Z\r\nB Z\r\nC Y\r\nA X\r\nA X\r\nA X\r\nC Y\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nC Y\r\nA X\r\nC X\r\nC Y\r\nC Y\r\nC X\r\nA X" +
                    "\r\nC Y\r\nA Z\r\nC Y\r\nB Z\r\nB Z\r\nC Z\r\nA X\r\nB X\r\nC X\r\nA Z\r\nA Y\r\nA Z\r\nB Z\r\nA Z\r\nB Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC Y" +
                    "\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nB X\r\nA X\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nA X\r\nA X\r\nA X\r\nA X\r\nA X\r\nA Z\r\nC Y\r\nA X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nC Z\r\nA X\r\nC Y\r\nB Z\r\nC Y\r\nC Z\r\nB X\r\nA Z" +
                    "\r\nC Y\r\nA Z\r\nC Y\r\nA X\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nC Y\r\nA X\r\nC Y\r\nB Y\r\nA X\r\nA X\r\nA Z\r\nC Y\r\nC Z\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nA X\r\nA X\r\nA Z";
            string[] outcomes = rockPaperScissors.Split("\r\n", StringSplitOptions.None);
            int totalPoints = 0;
            foreach(string outcome in outcomes)
            {

                {
                    int roundOutcome = 0, shapeSelected = 1;                                                                  //First Char is Enemy Move, Second is Round Outcome
                    switch (outcome[0])
                    {
                        case 'A':                                       //Enemy Choice: Rock
                            switch (outcome[2])
                            {
                                case 'X':
                                    shapeSelected = 3;
                                    break;
                                case 'Y':
                                    roundOutcome = 3;
                                    break;
                                case 'Z':
                                    roundOutcome = 6;
                                    shapeSelected = 2;
                                    break;
                            }
                            break;
                        case 'B':                                       //Enemy Choice: Paper
                            switch (outcome[2])
                            {
                                case 'X':
                                    break;
                                case 'Y':
                                    roundOutcome = 3;
                                    shapeSelected = 2;
                                    break;
                                case 'Z':
                                    roundOutcome = 6;
                                    shapeSelected = 3;
                                    break;
                            }
                            break;
                        case 'C':                                       //Enemy Choice: Scissors
                            switch (outcome[2])
                            {
                                case 'X':
                                    shapeSelected = 2;
                                    break;
                                case 'Y':
                                    roundOutcome = 3;
                                    shapeSelected = 3;
                                    break;
                                case 'Z':
                                    roundOutcome = 6;
                                    break;
                            }
                            break;
                    }
                    totalPoints += (roundOutcome + shapeSelected);
                    /*int roundOutcome = 0, shapeSelected = 1;                                                                  //First Char is Enemy Move, Second is Player Move
                    switch(outcome[0])
                    {
                        case 'A':                                       //Enemy Choice: Rock
                            switch(outcome[2])
                            {
                                case 'X':
                                    roundOutcome = 3;
                                    break;
                                case 'Y':
                                    roundOutcome = 6;
                                    shapeSelected = 2;
                                    break;
                                case 'Z':
                                    shapeSelected = 3;
                                    break;
                            }
                            break;
                        case 'B':                                       //Enemy Choice: Paper
                            switch (outcome[2])
                            {
                                case 'X':
                                    break;
                                case 'Y':
                                    roundOutcome = 3;
                                    shapeSelected = 2;
                                    break;
                                case 'Z':
                                    roundOutcome = 6;
                                    shapeSelected = 3;
                                    break;
                            }
                            break;
                        case 'C':                                       //Enemy Choice: Scissors
                            switch (outcome[2])
                            {
                                case 'X':
                                    roundOutcome = 6;
                                    break;
                                case 'Y':
                                    shapeSelected = 2;
                                    break;
                                case 'Z':
                                    roundOutcome = 3;
                                    shapeSelected = 3;
                                    break;
                            }
                            break;
                    }
                    totalPoints += (roundOutcome+shapeSelected);*/
                }                
            }
            Console.WriteLine($"You scored {totalPoints} total points in the championship!");
            Console.ReadKey();
        }
    }
}
