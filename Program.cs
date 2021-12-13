using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger(); // Buradan ileride Database,File,Sms gibi çeşitli yöntemlerle göndermeyi mümkün kıldık.
            customerManager.Add();

            Console.ReadLine();
        }




        class CustomerManager // Burası kullanım kısmı.
        {
            public ILogger Logger { get; set; }
            public void Add()
            {

                Logger.Log();
                Console.WriteLine("Customer Added.");
            }

        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database!");
            }

        }
            class FileLogger : ILogger
            {
                public void Log()
                {
                    Console.WriteLine("Logged to file.");
                }
            }

            interface ILogger
            {
                public void Log();
            }

        }
    }
