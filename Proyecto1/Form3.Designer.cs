namespace Cliente
{
    partial class Form3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chatLbl = new System.Windows.Forms.Label();
            this.partidaIdLbl = new System.Windows.Forms.Label();
            this.Ganador = new System.Windows.Forms.Label();
            this.Restartbtn1 = new System.Windows.Forms.Button();
            this.Restartbtn2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enviarBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.chatLbl);
            this.panel1.Location = new System.Drawing.Point(680, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 523);
            this.panel1.TabIndex = 11;
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(166, 491);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(62, 23);
            this.enviarBtn.TabIndex = 14;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 493);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 13;
            // 
            // chatLbl
            // 
            this.chatLbl.Location = new System.Drawing.Point(3, 6);
            this.chatLbl.Name = "chatLbl";
            this.chatLbl.Size = new System.Drawing.Size(227, 474);
            this.chatLbl.TabIndex = 12;
            this.chatLbl.Text = "CHAT:";
            // 
            // partidaIdLbl
            // 
            this.partidaIdLbl.AutoSize = true;
            this.partidaIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidaIdLbl.Location = new System.Drawing.Point(21, 9);
            this.partidaIdLbl.Name = "partidaIdLbl";
            this.partidaIdLbl.Size = new System.Drawing.Size(41, 13);
            this.partidaIdLbl.TabIndex = 12;
            this.partidaIdLbl.Text = "label6";
            // 
            // Ganador
            // 
            this.Ganador.BackColor = System.Drawing.Color.Transparent;
            this.Ganador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganador.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Ganador.Location = new System.Drawing.Point(258, 255);
            this.Ganador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ganador.Name = "Ganador";
            this.Ganador.Size = new System.Drawing.Size(133, 49);
            this.Ganador.TabIndex = 14;
            this.Ganador.Text = "sad";
            this.Ganador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Restartbtn1
            // 
            this.Restartbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restartbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restartbtn1.Location = new System.Drawing.Point(725, 568);
            this.Restartbtn1.Name = "Restartbtn1";
            this.Restartbtn1.Size = new System.Drawing.Size(124, 41);
            this.Restartbtn1.TabIndex = 15;
            this.Restartbtn1.Text = "Nueva Ronda";
            this.Restartbtn1.UseVisualStyleBackColor = true;
            this.Restartbtn1.Click += new System.EventHandler(this.Restartbtn1_Click);
            // 
            // Restartbtn2
            // 
            this.Restartbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restartbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restartbtn2.Location = new System.Drawing.Point(725, 568);
            this.Restartbtn2.Name = "Restartbtn2";
            this.Restartbtn2.Size = new System.Drawing.Size(124, 41);
            this.Restartbtn2.TabIndex = 16;
            this.Restartbtn2.Text = "Nueva Ronda";
            this.Restartbtn2.UseVisualStyleBackColor = true;
            this.Restartbtn2.Click += new System.EventHandler(this.Restartbtn2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Cliente.Properties.Resources._66F7C780_A7B7_4798_BA0F_F94087BB2EE4__1_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.Ganador);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(11, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 575);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Cliente.Properties.Resources._1_d;
            this.pictureBox8.Location = new System.Drawing.Point(386, 383);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(264, 174);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Cliente.Properties.Resources._3_d;
            this.pictureBox7.Location = new System.Drawing.Point(386, 191);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(264, 175);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Cliente.Properties.Resources._2_d;
            this.pictureBox6.Location = new System.Drawing.Point(386, 9);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(278, 165);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cliente.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Cliente.Properties.Resources._1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 383);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cliente.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 191);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Restartbtn2);
            this.Controls.Add(this.Restartbtn1);
            this.Controls.Add(this.partidaIdLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label chatLbl;
        private System.Windows.Forms.Label partidaIdLbl;
        private System.Windows.Forms.Label Ganador;
        private System.Windows.Forms.Button Restartbtn1;
        private System.Windows.Forms.Button Restartbtn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer2;
    }
}