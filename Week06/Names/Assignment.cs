using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Module_06 
{
    public class Assignment
    {

        public string SearchPlace(string name){
            List<string> names = File.ReadLines("names.txt").ToList();
            names = SortList(names);

          //  int pos = SearchPosition(name,names);
            int pos = names.FindIndex(a => a.Contains(name));
            if(pos >= 0) return pos.ToString();
            return "No index found";
        }

        public List<string> SortList(List<string> names){

            if(names.Count <= 1) return names;

            string piviot = names[0];

            List<string> lower = new List<string>();
            List<string> higher = new List<string>();

            foreach(var item in names){
                if(item.CompareTo(piviot) < 0 ) lower.Add(item);

                else if(item.CompareTo(piviot) > 0 ) higher.Add(item);
            }
            
            return SortList(lower).Union(new List<string> {piviot}).Union(SortList(higher)).ToList();
        }
    }

   // public int SearchPosition(string name, List<string> names){

//    }
}
