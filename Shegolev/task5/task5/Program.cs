using System;
using System.Threading;
using System.Collections.Generic;
namespace Task5
{
    class Program
    {
        static List<Fork> fork = new List<Fork>();
        static List<Philosopher> ph = new List<Philosopher>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a quantity of Philosophers:");
            int n = Convert.ToInt32(Console.ReadLine());
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
                    ph.Add(new Philosopher((i + 1).ToString(), i));
                    // Thread th = new Thread(new ParameterizedThreadStart(ph[i].Run));
                    
                    thArray[i] = new Thread(new ParameterizedThreadStart(ph[i].Run));
                    
                }
                for (int i = 0; i < n; i++)
                {
                    thArray[i].Start(fork);

                    //Philosopher.Tracking();
                }

                for (int i = 0; i < n; i++)
                {
                    ph1.Tracking(thArray[i], n);

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
        public Philosopher(string name, int count) // конструктор класса
        {
            Name = name;
            Count = count;
         //   Times = times;
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
            //List<int> times;
            int podhod = 0;
            while (true)
            {
                Console.WriteLine($"Философ {Name} ждет вилку ({time}мс)");
                CurrentState = State.Hunger;
                int first = Count;
                int second = (Count == fork.Count - 1) ? 0 : Count + 1;
                //int second = (Count == fork.Count - 1) % (fork.Count + 1);
                fork[first].TakeFork();
                fork[second].TakeFork();
                CurrentState = State.Eat;
                Console.WriteLine($"Философ {Name} обедает");
                Console.WriteLine($"Вилки с номерами {first} и {second} заняты");
                Thread.Sleep(rand.Next(300, 800));
                fork[first].PutFork();
                fork[second].PutFork();
                //Times++;
                //times[n] += 1; //.Add(1);
                //вкидон
                //podhod = Count;
                podhod++;
                Console.WriteLine($"!!!Философ {Name} сделал {podhod} подходов к еде");
                CurrentState = State.Think;
                Console.WriteLine($"Философ {Name} думает");
                Thread.Sleep(rand.Next(500, 800));
                


            }
        }
        public void GetTimes(int n)
        {
            Mutex mobj = new Mutex();
            mobj.WaitOne();
            for (int i = 0; i < n; i++)
            {
                
                //Console.WriteLine("Философ {0} сделал {1} подход к еде", Name, Times);
                
            }
            mobj.ReleaseMutex();
        }

        public void Tracking(Thread thread, int n)
        {
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {  
                thread.Interrupt();
                //GetTimes(n);
            }
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
