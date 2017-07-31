using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServidorChatBot
{
    class Program
    {

        static void Main(string[] args)
        {

            Server myServer = new Server();
            myServer.ServerConfig();

            while (true)
            {
                try
                {
                    myServer.ServerConextion();
                }
                catch (SocketException err)
                {
                    Console.WriteLine("Fallo: {0}", err.Message);
                }

            }

        }

    }
}
