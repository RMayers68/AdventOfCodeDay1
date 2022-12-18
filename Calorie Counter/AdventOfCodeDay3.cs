namespace Calorie_Counter
{
    public class AdventOfCodeDay3
    {

        public static void RucksackSorting()
        {
            string[] rucksacks = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day3.txt");
            // Method to find badge sums
            int sum = 0;
            for (int i = 0; i < rucksacks.Length; i++)
            {
                bool foundLetter = false;
                char letter = '2';
                foreach (char x in rucksacks[i])
                {
                    foreach (char y in rucksacks[i + 1])
                        if (y == x)
                        {
                            foreach (char z in rucksacks[i + 2])
                            {
                                if (z == y)
                                {
                                    foundLetter = true;
                                    letter = x;
                                }

                            }
                            if (foundLetter)
                                break;
                        }
                    if (foundLetter)
                        break;
                }
                sum += Dict.typePriority[letter];
                i += 2;
            }
            Console.WriteLine($"The sum of elve's badges is {sum}.");

            // Method to find matching types in one rucksack 
            sum = 0;
            foreach (string ruck in rucksacks)
            {
                bool foundLetter = false;
                char letter = '2';
                string one = ruck.Substring(0, (ruck.Length / 2));
                string two = ruck.Substring(ruck.Length / 2);
                foreach (char x in one)
                {
                    foreach(char y in two)
                        if(y==x)
                        {
                            foundLetter = true;
                            letter = x;
                        }
                    if (foundLetter)
                        break;
                }
                sum += Dict.typePriority[letter];
        }
            Console.WriteLine($"The sum of same item type priorities is {sum}.");
            
            Console.ReadKey();
        }

        public class Dict
        {
            public static Dictionary<char, int> typePriority = new()                                             //Dictionary for type Priority
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11},
            { 'l', 12},
            { 'm', 13},
            { 'n', 14},
            { 'o', 15},
            { 'p', 16},
            { 'q', 17 },
            { 'r', 18},
            { 's', 19},
            { 't', 20},
            { 'u', 21},
            { 'v', 22},
            { 'w', 23},
            { 'x', 24},
            { 'y', 25},
            { 'z', 26 },
            { 'A', 27},
            { 'B', 28},
            { 'C', 29},
            { 'D', 30},
            { 'E', 31},
            { 'F', 32},
            { 'G', 33},
            { 'H', 34},
            { 'I', 35},
            { 'J', 36},
            { 'K', 37},
            { 'L', 38 },
            { 'M', 39},
            { 'N', 40},
            { 'O', 41},
            { 'P', 42},
            { 'Q', 43},
            { 'R', 44},
            { 'S', 45},
            { 'T', 46},
            { 'U', 47 },
            { 'V', 48},
            { 'W', 49},
            { 'X', 50},
            { 'Y', 51},
            { 'Z', 52},
        };
        }

    }
}
