using System;
using System.Threading;
using System.Collections.Generic;
namespace Task5
{
    class Program
    {
        static List<Fork> fork = new List<Fork>();//лист вилок
        static List<Philosopher> ph = new List<Philosopher>();//лист философов

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a quantity of Philosophers:");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread[] thArray = new Thread[n]; //пул потоков
            Philosopher ph1 = new Philosopher();

            if (n == 1)//проверка на количество заданных философов, если 1, то выход
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
                    ph.Add(new Philosopher((i + 1).ToString(), i));                    
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
   
    public class Philosopher
    {
        Random rand = new Random(); // рандомная задержка между состояниями философов
        public enum State { Hunger, Eat, Think } // состояния философа
        public State CurrentState { get; set; } // текущее состояние
        public string Name { get; set; } // имя философа
        public int Count { get; set; } // порядковый номер
        public int Times { get; set; } = 0; //счетчик подходов к еде

        private object mSyncObj = new object();
        private bool mStop = true;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя философа</param>
        /// <param name="count">Номер вилки</param>
        public Philosopher(string name, int count)
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
                Console.WriteLine($"Philosopher {Name}is waiting for the forks ({time}ms)");
                Thread.Sleep(time);
                CurrentState = State.Hunger;//смена статуса на "голоден"
                int first = Count;
                int second = (Count == fork.Count - 1) ? 0 : Count + 1;
                fork[first].TakeFork();//берет вилки
                fork[second].TakeFork();
                CurrentState = State.Eat;//смена статуса на "ест"
                Console.WriteLine($"Philosopher {Name} is eating");
                Console.WriteLine($"Forks with numbers {first + 1} and {second + 1} are occupied");
                Thread.Sleep(rand.Next(300, 800));
                fork[first].PutFork();//кладет вилки
                fork[second].PutFork();
                Times++;//счетчик сколько съел каждый философ
                CurrentState = State.Think;//смена статуса на "думает"
                Console.WriteLine($"Philosopher {Name} is thinking");
                Thread.Sleep(rand.Next(500, 800));

                lock (mSyncObj)
                {
                    if (mStop)
                        break;
                }
            }
        }
        /// <summary>
        /// Остановка потоков
        /// </summary>
        public void Stop()
        {
            lock (mSyncObj)
            {
                mStop = true;
            }
        }
        /// <summary>
        /// Подсчет еды каждого философа
        /// </summary>
        /// <param name="n">Заданное количество философов</param>
        /// <param name="ph">Имя философа</param>
        public void GetTimes(int n, List<Philosopher> ph)
        {
            Console.WriteLine($"Philosopher {ph[n].Name} ate {ph[n].Times} times");
        }
    }

    class Fork
    {
        Semaphore semaphore = new Semaphore(1, 1);//cемафор

        public void TakeFork()//взять вилку
        {
            semaphore.WaitOne();//ожидание ресурса
        }
        public void PutFork()//положить вилку
        {
            semaphore.Release();//выход из семафора
        }
    }

}
