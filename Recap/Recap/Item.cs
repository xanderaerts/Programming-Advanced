using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    internal class Item : IComparable<Item>
    {
        public int Weight { get; set; }
        public int Value { get; set; }
        public Item(int value, int weight)
        {
            Value = value;
            Weight = weight;
        }

        public int CompareTo(Item other)
        {
            if (this.Value < other.Value) return -1;
            if (this.Value > other.Value) return 1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Value}:{Weight}";
        }
    }
}
