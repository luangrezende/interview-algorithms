namespace interview_algorithms.graphs
{
    public class Graph
    {
        private int vertices;
        private List<int>[] adjacencyList;
        
        public Graph(int v)
        {
            vertices = v;
            adjacencyList = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }
        
        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
        }
        
        public void AddUndirectedEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }
        
        public void DepthFirstSearch(int startVertex)
        {
            bool[] visited = new bool[vertices];
            Console.WriteLine("DFS Traversal starting from vertex " + startVertex + ":");
            DFSUtil(startVertex, visited);
            Console.WriteLine();
        }
        
        private void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");
            
            foreach (int adjacentVertex in adjacencyList[vertex])
            {
                if (!visited[adjacentVertex])
                {
                    DFSUtil(adjacentVertex, visited);
                }
            }
        }
        
        public void BreadthFirstSearch(int startVertex)
        {
            bool[] visited = new bool[vertices];
            Queue<int> queue = new Queue<int>();
            
            visited[startVertex] = true;
            queue.Enqueue(startVertex);
            
            Console.WriteLine("BFS Traversal starting from vertex " + startVertex + ":");
            
            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                Console.Write(vertex + " ");
                
                foreach (int adjacentVertex in adjacencyList[vertex])
                {
                    if (!visited[adjacentVertex])
                    {
                        visited[adjacentVertex] = true;
                        queue.Enqueue(adjacentVertex);
                    }
                }
            }
            Console.WriteLine();
        }
        
        // Check if graph has cycle (for directed graph)
        public bool HasCycle()
        {
            bool[] visited = new bool[vertices];
            bool[] recStack = new bool[vertices];
            
            for (int i = 0; i < vertices; i++)
            {
                if (HasCycleUtil(i, visited, recStack))
                    return true;
            }
            
            return false;
        }
        
        private bool HasCycleUtil(int vertex, bool[] visited, bool[] recStack)
        {
            if (recStack[vertex])
                return true;
                
            if (visited[vertex])
                return false;
                
            visited[vertex] = true;
            recStack[vertex] = true;
            
            foreach (int adjacentVertex in adjacencyList[vertex])
            {
                if (HasCycleUtil(adjacentVertex, visited, recStack))
                    return true;
            }
            
            recStack[vertex] = false;
            return false;
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Graph Algorithms...");
            
            Graph graph = new Graph(6);
            graph.AddEdge(5, 2);
            graph.AddEdge(5, 0);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);
            
            graph.DepthFirstSearch(5);
            graph.BreadthFirstSearch(5);
            
            Console.WriteLine($"Graph has cycle: {graph.HasCycle()}");
        }
    }
}
