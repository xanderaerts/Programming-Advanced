using System;

namespace Module_03{
    internal class Program{
        static void Main(string[] args){

            string songs = Console.ReadLine();
            string actions = Console.ReadLine();
            string startSong = Console.ReadLine();

            PlayList playList = new PlayList(songs,actions,startSong);


        }
    }
}