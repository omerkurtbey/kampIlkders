using System;

namespace Oop3
{
    class FİleLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
