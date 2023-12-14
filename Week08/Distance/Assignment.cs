using System;
using System.Collections.Generic;
using System.Linq;


namespace Module_08 
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

            int amoutEdges = Int32.Parse(inputEdges);
            this.AmountEdges = amoutEdges;

            for(int i = 0; i < amoutEdges; i++){
                string[] edges = Console.ReadLine().Split(" ");
                int p1 = Int32.Parse(edges[0]);
                int p2 = Int32.Parse(edges[1]);

                AddEdge(p1,p2);
            }

            List<int> visited = new List<int>();

            int count = 0;
            for(int i = 0; i < this.AmountNodes; i++){
                if(!visited.Contains(i)){
                    DFSearch(i,visited);
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public void DFSearch(int node,List<int> visited)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);
                foreach (var vr in graph[node])
                {
                    DFSearch(vr,visited);
                }
            }
        }


        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
             graph[node2].Add(node1);
        }
    }
}