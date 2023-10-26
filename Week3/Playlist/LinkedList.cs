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
                this.Head = node;
            }
            else{
                Node prev = this.Head.Previvous;
                node.Next = this.Head;
                node.Previvous = prev;

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

        public bool Search(string data){
            Node iterator = this.Head;

            do{

                if(iterator.Data == data){
                    return true;
                }

                iterator = iterator.Next;
            }while(iterator != this.Head);

            return false;
        }
    }
}
