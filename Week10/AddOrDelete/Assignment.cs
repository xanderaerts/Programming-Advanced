using System;
using System.Linq.Expressions;

namespace Module_10
{
    public class Assignment
    {
        public Node Root { get; private set; }

        public Assignment()
        {

        }

        public void Start()
        {
            string rawIn = "";
            do{
                rawIn = Console.ReadLine();

                if(string.IsNullOrEmpty(rawIn)) Environment.Exit(0);

               rawIn =  rawIn.TrimStart();

                string aORd = rawIn.Substring(0,1);

                if(aORd == "A"){
                    string[] nodes = rawIn.Split(" ");

                    for(int i = 1; i < nodes.Length; i++){
                        int nd = Int32.Parse(nodes[i]);

                        Add(nd);     

                    }
                    
                    TraverseInOrder();

                    Console.Write("\n");
                }
                else if(aORd == "D"){                    
                    string[] nodes = rawIn.Split(" "); 

                    int nd = Int32.Parse(nodes[1]);

                    Delete(nd);

                    TraverseInOrder();
                    Console.Write("\n");
                }
                else{
                    throw new Exception();
                }

            }while(!string.IsNullOrWhiteSpace(rawIn));

        }

        public void Delete(int NodeValue){
           Delete(NodeValue,Root); 
        }

        public Node Delete(int NodeValue,Node node){

            if( null== this.Root){
                Console.Write("Tree is empty!");
            }

            if(node == null) return node;

            if(node.Value > NodeValue){
                node.Left = Delete(NodeValue,node.Left);
                return node;
            }
            else if(node.Value < NodeValue){
                node.Right = Delete(NodeValue,node.Right);
                return node;
            }

            else{

                if(node.Right == null && node.Left == null && node == this.Root){
                    Console.Write("Tree is empty!");
                    node = null; 
                    this.Root = null;
                    return node;
                }
                else if(node.Right == null && this.Root == node){
                   Node temp = node.Left;
                   this.Root = node.Left;

                   node = null; 
                   return temp; 
                }

                else if(node.Left == null && node == this.Root){
                    Node temp = node.Right;

                    this.Root = node.Right; 
                    node = null;
                    return temp;
                }
                else if(node.Left == null){
                    Node temp = node.Right;
                    node = null; 
                    return temp;
                }


                else if(node.Right == null){
                    Node temp = node.Left;
                    node = null; 
                    return temp;
                }

                else{

                    Node currentNode = node; 

                    Node next = node.Right;

                    while(next.Left != null){
                        currentNode = next; 
                        next = next.Left;
                    }

                    if(currentNode != node){
                        currentNode.Left = next.Right;
                    }
                    else{
                        currentNode.Right = next.Right;
                    }

                    node.Value = next.Value;

                    next = null; 
                    return node;
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

        public void TraverseInOrder()
        {
            TraverseInOrder(Root);

        }
        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {

                TraverseInOrder(node.Left);
                Console.Write(node.Value + " ");
                TraverseInOrder(node.Right);
            }
        }
    }
}
