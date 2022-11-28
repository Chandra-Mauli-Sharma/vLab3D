namespace LinkedSimulation
{
    public class Node
    {
        public string node;
        public int position;
        public int loc;

        public Node(string node, int position,int location)
        {
            this.node = node;
            this.position = position;
            this.loc=location;
        }
    }
}