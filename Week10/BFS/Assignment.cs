using System;
using System.Linq.Expressions;

namespace Module_10
{
    public class Assignment
    {
        public Node Root { get; private set; }

        public void Start()
        {
          /*  string rawIn = "";
         
            rawIn = Console.ReadLine();

            if(string.IsNullOrEmpty(rawIn)) Environment.Exit(0);

            rawIn =  rawIn.TrimStart();

            string aORd = rawIn.Substring(0,1);
        
            string[] nodes = rawIn.Split(" "); */
            
           string[] nodes = new string[]{"10","3","5","2","12","11"};

            for(int i = 1; i < nodes.Length; i++){
                int nd = Int32.Parse(nodes[i]);

                Add(nd);     
            } 

            BFS();

        }

        private void BFS(){            
            Node Left = this.Root.Left; 
            Node Right = this.Root.Right; 

            Console.Write(this.Root.Value);

            do{

                Console.Write(" "+ Left.Value + " " + Right.Value);


                if(Left != null)   Left = Left.Left; 
                if(Right != null) Right = Right.Right;


            }while(Left != null && Right != null);
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