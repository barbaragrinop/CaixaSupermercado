using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CaixaSupermercado
{
    public partial class FrmPagamento : Form
    {
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
        public float calcTotal { get; set; }
        public string cpfCliente { get; set; }
        public FrmPagamento()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public FrmPagamento(float calc)
        {
            InitializeComponent();
            lbltt.Text = calc.ToString("N2");
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            if (!this.calcTotal.Equals(""))
            {
                lbltt.Text = this.calcTotal.ToString("N2");
            }

           
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalcTroco_Click(object sender, EventArgs e)
        {
            float tt, entrada;
            entrada = float.Parse(txtEntrada.Text);
            tt = entrada - calcTotal  ;
            if(tt <= 0)
            {
                MessageBox.Show($"Valor insuficiente. Faltam R${tt}");
            } else
            {
                MessageBox.Show($"Total da Compra: {calcTotal}\nValor pago: {entrada}\nTroco: {tt}", "Resultado", MessageBoxButtons.OK);
                FrmInicio inicio = new FrmInicio();
                this.Dispose();
                inicio.Show();
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            { 
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlTroco.Visible = true;
            btnDebito.Enabled = false;
            btnCredito.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cartão de Débito\nTotal da Compra: {calcTotal}", "Resultado", MessageBoxButtons.OK);
            FrmInicio inicio = new FrmInicio();
            this.Dispose();
            inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cartão de Crédito \nTotal da Compra: {calcTotal}", "Resultado", MessageBoxButtons.OK);
            //Process.Start(Application.ExecutablePath, "/restart" + Process.GetCurrentProcess().Id);
            FrmInicio inicio = new FrmInicio();
            this.Dispose();
            inicio.Show();
            //Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            pnlTroco.Visible = false;
            btnCredito.Enabled = true;
            btnDebito.Enabled = true;
        }

        private void botaoCircular1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            FrmCadastroProdutos frcad = new FrmCadastroProdutos();
            this.Hide();
            frcad.Show();
        }
    }
}
