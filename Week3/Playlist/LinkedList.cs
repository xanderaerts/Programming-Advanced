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
            Node found = this.Search(data);

            if(found != null){
                Node prev = found.Previvous;
                Node next = found.Next;

                if(prev == next && prev != found.Previvous && next != found.Next){
                    this.Head.Data = prev.Data;
                    this.Head.Previvous = prev;
                    this.Head.Next = prev;
                    //prev.Previvous = prev;
                   // prev.Next = prev;
                    return; 
                }
                else if(prev == next && prev == found && next == found){
                   this.Head.Data = null;
                   this.Head.Next = null; 
                   this.Head.Previvous = null;
                   return;
                }

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
