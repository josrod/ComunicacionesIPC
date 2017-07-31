using System;
using System.Collections.Generic;
using System.Text;
using AIMLbot;
using System.IO;

namespace ServidorChatBot
{
    class ChatBot
    {
        private Bot myBot;
        private User myUser;
        public string strLastResult;

        public ChatBot()
        {
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser", myBot);

        }

        public void ChatBotConfig()
        {
            //FileInfo fi = new FileInfo("K://ConsoleBot//ConsoleBot//bin//Debug//");

            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            //myBot.loadCustomTagHandlers(fi.DirectoryName.ToString() + "//CustomAIMLTags.dll");
            myBot.loadCustomTagHandlers("CustomAIMLTags.dll");

            Console.WriteLine("Archivos AIML y CustomTag insertados correctamente en la memoria del Bot!!\n");
            Console.WriteLine("!! AriscoBot 2009 !!\n");

            myBot.isAcceptingUserInput = true;
        }

        public string InputFromUser(string strInput, double fConfidence)
        {
            strLastResult = "";
            //  string strInput = AsrDll.strLastResult; es la salida del ASR que en este caso lo mando por la funcion
            //cuando tenga la comunicacion mando tambien confidence
            if (myBot.isAcceptingUserInput && strInput != null && fConfidence >=0.3)
            {
                Request myRequest = new Request(strInput, myUser, myBot);
                Result myResult = myBot.Chat(myRequest);
                strLastResult = myResult.Output.ToString();

                if (myUser.Nombre == "desconocido")
                {
                    strLastResult = strLastResult.Replace("desconocido", " ");
                }
                /*** OJO lo utilizo para identificar risas llanto , etc *********/
                string sTemaTag = "";
                sTemaTag = this.myUser.Topic.ToString();

                /**********************************************************************/
                switch (sTemaTag)
                {
                    case "chiste":
                        {
                            strLastResult = strLastResult + " \\item=Laugh_01";
                            this.myUser.Predicates.addSetting("topic", "*");
                            break;
                        }
                    case "sonrisa":
                        {
                            strLastResult = "\\item=Yeee_01 " + strLastResult;
                            this.myUser.Predicates.addSetting("topic", "*");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                return strLastResult;

            }
            else
            {
                Console.WriteLine("El Bot no acepta la entrada del usuario.\n");
                return strLastResult="\\item=Breath_04";
            }
        }

    }
}
