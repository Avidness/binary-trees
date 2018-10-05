using System;
using System.Collections.Generic;

namespace BinaryTrees
{
  class Program
  {
    public static void printBFS(Node root)
    {
      Queue<Node> queue = new Queue<Node>();
      queue.Enqueue(root);

      while(queue.Count > 0){
        var cur = queue.Dequeue();
        Console.Write(cur.Value + " ");
        if(cur.Left != null)
          queue.Enqueue(cur.Left);
        if(cur.Right != null)
          queue.Enqueue(cur.Right);
      }
    }

    public static void printDFS(Node root)
    {
      if(root == null)
        return;

      Console.Write(root.Value + " ");
      printDFS(root.Left);
      printDFS(root.Right);
    }

    public static void getLevelVals(Node root, int destLvl)
    {
      getLevelVals(root, 0, destLvl);
    }

    public static void getLevelVals(Node root, int curLvl, int destLvl)
    {
      if(root == null)
        return;

      if(curLvl == destLvl){
        Console.Write(root.Value + " ");
        return;
      }
      getLevelVals(root.Left, curLvl+1, destLvl);
      getLevelVals(root.Right, curLvl+1, destLvl);
    }

    static void Main(string[] args)
    {
      BinarySearchTree tree = new BinarySearchTree();
      tree.Add(5);
      tree.Add(3);
      tree.Add(2);
      tree.Add(9);
      tree.Add(1);
      tree.Add(20);
      tree.Add(15);
      tree.Add(7);
      BTreePrinter.Print(tree.Root, 0);

      Console.WriteLine("\n\nBFS");
      printBFS(tree.Root);
      
      Console.WriteLine("\n\nDFS");
      printDFS(tree.Root);

      Console.WriteLine("\n\nValues at level [2]");
      getLevelVals(tree.Root, 2);
    }
  }
}
