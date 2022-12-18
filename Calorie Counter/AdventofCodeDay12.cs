namespace Calorie_Counter
{
    public class AdventofCodeDay12
        
    {
        public static void HillClimbingAlgorithm()
        {
            var day12Input = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day12.txt"); 
            int mapHeight = day12Input.Length;
            int mapWidth = day12Input[0].Length;
            var heightmap = new int[mapHeight, mapWidth];
            var start = ((0, 0), 0);
            var end = ((0, 0), 0);

            for (int x = 0; x < mapHeight; x++)
            {
                for (int y = 0; y < mapWidth; y++)
                {
                    if (day12Input[x][y] == 'S')
                    {
                        heightmap[x, y] = 1;
                        start = ((x, y), 1);
                    }
                    else if (day12Input[x][y] == 'E')
                    {
                        heightmap[x, y] = 26;
                        end = ((x, y), 26);
                    }
                    else
                        heightmap[x, y] = day12Input[x][y] - 'a' + 1;
                }
            }

            int fewestStepsFromStart = GetShortestPath(heightmap, start, end, true);
            int fewestStepsOverall = GetShortestPath(heightmap, start, end, false);

            Console.WriteLine($"The fewest steps from the starting position: {fewestStepsFromStart}\nThe fewest steps from any lowest position: {fewestStepsOverall}.\n");
            Console.ReadKey();

            //Breadth-first search algorithm - procedure BFS(graph G, starting vertex root of G)
            static int GetShortestPath(int[,] heightmap, ((int, int), int) start, ((int, int), int) end, bool isPartOne)
            {
                int mapHeight = heightmap.GetLength(0);
                int mapWidth = heightmap.GetLength(1);
                List<(int x, int y)> neighbours = new() { (-1, 0), (1, 0), (0, -1), (0, 1) };

                //let Q be a queue
                var queue = new Queue<((int x, int y), int step)>();
                //(a list to store the visited nodes)
                var visited = new HashSet<(int x, int y)>();

                //label root as explored
                //(start from S for part 1, and from any node of height value 1 for part 2)
                if (isPartOne)
                    queue.Enqueue(((start.Item1.Item1, start.Item1.Item2), 0));
                else
                {
                    for (int x = 0; x < mapHeight; x++)
                    {
                        for (int y = 0; y < mapWidth; y++)
                            if (heightmap[x, y] == 1)
                                //Q.enqueue(root)
                                queue.Enqueue(((x, y), 0));
                    }
                }

                //while Q is not empty do
                while (queue.Any())
                {
                    //v := Q.dequeue() - define the current node as the first in the queue
                    ((int x, int y), int step) = queue.Dequeue();

                    //(check if current node has been visited, if yes, skip exploration and adding to the queue)
                    if (!visited.Add((x, y)))
                        continue;

                    //if v is the goal then - current node is end node, so break the loop
                    if (x == end.Item1.Item1 && y == end.Item1.Item2)
                        //return v
                        return step;

                    //for all edges from v to w in G.adjacentEdges(v) do
                    foreach ((int dx, int dy) in neighbours)
                    {
                        var dxPos = x + dx;
                        var dyPos = y + dy;

                        //if w is not labeled as explored then
                        //label w as explored
                        if ((dxPos >= 0 && dxPos < mapHeight) && (dyPos >= 0 && dyPos < mapWidth))
                        {
                            //w.parent := v - define the child node and the current node as its parent
                            var parentNode = heightmap[x, y];
                            var childNode = heightmap[dxPos, dyPos];

                            //Q.enqueue(w)
                            if (childNode - parentNode <= 1)
                                queue.Enqueue(((dxPos, dyPos), step + 1));
                        }
                    }
                }
                //no roots (starting node(s)), so no path
                return 0;
            }
        }
    }
}
