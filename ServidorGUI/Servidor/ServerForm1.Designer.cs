namespace Servidor
{
    partial class ServerForm1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm1));
            this.axWinsock1 = new AxMSWinsockLib.AxWinsock();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIPlocal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.btnEscuchar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWinsock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWinsock1
            // 
            this.axWinsock1.Enabled = true;
            this.axWinsock1.Location = new System.Drawing.Point(305, 374);
            this.axWinsock1.Name = "axWinsock1";
            this.axWinsock1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWinsock1.OcxState")));
            this.axWinsock1.Size = new System.Drawing.Size(28, 28);
            this.axWinsock1.TabIndex = 0;
            this.axWinsock1.ConnectionRequest += new AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEventHandler(this.axWinsock1_ConnectionRequest);
            this.axWinsock1.DataArrival += new AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEventHandler(this.axWinsock1_DataArrival);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del equipo:";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelHost.Location = new System.Drawing.Point(117, 9);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(29, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP Local:";
            // 
            // labelIPlocal
            // 
            this.labelIPlocal.AutoSize = true;
            this.labelIPlocal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelIPlocal.Location = new System.Drawing.Point(216, 9);
            this.labelIPlocal.Name = "labelIPlocal";
            this.labelIPlocal.Size = new System.Drawing.Size(42, 13);
            this.labelIPlocal.TabIndex = 4;
            this.labelIPlocal.Text = "IP local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto:";
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(22, 59);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuerto.TabIndex = 6;
            // 
            // btnEscuchar
            // 
            this.btnEscuchar.Location = new System.Drawing.Point(22, 85);
            this.btnEscuchar.Name = "btnEscuchar";
            this.btnEscuchar.Size = new System.Drawing.Size(99, 20);
            this.btnEscuchar.TabIndex = 7;
            this.btnEscuchar.Text = "Escuchar";
            this.btnEscuchar.UseVisualStyleBackColor = true;
            this.btnEscuchar.Click += new System.EventHandler(this.btnEscuchar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(22, 111);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(98, 22);
            this.btnDesconectar.TabIndex = 8;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.Color.Red;
            this.labelEstado.Location = new System.Drawing.Point(189, 66);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(138, 13);
            this.labelEstado.TabIndex = 10;
            this.labelEstado.Text = "Sin Escuchar ningun puerto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mensaje:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(25, 169);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(219, 20);
            this.textBoxMsg.TabIndex = 12;
            this.textBoxMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMsg_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(258, 169);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(59, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(22, 217);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(298, 173);
            this.listBoxLog.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Log:";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(234, 96);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(0, 13);
            this.labelPuerto.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Servidor.Properties.Resources.x;
            this.pictureBox2.Location = new System.Drawing.Point(147, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Servidor.Properties.Resources.ok;
            this.pictureBox1.Location = new System.Drawing.Point(147, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ServerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 404);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnEscuchar);
            this.Controls.Add(this.textBoxPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIPlocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWinsock1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ServerForm1";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.ServerForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWinsock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSWinsockLib.AxWinsock axWinsock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIPlocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.Button btnEscuchar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

