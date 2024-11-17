using System;

namespace EventRegistration
{
    
    public class EventDetails
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }

      
        public EventDetails(string eventName, DateTime eventDate, string location)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
        }
    }

   
    public class EventManager
    {
      
        public void RegisterEvent(EventDetails eventDetails)
        {
            Console.WriteLine($"Event: {eventDetails.EventName}, Date: {eventDetails.EventDate}, Location: {eventDetails.Location}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
          
            EventDetails eventDetails = new EventDetails("Music Concert", new DateTime(2024, 12, 25), "City Arena");

     
            EventManager eventManager = new EventManager();
            eventManager.RegisterEvent(eventDetails);
        }
    }
}
