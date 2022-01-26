using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;


namespace Cliente
{
    public partial class Form3 : Form
    {
        int Tiempo = 0;
        int Tiempo2 = 20;
        int seleccion, seleccion2;
        int ID_Partida;
        bool encontrado1;
        bool encontrado2;
        bool restart = true;
        string nombreMsg1;
        string nombreMsg2;
        bool jugador1 = false;
        bool jugador2 = false;
        int jugada1;
        int jugada2;
        int contadorpartidas;
        int numero;
        Socket server;
        delegate void DelegadochatLbl(string nombreMsg, string chat);
        delegate void Delegadojugador1(string nombreMsg1, int jugada1);
        delegate void Delegadojugador2(string nombreMsg2, int jugada2);

        public Form3(int ID_Partida, Socket server)
        {
            InitializeComponent();
            this.ID_Partida = ID_Partida;
            this.server = server;

        }

        public Form3()
        {
            // TODO: Complete member initialization
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            partidaIdLbl.Text = "Número de la partida: " + ID_Partida;
            encontrado1 = false;
            encontrado2 = false;
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
 
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();

            Restartbtn1.Hide();

            Restartbtn2.Hide();

            Ganador.Text = "";
            Ganador.Hide();
            FuncionJugador1();
            numero = Form2.numjugador;
            if (numero == 2)
            {
                FuncionJugador2();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Tiempo++;
            if (Tiempo < 20)
            {
                if (Tiempo % 2 == 0 && jugador1 == true)
                    Juego();
                if (Tiempo % 2 == 0 && jugador2 == true)
                    Juego2();
            }
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            seleccion = 2;
         
            string mensaje = "11/" + Form1.N + "/" + ID_Partida + "/" + seleccion;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado1 = true;
            pictureBox1.Hide();
            pictureBox3.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            seleccion = 1;
  
            string mensaje = "11/" + Form1.N + "/" + ID_Partida + "/" + seleccion;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado1 = true;
            pictureBox2.Hide();
            pictureBox3.Hide();

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            seleccion = 3;
 
            string mensaje = "11/" + Form1.N + "/" + ID_Partida + "/" + seleccion;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado1 = true;
            pictureBox1.Hide();
            pictureBox2.Hide();
           
        }

        private void jugarbtn1_Click(object sender, EventArgs e)
        {
            //string mensaje = "11/" + Form1.N + "/" + ID_Partida + "/" + seleccion;
            //byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            //Form1.server.Send(msg);
            //encontrado1 = true;



        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            string mensaje = "8/" + Form1.N + "/" + ID_Partida + "/" + textBox1.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
        }

        public void tomaRespuesta(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {
                case 9:
                    DelegadochatLbl delegado = new DelegadochatLbl(EscribirMensaje);
                    this.Invoke(delegado, new object[] { respuesta[1], respuesta[3] });
                    break;
            }
        }

        public void tomaRespuesta2(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {

                case 11:

                    nombreMsg1 = respuesta[1];
                    jugada1 = Convert.ToInt32(respuesta[3]);

                    break;

            }
        }
        public void tomaRespuesta3(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {
                case 12:
                    nombreMsg2 = respuesta[1];
                    jugada2 = Convert.ToInt32(respuesta[3]);


                    break;
            }
        }
        public void EscribirMensaje(string nombreMsg, string mensajeChat)
        {

            chatLbl.Text = chatLbl.Text + Environment.NewLine + nombreMsg + ": " + mensajeChat;
        }

        public void Juego()
        {
            if (encontrado1 == true)
            {
                if (jugada1 == 1 && jugada2 == 1)
                {
                    pictureBox6.Show();
                    Ganador.Text = "Empate";
                }
                if (jugada1 == 2 && jugada2 == 2)
                {
                    pictureBox7.Show();
                    Ganador.Text = "Empate";
                }
                if (jugada1 == 3 && jugada2 == 3)
                {
                    pictureBox8.Show();
                    Ganador.Text = "Empate";
                }
                if (jugada1 == 1 && jugada2 == 3)
                {
                    pictureBox8.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada1 == 2 && jugada2 == 1)
                {
                    pictureBox6.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada1 == 3 && jugada2 == 2)
                {
                    pictureBox7.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada1 == 1 && jugada2 == 2)
                {
                    pictureBox7.Show();
                    Ganador.Text = "Has perdido";
                }
                if (jugada1 == 2 && jugada2 == 3)
                {
                    pictureBox8.Show();
                    Ganador.Text = "Has perdido";
                }
                if (jugada1 == 3 && jugada2 == 1)
                {
                    pictureBox6.Show();
                    Ganador.Text = "Has perdido";
                }
               
            }
        }


        public void Juego2()
        {
            if (encontrado2 == true)
            {
                if (jugada1 == 1 && jugada2 == 1)
                {
                    pictureBox1.Show();
                    Ganador.Text = "Empate";
                 
                }
                if (jugada1 == 2 && jugada2 == 2)
                {
                    pictureBox2.Show();
                    Ganador.Text = "Empate";
                }
                if (jugada1 == 3 && jugada2 == 3)
                {
                    pictureBox3.Show();
                    Ganador.Text = "Empate";
                }
                if (jugada2 == 1 && jugada1 == 3)
                {
                    pictureBox3.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada2 == 2 && jugada1 == 1)
                {
                    pictureBox1.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada2 == 3 && jugada1 == 2)
                {
                    pictureBox2.Show();
                    Ganador.Text = "Has ganado";
                }
                if (jugada2 == 1 && jugada1 == 2)
                {
                    pictureBox2.Show();
                    Ganador.Text = "Has perdido";
                }
                if (jugada2 == 2 && jugada1 == 3)
                {
                    pictureBox3.Show();
                    Ganador.Text = "Has perdido";
                }
                if (jugada2 == 3 && jugada1 == 1)
                {
                    pictureBox1.Show();
                    Ganador.Text = "Has perdido";
                }
               
            }
        }

        public void FuncionJugador1()
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();


            Restartbtn1.Show();
 
            Restartbtn2.Hide();

            Ganador.Show();

            jugador1 = true;
        }
        public void FuncionJugador2()
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
          
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();

