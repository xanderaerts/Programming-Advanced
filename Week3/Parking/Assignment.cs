using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace Module_03 
{
    public class Assignment
    {  
        public int amountParkingSpots {get;set;}
        public LinkedList cars = new LinkedList();

        public string Parking(string input){

            string[] timeStamps = input.Split(" ");

            foreach(string ts in timeStamps){
                string[] rawinput = ts.Split(":");

                int timeStamp,ParkingDuration;

                try{
                    timeStamp = Int32.Parse(rawinput[0]);
                    ParkingDuration = Int32.Parse(rawinput[1]);
                }
                catch{
                    throw new Exception("Crazy input!");
                }               

                cars.Insert(new Node(timeStamp,ParkingDuration));
            }


            return "test";
        }

        public void checkCarsLeaving(Node current){
            Node last = this.cars.Last();

            if(last.TimeStamp > current.TimeStamp){

            }
        }
    }
}
