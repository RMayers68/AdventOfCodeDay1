namespace Calorie_Counter
{
    public class AdventofCodeDay4
    {
        public static void SectionSearch()
        {
            string[] elfPairs = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day4.txt");   // Example: Splits to 49-49,3-48
            int containedPairs = 0, fullyContainedPairs = 0;
            foreach (string pair in elfPairs)
            {
                string[] sections = pair.Split(",");                                            // Split to 49-49 and 3-48
                int[] firstElf = new int[2];
                int[] secondElf = new int[2];
                bool firstSet = true;
                foreach (string section in sections)
                {
                    string[] numbers = section.Split("-");                                      // Split to 49 and 49
                    int lowerRange = Int32.Parse(numbers[0]);
                    int upperRange = Int32.Parse(numbers[1]);
                    if (firstSet)
                    {
                        firstElf[0] = lowerRange;
                        firstElf[1] = upperRange;
                        firstSet = false;
                    }
                    else
                    {
                        secondElf[0] = lowerRange;
                        secondElf[1] = upperRange;
                        firstSet = true;
                    }
                }
                if (firstElf[0] <= secondElf[0] && firstElf[1] >= secondElf[1])               // Examining fully contained pairs
                    fullyContainedPairs++;
                else if (secondElf[0] <= firstElf[0] && secondElf[1] >= firstElf[1])
                    fullyContainedPairs++;
                if (firstElf[0] <= secondElf[1] && firstElf[1] >= secondElf[1])                 // Examining pairs with any similar number
                    containedPairs++;
                else if (secondElf[0] <= firstElf[1] && secondElf[1] >= firstElf[1])
                    containedPairs++;
            }
            Console.WriteLine($"The amount of similar pairs is {containedPairs} and the amount of fully contained pairs is {fullyContainedPairs}.");
            Console.ReadKey();
        }
    }
}
