using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxMSWinsockLib;

namespace Servidor
{
    public partial class ServerForm1 : Form
    {
        public ServerForm1()
        {
            InitializeComponent();
        }
        //variable para el tener un ontrol sobre el estao de la conexion
        bool isConnected = false;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected)
                {
                    axWinsock1.SendData(textBoxMsg.Text);

                    //con esto se envia el texto que este el en txtMsg
                    listBoxLog.Items.Add("Servidor: " + textBoxMsg.Text);

                    //se borra la info del txtmsg
                    textBoxMsg.Clear();
                }
                else
                    MessageBox.Show("No estas conectado");
            }
            // con el bloque try-catch se muestra cualquier error que ocurra en el log
            catch (AxWinsock.InvalidActiveXStateException g)
            {
                listBoxLog.Items.Add(g.ToString());
            }
            catch (Exception ex)
            {
                listBoxLog.Items.Add(ex.Message);
            }
        }

        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                if(textBoxPuerto.Text != "" && int.TryParse(textBoxPuerto.Text,out x))
                {
                    //Para crear una conexion se necesita que el servidor(host) 
                    //siempre este escuchando por un puerto especifico, 
                    //y si un cliente se quiere conectar a el debe ir a abrir ese puerto

                    //Con esto se le asigna el puerto al winsock
                    axWinsock1.LocalPort=Int32.Parse(textBoxPuerto.Text);
                    isConnected=true;
                    //este comando abre la conexion con el puerto y se mantiene escuchando por el puerto especificado
                    axWinsock1.Listen();

                    labelEstado.ForeColor=Color.Green;
                    labelEstado.Text="Escuchando por el puerto:";

                    labelPuerto.Text=textBoxPuerto.Text;
                    labelPuerto.ForeColor=Color.Green;

                    pictureBox1.Show();
                    pictureBox2.Hide();

                    listBoxLog.Items.Add("Escuchando por el puerto: " + textBoxPuerto.Text);
                    btnDesconectar.Enabled=true;
                    btnEscuchar.Enabled=false;
                    btnEnviar.Enabled=true;
                }
                else
                {
                    MessageBox.Show("Debe asignar un puerto para escuchar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, lo mas probable es que el puerto seleccionado no este disponible");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                ////cierra la cinecion con el cliente
                axWinsock1.Close();

                this.listBoxLog.Items.Add("Desconectando......");

                btnEscuchar.Enabled = true;
                btnDesconectar.Enabled = false;
                btnEnviar.Enabled = false;

                labelEstado.ForeColor = Color.Red;

                pictureBox2.Show();
                pictureBox1.Hide();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, el puerto no esta abierto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
         //cuando se hace una peticion de coneccion de parte de un cliente
        private void axWinsock1_ConnectionRequest(object sender, DMSWinsockControlEvents_ConnectionRequestEvent e)
        {
            if (isConnected == true)
            {
                axWinsock1.Close();
            }

            //este comando acepta la coneccion con el cliente
            axWinsock1.Accept(e.requestID);
            isConnected = true;
            //escribe en el log si el cliente esta conectado.
            listBoxLog.Items.Add("Cliente conectado: " + axWinsock1.RemoteHostIP);
        }

        private void axWinsock1_DataArrival(object sender, DMSWinsockControlEvents_DataArrivalEvent e)
        {
            //creamos una variable para obtener los datos que llegaron
            string data = "";
            //creamos otra variable tipo object porque el metodo quse utiliza para recivir datos es object
            object dat = (object)data;
            //obtenemos la informacion que envio el servidor en forma de object
            axWinsock1.GetData(ref dat);

            //hacemos un cast a esa variable y la guardamos en la variable data
            data = (string)dat;

            //Mostramos la informacion en log
            listBoxLog.Items.Add(axWinsock1.RemoteHostIP + ": " + data);
        }

        private void ServerForm1_Load(object sender, EventArgs e)
        {
            //se muestra el nombre del equipo
            labelHost.Text = axWinsock1.LocalHostName;
            //se muestra la IP del equipo
            labelIPlocal.Text = axWinsock1.LocalIP;
        }

        private void textBoxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnviar.PerformClick();
            }
        }

    }
     
}