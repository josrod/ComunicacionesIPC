using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxMSWinsockLib;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // se le agregan los eventos necesarios al control axWinsock1
            this.axWinsock1.Error +=new DMSWinsockControlEvents_ErrorEventHandler(this.axWinsock1_Error);
            this.axWinsock1.ConnectEvent +=new EventHandler(this.axWinsock1_ConnectEvent);
            this.axWinsock1.DataArrival +=new DMSWinsockControlEvents_DataArrivalEventHandler(axWinsock1_DataArrival);
        }
        //variable para tener un control del estado de conexion entre el cliente y el servidor
        bool isConnected = false;

        private void bttConect_Click(object sender, EventArgs e)
        {
            //si esta conectado se cierra y si no se abre la conexion
            if (isConnected == false)
            {
                try
                {
                    // se cierra el winsock en caso de que este abierto.
                    axWinsock1.Close();
                    // se llama al metodo connect del winsock que pide una IP y un puerto a cual conectarce
                    axWinsock1.Connect(textBoxIP.Text, textBoxPort.Text);
                    isConnected = true;
                    labelEstado.Text = "Conectado por el puerto: " + textBoxPort.Text;
                    labelEstado.ForeColor = Color.Green;
                    bttConect.Text = "Desconectar";
                }
                //  con un bloque try-catch se cacha cualquier error y lo muestra en el log
                catch (System.Windows.Forms.AxHost.InvalidActiveXStateException g)
                {
                    listBoxLog.Items.Add(g.ToString());
                }
                catch (Exception ex)
                {
                    listBoxLog.Items.Add(ex.Message);
                }
            }
            else
            {
                try
                {
                    //Esto cierra la conexion con el cliente
                    axWinsock1.Close();

                    this.listBoxLog.Items.Add("Desconectandose..........");

                    bttConect.Text = "Conectar";
                    labelEstado.ForeColor = Color.Red;
                    labelEstado.Text = "Desconectado";
                    isConnected = false;
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error, el puerto no esta abierto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttSend_Click(object sender, EventArgs e)
        {
            try
            {
                //si esta conectado puede enviar informacion
                if (isConnected)
                {
                    //con esto se evia la informacion que tenga el textbox txtMsg hacia el servidor
                    axWinsock1.SendData(textBoxMsg.Text);
                    //"Reconocedor_ASR" + "127.0.0.1

                    //con esto visualizamos en pantalla el mensage que se acaba de enviar
                    listBoxLog.Items.Add("cliente- " + axWinsock1.LocalIP + ": " + textBoxMsg.Text);

                    //borramos el conteido del texbox para dejarlo listo para mandar un nuevo mensage
                    textBoxMsg.Clear();
                }
                else
                    MessageBox.Show("No esta conectado con el servidor");
            }
            //  con un bloque try-catch se muestra cualquier error y lo muestra en el log
            catch (AxWinsock.InvalidActiveXStateException g)
            {
                listBoxLog.Items.Add(g.ToString());
            }
            catch (Exception ex)
            {
                listBoxLog.Items.Add(ex.Message);
            }
        }
        
        //en caso de algun error solamente del winsock se activa este evento y se escribe en el log la informacion del error
        void axWinsock1_Error(object sender, DMSWinsockControlEvents_ErrorEvent e)
        {
            listBoxLog.Items.Add("Error :" + e.description);
            isConnected = false;
        }

        // Este evento se activa cuando el servidor ebvia informacion y el winsock del cliente atrapa esa informacion
        private void axWinsock1_DataArrival(object seder, DMSWinsockControlEvents_DataArrivalEvent e)
        {
            //creamos una variable para obtener los datos que llegaron
            string data="";
            //creamos otra variable tipo object porque el metodo que se utiliza para recivir datos es object
            object dat=(object)data;
            //obtenemos la informacion que envio el servidor en forma de object
            axWinsock1.GetData(ref dat);

            //hacemos un cast a esa variable y la guardamos en la variable data
            data=(string)dat;

            //mostramos la informacion en log
            listBoxLog.Items.Add("Servidor -" + axWinsock1.RemoteHostIP + ": " + data);
        }

        //esto pasa cuano se conecta a un servidor, muestra la informacion de conexion en el log
        private void axWinsock1_ConnectEvent(object sender, EventArgs e)
        {
            listBoxLog.Items.Add("Conectado con el servidor en: " + axWinsock1.RemoteHostIP);
            isConnected = true;
        }

        private void textBoxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bttSend.PerformClick();
            }
        }

        private void textBoxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bttConect.PerformClick();
            }
        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {

        }

    }
}