            Restartbtn2.Show();
            Restartbtn1.Hide();
           
           
            Ganador.Show();

            jugador2 = true;
        }

        private void Restartbtn1_Click(object sender, EventArgs e)
        {

            Ganador.Text = null;
            jugada2 = 0;
            jugada1 = 0;
            pictureBox1.Show();
            pictureBox3.Show();
            pictureBox2.Show();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            Tiempo = 0;
            timer2.Start();
            Tiempo2 = 20;
            seleccion = 0;
          
          
        }

        private void jugarbtn2_Click(object sender, EventArgs e)
        {

            //string mensaje = "12/" + Form1.N + "/" + ID_Partida + "/" + seleccion2;
            //byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            //Form1.server.Send(msg);
            //encontrado2 = true;

            

        }

        private void Restartbtn2_Click(object sender, EventArgs e)
        {

            Ganador.Text = null;
            jugada2 = 0;
            jugada1 = 0;
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            Tiempo = 0;
            timer2.Start();
            Tiempo2 = 20;
            seleccion2 = 0;
        
        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {
            seleccion2 = 1;

            string mensaje = "12/" + Form1.N + "/" + ID_Partida + "/" + seleccion2;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado2 = true;
            pictureBox7.Hide();
            pictureBox8.Hide();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            seleccion2 = 2;

            string mensaje = "12/" + Form1.N + "/" + ID_Partida + "/" + seleccion2;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado2 = true;
            pictureBox6.Hide();
            pictureBox8.Hide();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            seleccion2 = 3;

            string mensaje = "12/" + Form1.N + "/" + ID_Partida + "/" + seleccion2;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Form1.server.Send(msg);
            encontrado2 = true;
            pictureBox7.Hide();
            pictureBox6.Hide();
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            Tiempo2--;
            if (Tiempo2 == 0)
            {
                timer2.Stop();
            }
            label3.Text = "Tiempo Restante: " + (Convert.ToInt32(Tiempo2).ToString());
        }

    }
}
