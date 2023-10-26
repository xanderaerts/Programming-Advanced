using System;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace Module_03 
{
    public class Assignment
    {  
        public int amountParkingSpots {get;set;}
        private int parkedCarsCounter {get;set;} = 0;

        public string Parking(string input){

            int carsWithNoPlace = 0;
            int[] cars = new int[amountParkingSpots];

            foreach(string ts in input.Split(" ")){
                string[] rawinput = ts.Split(":");

                int timeStamp,ParkingDuration,parkingEndTime;
                try{
                    timeStamp = Int32.Parse(rawinput[0]);
                    ParkingDuration = Int32.Parse(rawinput[1]);
                    parkingEndTime = timeStamp+ParkingDuration;

                }
                catch{
                    throw new Exception();
                }


                bool carAdded = false;

                for(int i = 0; i < cars.Length; i++){
                    if(cars[i] < timeStamp && cars[i] != 0){
                        cars[i] = 0;
                        parkedCarsCounter--;
                    }
                    if(parkedCarsCounter < amountParkingSpots && cars[i] == 0 && !carAdded){
                        cars[i] = parkingEndTime;
                        parkedCarsCounter++;
                        carAdded = true;
                    }
                    else if(parkedCarsCounter >= amountParkingSpots && !carAdded && i >= amountParkingSpots-1){
                        carsWithNoPlace++;
                        break;
                    }

                }
            }
            return carsWithNoPlace.ToString();
            }
    }
}
