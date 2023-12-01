using System;

namespace Trees
{
    public class Node
    {
        public int Value {get;set;}

        public Node Left {get;set;}

        public Node Right {get;set;}

        public Node(int value){
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
}
