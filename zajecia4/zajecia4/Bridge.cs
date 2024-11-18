using System;
using System.Collections.Generic;

namespace BridgePattern
{
    
    public abstract class Interface
    {
        protected ISystem System;

        public Interface(ISystem system)
        {
            System = system;
        }

        public abstract void DisplayMenu();
    }

  
    public class GraphicInterface : Interface
    {
        public GraphicInterface(ISystem system) : base(system) { }

        public override void DisplayMenu()
        {
            Console.WriteLine("Graficzny Interfejs:");
            System.GetInstalledPrograms().ForEach(program => Console.WriteLine($"- {program}"));
        }
    }

    
    public class TextInterface : Interface
    {
        public TextInterface(ISystem system) : base(system) { }

        public override void DisplayMenu()
        {
            Console.WriteLine("Tekstowy Interfejs:");
            System.GetInstalledPrograms().ForEach(program => Console.WriteLine($"* {program}"));
        }
    }

  
    public interface ISystem
    {
        List<string> GetInstalledPrograms();
    }

    
    public class WindowsSystem : ISystem
    {
        public List<string> GetInstalledPrograms()
        {
            return new List<string> { "Notepad", "Calculator", "Paint" };
        }
    }

    
    public class LinuxSystem : ISystem
    {
        public List<string> GetInstalledPrograms()
        {
            return new List<string> { "Vim", "GCC", "GIMP" };
        }
    }

    public class Bridge
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wybierz system operacyjny:");
            Console.WriteLine("1 - Windows");
            Console.WriteLine("2 - Linux");

            var choice = Console.ReadLine();

            ISystem system = choice switch
            {
                "1" => new WindowsSystem(),
                "2" => new LinuxSystem(),
                _ => throw new InvalidOperationException("Niepoprawny wybór.")
            };

            Console.WriteLine("Wybierz interfejs:");
            Console.WriteLine("1 - Graficzny");
            Console.WriteLine("2 - Tekstowy");

            choice = Console.ReadLine();

            Interface userInterface = choice switch
            {
                "1" => new GraphicInterface(system),
                "2" => new TextInterface(system),
                _ => throw new InvalidOperationException("Niepoprawny wybór.")
            };

            Console.WriteLine("\nWyświetlam menu:");
            userInterface.DisplayMenu();
        }
    }
}
