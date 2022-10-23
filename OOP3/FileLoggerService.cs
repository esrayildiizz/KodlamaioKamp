using System;

namespace OOP3
{
    //Metin dosyasını loglamak istiyorsun gibi düşün
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
