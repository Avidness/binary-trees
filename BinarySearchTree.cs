namespace BinaryTrees
{
  public class BinarySearchTree
  {
    public Node Root;

    public void Add(int val)
    {
      Root = Add(Root, val);
    }

    public Node Add(Node node, int val)
    {
      if (node == null)
      {
        node = new Node() { Value = val };
        return node;
      }
      
      else if (node.Value <= val)
        node.Right = Add(node.Right, val);

      else if (node.Value > val)
        node.Left = Add(node.Left, val);

      return node;
    }
  }
}
