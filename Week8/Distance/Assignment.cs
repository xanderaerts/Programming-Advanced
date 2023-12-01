using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml;

namespace Module_08 
{
    public class Assignment
    {

        private int AmountNodes;
        private int AmountEdges;
        private int StartNode;

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
            string startpoint = Console.ReadLine();
            this.StartNode = Int32.Parse(startpoint);

            CalcDistances();
        }



       public void CalcDistances(){
            Queue<int> queue = new Queue<int>();
            int[] distaneces = new int[this.AmountNodes];

            for(int i = 0; i < this.AmountNodes; i++){
                distaneces[i] = -1;
            }

            distaneces[this.StartNode] = 0;

            queue.Enqueue(this.StartNode);

            while(queue.Count > 0){
                int node = queue.Dequeue();

                foreach(var next in this.graph[node]){
                    if(distaneces[next] == -1 ){
                        
                        distaneces[next] = distaneces[node] + 1 ;
                        queue.Enqueue(next);
                    }
                }
            }

            string output = "";
            foreach(var dist in distaneces){
                output += dist + " ";
            }

            Console.WriteLine(output.Trim());
        }


        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
             graph[node2].Add(node1);
        }
    }
}