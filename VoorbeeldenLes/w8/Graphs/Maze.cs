using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Graphs
{
    public class Maze
    {
        private int AmountNodes;

        public List<int>[] graph {get;set;}

        public Maze(int amountNodes){
            this.AmountNodes = amountNodes;  

            this.graph = new List<int>[amountNodes];

            this.graph = new List<int>[amountNodes];    

            for(int i = 0; i < this.AmountNodes; i++){
                this.graph[i] = new List<int>();
            }      
        }

        public void AddEdge(int node1, int node2){
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }

        public string DSF(int start, List<int> visited = null ){

            if(visited == null) visited = new List<int>();

            visited.Add(start);

            foreach(var node in this.graph[start]){
                if(!visited.Contains(node)){
                    DSF(node, visited);
                }
            }

            return string.Join(" ",visited);
        }

        public string DFS_Stack(int startnode){
            Stack<int> stack = new Stack<int>();
            List<int> visited = new List<int>();

            stack.Push(startnode);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                visited.Add(node);

                if (node == 0) return String.Join(" ", visited);

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        stack.Push(nextNode);
                    }
                }
            }
          return string.Join(" ",visited);
        }

        public string BSF(int startnode){
             Queue<int> stack = new Queue<int>();
            List<int> visited = new List<int>();

            stack.Enqueue(startnode);

            while (stack.Count > 0)
            {
                int node = stack.Dequeue();
                visited.Add(node);

                if (node == 0) return String.Join(" ", visited);

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        stack.Enqueue(nextNode);
                    }
                }
            }
          return string.Join(" ",visited);
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
