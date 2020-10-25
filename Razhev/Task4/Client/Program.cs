using System;

namespace Client
{
    // Сделал: Ражев Дмитрий
    class Program
    {
        /// <summary>
        /// В main объявляется экземляр класса в котором описана работа клиента , а потом вызывается и сам метод класса экземпляр которого мы создали.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClientClass InstanceClintClass = new ClientClass();
            InstanceClintClass.Client();
        }
    }
}
