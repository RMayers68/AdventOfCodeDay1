using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Calorie_Counter
{
    public class AdventofCodeDay13
    {
        public static void DistressSignal()
        {
            string day13Input = File.ReadAllText("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day13.txt");
            string[] pairs = day13Input.Split("\r\n\r\n");
            int correctOrderPairs = 0, decoderKey = 0;
            for (int i = 0; i < pairs.Length;i++)
            {
                string[] strings = pairs[i].Split("\r\n");
                var list1 = (JsonElement)JsonSerializer.Deserialize<object>(strings[0])!;
                var list2 = (JsonElement)JsonSerializer.Deserialize<object>(strings[1])!;
                if (Comp(list1, list2) != 1 )
                    correctOrderPairs += i+1;
            }            
            string[] sequence = day13Input.Split("\r\n");
            var sortedList = new List<JsonElement>();
            var two = JsonSerializer.Deserialize<JsonElement>("[[2]]");
            var six = JsonSerializer.Deserialize<JsonElement>("[[6]]");
            sortedList.Add(two);
            sortedList.Add(six);
            foreach (string s in sequence)
            {
                if (s == "")
                    continue;
                var tmp = (JsonElement)JsonSerializer.Deserialize<object>(s)!;
                sortedList.Add(tmp);
            }
            sortedList = Sort(sortedList);
            for (int i = 0; i < sortedList.Count;i++)
            {
                if (sortedList[i].ToString() == "[[2]]")
                    decoderKey += i + 1;
                else if (sortedList[i].ToString() == "[[6]]")
                    decoderKey *= i + 1;       
            }
            Console.WriteLine($"The amount of correctly ordered pairs is {correctOrderPairs} and the decoder key is {decoderKey}.");
            Console.ReadKey();
        }

        public static int Comp(JsonElement leftPair, JsonElement rightPair)
        {
            JsonElement intConversion;
            switch (leftPair.ValueKind, rightPair.ValueKind)
            {
                case (JsonValueKind.Null, not JsonValueKind.Null):
                    return -1;
                case (not JsonValueKind.Null, JsonValueKind.Null):
                    return 1;
                case (JsonValueKind.Number, JsonValueKind.Number):
                    return Comparer<int>.Default.Compare(leftPair.GetInt32(), rightPair.GetInt32());
                case (JsonValueKind.Number, JsonValueKind.Array):
                    intConversion = JsonSerializer.Deserialize<JsonElement>("[" + leftPair.GetInt32() + "]");
                    return Comp(intConversion, rightPair);
                case (JsonValueKind.Array, JsonValueKind.Number):
                    intConversion = JsonSerializer.Deserialize<JsonElement>("[" + rightPair.GetInt32() + "]");
                    return Comp(leftPair, intConversion);
                case (JsonValueKind.Array, JsonValueKind.Array):
                    var leftArray = leftPair.EnumerateArray();
                    var rightArray = rightPair.EnumerateArray();

                    while (leftArray.MoveNext() && rightArray.MoveNext())
                    {
                        var leftPants = leftArray.Current;
                        var rightPants = rightArray.Current;

                        var compair = Comp(leftPants, rightPants);

                        if (compair != 0)
                        {
                            return compair;
                        }
                    }

                    var legCount = leftArray.Count() - rightArray.Count();

                    return legCount switch
                    {
                        0 => 0,
                        < 0 => -1,
                        _ => 1
                    };
                default:
                    return 0;
            };
        }

        public static List<JsonElement> Sort(List<JsonElement> sorted)
        {
            sorted.Sort(Comparer);
            return sorted;
        }

        private static int Comparer(JsonElement x, JsonElement y)
        {
            return Comp(x,y);
        }
    }
}
