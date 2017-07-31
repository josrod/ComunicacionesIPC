namespace Cliente
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttConect = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.bttSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.axWinsock1 = new AxMSWinsockLib.AxWinsock();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWinsock1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(12, 34);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 0;
            this.textBoxIP.Text = "192.168.107.25";
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            this.textBoxIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIP_KeyPress);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(144, 34);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto:";
            // 
            // bttConect
            // 
            this.bttConect.Location = new System.Drawing.Point(17, 75);
            this.bttConect.Name = "bttConect";
            this.bttConect.Size = new System.Drawing.Size(83, 23);
            this.bttConect.TabIndex = 4;
            this.bttConect.Text = "Conectar";
            this.bttConect.UseVisualStyleBackColor = true;
            this.bttConect.Click += new System.EventHandler(this.bttConect_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEstado.Location = new System.Drawing.Point(13, 101);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(125, 20);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Desconectado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensaje:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(12, 154);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(174, 20);
            this.textBoxMsg.TabIndex = 7;
            this.textBoxMsg.Text = "str/bien/nconf/0.4";
            this.textBoxMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMsg_KeyPress);
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(209, 154);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(58, 23);
            this.bttSend.TabIndex = 8;
            this.bttSend.Text = "Enviar";
            this.bttSend.UseVisualStyleBackColor = true;
            this.bttSend.Click += new System.EventHandler(this.bttSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Log:";
            // 
            // axWinsock1
            // 
            this.axWinsock1.Enabled = true;
            this.axWinsock1.Location = new System.Drawing.Point(304, 310);
            this.axWinsock1.Name = "axWinsock1";
            this.axWinsock1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWinsock1.OcxState")));
            this.axWinsock1.Size = new System.Drawing.Size(28, 28);
            this.axWinsock1.TabIndex = 11;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(20, 223);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(247, 121);
            this.listBoxLog.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 350);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.axWinsock1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.bttConect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Form1";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.axWinsock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttConect;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button bttSend;
        private System.Windows.Forms.Label label5;
        private AxMSWinsockLib.AxWinsock axWinsock1;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

