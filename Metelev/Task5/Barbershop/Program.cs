using System;
using System.Threading;

namespace Barbershop
{
    class Program
    {
        private static AutoResetEvent gHairdresser = new AutoResetEvent(false);
        private static AutoResetEvent gVisitor = new AutoResetEvent(false);

        private static int countVisitor = 0; // считать количество посетителей
        private static int count; //общее число посетителей
        private static bool mStop = false;         
        private static bool verify = false; //  не занято
        private static Timer timer;
        public static void Do()
        {
            Thread hairdresser = new Thread(Hairdresser);
            Thread visitor = new Thread(Visitor);
            hairdresser.Start();
            Thread.Sleep(100); // Изначально парикмахер спит. Т.к посетителей нет. Ждет пока его разбудят.
            
            visitor.Start();
            TimerCallback tm = new TimerCallback(VisitorExit);
            timer = new Timer(tm, null, 0, 15000); //парикмахер обслуживает каждого клиента в течении 15 секунд
            Tracking();
        }
        public static void Tracking() 
        {
            while(true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    timer.Dispose();
                    Stop();
                    Console.WriteLine($"\nПарикмахер закончил работу. Всего было посетителей: {count}");
                    break;
                }
            }
        }
        public static void VisitorExit(object obj)
        {
            if(countVisitor >= 1)
            {
                countVisitor--;
                count++;
                Console.WriteLine($"Парикмахер закончил стричь посетителя. Посетитель уходит. Количество посетителей: {countVisitor}");
                if(countVisitor == 0)
                {
                    Console.WriteLine("Парикмахер спит.");
                    verify = false;
                }
            }
        }
        public static void Visitor()
        {
            Thread.Sleep(1000);
            Random rand = new Random();
            while (true)
            {
                if (mStop)
                {
                    break;
                }
                int time = rand.Next(5000,20000); //посетители приходят рандомно в промежуток времени от 5 до 20 сек
                countVisitor++;      //Пришел первый посетитель. Плюсуем счетчик.
                Console.WriteLine("Посетитель пришёл.Всего посетителей: {0}", countVisitor);
                gVisitor.Set(); //Запускаем поток посетителей.
                Thread.Sleep(time);     //Через какое то время приходит новый посетитель.

            }
           
        }
       
        public static void Hairdresser() 
        {
            AutoResetEvent[] events = new AutoResetEvent[] { gVisitor };
            Console.WriteLine("Парикмахер спит.");

            while (true)
            {
                if (mStop)
                {
                    break;
                }

                int which = WaitHandle.WaitAny(events);

                if (which == 0)
                {
                    if (countVisitor == 0)                  //Если посетителей нет то парикмахер спит.
                    {
                        Console.WriteLine("Парикмахер спит.");
                        gHairdresser.WaitOne();
                    }
                    else if (verify == false && countVisitor != 0) //Если парикмахер не занят и посетителей больше 0 то парикмахер просыпается и приступает к работе.
                    {
                        Console.WriteLine("Парикмахер просыпается.Приступает к работе.");
                        verify = true;
                        gHairdresser.Set();
                    }
                    else if (verify == true && countVisitor <= 3) //Если парикмахер занят и количество посетителей меньшее 3 то просим ожидать.
                    {
                        Console.WriteLine("Парикмахер занят другим посетителем.Ожидайте...");
                    }
                    else if (verify == true && countVisitor >= 3) //Если парикмахер занят и количество посетителей больше 3 то посетитель уходит т.к нет мест.
                    {
                        Console.WriteLine("Все места ожидания заняты. Посетитель уходит.Посетители: {0}", countVisitor-1);
                        countVisitor--;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public static void Stop()
        {
                mStop = true;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Do();
        }
    }
}
