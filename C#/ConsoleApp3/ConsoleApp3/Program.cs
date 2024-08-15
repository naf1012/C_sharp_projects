using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an example graph
            int vertices = 7;
            List<int>[] adjacencyList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }

            // Add edges
            AddEdge(adjacencyList, 0, 1);
            AddEdge(adjacencyList, 0, 2);
            AddEdge(adjacencyList, 1, 3);
            AddEdge(adjacencyList, 1, 4);
            AddEdge(adjacencyList, 2, 5);
            AddEdge(adjacencyList, 2, 6);

            // Print the adjacency list representation of the graph
            Console.WriteLine("Graph (Adjacency List Representation):");
            for (int i = 0; i < vertices; i++)
            {
                Console.Write(i + " -> ");
                foreach (int neighbor in adjacencyList[i])
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nBFS Traversal:");
            BFS(0, adjacencyList);

            Console.WriteLine("\n\nDFS Traversal:");
            bool[] visited = new bool[vertices];
            DFS(0, adjacencyList, visited);
        }

        static void AddEdge(List<int>[] adjacencyList, int src, int dest)
        {
            adjacencyList[src].Add(dest);
            adjacencyList[dest].Add(src); // For undirected graph
        }

        static void BFS(int start, List<int>[] adjacencyList)
        {
            bool[] visited = new bool[adjacencyList.Length];
            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.Write(node + " ");

                foreach (var neighbor in adjacencyList[node])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        static void DFS(int node, List<int>[] adjacencyList, bool[] visited)
        {
            visited[node] = true;
            Console.Write(node + " ");

            foreach (var neighbor in adjacencyList[node])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, adjacencyList, visited);
                }
            }
        }
    }
}
