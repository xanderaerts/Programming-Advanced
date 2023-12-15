using System;
using System.Runtime.InteropServices;

namespace Greedy
{
    public class Course : IComparable<Course>
    {
        public double Start {get;set;}

        public double End {get;set;}

        public string Name {get;set;}

        public Course(string name, double start, double end){
            this.Start = start; 
            this.End = end; 
            this.Name = name;
        }


        public override string ToString()
        {
            string s = "";
           
            s+= $"{Name}\t {this.Start}\t {this.End}";

            return s;
        }

        public int CompareTo(Course other)
        {
            if (this.End < other.End) return -1;
            if (this.End > other.End) return 1;

            return 0; 
        }
    }
}
