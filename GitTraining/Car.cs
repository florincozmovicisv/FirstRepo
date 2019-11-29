using System;
using System.Collections.Generic;
using System.Text;

namespace GitTraining
{
    public class Car : Vehicle
    {
        private Vehicle currentVehicle;
        public Car(Vehicle vehicle)
        {
            currentVehicle = vehicle;
        }
        public Car(string Make, string Model)
        {
            currentVehicle = new Vehicle
            {
                Make = Make,
                Model = Model
            };
        }

        public Vehicle GetCar()
        {
            return currentVehicle;
        }

        public int GetYear()
        {
            return currentVehicle.Year;
        }

        public double GetValue()
        {
            return currentVehicle.CurrentValue;
        }
        public override string ToString()
        {
            return $"The car has the following properties: Make = {currentVehicle.Make}; Model = {currentVehicle.Model}; Year = {currentVehicle.Year}; Registration = {currentVehicle.Registration}; CurrentValue = {currentVehicle.CurrentValue}";
        }
    }
}
