using System;

namespace Module_03
{
    public class LinkedList
    {  
        public Node Head {get;set;}

        public LinkedList(){
            Head = null;
        }

        public LinkedList(Node head){
            this.Head = head;
        }

        public Node Last(){
            Node iterator = Head;

            while(iterator.Next != null){
                iterator = iterator.Next;
            }

            return iterator;
        }

        public void Insert(Node node){
            if(this.Head == null){
                this.Head = node;
            }
            else{
                Last().Next = node; 
                Last().Previvous = node;
            }
        }

        public void Remove(string data){
            if(this.Head.Data == data){
                Head = Head.Next;
                return;
            }
            else{
                Node current = this.Head;
                Node previous = null;

                while(current != null && current.Data != data){
                    previous = current;
                    current = current.Next;
                }

                if(current == null){
                    return;
                }
                else{
                    previous.Next = current.Next;
                }
            }
        }

        public bool Search(string data){
            Node iterator = this.Head;

            while(iterator != null){

                if(iterator.Data == data){
                    return true;
                }

                iterator = iterator.Next;
            }

            return false;
        }
    }
}
