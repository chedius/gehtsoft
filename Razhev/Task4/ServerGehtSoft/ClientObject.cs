using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Linq;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    //class Actor
    //{
    //    public string FirstName;
    //    public string LastName;
    //}
    class Movie 
    {
       public string Name { get; set; }
       public string Year { get; set; }
       public string Actors { get; set; }
    }

    class ClientObject
    {
        public string path = @"movies.txt";
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
            Movie InstanceMovie = new Movie();
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

                    //string[] массив фильмов ,один элемент массива - это один Название фильма (год экранизации)/Актер/Актер
                    var films = InstanceWorkWithFile.ReadFile(path);
                    
                    //получили Название фильмов (год экранизации)
                    List<string> actorsFilms = new List<string>();
                    var nameYearFilm = InstanceWorkWithFile.FindNameYearFilms(films, out actorsFilms);
                    
                    //получили отдельно лист с названиями фильмов и с годами их экранизации
                    List<string> yearFilms = new List<string>();
                    var nameFilms = InstanceWorkWithFile.SubNameYearFilms(nameYearFilm, out yearFilms);
                    
                    //Массив объектов - его заполнение
                    List<Movie> movies = new List<Movie>();
                    for (int i = 0; i < nameFilms.Count; i++) 
                    {
                        movies.Add(new Movie() { Name = nameFilms[i], Year = yearFilms[i], Actors = actorsFilms[i]});
                    }

                    string message = builder.ToString();
                    string result = "";
                    if (message.ToCharArray()[message.Length - 1] == '|')
                    {
                        message = message.TrimEnd('|');
                        result += InstanceWorkWithFile.FindNameFilm(movies, message);
                    }
                    else if (message.ToCharArray()[message.Length - 1] == ';')
                    {
                        message = message.Replace(';', ' ');
                        string[] actors = message.Split(' ');
                        result += InstanceWorkWithFile.FindActorsFilm(movies, actors);
                    }
                    else if (message.ToCharArray()[message.Length - 1] == '.')
                    {
                        message = message.TrimEnd('.');
                        result += InstanceWorkWithFile.FindYearFilm(movies, message);
                    }
                    else
                    {
                        result += "You did not use the search correctly.";
                    }

                    //Отправляем найденную информацию клиенту
                    byte[] datafilms = Encoding.UTF8.GetBytes(result);
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
