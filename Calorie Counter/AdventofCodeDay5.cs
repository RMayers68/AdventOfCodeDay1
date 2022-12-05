using System.Text.RegularExpressions;

namespace Calorie_Counter
{
    public class AdventofCodeDay5
    {
        public static void CrateStacker()
        {
            //Setup of input 
            string day5Input = "move 1 from 2 to 6\r\nmove 3 from 7 to 9\r\nmove 7 from 9 to 4\r\nmove 2 from 5 to 3\r\nmove 3 from 2 to 8\r\nmove 14 from 4 to 5\r\nmove 1 from 2 to 1\r\nmove 1 from 2 to 3\r\nmove 3 from 6 to 8\r\nmove 3 from 6 to 9" +
                "\r\nmove 1 from 4 to 6\r\nmove 5 from 9 to 8\r\nmove 9 from 8 to 9\r\nmove 3 from 3 to 8\r\nmove 8 from 9 to 4\r\nmove 2 from 1 to 7\r\nmove 4 from 1 to 5\r\nmove 2 from 7 to 1\r\nmove 1 from 9 to 6\r\nmove 7 from 4 to 7" +
                "\r\nmove 1 from 8 to 4\r\nmove 1 from 9 to 8\r\nmove 2 from 6 to 7\r\nmove 7 from 7 to 3\r\nmove 10 from 3 to 1\r\nmove 1 from 3 to 2\r\nmove 1 from 2 to 9\r\nmove 1 from 9 to 8\r\nmove 15 from 5 to 8\r\nmove 1 from 6 to 9" +
                "\r\nmove 2 from 7 to 3\r\nmove 11 from 1 to 8\r\nmove 1 from 9 to 8\r\nmove 1 from 1 to 5\r\nmove 3 from 5 to 2\r\nmove 2 from 6 to 9\r\nmove 1 from 2 to 4\r\nmove 2 from 4 to 5\r\nmove 1 from 3 to 6\r\nmove 5 from 8 to 3" +
                "\r\nmove 12 from 8 to 4\r\nmove 2 from 2 to 5\r\nmove 12 from 8 to 1\r\nmove 1 from 6 to 9\r\nmove 10 from 5 to 7\r\nmove 3 from 3 to 9\r\nmove 6 from 8 to 9\r\nmove 2 from 3 to 5\r\nmove 8 from 4 to 7\r\nmove 1 from 3 to 2" +
                "\r\nmove 6 from 8 to 6\r\nmove 8 from 9 to 3\r\nmove 2 from 5 to 4\r\nmove 1 from 2 to 3\r\nmove 2 from 9 to 2\r\nmove 1 from 9 to 2\r\nmove 1 from 2 to 1\r\nmove 2 from 2 to 4\r\nmove 5 from 4 to 2\r\nmove 3 from 2 to 3" +
                "\r\nmove 2 from 4 to 2\r\nmove 18 from 7 to 3\r\nmove 3 from 6 to 9\r\nmove 1 from 6 to 3\r\nmove 1 from 4 to 1\r\nmove 1 from 6 to 3\r\nmove 6 from 3 to 9\r\nmove 2 from 2 to 6\r\nmove 26 from 3 to 7\r\nmove 2 from 2 to 3" +
                "\r\nmove 2 from 6 to 8\r\nmove 3 from 1 to 5\r\nmove 8 from 9 to 1\r\nmove 1 from 8 to 5\r\nmove 1 from 3 to 1\r\nmove 2 from 9 to 3\r\nmove 1 from 1 to 2\r\nmove 12 from 1 to 7\r\nmove 1 from 8 to 5\r\nmove 2 from 3 to 5" +
                "\r\nmove 1 from 3 to 6\r\nmove 2 from 6 to 2\r\nmove 7 from 5 to 7\r\nmove 1 from 4 to 2\r\nmove 15 from 7 to 4\r\nmove 1 from 4 to 9\r\nmove 1 from 7 to 6\r\nmove 14 from 4 to 2\r\nmove 1 from 1 to 2\r\nmove 5 from 1 to 5" +
                "\r\nmove 4 from 5 to 4\r\nmove 1 from 6 to 3\r\nmove 4 from 4 to 7\r\nmove 1 from 9 to 2\r\nmove 1 from 3 to 5\r\nmove 2 from 5 to 1\r\nmove 1 from 1 to 6\r\nmove 2 from 1 to 5\r\nmove 9 from 2 to 9\r\nmove 1 from 6 to 1" +
                "\r\nmove 1 from 1 to 9\r\nmove 1 from 5 to 4\r\nmove 1 from 5 to 6\r\nmove 4 from 7 to 2\r\nmove 1 from 4 to 1\r\nmove 18 from 7 to 1\r\nmove 17 from 1 to 7\r\nmove 4 from 9 to 5\r\nmove 1 from 5 to 8\r\nmove 1 from 1 to 4" +
                "\r\nmove 2 from 9 to 6\r\nmove 3 from 9 to 7\r\nmove 1 from 1 to 5\r\nmove 1 from 7 to 5\r\nmove 16 from 7 to 2\r\nmove 1 from 4 to 2\r\nmove 1 from 8 to 7\r\nmove 1 from 9 to 8\r\nmove 1 from 8 to 4\r\nmove 3 from 5 to 3" +
                "\r\nmove 15 from 7 to 6\r\nmove 7 from 6 to 4\r\nmove 9 from 6 to 2\r\nmove 2 from 5 to 7\r\nmove 2 from 6 to 8\r\nmove 4 from 4 to 7\r\nmove 2 from 8 to 1\r\nmove 11 from 2 to 7\r\nmove 1 from 4 to 2\r\nmove 2 from 3 to 6" +
                "\r\nmove 3 from 4 to 5\r\nmove 12 from 7 to 1\r\nmove 1 from 7 to 3\r\nmove 31 from 2 to 4\r\nmove 3 from 7 to 2\r\nmove 1 from 6 to 3\r\nmove 1 from 5 to 1\r\nmove 1 from 5 to 2\r\nmove 2 from 3 to 4\r\nmove 1 from 6 to 1" +
                "\r\nmove 1 from 3 to 6\r\nmove 1 from 5 to 6\r\nmove 1 from 2 to 4\r\nmove 11 from 1 to 4\r\nmove 5 from 1 to 5\r\nmove 1 from 7 to 3\r\nmove 3 from 5 to 8\r\nmove 1 from 8 to 7\r\nmove 1 from 5 to 3\r\nmove 2 from 8 to 5" +
                "\r\nmove 2 from 6 to 2\r\nmove 2 from 5 to 1\r\nmove 1 from 7 to 9\r\nmove 1 from 3 to 9\r\nmove 2 from 9 to 5\r\nmove 1 from 1 to 6\r\nmove 1 from 6 to 5\r\nmove 1 from 3 to 5\r\nmove 13 from 4 to 8\r\nmove 5 from 2 to 3" +
                "\r\nmove 3 from 3 to 4\r\nmove 1 from 8 to 6\r\nmove 4 from 5 to 2\r\nmove 1 from 1 to 5\r\nmove 1 from 3 to 7\r\nmove 2 from 5 to 4\r\nmove 11 from 4 to 5\r\nmove 1 from 3 to 7\r\nmove 15 from 4 to 2\r\nmove 1 from 6 to 4" +
                "\r\nmove 19 from 2 to 8\r\nmove 8 from 8 to 3\r\nmove 2 from 3 to 8\r\nmove 7 from 5 to 4\r\nmove 6 from 3 to 4\r\nmove 8 from 4 to 5\r\nmove 7 from 4 to 6\r\nmove 2 from 7 to 5\r\nmove 9 from 5 to 6\r\nmove 13 from 8 to 3" +
                "\r\nmove 3 from 4 to 3\r\nmove 6 from 3 to 4\r\nmove 6 from 8 to 2\r\nmove 4 from 5 to 9\r\nmove 5 from 8 to 7\r\nmove 4 from 6 to 2\r\nmove 5 from 3 to 5\r\nmove 1 from 6 to 9\r\nmove 8 from 2 to 6\r\nmove 1 from 8 to 7" +
                "\r\nmove 1 from 2 to 5\r\nmove 1 from 4 to 1\r\nmove 3 from 3 to 1\r\nmove 1 from 7 to 3\r\nmove 4 from 9 to 8\r\nmove 6 from 6 to 2\r\nmove 2 from 8 to 4\r\nmove 1 from 7 to 6\r\nmove 3 from 5 to 1\r\nmove 4 from 5 to 3" +
                "\r\nmove 6 from 2 to 9\r\nmove 4 from 7 to 4\r\nmove 2 from 8 to 5\r\nmove 2 from 9 to 5\r\nmove 4 from 5 to 6\r\nmove 1 from 2 to 5\r\nmove 8 from 6 to 7\r\nmove 18 from 4 to 2\r\nmove 2 from 3 to 6\r\nmove 6 from 1 to 8" +
                "\r\nmove 8 from 7 to 9\r\nmove 9 from 6 to 4\r\nmove 1 from 5 to 4\r\nmove 5 from 8 to 4\r\nmove 1 from 4 to 5\r\nmove 1 from 8 to 1\r\nmove 8 from 9 to 8\r\nmove 3 from 3 to 9\r\nmove 5 from 2 to 7\r\nmove 1 from 5 to 2" +
                "\r\nmove 2 from 4 to 8\r\nmove 11 from 2 to 8\r\nmove 1 from 7 to 2\r\nmove 2 from 6 to 5\r\nmove 1 from 6 to 2\r\nmove 4 from 2 to 3\r\nmove 2 from 1 to 3\r\nmove 5 from 9 to 7\r\nmove 1 from 5 to 8\r\nmove 6 from 7 to 8" +
                "\r\nmove 7 from 3 to 7\r\nmove 1 from 5 to 9\r\nmove 3 from 9 to 7\r\nmove 1 from 4 to 1\r\nmove 1 from 9 to 8\r\nmove 8 from 7 to 3\r\nmove 1 from 2 to 4\r\nmove 1 from 1 to 7\r\nmove 9 from 3 to 7\r\nmove 7 from 4 to 7" +
                "\r\nmove 8 from 7 to 3\r\nmove 1 from 7 to 9\r\nmove 13 from 7 to 4\r\nmove 1 from 4 to 6\r\nmove 11 from 8 to 2\r\nmove 5 from 3 to 7\r\nmove 1 from 9 to 6\r\nmove 7 from 2 to 9\r\nmove 2 from 2 to 4\r\nmove 4 from 9 to 2" +
                "\r\nmove 17 from 8 to 3\r\nmove 3 from 3 to 4\r\nmove 1 from 7 to 6\r\nmove 5 from 2 to 3\r\nmove 8 from 4 to 1\r\nmove 2 from 6 to 4\r\nmove 1 from 2 to 7\r\nmove 1 from 1 to 4\r\nmove 1 from 8 to 2\r\nmove 2 from 7 to 4" +
                "\r\nmove 7 from 1 to 9\r\nmove 16 from 4 to 2\r\nmove 1 from 6 to 1\r\nmove 2 from 2 to 9\r\nmove 6 from 2 to 7\r\nmove 1 from 1 to 6\r\nmove 3 from 2 to 6\r\nmove 10 from 3 to 6\r\nmove 6 from 9 to 8\r\nmove 3 from 4 to 3" +
                "\r\nmove 6 from 9 to 2\r\nmove 4 from 3 to 7\r\nmove 10 from 2 to 5\r\nmove 2 from 2 to 6\r\nmove 3 from 6 to 3\r\nmove 1 from 8 to 2\r\nmove 1 from 2 to 6\r\nmove 5 from 6 to 1\r\nmove 3 from 6 to 7\r\nmove 5 from 8 to 4" +
                "\r\nmove 3 from 7 to 1\r\nmove 2 from 6 to 1\r\nmove 2 from 4 to 1\r\nmove 2 from 5 to 8\r\nmove 1 from 8 to 7\r\nmove 1 from 8 to 9\r\nmove 8 from 3 to 4\r\nmove 11 from 1 to 7\r\nmove 1 from 9 to 8\r\nmove 1 from 8 to 3" +
                "\r\nmove 3 from 6 to 3\r\nmove 1 from 6 to 8\r\nmove 3 from 5 to 2\r\nmove 1 from 8 to 6\r\nmove 2 from 5 to 8\r\nmove 3 from 5 to 6\r\nmove 3 from 2 to 4\r\nmove 2 from 8 to 4\r\nmove 22 from 7 to 3\r\nmove 12 from 3 to 2" +
                "\r\nmove 9 from 3 to 9\r\nmove 1 from 1 to 2\r\nmove 2 from 6 to 8\r\nmove 2 from 8 to 4\r\nmove 2 from 6 to 5\r\nmove 11 from 3 to 1\r\nmove 18 from 4 to 3\r\nmove 3 from 7 to 3\r\nmove 1 from 5 to 7\r\nmove 3 from 2 to 4" +
                "\r\nmove 2 from 4 to 9\r\nmove 6 from 1 to 4\r\nmove 1 from 5 to 1\r\nmove 10 from 9 to 3\r\nmove 27 from 3 to 9\r\nmove 6 from 2 to 8\r\nmove 5 from 4 to 2\r\nmove 3 from 3 to 8\r\nmove 1 from 7 to 8\r\nmove 10 from 8 to 2" +
                "\r\nmove 5 from 1 to 5\r\nmove 1 from 3 to 5\r\nmove 1 from 1 to 8\r\nmove 14 from 9 to 4\r\nmove 6 from 5 to 6\r\nmove 11 from 9 to 4\r\nmove 6 from 6 to 3\r\nmove 1 from 8 to 6\r\nmove 2 from 9 to 5\r\nmove 1 from 2 to 5" +
                "\r\nmove 8 from 2 to 1\r\nmove 12 from 4 to 7\r\nmove 1 from 6 to 8\r\nmove 14 from 4 to 1\r\nmove 1 from 9 to 8\r\nmove 1 from 5 to 1\r\nmove 2 from 5 to 2\r\nmove 11 from 1 to 6\r\nmove 11 from 6 to 1\r\nmove 1 from 8 to 7" +
                "\r\nmove 1 from 8 to 2\r\nmove 12 from 1 to 7\r\nmove 1 from 4 to 7\r\nmove 5 from 1 to 5\r\nmove 5 from 2 to 6\r\nmove 1 from 5 to 6\r\nmove 1 from 2 to 9\r\nmove 6 from 1 to 3\r\nmove 19 from 7 to 2\r\nmove 1 from 9 to 6" +
                "\r\nmove 9 from 3 to 2\r\nmove 9 from 2 to 7\r\nmove 3 from 5 to 8\r\nmove 1 from 5 to 1\r\nmove 3 from 3 to 9\r\nmove 7 from 2 to 9\r\nmove 15 from 7 to 2\r\nmove 10 from 9 to 4\r\nmove 4 from 4 to 9\r\nmove 1 from 6 to 4" +
                "\r\nmove 1 from 1 to 6\r\nmove 26 from 2 to 5\r\nmove 1 from 7 to 3\r\nmove 6 from 4 to 8\r\nmove 3 from 2 to 9\r\nmove 6 from 8 to 3\r\nmove 4 from 5 to 7\r\nmove 1 from 4 to 5\r\nmove 2 from 2 to 1\r\nmove 6 from 9 to 1" +
                "\r\nmove 3 from 3 to 8\r\nmove 3 from 2 to 8\r\nmove 3 from 7 to 9\r\nmove 6 from 1 to 7\r\nmove 2 from 3 to 2\r\nmove 2 from 2 to 5\r\nmove 1 from 8 to 6\r\nmove 4 from 7 to 3\r\nmove 10 from 5 to 3\r\nmove 4 from 9 to 1" +
                "\r\nmove 6 from 3 to 1\r\nmove 1 from 7 to 4\r\nmove 4 from 3 to 2\r\nmove 1 from 3 to 1\r\nmove 13 from 1 to 5\r\nmove 1 from 3 to 7\r\nmove 1 from 3 to 8\r\nmove 4 from 6 to 3\r\nmove 1 from 6 to 3\r\nmove 7 from 8 to 2" +
                "\r\nmove 1 from 6 to 9\r\nmove 2 from 7 to 2\r\nmove 1 from 9 to 5\r\nmove 2 from 8 to 6\r\nmove 1 from 7 to 5\r\nmove 1 from 3 to 1\r\nmove 30 from 5 to 2\r\nmove 1 from 3 to 4\r\nmove 2 from 6 to 1\r\nmove 5 from 3 to 4" +
                "\r\nmove 2 from 6 to 5\r\nmove 5 from 4 to 3\r\nmove 1 from 3 to 1\r\nmove 4 from 1 to 6\r\nmove 1 from 2 to 5\r\nmove 2 from 4 to 9\r\nmove 4 from 3 to 5\r\nmove 1 from 3 to 5\r\nmove 1 from 5 to 3\r\nmove 6 from 5 to 1" +
                "\r\nmove 2 from 1 to 9\r\nmove 4 from 6 to 2\r\nmove 1 from 3 to 5\r\nmove 1 from 5 to 2\r\nmove 1 from 5 to 2\r\nmove 8 from 2 to 5\r\nmove 4 from 9 to 6\r\nmove 3 from 1 to 4\r\nmove 3 from 6 to 2\r\nmove 2 from 4 to 2" +
                "\r\nmove 1 from 6 to 1\r\nmove 1 from 4 to 6\r\nmove 2 from 5 to 1\r\nmove 1 from 6 to 8\r\nmove 3 from 5 to 2\r\nmove 2 from 5 to 6\r\nmove 1 from 6 to 7\r\nmove 1 from 5 to 9\r\nmove 1 from 7 to 5\r\nmove 3 from 1 to 9" +
                "\r\nmove 3 from 9 to 5\r\nmove 31 from 2 to 6\r\nmove 1 from 1 to 3\r\nmove 1 from 8 to 9\r\nmove 30 from 6 to 9\r\nmove 2 from 9 to 8\r\nmove 13 from 2 to 3\r\nmove 4 from 5 to 2\r\nmove 1 from 8 to 4\r\nmove 1 from 4 to 1" +
                "\r\nmove 1 from 1 to 6\r\nmove 5 from 2 to 8\r\nmove 1 from 2 to 8\r\nmove 26 from 9 to 3\r\nmove 18 from 3 to 8\r\nmove 1 from 2 to 1\r\nmove 12 from 3 to 8\r\nmove 1 from 2 to 3\r\nmove 3 from 6 to 4\r\nmove 1 from 1 to 9" +
                "\r\nmove 11 from 8 to 5\r\nmove 1 from 4 to 7\r\nmove 9 from 3 to 9\r\nmove 1 from 7 to 8\r\nmove 11 from 8 to 3\r\nmove 11 from 3 to 2\r\nmove 11 from 2 to 9\r\nmove 19 from 9 to 8\r\nmove 3 from 5 to 7\r\nmove 2 from 4 to 2" +
                "\r\nmove 2 from 2 to 8\r\nmove 29 from 8 to 2\r\nmove 5 from 5 to 4\r\nmove 1 from 9 to 6\r\nmove 2 from 5 to 9\r\nmove 1 from 6 to 9\r\nmove 7 from 8 to 7\r\nmove 1 from 9 to 7\r\nmove 6 from 9 to 1\r\nmove 1 from 9 to 4" +
                "\r\nmove 1 from 5 to 4\r\nmove 15 from 2 to 5\r\nmove 3 from 1 to 7\r\nmove 5 from 5 to 2\r\nmove 1 from 8 to 3\r\nmove 1 from 5 to 8\r\nmove 2 from 3 to 6\r\nmove 1 from 3 to 8\r\nmove 9 from 2 to 1\r\nmove 1 from 8 to 7" +
                "\r\nmove 1 from 8 to 3\r\nmove 10 from 7 to 8\r\nmove 4 from 7 to 3\r\nmove 1 from 7 to 2\r\nmove 1 from 8 to 6\r\nmove 3 from 6 to 5\r\nmove 6 from 5 to 8\r\nmove 3 from 1 to 3\r\nmove 8 from 3 to 7\r\nmove 3 from 1 to 3" +
                "\r\nmove 4 from 8 to 3\r\nmove 1 from 4 to 5\r\nmove 4 from 1 to 4\r\nmove 1 from 4 to 5\r\nmove 1 from 7 to 4\r\nmove 4 from 4 to 1\r\nmove 2 from 8 to 7\r\nmove 6 from 5 to 2\r\nmove 2 from 8 to 1\r\nmove 6 from 4 to 7" +
                "\r\nmove 1 from 5 to 4\r\nmove 5 from 8 to 6\r\nmove 1 from 6 to 9";
            List<Stack<char>> cargo = new();
            for (int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0: char[] firstArray = { 'R', 'S', 'L', 'F', 'Q' }; Stack<char> one = new(firstArray); cargo.Add(one); break;
                    case 1: char[] secondArray = { 'N', 'Z', 'Q', 'G', 'P', 'T' }; Stack<char> two = new(secondArray); cargo.Add(two); break;
                    case 2: char[] thirdArray = { 'S', 'M', 'Q', 'B' }; Stack<char> three = new(thirdArray); cargo.Add(three); break;
                    case 3: char[] fourthArray = { 'T', 'G', 'Z', 'J', 'H', 'C', 'B', 'Q' }; Stack<char> four = new(fourthArray); cargo.Add(four); break;
                    case 4: char[] fifthArray = { 'P', 'H', 'M', 'B', 'N', 'F', 'S' }; Stack<char> five = new(fifthArray); cargo.Add(five); break;
                    case 5: char[] sixthArray = { 'P', 'C', 'Q', 'N', 'S', 'L', 'V', 'G' }; Stack<char> six = new(sixthArray); cargo.Add(six); break;
                    case 6: char[] seventhArray = { 'W', 'C', 'F' }; Stack<char> seven = new(seventhArray); cargo.Add(seven); break;
                    case 7: char[] eightArray = { 'Q', 'H', 'G', 'Z', 'W', 'V', 'P', 'M' }; Stack<char> eight = new(eightArray); cargo.Add(eight); break;
                    case 8: char[] ninthArray = { 'G', 'Z', 'D', 'L', 'C', 'N', 'R' }; Stack<char> nine = new(ninthArray); cargo.Add(nine); break;
                }
            }
            string[] directions = day5Input.Split("\r\n");                                      //Ex: "move 1 from 4 to 5"
            foreach (string direction in directions)
            {
                string numbers = Regex.Replace(direction, @"[a-zA-Z .]", "");                   //Ex:"145"
                List<char> numbersArray = new List<char>();
                /*for (int i = 0; i < Int32.Parse(numbers.Substring(0,numbers.Length-2)); i++)  //Using Stack Push and Pops
                    cargo[Int32.Parse(numbers.Substring(numbers.Length-1))-1].Push(cargo[Int32.Parse(numbers.Substring(numbers.Length - 2, 1))-1].Pop());*/
                for (int i = 0; i < Int32.Parse(numbers.Substring(0, numbers.Length - 2)); i++)    //Using a List to "Stack Crates" (Push in reverse order of what's moving from the Stack)
                    numbersArray.Add(cargo[Int32.Parse(numbers.Substring(numbers.Length - 2, 1)) - 1].Pop());
                numbersArray.Reverse();
                for (int i = 0; i < Int32.Parse(numbers.Substring(0, numbers.Length - 2)); i++)
                    cargo[Int32.Parse(numbers.Substring(numbers.Length - 1)) - 1].Push(numbersArray[i]);
            }
            Console.Write("The top crates in order are ");
            foreach (Stack<char> s in cargo)
                Console.Write(s.Peek());
            Console.ReadKey();

        }
    }
}
