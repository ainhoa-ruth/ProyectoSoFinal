namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ganado = new System.Windows.Forms.RadioButton();
            this.febrero = new System.Windows.Forms.RadioButton();
            this.puntos = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconectarbtn = new System.Windows.Forms.Button();
            this.lblconexion = new System.Windows.Forms.Label();
            this.ListaConectados = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.invitarbtn = new System.Windows.Forms.Button();
            this.darsedebajabtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.consultasbtn = new System.Windows.Forms.Button();
            this.sobrenosotrosbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // ganado
            // 
            this.ganado.AutoSize = true;
            this.ganado.Location = new System.Drawing.Point(587, 299);
            this.ganado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ganado.Name = "ganado";
            this.ganado.Size = new System.Drawing.Size(257, 21);
            this.ganado.TabIndex = 3;
            this.ganado.TabStop = true;
            this.ganado.Text = "Dime quien ha ganado mas partidas";
            this.ganado.UseVisualStyleBackColor = true;
            // 
            // febrero
            // 
            this.febrero.AutoSize = true;
            this.febrero.Location = new System.Drawing.Point(587, 330);
            this.febrero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.febrero.Name = "febrero";
            this.febrero.Size = new System.Drawing.Size(334, 21);
            this.febrero.TabIndex = 4;
            this.febrero.TabStop = true;
            this.febrero.Text = "Dime cuantas partidas se han jugado en febrero";
            this.febrero.UseVisualStyleBackColor = true;
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(587, 358);
            this.puntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(504, 21);
            this.puntos.TabIndex = 5;
            this.puntos.TabStop = true;
            this.puntos.Text = "Dime el numero de partidas en las que Juan ha obtenido mas de 30 puntos";
            this.puntos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(757, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(231, 212);
            this.usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(224, 22);
            this.usuario.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(231, 257);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 22);
            this.password.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(92, 330);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 64);
            this.button3.TabIndex = 9;
            this.button3.Text = "Iniciar Sesion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(279, 330);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "Registrarse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña:";
            // 
            // Desconectarbtn
            // 
            this.Desconectarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desconectarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectarbtn.Location = new System.Drawing.Point(92, 430);
            this.Desconectarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Desconectarbtn.Name = "Desconectarbtn";
            this.Desconectarbtn.Size = new System.Drawing.Size(164, 63);
            this.Desconectarbtn.TabIndex = 21;
            this.Desconectarbtn.Text = "Desconectar";
            this.Desconectarbtn.UseVisualStyleBackColor = true;
            this.Desconectarbtn.Click += new System.EventHandler(this.Desconectarbtn_Click);
            // 
            // lblconexion
            // 
            this.lblconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconexion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblconexion.Location = new System.Drawing.Point(1052, -80);
            this.lblconexion.Name = "lblconexion";
            this.lblconexion.Size = new System.Drawing.Size(171, 209);
            this.lblconexion.TabIndex = 22;
            this.lblconexion.Text = "·";
            this.lblconexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListaConectados
            // 
            this.ListaConectados.AllowUserToAddRows = false;
            this.ListaConectados.AllowUserToDeleteRows = false;
            this.ListaConectados.AllowUserToResizeColumns = false;
            this.ListaConectados.AllowUserToResizeRows = false;
            this.ListaConectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaConectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaConectados.BackgroundColor = System.Drawing.Color.White;
            this.ListaConectados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaConectados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListaConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaConectados.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaConectados.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaConectados.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListaConectados.Location = new System.Drawing.Point(1150, 0);
            this.ListaConectados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaConectados.MultiSelect = false;
            this.ListaConectados.Name = "ListaConectados";
            this.ListaConectados.ReadOnly = true;
            this.ListaConectados.RowHeadersVisible = false;
            this.ListaConectados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaConectados.RowTemplate.Height = 24;
            this.ListaConectados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListaConectados.ShowCellErrors = false;
            this.ListaConectados.ShowCellToolTips = false;
            this.ListaConectados.ShowEditingIcon = false;
            this.ListaConectados.ShowRowErrors = false;
            this.ListaConectados.Size = new System.Drawing.Size(247, 625);
            this.ListaConectados.TabIndex = 23;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // invitarbtn
            // 
            this.invitarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invitarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invitarbtn.Location = new System.Drawing.Point(967, 545);
            this.invitarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invitarbtn.Name = "invitarbtn";
            this.invitarbtn.Size = new System.Drawing.Size(161, 55);
            this.invitarbtn.TabIndex = 24;
            this.invitarbtn.Text = "Invitar";
            this.invitarbtn.UseVisualStyleBackColor = true;
            this.invitarbtn.Click += new System.EventHandler(this.invitarbtn_Click);
            // 
            // darsedebajabtn
            // 
            this.darsedebajabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darsedebajabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darsedebajabtn.Location = new System.Drawing.Point(276, 430);
            this.darsedebajabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.darsedebajabtn.Name = "darsedebajabtn";
            this.darsedebajabtn.Size = new System.Drawing.Size(164, 63);
            this.darsedebajabtn.TabIndex = 26;
            this.darsedebajabtn.Text = "Darse de baja";
            this.darsedebajabtn.UseVisualStyleBackColor = true;
            this.darsedebajabtn.Click += new System.EventHandler(this.darsedebajabtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(75, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(984, 154);
            this.label3.TabIndex = 27;
            this.label3.Text = "PIEDRA PAPEL TIJERA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consultasbtn
            // 
            this.consultasbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasbtn.Location = new System.Drawing.Point(757, 212);
            this.consultasbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultasbtn.Name = "consultasbtn";
            this.consultasbtn.Size = new System.Drawing.Size(164, 62);
            this.consultasbtn.TabIndex = 28;
            this.consultasbtn.Text = "Consultas";
            this.consultasbtn.UseVisualStyleBackColor = true;
            this.consultasbtn.Click += new System.EventHandler(this.consultasbtn_Click);
            // 
            // sobrenosotrosbtn
            // 
            this.sobrenosotrosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobrenosotrosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenosotrosbtn.Location = new System.Drawing.Point(12, 12);
            this.sobrenosotrosbtn.Name = "sobrenosotrosbtn";
            this.sobrenosotrosbtn.Size = new System.Drawing.Size(164, 63);
            this.sobrenosotrosbtn.TabIndex = 29;
            this.sobrenosotrosbtn.Text = "Sobre nosotros";
            this.sobrenosotrosbtn.UseVisualStyleBackColor = true;
            this.sobrenosotrosbtn.Click += new System.EventHandler(this.sobrenosotrosbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1397, 625);
            this.Controls.Add(this.sobrenosotrosbtn);
            this.Controls.Add(this.consultasbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.darsedebajabtn);
            this.Controls.Add(this.invitarbtn);
            this.Controls.Add(this.ListaConectados);
            this.Controls.Add(this.lblconexion);
            this.Controls.Add(this.Desconectarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.febrero);
            this.Controls.Add(this.ganado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ganado;
        private System.Windows.Forms.RadioButton febrero;
        private System.Windows.Forms.RadioButton puntos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Desconectarbtn;
        private System.Windows.Forms.Label lblconexion;
        private System.Windows.Forms.DataGridView ListaConectados;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button invitarbtn;
        private System.Windows.Forms.Button darsedebajabtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button consultasbtn;
        private System.Windows.Forms.Button sobrenosotrosbtn;
    }
}

