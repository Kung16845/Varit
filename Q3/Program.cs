using System;

class Graph
{
    private int[,] adjacencyMatrix;
    private int numNodes;

    public Graph(int numNodes)
    {
        this.numNodes = numNodes;
        adjacencyMatrix = new int[numNodes, numNodes];
    }

    public void AddEdge(int source, int destination)
    {
        adjacencyMatrix[source, destination] = 1;
    }

    public bool IsReachable(int source, int destination)
    {
        bool[] visited = new bool[numNodes];
        DFS(source, visited);

        return visited[destination];
    }

    private void DFS(int node, bool[] visited)
    {
        visited[node] = true;

        for (int i = 0; i < numNodes; i++)
        {
            if (adjacencyMatrix[node, i] == 1 && !visited[i])
            {
                DFS(i, visited);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of nodes in the graph: ");
        int numNodes = int.Parse(Console.ReadLine());

        Graph graph = new Graph(numNodes);

        Console.WriteLine("Enter edges as pairs of nodes (0 <= i,j < n) (negative or out of range values to stop):");
        while (true)
        {
            Console.Write("Source: ");
            int source = int.Parse(Console.ReadLine());
            if (source < 0 || source >= numNodes) break;

            Console.Write("Destination: ");
            int destination = int.Parse(Console.ReadLine());
            if (destination < 0 || destination >= numNodes) break;

            graph.AddEdge(source, destination);
        }

        Console.WriteLine("Enter pairs of nodes to check reachability (0 <= i,j < n):");
        while (true)
        {
            Console.Write("Source: ");
            int source = int.Parse(Console.ReadLine());
            if (source < 0 || source >= numNodes) break;

            Console.Write("Destination: ");
            int destination = int.Parse(Console.ReadLine());
            if (destination < 0 || destination >= numNodes) break;

            if (graph.IsReachable(source, destination))
            {
                Console.WriteLine("Reachable");
                break;
            }
            else
            {
                Console.WriteLine("Unreachable");
                break;
            }
        }
    }
}
