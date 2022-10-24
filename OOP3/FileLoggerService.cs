using System;

namespace OOP3
{
    //Metin dosyasını loglamak istiyorsun gibi düşün ve loggerservice den kalıtım alacağım.
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
