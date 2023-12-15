using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Greedy
{
    public class Schedule
    {
        public List<Course> Courses {get;set;}


        public Schedule(List<Course> courses){
            this.Courses = courses;
        }

        public List<Course> Create() {
            List<Course> schedule = new List<Course>();

            Courses.Sort();

            schedule.Add(this.Courses[0]);

            for (int i = 1; i < this.Courses.Count; i++) {
                if (Courses[i].Start >= schedule.Last().End) {
                    schedule.Add(Courses[i]);
                }
            }


            return schedule;


        }



        public override string ToString()
        {
            string s = "";

             s += "Name\t Start\t End\n";

            foreach(Course item in this.Courses){
                s+= item + "\n";
            }
            return s;
        }
    }
}
