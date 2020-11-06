using System;
using System.Threading;
using System.Collections.Generic;
namespace Task5
{
    class Program
    {
        static List<Fork> fork = new List<Fork>();
        static List<Philosopher> ph = new List<Philosopher>();
        public static int n;
        public static int[] times;

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a quantity of Philosophers:");
            n = Convert.ToInt32(Console.ReadLine());
            times = new int[n];
            Thread[] thArray = new Thread[n]; //пул потоков
            Philosopher ph1 = new Philosopher();

            if (n == 1)
            {
                Console.WriteLine("One philosopher cannot eat with only one fork!");
            }
            else
            {
                for (int i = 0; i < n; i++) //создаем 
                {
                    fork.Add(new Fork());
                }
                for (int i = 0; i < n; i++)
                {
                    ph.Add(new Philosopher(i + 1, i));
                    thArray[i] = new Thread(new ParameterizedThreadStart(ph[i].Run));

                }
                for (int i = 0; i < n; i++)
                {
                    thArray[i].Start(fork);
                }

                while (true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        foreach (var philosopher in ph)
                        {
                            philosopher.Stop();

                        }

                        foreach (var thread in thArray)
                        {
                            thread.Join();
                        }
                        for (int i = 0; i < n; i++)
                        {
                            ph[i].GetTimes(i, ph);
                        }
                        break;
                    }
                }

            }
        }

    }

    public class Calculator
    {

    }

    class Philosopher
    {
        Random rand = new Random(); // рандомная задержка между состояниями философов
        public enum State { Hunger, Eat, Think } // состояния философа
        public State CurrentState { get; set; } // текущее состояние
        public int Name { get; set; } // имя философа
        public int Count { get; set; } // порядковый номер
        public int Times { get; set; } = 0; //счетчик подходов к еде

        private object mSyncObj = new object();
        private bool mStop = true;

        public Philosopher(int name, int count) // конструктор класса
        {
            Name = name;
            Count = count;
        }
        public Philosopher()
        {

        }
        public void Run(object obj)
        {
            Start((List<Fork>)obj);
        }

        void Start(List<Fork> fork)
        {
            int time = new Random().Next(System.DateTime.Now.Millisecond);
            mStop = false;

            while (true)
            {
                Console.WriteLine($"Философ {Name} ждет вилку ({time}мс)");
                Thread.Sleep(time);
                CurrentState = State.Hunger;
                int first = Count;
                int second = (Count == fork.Count - 1) ? 0 : Count + 1;
                fork[first].TakeFork();
                fork[second].TakeFork();
                CurrentState = State.Eat;
                Console.WriteLine($"Философ {Name} обедает");
                Console.WriteLine($"Вилки с номерами {first + 1} и {second + 1} заняты");
                Thread.Sleep(rand.Next(300, 800));
                fork[first].PutFork();
                fork[second].PutFork();
                Times++;
                CurrentState = State.Think;
                Console.WriteLine($"Философ {Name} думает");
                Thread.Sleep(rand.Next(500, 800));

                lock (mSyncObj)
                {
                    if (mStop)
                        break;
                }

            }
        }

        public void Stop()
        {
            lock (mSyncObj)
            {
                mStop = true;
            }
        }

        public void GetTimes(int n, List<Philosopher> ph)
        {
            Console.WriteLine("Философ {0} подошёл {1} раз(а)", ph[n].Name, ph[n].Times);
        }

    }





    class Fork
    {
            Semaphore semaphore = new Semaphore(1, 1);

            public void TakeFork()
            {
                semaphore.WaitOne();

            }
            public void PutFork()
            {
                semaphore.Release();


            }
    }

}
