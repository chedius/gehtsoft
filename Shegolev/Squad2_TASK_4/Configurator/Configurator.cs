using System;

namespace Configurator
{
    public class Config
    {
        //ChatClient
        public string userName;
        public string host = "127.0.0.1";
        public int port = 8888;
        public int buf = 256;
        ////////////////////////////////////////////////////

        //ServerHost
        public string TextPath = @"..\Texts.txt";
        ////////////////////////////////////////////////////

        public string GetPath(string userName)
        {
            string path = $@"../UsersResults/{userName}";
            return path;
        }

    }
}
