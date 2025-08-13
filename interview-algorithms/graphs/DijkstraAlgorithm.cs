namespace interview_algorithms.graphs
{
    public class DijkstraAlgorithm
    {
        private const int INF = int.MaxValue;
        
        public class Edge
        {
            public int Destination { get; set; }
            public int Weight { get; set; }
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Dijkstra's Algorithm...");
            
            // Create a graph with 5 vertices
            List<Edge>[] graph = new List<Edge>[5];
            for (int i = 0; i < 5; i++)
            {
                graph[i] = new List<Edge>();
            }
            
            // Add edges (vertex, weight)
            graph[0].Add(new Edge { Destination = 1, Weight = 10 });
            graph[0].Add(new Edge { Destination = 4, Weight = 5 });
            graph[1].Add(new Edge { Destination = 2, Weight = 1 });
            graph[1].Add(new Edge { Destination = 4, Weight = 2 });
            graph[2].Add(new Edge { Destination = 3, Weight = 4 });
            graph[3].Add(new Edge { Destination = 2, Weight = 6 });
            graph[3].Add(new Edge { Destination = 0, Weight = 7 });
            graph[4].Add(new Edge { Destination = 1, Weight = 3 });
            graph[4].Add(new Edge { Destination = 2, Weight = 9 });
            graph[4].Add(new Edge { Destination = 3, Weight = 2 });
            
            int[] distances = Dijkstra(graph, 0);
            
            Console.WriteLine("Shortest distances from source vertex 0:");
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] == INF)
                    Console.WriteLine($"Vertex {i}: INF");
                else
                    Console.WriteLine($"Vertex {i}: {distances[i]}");
            }
        }
        
        public static int[] Dijkstra(List<Edge>[] graph, int source)
        {
            int vertices = graph.Length;
            int[] distances = new int[vertices];
            bool[] visited = new bool[vertices];
            
            // Initialize distances
            for (int i = 0; i < vertices; i++)
            {
                distances[i] = INF;
            }
            distances[source] = 0;
            
            // Process all vertices
            for (int count = 0; count < vertices - 1; count++)
            {
                int u = GetMinDistanceVertex(distances, visited);
                visited[u] = true;
                
                // Update distances of adjacent vertices
                foreach (var edge in graph[u])
                {
                    int v = edge.Destination;
                    int weight = edge.Weight;
                    
                    if (!visited[v] && distances[u] != INF &&
                        distances[u] + weight < distances[v])
                    {
                        distances[v] = distances[u] + weight;
                    }
                }
            }
            
            return distances;
        }
        
        private static int GetMinDistanceVertex(int[] distances, bool[] visited)
        {
            int min = INF;
            int minIndex = -1;
            
            for (int v = 0; v < distances.Length; v++)
            {
                if (!visited[v] && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }
            
            return minIndex;
        }
    }
}
