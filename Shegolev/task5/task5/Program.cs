using System;
using System.Threading;
using System.Collections.Generic;

namespace task5
{
    class Program
    {
        public static Semaphore Semaphore = new Semaphore(3, 3);
        static List<Fork> Fork = new List<Fork>();
        static List<Philosopher> Ph = new List<Philosopher>();

        static void Main()
        {
            Console.WriteLine("Введите кол-во философов: ");
            var count = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                Fork.Add(new Fork());
                Ph.Add(new Philosopher((i + 1).ToString(), i));
                new Thread(Ph[i].Start).Start(Fork);
            }
            /*while (true)
            {
                var kk = Console.ReadKey();
                if (kk.Key == ConsoleKey.Escape)
                    break;
            }*/
        }
    }

    public class Philosopher
    {
        bool isHunger;
        string philosopherName;
        int philosopherNumber;
        int time;

        public Philosopher(string name, int number)
        {
            philosopherName = name;
            philosopherNumber = number;
        }

        void GetFork(IList<Fork> fork)
        {
            time = new Random().Next(System.DateTime.Now.Millisecond);

            Console.WriteLine("Философ " + philosopherName + " ждет вилку" + "\t ({0}мс)", time);

            var first = philosopherNumber;
            var second = (philosopherNumber + 1) % (fork.Count - 1);

            if (fork[first].IsUsing || fork[second].IsUsing) return;

            fork[first].IsUsing = true;
            fork[second].IsUsing = true;

            Console.WriteLine("Философ " + philosopherName + " обедает" + "\t ({0}мс)", time);
            Console.WriteLine("Вилки " + (first + 1) + " и " + (second + 1) + " заняты " + "\t ({0}мс)", time);
            Thread.Sleep(time);

            fork[first].IsUsing = false;
            fork[second].IsUsing = false;
        }

        public void Start(object obj)
        {
            while (true)
            {
                Thread.Sleep(time);
                ChangeStatus();
                if (isHunger)
                    GetFork((List<Fork>)obj);
            }
        }

        void ChangeStatus()
        {
            isHunger = !isHunger;
            if (!isHunger)
                Console.WriteLine("Философ " + philosopherName + " думает." + "\t ({0}мс)", time);
        }
    }

    public class Fork
    {
        public bool IsUsing { get; set; }
    }
}
