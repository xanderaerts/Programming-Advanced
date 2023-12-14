using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Module_09 
{
    public class Assignment
    {

        private int AmountNodes;
        private int AmountEdges;

        public List<int>[] graph {get;set;}

        public Assignment(){
          string inputNodes = Console.ReadLine();
          
            this.AmountNodes = Int32.Parse(inputNodes);

            this.graph = new List<int>[this.AmountNodes];

            for(int i = 0; i < this.AmountNodes; i++){
                this.graph[i] = new List<int>();
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

                if(i == 0) start = p1;

                AddEdge(p1,p2);
            }

           bool res =  SearchEn(start);

           Console.WriteLine(res ? "connected" : "not connected");

        }

        public bool SearchEn(int start, List<int> visited = null){
            if(visited == null) visited = new List<int>();

            visited.Add(start);

            foreach(var node in this.graph[start]){
                if(!visited.Contains(node)){
                    SearchEn(node,visited);
                }
            }  

            if(visited.Count >= this.AmountNodes) return true;
            return false;
        }

        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
            //graph[node2].Add(node1);
        }
    }
}