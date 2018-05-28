using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt_jogo
{
    public partial class Form1 : Form
    {
        int vitorias = 0;
        int derrotas = 0;
        int empates = 0;
        int cont = 2;

        public Form1()
        {
            InitializeComponent();
        }

        public void pedraVisible(Boolean x) {
            pb_tesoura1.Visible = x;
            pb_papel1.Visible   = x;
            rb_pedra.Visible    = x;
            rb_tesoura.Visible  = x;
            rb_papel.Visible    = x;
        }

        public void tesouraVisible(Boolean x)
        {
            pb_pedra1.Visible = x;
            pb_papel1.Visible = x;
            rb_pedra.Visible = x;
            rb_tesoura.Visible = x;
            rb_papel.Visible = x;
        }

        public void papelVisible(Boolean x)
        {
            pb_tesoura1.Visible = x;
            pb_pedra1.Visible = x;
            rb_pedra.Visible = x;
            rb_tesoura.Visible = x;
            rb_papel.Visible = x;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(cont%2 == 0)
            {
                if (rb_pedra.Checked)
                {
                    pedraVisible(false);
                }
                else if (rb_tesoura.Checked)
                {
                    tesouraVisible(false);
                }
                if (rb_papel.Checked)
                {
                    papelVisible(false);
                }

                Random rdm = new Random();
                int numero = rdm.Next(1, 4);

                if (numero == 1)
                {
                    pb_pedra2.Visible = true;
                }
                else if (numero == 2)
                {
                    pb_tesoura2.Visible = true;
                }
                else if (numero == 3)
                {
                    pb_papel2.Visible = true;
                }

                if (pb_pedra1.Visible == true && pb_pedra2.Visible == true)
                {
                    lb_resultado.Text = "Empate";
                    empates += 1;
                }
                else if (pb_tesoura1.Visible == true && pb_tesoura2.Visible == true)
                {
                    lb_resultado.Text = "Empate";
                    empates += 1;
                }
                else if (pb_papel1.Visible == true && pb_papel2.Visible == true)
                {
                    lb_resultado.Text = "Empate";
                    empates += 1;
                }
                else if (pb_pedra1.Visible == true && pb_tesoura2.Visible == true)
                {
                    lb_resultado.Text = "Venceu";
                    vitorias += 1;
                }
                else if (pb_pedra1.Visible == true && pb_papel2.Visible == true)
                {
                    lb_resultado.Text = "Perdeu";
                    derrotas += 1;
                }
                else if (pb_tesoura1.Visible == true && pb_pedra2.Visible == true)
                {
                    lb_resultado.Text = "Perdeu";
                    derrotas += 1;
                }
                else if (pb_tesoura1.Visible == true && pb_papel2.Visible == true)
                {
                    lb_resultado.Text = "Venceu";
                    vitorias += 1;
                }
                else if (pb_papel1.Visible == true && pb_pedra2.Visible == true)
                {
                    lb_resultado.Text = "Venceu";
                    vitorias += 1;
                }
                else if (pb_papel1.Visible == true && pb_tesoura2.Visible == true)
                {
                    lb_resultado.Text = "Perdeu";
                    derrotas += 1;
                }
                lb_vitorias.Text = vitorias.ToString();
                lb_derrotas.Text = derrotas.ToString();
                lb_empates.Text = empates.ToString();

                button1.Text = "Jogar novamente";
            }
            else if(cont%2 != 0)
            {
                pedraVisible(true);
                tesouraVisible(true);
                papelVisible(true);

                pb_pedra2.Visible = false;
                pb_tesoura2.Visible = false;
                pb_papel2.Visible = false;

                button1.Text = "Jogar";
                lb_resultado.Text = " ";
            }
            cont++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

