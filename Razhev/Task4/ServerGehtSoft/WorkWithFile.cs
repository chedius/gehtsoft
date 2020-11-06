using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ServerGehtSoft
{
    // Сделал: Ражев Дмитрий
    class WorkWithFile
    {
        public string[] ReadFile(string path)
        {
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {

                str = sr.ReadToEnd();
            }

            string[] films = str.Split('\n');
            return films;
        }
        // Получаем из каждой строки массива фильмов Название фильма (год экранизации)
        public List<string> FindNameYearFilms(string[] films , out List<string> actorsFilms) 
        {
            List<string> nameYearFilm = new List<string>();
            actorsFilms = new List<string>();
            for (int i = 0; i < films.Length; i++) 
            {
                if (!string.IsNullOrEmpty(films[i])) 
                {
                    string variable = films[i].Substring(0, films[i].IndexOf(')') + 1);
                    string variable1 = films[i].Replace(variable,"");
                    variable1 = variable1.Trim('/');
                    variable1 = variable1.Replace(",","");
                    variable1 = variable1.Replace("/", ",");
                    nameYearFilm.Add(variable);
                    actorsFilms.Add(variable1);
                }
            }
            return nameYearFilm;
        }
        // Получаем отдельно Название каждого фильма и год экранизации
        public List<string> SubNameYearFilms(List<string> nameYearFilms , out List<string> yearFilms) 
        {
            List<string> nameFilms = new List<string>();
            yearFilms = new List<string>();
            for (int i = 0; i < nameYearFilms.Count; i++) 
            {
                string variable2 = nameYearFilms[i].Substring(0, nameYearFilms[i].IndexOf('(') - 1);
                nameFilms.Add(variable2);
                nameYearFilms[i] = nameYearFilms[i].Replace(variable2, "").Trim(' ');
                nameYearFilms[i] = nameYearFilms[i].TrimStart('(').TrimEnd(')');
                yearFilms.Add(nameYearFilms[i]);
            }
            return nameFilms;
        }

        public string FindActorsFilm(List<Movie> movies , string[] actors) 
        {
            string result = "";
            for (int i = 0; i < movies.Count; i++)
            {
                if (actors.All(movies[i].Actors.Contains))
                {
                    result += movies[i].Name + " " + "-" + " " + movies[i].Year + '\n' + movies[i].Actors + '\n';
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                result += "Nothing found.";
            }
            return result;
        }

        public string FindNameFilm(List<Movie> movies, string name)
        {
            string result = "";
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Name.Contains(name))
                {
                    result += movies[i].Name + " " + "-" + " " + movies[i].Year + '\n';
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                result += "Nothing found.";
            }
            return result;
        }

        public string FindYearFilm(List<Movie> movies, string year)
        {
            string result = "";
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Year.Contains(year))
                {
                    result += movies[i].Name + " " + "-" + " " + movies[i].Year + '\n';
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                result += "Nothing found.";
            }
            return result;
        }
    }
}
