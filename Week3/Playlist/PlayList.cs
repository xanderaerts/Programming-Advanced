using System;
using System.Security.Cryptography.X509Certificates;

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
        public string InputSongs {get;set;}
        public string InputActions {get;set;}
        public string StartSong {get;set;}
        public LinkedList Songs = new LinkedList();
        public Node currentSong = null;

        public PlayList(string songs,string actions,string startSong){
            this.InputSongs = songs;
            this.InputActions = actions;
            this.StartSong = startSong;            
        }
        
        public string doActions(){
            string playingSongs = "";

            foreach(string song in this.InputSongs.Split(" ")){
                this.Add(song);
            }

            this.currentSong = this.Songs.Search(this.StartSong);
            if(this.currentSong == null) playingSongs += "Not found";
            else playingSongs += this.currentSong.Data;

            
            foreach(string action in this.InputActions.Split(" ")){
                if(action == "next"){
                    string NextSong = this.Next();
                   if(this.currentSong != null && NextSong != null) playingSongs += " " + NextSong;
                }
                else if(action == "previous"){
                    playingSongs += " " + this.Previous();
                }
                else if(action.StartsWith("add:")){
                    string song = action.Substring(4);
                    
                    if(song == "") throw new Exception();
                    
                    this.Add(song);
                }
                else if(action.StartsWith("remove:")){
                    string song = action.Substring(7);
                    this.Remove(song);
                    
                    if(song == "") throw new Exception();

                    if(Songs.Head.Data == null && Songs.Head.Next == null){
                        this.currentSong = null;
                    }
                    continue;
                }
                else{
                    throw new Exception();
                }

                if(Songs.Head.Data == null && Songs.Head.Next == null){
                    playingSongs += " empty";
                }
            }

            return playingSongs;

        }

        public string Next(){

            if(this.currentSong == null){
                this.currentSong =  Songs.Head;
            }else{
                Node next = this.currentSong.Next;
                this.currentSong = next;
            }

            if(currentSong == null) return null;
            return currentSong.Data;
        }

        public string Previous(){
            Node prev = this.currentSong.Previvous;
            this.currentSong = prev;
            return this.currentSong.Data;
        }

        public void Add(string data){
            this.Songs.Insert(new Node(data));            
        }
        public void Remove(string data){
            this.Songs.Remove(data);
        }       
    }
}
