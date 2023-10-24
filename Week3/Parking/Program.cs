using System;

namespace Module_03{
    internal class Program{
        static void Main(string[] args){
                
            Assignment assignment = new Assignment();

            string inputParkingSpotsRaw = Console.ReadLine();
            string inputTimeStamps = Console.ReadLine();

            try{
                int amountParkingSpots = Int32.Parse(inputParkingSpotsRaw);
                assignment.amountParkingSpots = amountParkingSpots;
                Console.WriteLine(assignment.Parking(inputTimeStamps));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }


        }
    }
}