using System;
using System.Threading;

namespace Barbershop
{
    class Program
    {
        private static AutoResetEvent gHairdresser = new AutoResetEvent(false);
        private static AutoResetEvent gVisitor = new AutoResetEvent(false);

        private static int countVisitor = 0; // считать количество посетителей 
        private static int count = 0;
        private static bool verify = false; //  не занято

        public static void Do()
        {
            Thread hairdresser = new Thread(Hairdresser);
            Thread visitor = new Thread(Visitor);

            hairdresser.Start();
            Thread.Sleep(100); // Изначально парикмахер спит. Т.к посетителей нет. Ждет пока его разбудят.

            visitor.Start();

            hairdresser.Join();
            visitor.Join();
        }
        // Посетители приходят через какое то отпределённое время. Первый посетитель будет парикмахера.
        public static void Visitor()
        {
            do
            {
                Thread.Sleep(5000);     //Через какое то время приходит новый посетитель.
                countVisitor++;      //Пришел первый посетитель. Плюсуем счетчик.
                Console.WriteLine("Посетитель пришёл.Всего посетителей: {0}", countVisitor);
                gVisitor.Set(); //Запускаем поток посетителей.
                //gHairdresser.Set(); //Запускаем поток парикмахера.

            } while (true);
           
        }
       
        public static void Hairdresser() 
        {
            AutoResetEvent[] events = new AutoResetEvent[] { gVisitor };

            while (true)
            {
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
                        //Thread.Sleep(500);
                        Console.WriteLine("Парикмахер просыпается.Приступает к работе.");
                        countVisitor--;
                        verify = true;
                    }
                    else if (verify == true && countVisitor <= 3) //Если парикмахер занят и количество посетителей меньшее 3 то просим ожидать.
                    {
                        countVisitor--;
                        Console.WriteLine("Парикмахер занят другим посетителем.Ожидайте..");
                    }
                    while (verify == true && countVisitor >= 3) //Если парикмахер занят и количество посетителей больше 3 то посетитель уходит т.к нет мест.
                    {
                        Console.WriteLine("Все места ожидания заняты. Посетитель уходит.Посетители: {0}", countVisitor);
                        countVisitor--;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Do();
        }
    }
}
