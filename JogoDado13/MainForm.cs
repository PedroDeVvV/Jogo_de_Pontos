using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDado13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void Limpar()
        {
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Load("padrao.png");
            pictureBox2.Load("padrao.png");
            pictureBox4.Load("padrao.png ");
            pictureBox5.Load("padrao.png");
            pictureBox3.Load("padrao.png ");
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Load("padrao.png");
            pictureBox7.Load("padrao.png");
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
        }
        Random rnd = new Random();
        int n6, n7; //dados do computador

        void Button1Click(object sender, EventArgs e) //iniciar
        {
            Limpar();
            int n1 = rnd.Next(1, 7);
            pictureBox1.Load("dado" + n1 + ".png"); //dado3.jpg, evita de fazer 6 ifs

            int n2 = rnd.Next(1, 7);
            pictureBox2.Load("dado" + n2 + ".png");

            int soma = n1 + n2;
            label1.Text = soma.ToString();

            // dados do computador recebem valor
            n6 = rnd.Next(1, 7);
            n7 = rnd.Next(1, 7);
            button1.Enabled = false;
            button2.Enabled = true;
        }
        void PictureBox3Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = false;
            int n3 = rnd.Next(1, 7);
            pictureBox3.Load("dado" + n3 + ".png");

            int soma = int.Parse(label1.Text) + n3;
            label1.Text = soma.ToString();

            if (soma > 13)
            {
                MessageBox.Show("Você estourou os 13 pontos. Perdeu!");
            }
            else
            {
                pictureBox4.Visible = true;
            }
        }
        void PictureBox4Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = false;
            int n4 = rnd.Next(1, 7);
            pictureBox4.Load("dado" + n4 + ".png");

            int soma = int.Parse(label1.Text) + n4;
            label1.Text = soma.ToString();

            if (soma > 13)
            {
                MessageBox.Show("Você estourou os 13 pontos. Perdeu!");
            }
            else
            {
                pictureBox5.Visible = true;
            }
        }
        void PictureBox5Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = false;
            int n5 = rnd.Next(1, 7);
            pictureBox5.Load("dado" + n5 + ".png");

            int soma = int.Parse(label1.Text) + n5;
            label1.Text = soma.ToString();

            if (soma > 13)
            {
                MessageBox.Show("Você estourou os 13 pontos. Perdeu!");
            }
            else
            {
                MessageBox.Show("Número máximo de quadrados clicados, clique em finalizar");
            }
        }
        void Button2Click(object sender, EventArgs e) //finalizar
        {
            int placarUser = int.Parse(label10.Text) + 1;
            int placarPc = int.Parse(label9.Text) + 1;
            int somaJogador = int.Parse(label1.Text);
            int somaPc = n6 + n7;
            label2.Text = somaPc.ToString();
            pictureBox6.Load("dado" + n6 + ".png");
            pictureBox7.Load("dado" + n7 + ".png");
            button1.Enabled = true;
            button2.Enabled = false;
            if (somaPc == 13)
            {
                MessageBox.Show("Perdeu, computador somou 13");
                label9.Text = placarPc.ToString();
            }

            else if (somaJogador > 13)
            {
                MessageBox.Show("Perdeu, estourou limite!");

                label9.Text = placarPc.ToString();
            }
            else if (somaJogador == 13)
            {
                MessageBox.Show("Parabéns, você ganhou com 13 pontos!");
                label10.Text = placarUser.ToString();
            }
            else if (somaJogador > somaPc)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                label10.Text = placarUser.ToString();
            }
            else
            {
                MessageBox.Show("Você perdeu!");
                label9.Text = placarPc.ToString();
            }
            if (placarPc == 5)
            {
                MessageBox.Show("Você perdeu na melhor de 5!");
                label9.Text = "";
                label10.Text = "";
            }
            if (placarUser == 5)
            {
                MessageBox.Show("Você ganhou na melhor de 5!");
                label9.Text = "";
                label10.Text = "";
            }
        }
    }
}

