using System;
using System.ComponentModel;

namespace Module_03{
    internal class Program{
        static void Main(string[] args){

            string songs = Console.ReadLine();
            string actions = Console.ReadLine();
            string startSong = Console.ReadLine();



            try{
                if(songs == "" || actions == "" || startSong == "") throw new Exception();
                PlayList playList = new PlayList(songs,actions,startSong);
                Console.WriteLine(playList.doActions());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }

        }
    }
}