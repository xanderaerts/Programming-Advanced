using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Module_03 
{
    public class Assignment
    {  
        public int amountParkingSpots {get;set;}
        public string Parking(string input){

            int carsWithNoPlace = 0;
            List<int> cars = new List<int>();

            for(int i = 0; i < amountParkingSpots; i++){
                cars.Add(-1);
            }

            string[] ts = input.Split(" ");
            for(int j = 0; j < ts.Length;j++){
                string[] rawinput = ts[j].Split(":");

                int timeStamp,ParkingDuration,parkingEndTime;
                
                timeStamp = Int32.Parse(rawinput[0]);
                ParkingDuration = Int32.Parse(rawinput[1]);
                parkingEndTime = timeStamp+ParkingDuration;

                bool carAdded = false;

                for(int i = 0; i < this.amountParkingSpots; i++){
                    
                    if(cars[i] < timeStamp){

                        cars[i] = parkingEndTime;
                        carAdded = true;
                        break;
                    }
             
                }
                if(!carAdded) carsWithNoPlace++;

            }
            return carsWithNoPlace.ToString();
            }
    }
}
