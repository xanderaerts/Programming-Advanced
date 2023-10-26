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
            this.Previvous = null;
        }
    }


    public class PlayList
    {
        public string Songs {get;set;}
        public string Actions {get;set;}
        public string StartSong {get;set;}

        public PlayList(string songs,string actions,string startSong){
            this.Songs = songs;
            this.Actions = actions;
            this.StartSong = startSong;            
        }

        public string Next(){}

        public void Add(string data){}
        public void Remove(string data){}       
    }
}
