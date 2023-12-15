using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    internal class Knapsack
    {
        public List<Item> Items { get; }
        public int MaxWeight { get; set; }
        public Knapsack(List<Item> items, int max)
        {
            Items = items;
            MaxWeight = max;
        }



        public override string ToString()
        {
            string s = "";
            foreach (var item in Items)
            {
                s += item + "\n";
            }
            return s;
        }
    }
}
