using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Module_10
{
    public class Assignment
    {
        public Node Root { get; private set; }

        public void Start()
        {
            string rawIn = "";
         
            rawIn = Console.ReadLine();

            if(string.IsNullOrEmpty(rawIn)) Environment.Exit(0);

            rawIn =  rawIn.TrimStart();
        
            string[] nodes = rawIn.Split(" "); 
            
          
            for(int i = 0; i < nodes.Length; i++){
                int nd = Int32.Parse(nodes[i]);

                Add(nd);     
            } 

            BFS();
        }

        private void BFS(){
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(this.Root);
            
            while(queue.Count > 0){

                Node node = queue.Dequeue();

                Console.Write(node.Value + " ");

                if(node.Left != null){
                    queue.Enqueue(node.Left);
                }

                if(node.Right != null){
                    queue.Enqueue(node.Right);
                }
            }
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