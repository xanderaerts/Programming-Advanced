using System;
using System.Linq.Expressions;

namespace Module_10
{
    public class Assignment
    {
        public Node Root { get; private set; }
        private int LeftCounter=0; 
        private int RightCounter=0;

        public Assignment()
        {

        }

        public void Start()
        {
            string rawIn = "";
         
            rawIn = Console.ReadLine();

            if(string.IsNullOrEmpty(rawIn)) Environment.Exit(0);

            rawIn =  rawIn.TrimStart();

            string aORd = rawIn.Substring(0,1);
        
            string[] nodes = rawIn.Split(" ");

            for(int i = 0 ; i < nodes.Length; i++){
                int nd = Int32.Parse(nodes[i]);

                Add(nd);     
            } 

            Node testnode = this.Root;

            while(testnode.Left != null){
                this.LeftCounter++;

                testnode = testnode.Left;
            }

            while(testnode.Right != null){
                this.RightCounter++;

                testnode = testnode.Right;
            }

            int abs = Math.Abs(this.LeftCounter - this.RightCounter); 
            if(abs <= 1) Console.WriteLine("balanced");
            else Console.WriteLine("not balanced");

        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }
        }

        private void Add(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null) node.Left = new Node(value);
                else Add(node.Left, value);
            }
            else
            {
                if (node.Right == null) node.Right = new Node(value);
                else Add(node.Right, value);
            }
        }
    }
}