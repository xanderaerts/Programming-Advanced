using System;
using System.Collections.Generic;
using System.Linq;


namespace Module_09 
{
    public class Assignment
    {

        private int AmountNodes;
        private int AmountEdges;
        private int nodeCounter = 0;

        public Dictionary<string,List<KeyValuePair<string,int>>> graph {get;set;}

        public Assignment(){
            string inputNodes = Console.ReadLine();

            this.AmountNodes = Int32.Parse(inputNodes);

            this.graph = new Dictionary<string,List<KeyValuePair<string,int>>>();
            
        }

        public void start(){

            string inputEdges = Console.ReadLine();

            int amoutEdges = Int32.Parse(inputEdges);
            this.AmountEdges = amoutEdges;

            for(int i = 0; i < amoutEdges; i++){
                string[] edges = Console.ReadLine().Split(", ");
                string p1 = edges[0].Trim();
                string p2 = edges[1].Trim();
                int weight = Int32.Parse(edges[2]);
                AddEdge(p1,p2,weight);
            }

            string start = Console.ReadLine();
            string finish = Console.ReadLine();

            string price = calcLowestPrice(start,finish);

            Console.WriteLine(price);

        }
        public string calcLowestPrice(string start,string finish){

            List<string> visited = new List<string>();

           Dictionary<string,int> costs = new Dictionary<string, int>();

            foreach(var n in this.graph.Keys){
                costs[n] = int.MaxValue;
            }


            costs[start] = 0;

            while(true){

                string node = GetNext(costs,visited);

                if(node == finish) break; 

                if(node == null) break;

                visited.Add(node);

                foreach(var nb in this.graph[node]){
                    int cost = costs[node] + Math.Abs(nb.Value);
                    if(costs[nb.Key] > cost){
                        costs[nb.Key] = cost;  
                    }
                }
            }

            return costs[finish].ToString();
        }

        public string GetNext(Dictionary<string,int> dist, List<string> visited){
            string node = "";
            int min = int.MaxValue;

            foreach(var n in this.graph.Keys){
                if(dist[n] < min && !visited.Contains(n)){
                    node = n; 
                    min = dist[n];
                }
            }
            return node;
        }

        public void AddEdge(string city1, string city2,int weight){
            KeyValuePair<string,int> input = new KeyValuePair<string, int>(city2,weight);

            if(!this.graph.ContainsKey(city1)) {
                List<KeyValuePair<string,int>> list = new List<KeyValuePair<string,int>>{input};                                            
                this.graph.Add(city1,list);
            }
            else{
                this.graph[city1].Add(input);
            }
        }
    }
}