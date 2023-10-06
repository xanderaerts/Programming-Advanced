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
            
        }

        public bool Search(string data){
            return true;
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
