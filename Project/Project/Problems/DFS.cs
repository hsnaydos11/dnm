using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Problems
{

    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    class BinaryTree
    {
        // Root of Binary Tree
        public Node root;

        public BinaryTree() { root = null; }

        /* Given a binary tree, print
           its nodes according to the
           "bottom-up" postorder traversal. */
        public void PrintPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            PrintPostorder(node.left);

            // then recur on right subtree
            PrintPostorder(node.right);

            // now deal with the node
            Console.Write(node.key + " ");
        }

        /* Given a binary tree, print
           its nodes in inorder*/
        public void PrintInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            PrintInorder(node.left);

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* now recur on right child */
            PrintInorder(node.right);
        }

        /* Given a binary tree, print
           its nodes in preorder*/
        public void PrintPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.key + " ");

            /* then recur on left sutree */
            PrintPreorder(node.left);

            /* now recur on right subtree */
            PrintPreorder(node.right);
        }

        // Wrappers over above recursive functions
        public void printPostorder() { PrintPostorder(root); }
        public void printInorder() { PrintInorder(root); }
        public void printPreorder() { PrintPreorder(root); }
    }
}
