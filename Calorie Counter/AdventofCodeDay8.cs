namespace Calorie_Counter
{
    public class AdventofCodeDay8
    {
        public static void TreetopTreeHouse()
        {
            var rows = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day8.txt");
            string[] columns = new string[rows[0].Length];

            for (int i = 0; i < rows[0].Length; i++)
            {
                for (int j = 0; j < rows.Length; j++)
                {
                    columns[i] += rows[j].Substring(i, 1);
                }
            }

            int visibleTrees = (2 * rows.Length + 2 * columns.Length - 4), scenicScore = 0;

            for (int i = 1; i < rows.Length - 1; i++)
            {
                for (int j = 1; j < rows[0].Length - 1; j++)
                {
                    bool[] visible = { true, true, true, true };
                    char a = rows[i][j];
                    int left = 0, right = 0, above = 0, below = 0;
                    string leftRow = rows[i].Substring(0, j);
                    string rightRow = rows[i].Substring(j + 1);
                    string aboveColumn = columns[j].Substring(0, i);
                    string belowColumn = columns[j].Substring(i + 1);
                    for (int k = leftRow.Length - 1; k >= 0; k--)
                    {
                        if (!visible[0] || leftRow == null)
                        {
                            break;
                        }
                        visible[0] = a > leftRow[k];
                        left++;
                    }
                    foreach (char c in rightRow)
                    {
                        if (!visible[1] || rightRow == null)
                        {
                            break;
                        }
                        visible[1] = a > c;
                        right++;
                    }
                    for (int k = aboveColumn.Length - 1; k >= 0; k--)
                    {
                        if (!visible[2] || aboveColumn == null)
                        {
                            break;
                        }
                        visible[2] = a > aboveColumn[k];
                        above++;
                    }
                    foreach (char c in belowColumn)
                    {
                        if (!visible[3] || belowColumn == null)
                        {
                            break;
                        }
                        visible[3] = a > c;
                        below++;
                    }
                    if (visible.Contains(true))
                        visibleTrees++;
                    if ((left * right * above * below) > scenicScore)
                        scenicScore = left * right * above * below;
                }
            }
            Console.WriteLine($"The amount of visible trees from the outside of the grid: {visibleTrees}.");
            Console.WriteLine($"Highest Scenic Score:{scenicScore}");
            Console.ReadKey();
        }
    }
}
