using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSupermercado
{
    public partial class FrmInicio : Form
    {
        public string cpfPrincipal { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x - cima esquerda
                int nTopRect, // y - cima esquerda
                int nRightRect, // x - baixo direita
                int nBottomRect, // y - baixo esquerda
                int nWidthEllipse, // largura da ellipse
                int nHeightEllipse // altura da ellipse
            );

        public FrmInicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.txtCpf.Mask = "000.000.000-99";
            string nome = txtCpf.Text;
            
        }

        public void Transferir(string cpf)
        {
            FrmCadastroProdutos frmCad = new FrmCadastroProdutos(cpf);
            frmCad.cpf = txtCpf.Text;
            //frmCad.cpf = txtCpf.Text;
            this.Hide();
            frmCad.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string nome = txtCpf.Text;
            txtCpf.Mask = "009.009.009-09";
            txtCpf.Culture = System.Globalization.CultureInfo.InvariantCulture;
            txtCpf.Text = cpfPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if (rdbSim.Checked)
            //{
            //    txtCpf.Visible = true;
            //    if(txtCpf.Text.Length > 4)
            //    {
            //        var frmCad = new FrmCadastroProdutos();
            //        this.Hide();
            //        frmCad.Show();
            //    }
            //}
            //else if (rdbNao.Checked)
            //{
            //    var frmCad = new FrmCadastroProdutos();
            //    this.Hide();
            //    frmCad.Show();
            //}


        }

        bool ValidaCPF()
        {
            if (txtCpf.Text.Length == 14)
            {
                int n1 = Convert.ToInt16(txtCpf.Text.Substring(0, 1));
                int n2 = Convert.ToInt16(txtCpf.Text.Substring(1, 1));
                int n3 = Convert.ToInt16(txtCpf.Text.Substring(2, 1));
                int n4 = Convert.ToInt16(txtCpf.Text.Substring(4, 1));
                int n5 = Convert.ToInt16(txtCpf.Text.Substring(5, 1));
                int n6 = Convert.ToInt16(txtCpf.Text.Substring(6, 1));
                int n7 = Convert.ToInt16(txtCpf.Text.Substring(8, 1));
                int n8 = Convert.ToInt16(txtCpf.Text.Substring(9, 1));
                int n9 = Convert.ToInt16(txtCpf.Text.Substring(10, 1));
                int n10 = Convert.ToInt16(txtCpf.Text.Substring(12, 1));
                int n11 = Convert.ToInt16(txtCpf.Text.Substring(13, 1));

                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }

                int soma = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                int digitoVerificador1 = soma % 11;

                if (digitoVerificador1 < 2)
                {
                    digitoVerificador1 = 0;
                }
                else
                {
                    digitoVerificador1 = 11 - digitoVerificador1;
                }

                int soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                int digitoVerificador2 = soma2 % 11;

                if (digitoVerificador2 < 2)
                {
                    digitoVerificador2 = 0;
                }
                else
                {
                    digitoVerificador2 = 11 - digitoVerificador2;
                }

                if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                txtCpf.Visible = true;
                txtCpf.Text = cpfPrincipal;
            }
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
            {
                txtCpf.Visible = false;
            }
        }

        private void botaoCircular2_Click(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                if (ValidaCPF() == true)
                {
                    Transferir(txtCpf.Text);
                    txtCpf.Text = cpfPrincipal;
                }
                else
                {
                    txtCpf.Text = cpfPrincipal;
                    MessageBox.Show("CPF Inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                    txtCpf.Text = cpfPrincipal;
                Transferir(txtCpf.Text);
            }
        }
    }
}
