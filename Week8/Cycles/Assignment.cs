using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_08 
{
    public class Assignment
    {

        private int AmountNodes;
        private int AmountEdges;
        public bool cyclic {get;set;}

        public List<int>[] graph {get;set;}

        public Assignment(){
          string inputNodes = Console.ReadLine();
          
            this.AmountNodes = Int32.Parse(inputNodes.Substring(0,1));

            this.graph = new List<int>[this.AmountNodes];

            for(int i = 0; i < this.AmountNodes; i++){
                this.graph[i] = new List<int>();
            } 
        }

        public string checkCyclic(){

            string inputEdges = Console.ReadLine();

            int amoutEdges = Int32.Parse(inputEdges.Substring(0,1));
            this.AmountEdges = amoutEdges;

            int start = 0;

            for(int i = 0; i < amoutEdges; i++){
                string[] edges = Console.ReadLine().Split(" ");


                int p1 = Int32.Parse(edges[0]);
                int p2 = Int32.Parse(edges[1]);

                if(i == 0) start = p1;

                AddEdge(p1,p2);
            }
            
            validateCyclic(start);  
            return this.cyclic ? "cyclic" : "acyclic";
        }   

        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
        }


        public void validateCyclic(int start, List<int> visited = null){

            if(visited == null) visited = new List<int>();

            visited.Add(start);

            foreach(var node in this.graph[start]){

                if(!visited.Contains(node)){
                    validateCyclic(node,visited);
                   
                }
                else if(visited.Count < this.AmountNodes || (this.AmountNodes == 1 && this.AmountEdges == 1))
                {
                    this.cyclic = true;
                    break;
                }
            }
        }
    }
}
