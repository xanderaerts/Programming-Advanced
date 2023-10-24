using System;

namespace Module_03
{

    public class Node{
        public int TimeStamp {get;set;} 
        public int ParkingDuration {get; set;}

        public Node Next {get;set;}

        public Node(int TS, int PD ){
            this.TimeStamp = TS;
            this.ParkingDuration = PD;
            this.Next = null;
        }
    }

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
                this.Head = null;
            }
            else{
                Last().Next = node; 
            }
        }

        public void Remove(int data){
            if(this.Head.TimeStamp == data){
                Head = Head.Next;
                return;
            }
            else{
                Node current = this.Head;
                Node previous = null;

                while(current != null && current.TimeStamp != data){
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

        public bool Search(int data){
            Node iterator = this.Head;

            while(iterator != null){

                if(iterator.TimeStamp == data){
                    return true;
                }

                iterator = iterator.Next;
            }

            return false;
        }
    }
}
