using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSupermercado
{
    public partial class FrmCadastroProdutos : Form
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
        public float subtotal1 { get; set; }
        public float calc { get; set; }
        public double  totaloutro { get; set; }
        public string cpf { get; set; }
        public FrmCadastroProdutos()
        {
            InitializeComponent(); 
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public FrmCadastroProdutos(string cpfff)
        {
            InitializeComponent();
            //lclpf.Text = cpf;
            cpf = cpfff;
        }


        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            carrinho.Enabled = false;
            btnRemove.Visible = true;
            if(carrinho.Items.Count <= 0)
            {
                btnRemove.Visible = false;
                btnRemoveOk.Visible = false;
            }

            txtSenhaPnl.PasswordChar = '*';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }      
            //return sub;
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtDs.Text;
                int codigo = int.Parse(txtCodigo.Text);
                int quant = int.Parse(txtQt.Text);
                float valor = float.Parse(txtValor.Text);
                float total = quant * valor;
                if(carrinho.Items.Count > 0)
                {
                    calc = calc + quant * valor;
                    //MessageBox.Show(calc.ToString());
                }
                else
                {
                   calc = quant * valor;
                }
                carrinho.Items.Add($"{quant} {descricao} || Código: {codigo} || Valor: R$ {total}");
                lblSub.Text = calc.ToString("N2");
                totaloutro = calc;
                btnRemove.Visible = true;
                btnRemoveOk.Visible = false;

            } catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos corretamente");
            }
            txtQt.Text = "";
            txtCodigo.Text = "";
            txtValor.Text = "";
            txtDs.Text = "";
            txtDs.Focus();
            
        }

        private void txtValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pnlConf.Visible = true;
            pnlConf.BringToFront();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnFechaPnl_Click(object sender, EventArgs e)
        {
            pnlConf.Visible = false;
        }

        private void btnValidaPnl_Click(object sender, EventArgs e)
        {
            if(txtSenhaPnl.Text == "1234"){
                carrinho.Enabled = true;
                btnRemoveOk.Visible = true;
                btnRemove.Visible = false;
                MessageBox.Show("Acesso permitido.","Ok!", MessageBoxButtons.OK);
                pnlConf.Visible = false;
                txtSenhaPnl.Text = "";
                btnAddProd.Enabled = false;
            }
            else
            {
                MessageBox.Show("Acesso Negado.","NEGADO!", MessageBoxButtons.OK);
                pnlConf.Visible = false;
            }
        }

        private void btnRemoveOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrinho.SelectedIndex != -1)
                {
                    carrinho.Enabled = true;
                    int i = carrinho.SelectedIndex;
                    string Valor = carrinho.Items[i].ToString();
                    Regex regex = new Regex("[^/\\d]+");
                    var lista = regex.Replace(Valor, " ").Split(' ').ToList();
                    double dec = calc - Convert.ToDouble(lista[lista.Count - 1]);
                    carrinho.Items.RemoveAt(carrinho.SelectedIndex);
                    totaloutro = dec;
                    lblSub.Text = dec.ToString();
                    carrinho.Enabled = false;
                    btnRemoveOk.Visible = false;
                    btnRemove.Visible = true;
                    btnAddProd.Enabled = true;
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Preencha todos os campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(carrinho.Items.Count <= 0)
            {
                MessageBox.Show("Insira ao menos 1 item no carrinho.");
            }
            else
            {
                FrmPagamento formPag = new FrmPagamento();
                formPag.calcTotal = (float)totaloutro;
                this.Hide();
                formPag.Show();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números e virgula");
            }
            
        }

        private void pnlConf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtQt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            FrmInicio frminicio = new FrmInicio();
            this.Hide();
            frminicio.Show();



            //            FrmCadastroProdutos.Content = frminicio;
        }
    }
}
