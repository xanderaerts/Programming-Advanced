using System;

namespace Module_03 
{
    public class Node{
        public string Data {get;set;}
        public Node Next {get;set;}
        public Node Previvous {get;set;}

        public Node(string data ){
            this.Data = data;
            this.Next = null;
        }
    }


    public class PlayList
    {
        public string Next(){}

        public void Add(string data){}
        public void Remove(string data){}       
    }
}
