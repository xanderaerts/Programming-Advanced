using System;
using System.Reflection.Emit;

namespace LinkedList
{
    public class Node{
        public string Data {get;set;}

        public Node Next {get;set;}

        public Node(string data){
            Data = data;
            Next = null; 
        }
    }

    public class LinkedList
    {
        public Node Head {get;set;}

        public LinkedList( ){
            Head = null;
        }

        public LinkedList(Node head){
            Head = head;
        }

        private Node Last(){
            Node iterator = Head;

            while(iterator.Next != null){
                iterator = iterator.Next;
            }

            return iterator;

        }

        public void Instert(Node node){
           if(Head == null){
                Head = node;
           } 
           else{

                Last().Next = node;
           }
        }

        public void Remove(string data){
        if(Head.Data == data)
            {
                Head = Head.Next;
                return;
            }
            else
            {
                Node current = Head;
                Node previous = null;
                while (current != null  && current.Data != data)
                {
                    previous = current;
                    current = current.Next;
                }
                if(current == null)
                {
                    return;
                }
                else
                {
                    previous.Next = current.Next;
                }
    }


        }

        public bool Search(string data){
            Node iterator = Head;

            while(iterator != null){
                
                if(iterator.Data == data){
                    return true;
                }

                iterator = iterator.Next;
            }

            return false;
        }

        public override string ToString()
        {
            string list = "HEAD: ";

            Node iterator = Head;

            while(iterator != null){
                list += iterator.Data + " --> ";
                iterator = iterator.Next;
            }

            return list;
        }

    }
}
