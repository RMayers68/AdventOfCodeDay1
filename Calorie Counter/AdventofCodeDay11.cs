namespace Calorie_Counter
{
    public class AdventofCodeDay11
    {
        public static void MonkeyInTheMiddle()
        {
            string day11Input = "Monkey 0:\r\n  Starting items: 93, 54, 69, 66, 71\r\n  Operation: new = old * 3\r\n  Test: divisible by 7\r\n    If true: throw to monkey 7\r\n    If false: throw to monkey 1" +
                "\r\n\r\nMonkey 1:\r\n  Starting items: 89, 51, 80, 66\r\n  Operation: new = old * 17\r\n  Test: divisible by 19\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 7" +
                "\r\n\r\nMonkey 2:\r\n  Starting items: 90, 92, 63, 91, 96, 63, 64\r\n  Operation: new = old + 1\r\n  Test: divisible by 13\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 3" +
                "\r\n\r\nMonkey 3:\r\n  Starting items: 65, 77\r\n  Operation: new = old + 2\r\n  Test: divisible by 3\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 6" +
                "\r\n\r\nMonkey 4:\r\n  Starting items: 76, 68, 94\r\n  Operation: new = old * old\r\n  Test: divisible by 2\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 6" +
                "\r\n\r\nMonkey 5:\r\n  Starting items: 86, 65, 66, 97, 73, 83\r\n  Operation: new = old + 8\r\n  Test: divisible by 11\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3" +
                "\r\n\r\nMonkey 6:\r\n  Starting items: 78\r\n  Operation: new = old + 6\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1" +
                "\r\n\r\nMonkey 7:\r\n  Starting items: 89, 57, 59, 61, 87, 55, 55, 88\r\n  Operation: new = old + 7\r\n  Test: divisible by 5\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 5";
            string[] monkeysString = day11Input.Split("\r\n\r\n");
            Monkey[] monkeys = new Monkey[monkeysString.Length];
            // Creating Monkey objects
            for (int i = 0; i < monkeysString.Length; i++)
            {
                string[] individualMonkey = monkeysString[i].Split("\r\n");
                int number = Int32.Parse(individualMonkey[0].Substring(7, 1));
                string[] items = individualMonkey[1].Substring(18).Split(",");
                List<long> itemsWorryAmount = new();
                for (int j = 0; j < items.Length; j++)
                    itemsWorryAmount.Add(Int32.Parse(items[j].Trim()));
                string operation = individualMonkey[2].Substring(23);
                int test = Int32.Parse(individualMonkey[3].Substring(21));
                int @true = Int32.Parse(individualMonkey[4].Substring(29));
                int @false = Int32.Parse(individualMonkey[5].Substring(30));
                monkeys[i] = new Monkey(number,itemsWorryAmount,operation,test,@true,@false);
            }
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < monkeys.Length; j++)
                {
                    if (monkeys[j].Items.Count == 0)
                        continue;
                    for (int k = 0; k < monkeys[j].Items.Count; k++)
                    {
                        // Inspect Item
                        monkeys[j].Items[k] = monkeys[j].Inspection(k);
                        // Worry Drop (Only Part 1)
                        //monkeys[j].Items[k] /= 3;
                        monkeys[j].Items[k] %= 9699690; //Got a hint about LCM for this line :)  MY COMMENT IS THIS IS BULLS###! Haha
                        // Test and Throw Item
                        if (monkeys[j].TestItem(k))
                            monkeys[monkeys[j].True].Items.Add(monkeys[j].Items[k]);
                        else monkeys[monkeys[j].False].Items.Add(monkeys[j].Items[k]);
                    }
                    monkeys[j].Items.Clear();
                }
            }
            foreach(Monkey monkey in monkeys)
                Console.WriteLine($"Monkey {monkey.Number} inspected items {monkey.ItemsInspected} times.");
            Console.ReadKey();
        }
        public class Monkey
        {
            public int Number { get; set; }
            public List<long> Items { get; set; }
            public string Operation { get; set; }
            public int Test { get; set; }
            public int True { get; set; }
            public int False { get; set; }
            public int ItemsInspected { get; set; }

            public Monkey(int number, List<long> items, string operation, int test, int @true, int @false)
            {
                Number = number;
                Items = items;
                Operation = operation;
                Test = test;
                True = @true;
                False = @false;
                ItemsInspected = 0;
            }

            public bool TestItem(int index)
            {
                if (Items[index] % Test == 0)
                    return true;
                else return false;
            }

            public long Inspection(int index)
            {
                ItemsInspected++;
                if (Operation[0] == '+')
                    return Items[index] += Int32.Parse(Operation.Substring(2));
                else if (Operation.EndsWith('d'))
                    return Items[index] * Items[index];
                else return Items[index] * Int32.Parse(Operation.Substring(2));
            }
        }
    }
}
