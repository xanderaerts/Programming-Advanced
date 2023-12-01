using System;

namespace Module_08 
{
    public class Assignment
    {
        public string checkCyclic(){
          string inputNodes = Console.ReadLine();

            string inputEdges = Console.ReadLine();

            int amoutEdges = Int32.Parse(inputEdges.Substring(0,1));

            string edgesList = "";

            for(int i = 0; i < amoutEdges; i++){
                edgesList += Console.ReadLine() + "\n";
            }
            
            return "";  
        }    
    }
}
