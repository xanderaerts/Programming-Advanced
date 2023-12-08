using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WeightedGraphs
{
    public class Maze
    {
        private int AmountNodes;

        public List<int>[] graph {get;set;}

        public Maze(int amountNodes){
            this.AmountNodes = amountNodes;  

            this.graph = new List<int>[amountNodes];   


            for(int i = 0; i < this.AmountNodes; i++){
                this.graph[i] = new List<int>();
            }      
        }

        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
            graph[node2].Add(node1);

        }

        public void Dijksta(int startnode){
            List<int> visited = new List<int>();

            int[] distances = new int[this.AmountNodes];
            int[] previous = new int[this.AmountNodes];

            for(int i = 0; i < this.AmountNodes; i++){
                distances[i] = Int32.MaxValue;
                previous[i] = -1;
            }

            distances[startnode] = 0;

            while(true){

                int node = GetNextNode(distances,visited);

                if(node == 0 ) break; // 0 = eindnode in dit voorbeeld
                
                if(node == -1) break;

                visited.Add(node);

                foreach(var neigbour in this.graph[node]){

                    int cost = distances[node] + Math.Abs(neigbour - node);

                    if(distances[neigbour] > cost){
                        distances[neigbour] = cost;
                        previous[neigbour] = node;
                    }
                }
            }

            int end = 0; 
            string path = " ";
            while(end != startnode){
                path = end + " " + path;
                end = previous[end];
            }

            path = end + " " + path;

            Console.WriteLine(path);




        /*
            for(int i = 0; i < this.AmountNodes; i++){
                Console.WriteLine($"Kost node {i} -> {distances[i]}");
                Console.WriteLine($"Voor {i} -> ga je via {previous[i]}");
            }
            Console.WriteLine(string.Join(" ",distances));
        */
        }
        

        private int GetNextNode(int[] distances, List<int> visited){

            int node = -1, min = int.MaxValue;

            for(int i = 0; i < this.AmountNodes; i++){
                if(distances[i] < min && !visited.Contains(i)){
                    node = i;
                    min = distances[i];
                } 
            }

            return node;
        }
        



        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < this.AmountNodes;i++){
                s += i + " --> " + string.Join(" ",graph[i]) + "\n";
            }

            return s;
        }

    }
}
