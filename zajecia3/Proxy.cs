using System;

namespace ProxyPattern
{
    public interface IFile
    {
        void Access();
    }

    public class PublicFile : IFile
    {
        public void Access()
        {
            Console.WriteLine("Uzyskano dostęp do pliku publicznego.");
        }
    }

    public class ProtectedFile : IFile
    {
        private readonly string _password;

        public ProtectedFile(string password)
        {
            _password = password;
        }

        public void Access()
        {
            Console.WriteLine("Uzyskano dostęp do pliku zastrzeżonego.");
        }

        public bool CheckPassword(string password)
        {
            return _password == password;
        }
    }

    public class FileProxy : IFile
    {
        private readonly ProtectedFile _protectedFile;
        private readonly string _password;

        public FileProxy(ProtectedFile protectedFile, string password)
        {
            _protectedFile = protectedFile;
            _password = password;
        }

        public void Access()
        {
            Console.WriteLine("Wprowadź hasło:");
            var inputPassword = Console.ReadLine();

            if (_protectedFile.CheckPassword(inputPassword))
            {
                _protectedFile.Access();
            }
            else
            {
                Console.WriteLine("Nieprawidłowe hasło. Dostęp zabroniony.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var publicFile = new PublicFile();
            var protectedFile = new ProtectedFile("tajnehaslo");
            var fileProxy = new FileProxy(protectedFile, "tajnehaslo");

            while (true)
            {
                Console.WriteLine("\nWybierz plik do otwarcia:");
                Console.WriteLine("1. Plik publiczny");
                Console.WriteLine("2. Plik zastrzeżony");
                Console.WriteLine("3. Wyjdź");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        publicFile.Access();
                        break;

                    case "2":
                        fileProxy.Access();
                        break;

                    case "3":
                        Console.WriteLine("Koniec programu.");
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
