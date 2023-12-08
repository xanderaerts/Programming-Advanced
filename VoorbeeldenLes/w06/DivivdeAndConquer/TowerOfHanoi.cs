using System;

namespace DivivdeAndConquer
{
    public class TowerOfHanoi
    {
        public void Solve(int disks, char from, char to, char other){
            if(disks == 1)Console.WriteLine($"{disks}: {from} --> {to}");
            else{
                Solve(disks - 1,from,other, to);
                Console.WriteLine($"{disks}: {from} --> {to} ");
                Solve(disks - 1,other, to , from);
            }
        }            
    }
}
