using System;

namespace Company
{
  
    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }

  
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Work()
        {
          
            Console.WriteLine($"{Name} is working.");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"{Name} is attending a meeting.");
        }
    }

    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

       
        public void Work()
        {
            
            Console.WriteLine($"{Name} is managing the team.");
        }

        public void AttendMeeting()
        {
      
            Console.WriteLine($"{Name} is attending a managerial meeting.");
        }

      
        public void ManageTeam()
        {
           
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            IEmployee employee = new Employee { Name = "John", Position = "Developer" };
            employee.Work();
            employee.AttendMeeting();

        
            IEmployee manager = new Manager { Name = "Alice", Position = "Team Leader" };
            manager.Work();
            manager.AttendMeeting();
          
            ((Manager)manager).ManageTeam();
        }
    }
}
