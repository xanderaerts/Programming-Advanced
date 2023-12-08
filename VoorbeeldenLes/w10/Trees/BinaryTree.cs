using System;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Trees
{
    public class BinaryTree
    {

        public Node Root {get; private set;}

        public BinaryTree(){
            Root = null;
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
           if(value < node.Value){
                if(node.Left == null) node.Left = new Node(value);
                else Add(node.Left,value);
                //Console.WriteLine(value);
           }
           else{
                if(node.Right == null) node.Right = new Node(value);
                else Add(node.Right,value);
                //Console.WriteLine(value);
           }
        }

        public void TraverseInOrder(){
            TraverseInOrder(Root);

        }
        private void TraverseInOrder(Node node){
            if(node != null){

                TraverseInOrder(node.Left);
                Console.Write(node.Value + " ");
                TraverseInOrder(node.Right);
            }
        }
        
        public void TraversePreOrder(){
            TraversePreOrder(Root);
        }
        private void TraversePreOrder(Node node){
            if(node != null){

                TraversePreOrder(node.Left);
                TraversePreOrder(node.Right);

                Console.Write(node.Value + " ");
            }
        }
        
        public void TraversePostOrder(){
            TraversePostOrder(Root);
        }

        private void TraversePostOrder(Node node){

            if(node != null ){
                TraversePostOrder(node.Left);
                TraversePostOrder(node.Right);

                Console.Write(node.Value + " ");
            }

        }

        public bool Search(int value)
        {
            return Search(Root, value);
        }

        private bool Search(Node current, int value)
        {
            if(current == null)
            {
                return false;
            }
            
            if(value < current.Value)
            {
                return Search(current.Left, value);
            }
            if(value > current.Value)
            {
                return Search(current.Right, value);
            }
            return true;
        }
        	
        public int FindMax(){
            Node node = Root;

            while(node.Right != null){
                node = node.Right;
            }

            return node.Value;
        }

        public int FindMin(){
            Node node = Root;

            while(node.Left != null){
                node = node.Left;
            }

            return node.Value;
        }

        public int FindMaxRec(){
            if(Root == null) throw new Exception("Tree is empty!");

            if(Root.Right == null) return Root.Value;

            return FindMaxRec(Root);
        }

        private int FindMaxRec(Node node){
            if(node.Right == null) return node.Value;

            return FindMaxRec(node.Right);
        }


    }
    
}

        
