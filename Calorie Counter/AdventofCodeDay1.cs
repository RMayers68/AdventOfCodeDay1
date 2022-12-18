namespace Calorie_Counter
{
    public class AdventOfCodeDay1
    {
        public static void CalorieCounter()
        {
            string day1Input = File.ReadAllText("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day1.txt");
            Console.Write(day1Input);
            Console.ReadKey();
            string[] elves = day1Input.Split("\r\n\r\n", StringSplitOptions.None);
            int firstElf = 0, secondElf = 0, thirdElf = 0;
            foreach (var elf in elves)
            {
                string[] tmp = elf.Split("\r\n", StringSplitOptions.None);
                int totalCalories = 0;
                foreach (string s in tmp)
                {
                    int calorieCheck = 0;
                    if (!s.Equals(""))
                        calorieCheck = Int32.Parse(s);
                    totalCalories += calorieCheck;
                }
                if (totalCalories > firstElf)
                {
                    if (firstElf > secondElf)
                        secondElf = firstElf;
                    else if (firstElf > thirdElf)
                        thirdElf = firstElf;
                    firstElf = totalCalories;
                }
                else if (totalCalories > secondElf)
                {
                    if (secondElf > thirdElf)
                        thirdElf = secondElf;
                    secondElf = totalCalories;
                }
                else if (totalCalories > thirdElf)
                    thirdElf = totalCalories;

            }
            Console.WriteLine($"The elf with the most calories has {firstElf} calories.");
            Console.WriteLine($"The highest calories combined is {firstElf + secondElf + thirdElf}.");
            Console.ReadKey();
        }
    }
   
}
