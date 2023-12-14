using System;
using System.Collections.Generic;
using System.Linq;


namespace Module_09 
{
    public class Assignment
    {

        private int AmountNodes;
        private int AmountEdges;

        public List<(int,int)>[] graph {get;set;}

        public Assignment(){
          string inputNodes = Console.ReadLine();
          
            this.AmountNodes = Int32.Parse(inputNodes);

            this.graph = new List<(int,int)>[this.AmountNodes];

            for(int i = 0; i < this.AmountNodes; i++){
                this.graph[i] = new List<(int,int)>();
            }
        }

        public void start(){

            string inputEdges = Console.ReadLine();

            int amoutEdges = Int32.Parse(inputEdges),start = 0;
            this.AmountEdges = amoutEdges;

            for(int i = 0; i < amoutEdges; i++){
                string[] edges = Console.ReadLine().Split(",");
                int p1 = Int32.Parse(edges[0]);
                int p2 = Int32.Parse(edges[1]);
                int weight = Int32.Parse(edges[2]);

                if(i == 0) start = p1;

                AddEdge(p1,p2,weight);
            }

            Console.WriteLine(findLongest(start));
        }

        public int findLongest(int start){
            int[] way = new int[this.AmountNodes];

            List<int> visited = new List<int>();

            for(int i = 0; i < this.AmountNodes;i++)
            {
                if(!visited.Contains(i)){
                    sort(i,visited,way);
                }
            }

            int max = 0;
            foreach (var vr in way)
            {
                max = Math.Max(max, vr);
            }

            return max;
        }

        private void sort(int i, List<int> visited, int[] way){
            visited.Add(i);

            foreach(var nb in this.graph[i]){
                if(!visited.Contains(nb.Item1)){
                    sort(nb.Item1,visited,way);
                }

                way[i] = Math.Max(way[i], way[nb.Item1] + nb.Item2);
            }
        }
            
        public void AddEdge(int node1, int node2,int weight){
            this.graph[node1].Add((node2,weight));
            //graph[node2].Add(node1);
        }
    }
}
