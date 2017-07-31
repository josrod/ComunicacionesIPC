using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Globalization;

namespace ServidorChatBot
{
    class Server
    {
        int nPuerto;
        byte[] receiveBufer;
        string strResult;
        string data;

        Socket tcpClient;
        Socket tcpServer;

        ChatBot myChatBot;
        
        public Server()
        {
            nPuerto = 7070;
            strResult="";
            data = "";
            receiveBufer = new byte[1024];
            myChatBot = new ChatBot();
        }

        public void ServerConfig()
        {
            // Inicializo el chatbot
            myChatBot.ChatBotConfig();
            
            //IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            string sHostName =Dns.GetHostName();
            IPHostEntry ipHostInfo =Dns.Resolve(sHostName);
            IPAddress ipAddress =ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, nPuerto);
            
            /* Los argumentos son:
             * AddressFamily.InterNetwork: indica que la direccion es para una IP v4 (xxx.xxx.xxx.xxx)
             * SocketType.Stream: Es el tipo de socket, hay varios tipos, para mas información sobre estos 
             * consultad la informacion que les da el entorno de programación.
             * ProtocolType.Tcp: Es el potocolo que se usara, tambien hay varios, para mas informacion consulten el entorno de programación. 
             * 
             */
            tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Nombre del equipo: " + sHostName);
            Console.WriteLine("Ip Local: " + ipAddress);
            Console.WriteLine("Escuchando por el puerto:" + localEndPoint.Port.ToString());
            
            tcpServer.Bind(localEndPoint);
            tcpServer.Listen(10);
            Console.WriteLine("Waiting");
        }

        public void ServerConextion()
        {
            tcpClient = tcpServer.Accept();
            Console.WriteLine("Cliente conectado: {0}", tcpClient.RemoteEndPoint.ToString());
            try
            {
                while (true)
                {
                    int rc = tcpClient.Receive(receiveBufer);
                    data = System.Text.Encoding.ASCII.GetString(receiveBufer, 0, rc); //Lo codificamos a cadena (ya que se envian como bytes)
                    if (rc == 0)
                        break;

                    strResult=decodificar(data);
                    //Enviamos
                    byte[] msgCliente = System.Text.Encoding.ASCII.GetBytes(strResult);
                    tcpClient.Send(msgCliente); //Enviamos el mensage al cliente
                }
            }
            catch (SocketException err)
            {
                Console.WriteLine("A ocurrido un error en el socket: {0}", err.Message);
            }
            finally
            {
                Console.WriteLine("Ha finalizado la conexión"); //Avisamos que que se a terminado la transferencia de datos
                byte[] msg = System.Text.Encoding.ASCII.GetBytes("\nConexion finalizada la aplicacion"); //Codificamos de string a byte el siguiente mensage para que se pueda enviar al NetCat (Cliente)

                tcpClient.Shutdown(SocketShutdown.Both); //"Apagamos" los sockets
                tcpClient.Close(); //Los cerramos*/
            }
            
        }

        private string decodificar(string strClientMsg)
        {
            // Variables para el mensaje decodificado en string y double
            string strASRMsg="";  // string del lo reconocido en el ASR
            string strASRConfiMsg = ""; // string de el confidence obtenido por el ASR
            double dConfidence = 0; // valor del confidence obtenido por el ASR

            
            string strChatResult="";  // string de la salida del ChatBot 
            
            // valores para recorrer el string del cliente codificado
            int nASRIni = 0;
            int nASREnd = 0;
            int nASRLength = 0;

            int nConfidenceIni = 0;
            int nConfidenceEnd = 0;
            int nConfiLength = 0;


            Console.WriteLine("Se a recibido: {0}", strClientMsg); //Mostramos lo recibido por pantalla

            nASRIni = strClientMsg.IndexOf("/");
            nASREnd = strClientMsg.IndexOf("/", nASRIni + 1);
            nASRLength = nASREnd - nASRIni;

            strASRMsg = strClientMsg.Substring((nASRIni + 1),(nASRLength - 1)); // encuentro el mensaje de reconocimiento del ASR

            nConfidenceIni = strClientMsg.LastIndexOf("/");
            nConfidenceEnd = strClientMsg.Length;
            nConfiLength = nConfidenceEnd - nConfidenceIni;

            strASRConfiMsg = strClientMsg.Substring((nConfidenceIni + 1), (nConfiLength - 1)); // en cueltro el confidence
            dConfidence = double.Parse(strASRConfiMsg,CultureInfo.InvariantCulture.NumberFormat); // lo paso a double


            Console.WriteLine("ASR Mensaje: {0}", strASRMsg);
            Console.WriteLine("Confidence Mensaje: {0}", dConfidence.ToString());

            strChatResult = myChatBot.InputFromUser(strASRMsg,dConfidence); // obtengo la salida del Chatbot

            return strChatResult;
        }
    }
}
