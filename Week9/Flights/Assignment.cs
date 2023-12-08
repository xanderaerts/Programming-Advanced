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
        private int nodeCounter = 0;

        //public List<(int,string)>[] graph {get;set;}
        public Dictionary<string, List<string>> graph {get;set;}


        public Assignment(){
          string inputNodes = Console.ReadLine();
          
            this.AmountNodes = Int32.Parse(inputNodes);

           // this.graph = new List<(int,string)>[this.AmountNodes];

           this.graph = new Dictionary<string, List<string>>();

            for(int i = 0; i < this.AmountNodes; i++){
                //this.graph[i] = new List<(int,string)>{(i,"")};
            }
        }

        public void start(){

            string inputEdges = Console.ReadLine();

            int amoutEdges = Int32.Parse(inputEdges);
            string start = "";
            this.AmountEdges = amoutEdges;

            for(int i = 0; i < amoutEdges; i++){
                string[] edges = Console.ReadLine().Split(", ");
                string p1 = edges[0];
                string p2 = edges[1];

                if(i == 0) start = p1;

                AddEdge(p1,p2);
            }

        }

        public void AddEdge(string city1, string city2){

            this.graph[city1].Add(city2);
            this.graph[city2].Add(city1);
        }
    }
}