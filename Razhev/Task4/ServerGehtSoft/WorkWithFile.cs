using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    class WorkWithFile
    {
        /// <summary>
        /// Приходит строка по типу A;B;C; этот метод разбивает слова отделённые символом ; и мы имеем доступ к кажому из них. Всё тоже самое только с Фамилиями актеров.
        /// </summary>
        /// <param name="inputactors"></param>
        /// <returns></returns>
        public string[] InputActors(string inputactors)
        {
            inputactors = inputactors.Replace(';', ' ');
            string[] actors = inputactors.Split(' ');
            return actors;
        }
        /// <summary>
        /// Читаем из файла данные. И разбиваем их по переносу строки. Этот метод даёт нам доступ к каждой строке отдельно.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] ReadFile(string path)
        {
            string str = "";
            using (StreamReader sr = new StreamReader(@path))
            {

                str = sr.ReadToEnd();
            }

            string[] films = str.Split('\n');
            return films;
        }
        /// <summary>
        /// Этот метод ищет в строке все подстроки. И если они имеются то добавляет их в лист и отправляет.
        /// </summary>
        /// <param name="actors"></param>
        /// <param name="films"></param>
        /// <returns></returns>
        public List<string> SearchFilms(string[] actors, string[] films)
        {
            List<string> foundfilms = new List<string>();
            for (int i = 0; i < films.Length; i++)
            {
                if (actors.All(films[i].Contains))
                {
                    foundfilms.Add(films[i]);
                }
            }
            
            return foundfilms;
        }
        /// <summary>
        /// Данный метод на основе предыдущего берет 0 индекс и первый индекс где встречается символ ) + 1 т.к нам этот символ нужен и вырезает данный участок + запихивает в лист и отправляет.
        /// </summary>
        /// <param name="foundfilms"></param>
        /// <returns></returns>
        public List<string> SubLines(List<string> foundfilms)
        {
            List<string> films = new List<string>();
            for (int i = 0; i < foundfilms.Count; i++)
            {
                string film = foundfilms[i].Substring(0, foundfilms[i].IndexOf(')') + 1);
                films.Add(film);
            }
            return films;
        }

        /// <summary>
        /// Этот метод на основе предыдущего из листа достает все элементы и делает из этого строку. Элементы разбиваются с помощью переноса строки.Или же если лист пуст отправляет сообщение о том что таких фильмов нет.
        /// </summary>
        /// <param name="films"></param>
        /// <returns></returns>
        public string OutputFilms(List<string> films)
        {
            string result = "";
            string failedsearch = "There are no such films.";
            if (Assert(films))
            {
                foreach (var i in films)
                {
                    result += i + '\n';
                }
                return result;
            }
            else
            {
                result += failedsearch;
                return result;
            }
            
        }
        /// <summary>
        /// Метод првоеряет пуст ли лист фильмов.
        /// </summary>
        /// <param name="films"></param>
        /// <returns></returns>
        public bool Assert(List<string> films)
        {
            if (films.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
