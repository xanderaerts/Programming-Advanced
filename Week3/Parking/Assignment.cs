using System;
using System.Linq.Expressions;

namespace Module_03 
{
    public class Assignment
    {  
        public int amountParkingSpots {get;set;}
        public LinkedList cars = new LinkedList();
        private int parkedCarsCounter {get;set;} = 0;

        public string Parking(string input){

            int carsWithNoPlace = 0;

            foreach(string ts in input.Split(" ")){
                string[] rawinput = ts.Split(":");

                int timeStamp,ParkingDuration;
                try{
                    timeStamp = Int32.Parse(rawinput[0]);
                    ParkingDuration = Int32.Parse(rawinput[1]);

                }
                catch{
                    throw new Exception();
                }

                Node parkedCar = this.cars.Head;
                Node latest = new Node(timeStamp,ParkingDuration);

                for(int i = 0; i < this.parkedCarsCounter; i++){
                    checkCarsLeaving(parkedCar,latest);

                    parkedCar = parkedCar.Next;
                }

                if(parkedCarsCounter < this.amountParkingSpots){ 
                    cars.Insert(latest);
                    this.parkedCarsCounter++;
                }
                else{carsWithNoPlace++;}

            }

            return carsWithNoPlace.ToString();
            }

        public void checkCarsLeaving(Node parkedCar,Node latest){
            if(parkedCar != latest && latest.TimeStamp > (parkedCar.TimeStamp + parkedCar.ParkingDuration)){
                this.cars.Remove(parkedCar.TimeStamp);
                this.parkedCarsCounter--;
            }
        }
    }
}
