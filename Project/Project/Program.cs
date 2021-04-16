using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Problems;

namespace Project
{

    class Program
    {
        static void Main(string[] args)
        {
            #region BreadthFirst

            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);
            #endregion

            #region DFS
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("\nPreorder traversal "
                              + "of binary tree is ");
            tree.printPreorder();

            Console.WriteLine("\nInorder traversal "
                              + "of binary tree is ");
            tree.printInorder();

            Console.WriteLine("\nPostorder traversal "
                              + "of binary tree is ");
            tree.printPostorder();
            #endregion

            #region Topological
            Graph2 gt = new Graph2(6);
            gt.AddEdge2(5, 2);
            gt.AddEdge2(5, 0);
            gt.AddEdge2(4, 0);
            gt.AddEdge2(4, 1);
            gt.AddEdge2(2, 3);
            gt.AddEdge2(3, 1);

            Console.WriteLine("\nFollowing is a Topological "
                              + "sort of the given graph");

            // Function Call
            gt.TopologicalSort();
            #endregion

          
            #region SCC
            var g7 = new Graph7(new[,] {
            {1, 0}, {0, 2}, {2, 1}, {0, 3}, {3, 4}});

            var sccs = g7.GetStronglyConnectedComponents();

            Console.WriteLine("\nFollowing are strongly connected components in given graph ");
            foreach (var scc in sccs)
            Console.WriteLine(String.Join(",", scc));
            #endregion
            
            #region MSTK
            int V = 4; // Number of vertices in graph
            int E = 5; // Number of edges in graph
            Graph5 graph = new Graph5(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 10;

            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 6;

            // add edge 0-3
            graph.edge[2].src = 0;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = 5;

            // add edge 1-3
            graph.edge[3].src = 1;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 15;

            // add edge 2-3
            graph.edge[4].src = 2;
            graph.edge[4].dest = 3;
            graph.edge[4].weight = 4;

            // Function call
            graph.KruskalMST();
            #endregion

            #region MSTP
            int[,] graph6 = new int[,] { { 0, 2, 0, 6, 0 },
                                      { 2, 0, 3, 8, 5 },
                                      { 0, 3, 0, 0, 7 },
                                      { 6, 8, 0, 0, 9 },
                                      { 0, 5, 7, 9, 0 } };

            // Print the solution
            primMST(graph6);
            #endregion

            Console.ReadLine();
        }

        private static void primMST(int[,] graph6)
        {
            throw new NotImplementedException();
        }
    }
}
