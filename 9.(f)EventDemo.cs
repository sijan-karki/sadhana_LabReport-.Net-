using System;

namespace Lab_Report_SadhanaKhadka
{
    public delegate void NotifyJourneyStatus();

    public class Car
    {
        public event NotifyJourneyStatus ReachedDestination;

        public void StartJourney()
        {
            Console.WriteLine("The car is starting the journey.");
            Console.WriteLine("The car is driving on the highway.");
            OnReachedDestination();
        }

        protected virtual void OnReachedDestination()
        {
            ReachedDestination?.Invoke();
        }
    }

    internal class CarJourneyApp
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.ReachedDestination += CarReachedDestinationHandler;

            // Start the car journey
            myCar.StartJourney();
            Console.WriteLine("\n Lab NO :9'f'");
            Console.WriteLine(" Name : Sadhana Khadka");
            Console.WriteLine(" Roll No:20");
        }

        static void CarReachedDestinationHandler()
        {
            Console.WriteLine("Car has reached its destination successfully.");
        }
    }
}
