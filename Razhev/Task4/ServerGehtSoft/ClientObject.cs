using System;
using System.Net.Sockets;
using System.Text;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    class ClientObject
    {
        //const string path = @"D:\C#\Task4\ServerGehtSoft\bin\Debug\netcoreapp3.1\movies.txt";
        public TcpClient client;
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }
        /// <summary>
        /// Данный класс служит помощником серверу. Под работу данного класса выделяется отдельный поток. Тут принимаются и отправляются данные.
        /// </summary>
        public void Process()
        {
            WorkWithFile InstanceWorkWithFile = new WorkWithFile();
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[256];
                while (true)
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    
                    var actors = InstanceWorkWithFile.InputActors(message);
                    var films = InstanceWorkWithFile.ReadFile(InstanceWorkWithFile.GetPath());
                    //var films = InstanceWorkWithFile.ReadFile(path);
                    var foundfilms = InstanceWorkWithFile.SearchFilms(actors, films);
                    var film = InstanceWorkWithFile.SubLines(foundfilms);              
                    var resultfilms = InstanceWorkWithFile.OutputFilms(film);
                    byte[] datafilms = Encoding.UTF8.GetBytes(resultfilms);
                    stream.Write(datafilms, 0, datafilms.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
