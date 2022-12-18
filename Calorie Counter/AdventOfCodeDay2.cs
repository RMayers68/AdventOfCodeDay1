namespace Calorie_Counter
{
    public class AdventOfCodeDay2
    {
        public static void RPSChampionship()
        {
            string[] outcomes = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day2.txt");
            int totalPoints = 0;
            foreach(string outcome in outcomes)
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
            }
            Console.WriteLine($"You scored {totalPoints} total points in the championship using Method 2!");
            totalPoints = 0;
            foreach (var outcome in outcomes)
            {
                int roundOutcome = 0, shapeSelected = 1;                                                                  //First Char is Enemy Move, Second is Player Move
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
                    totalPoints += (roundOutcome+shapeSelected);
            }
            Console.WriteLine($"You scored {totalPoints} total points in the championship using Method 1!");
            Console.ReadKey();
        }
    }
}
