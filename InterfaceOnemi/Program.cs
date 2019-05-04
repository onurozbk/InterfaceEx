using System;

namespace InterfaceOnemi
{
    class Program
    {
        static void Main(string[] args)
        {

            ILoger _loger;
            _loger = new TextLoger();

            _loger.Log();
            Console.ReadLine();
        }
    }
    public class TextLoger:ILoger
    {
        public void Log()
        {
            Console.WriteLine("Text dosyarı Loglama yapıldı");
        }
    }
    public class DatabaseLoger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Database Loglama yapıldı");
        }
    }

    public class DigerLogger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Diğer Loglama yapıldı.");
        }
    }
    public interface ILoger
    {
        void Log();
    }
}
