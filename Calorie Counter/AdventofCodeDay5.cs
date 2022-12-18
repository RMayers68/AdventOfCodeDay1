using System.Text.RegularExpressions;

namespace Calorie_Counter
{
    public class AdventofCodeDay5
    {
        public static void CrateStacker()
        {
            //Setup of input 
            string day5Input = File.ReadAllText("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day5.txt");
            List<Stack<char>> cargo = new();
            List<Stack<char>> cargo2 = new();
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
                for (int i = 0; i < Int32.Parse(numbers.Substring(0,numbers.Length-2)); i++)  //Using Stack Push and Pops
                    cargo[Int32.Parse(numbers.Substring(numbers.Length-1))-1].Push(cargo[Int32.Parse(numbers.Substring(numbers.Length - 2, 1))-1].Pop());
                //for (int i = 0; i < Int32.Parse(numbers.Substring(0, numbers.Length - 2)); i++)    //Using a List to "Stack Crates" (Push in reverse order of what's moving from the Stack)
                    //numbersArray.Add(cargo[Int32.Parse(numbers.Substring(numbers.Length - 2, 1)) - 1].Pop());
                //numbersArray.Reverse();
                //for (int i = 0; i < Int32.Parse(numbers.Substring(0, numbers.Length - 2)); i++)
                    //cargo[Int32.Parse(numbers.Substring(numbers.Length - 1)) - 1].Push(numbersArray[i]);
            }
            Console.Write("The top crates in cargo 1 are ");
            foreach (Stack<char> s in cargo)
                Console.Write(s.Peek());
            Console.Write("\nThe top crates in cargo 2 are ");
            foreach (Stack<char> s in cargo2)
                Console.Write(s.Peek());
            Console.ReadKey();

        }
    }
}
