using System;
using System.Runtime.CompilerServices;

namespace Module_03
{
    public class LinkedList
    {  
        public Node Head {get;set;}

        public LinkedList(){
            Head = null;
        }

        public LinkedList(Node node){
            this.Head = node;
        }

        public void Insert(Node node){
            if(this.Head == null) {
                node.Next = node;
                node.Previvous = node;
                this.Head = node;
            }
            else{
                Node lastNode = this.Head.Previvous;

                lastNode.Next = node;
                node.Previvous = lastNode;
                node.Next = this.Head;
                this.Head.Previvous = node;

            }
        }

        public void Remove(string data){
            Node iterator = this.Head;
            bool found = false;
            do{

                if(iterator.Data == data){
                    found = true;
                    break;
                }

                iterator = iterator.Next;
            }while(iterator != this.Head);

            if(found){
                Node prev = iterator.Previvous;
                Node next = iterator.Next;

                prev.Next = next;
                next.Previvous = prev;
            }
        }

        public Node Search(string data){
            Node iterator = this.Head;

            do{

                if(iterator.Data == data){
                    return iterator;
                }

                iterator = iterator.Next;
            }while(iterator != this.Head);

            return null;
        }
    }
}
