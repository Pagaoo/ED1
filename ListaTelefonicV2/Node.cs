namespace ListaTelefonicV2
{
    public class Node
    {
    public Contatos data;
    public Node next, prev;

    public Node(Contatos contatos)
    {
      data = contatos;
      next = null;
    }
    }
}