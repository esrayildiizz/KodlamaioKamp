using System;

namespace OOP3
{
    //Metin dosyasını loglamak istiyorsun gibi düşün ve loggerservice den kalıtım alacağım.
    class FileLoggerService : ILoggerService //aslında log servisin bir alt başlığı olduğu için kalıtım aldık.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
