
namespace CaixaSupermercado
{
    partial class FrmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProdutos));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.carrinho = new System.Windows.Forms.ListBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlConf = new System.Windows.Forms.Panel();
            this.btnFechaPnl = new System.Windows.Forms.Button();
            this.btnValidaPnl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaPnl = new System.Windows.Forms.TextBox();
            this.btnRemoveOk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.botaoCircular1 = new CaixaSupermercado.BotaoCircular();
            this.pnlConf.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(622, 500);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(194, 35);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "FINALIZAR COMPRA";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtQt.Location = new System.Drawing.Point(49, 297);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(131, 32);
            this.txtQt.TabIndex = 5;
            this.txtQt.TextChanged += new System.EventHandler(this.txtQt_TextChanged);
            this.txtQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtCodigo.Location = new System.Drawing.Point(49, 230);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(303, 32);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtDs
            // 
            this.txtDs.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtDs.Location = new System.Drawing.Point(49, 163);
            this.txtDs.Name = "txtDs";
            this.txtDs.Size = new System.Drawing.Size(303, 32);
            this.txtDs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código de Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição do Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço Unitário";
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.Color.Orange;
            this.btnAddProd.Location = new System.Drawing.Point(49, 373);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(303, 39);
            this.btnAddProd.TabIndex = 16;
            this.btnAddProd.Text = "ADICIONAR MAIS ITEMS";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtValor.Location = new System.Drawing.Point(248, 300);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(104, 32);
            this.txtValor.TabIndex = 17;
            this.txtValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtValor_MaskInputRejected);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // carrinho
            // 
            this.carrinho.FormattingEnabled = true;
            this.carrinho.Location = new System.Drawing.Point(543, 141);
            this.carrinho.Name = "carrinho";
            this.carrinho.Size = new System.Drawing.Size(273, 277);
            this.carrinho.TabIndex = 18;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lblSub.Location = new System.Drawing.Point(651, 95);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 28);
            this.lblSub.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(538, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subtotal: R$";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(543, 433);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(273, 39);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "REMOVER ITEMS";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlConf
            // 
            this.pnlConf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConf.Controls.Add(this.btnFechaPnl);
            this.pnlConf.Controls.Add(this.btnValidaPnl);
            this.pnlConf.Controls.Add(this.label6);
            this.pnlConf.Controls.Add(this.txtSenhaPnl);
            this.pnlConf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlConf.Location = new System.Drawing.Point(258, 95);
            this.pnlConf.Name = "pnlConf";
            this.pnlConf.Size = new System.Drawing.Size(356, 196);
            this.pnlConf.TabIndex = 23;
            this.pnlConf.Visible = false;
            this.pnlConf.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConf_Paint);
            // 
            // btnFechaPnl
            // 
            this.btnFechaPnl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFechaPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaPnl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaPnl.ForeColor = System.Drawing.Color.Black;
            this.btnFechaPnl.Location = new System.Drawing.Point(314, 8);
            this.btnFechaPnl.Name = "btnFechaPnl";
            this.btnFechaPnl.Size = new System.Drawing.Size(28, 32);
            this.btnFechaPnl.TabIndex = 25;
            this.btnFechaPnl.Text = "x";
            this.btnFechaPnl.UseVisualStyleBackColor = false;
            this.btnFechaPnl.Click += new System.EventHandler(this.btnFechaPnl_Click);
            // 
            // btnValidaPnl
            // 
            this.btnValidaPnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValidaPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidaPnl.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidaPnl.ForeColor = System.Drawing.Color.Black;
            this.btnValidaPnl.Location = new System.Drawing.Point(121, 122);
            this.btnValidaPnl.Name = "btnValidaPnl";
            this.btnValidaPnl.Size = new System.Drawing.Size(105, 35);
            this.btnValidaPnl.TabIndex = 24;
            this.btnValidaPnl.Text = "VALIDAR";
            this.btnValidaPnl.UseVisualStyleBackColor = false;
            this.btnValidaPnl.Click += new System.EventHandler(this.btnValidaPnl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "SENHA DO GERENTE";
            // 
            // txtSenhaPnl
            // 
            this.txtSenhaPnl.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtSenhaPnl.Location = new System.Drawing.Point(98, 71);
            this.txtSenhaPnl.Name = "txtSenhaPnl";
            this.txtSenhaPnl.Size = new System.Drawing.Size(158, 32);
            this.txtSenhaPnl.TabIndex = 0;
            // 
            // btnRemoveOk
            // 
            this.btnRemoveOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOk.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOk.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemoveOk.Location = new System.Drawing.Point(543, 433);
            this.btnRemoveOk.Name = "btnRemoveOk";
            this.btnRemoveOk.Size = new System.Drawing.Size(273, 39);
            this.btnRemoveOk.TabIndex = 24;
            this.btnRemoveOk.Text = "REMOVE ITEM";
            this.btnRemoveOk.UseVisualStyleBackColor = false;
            this.btnRemoveOk.Visible = false;
            this.btnRemoveOk.Click += new System.EventHandler(this.btnRemoveOk_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label8.Location = new System.Drawing.Point(216, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "R$";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.botaoCircular1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 53);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(661, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "ENCERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(47, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "   Cadastro de Produtos     ";
            // 
            // botaoCircular1
            // 
            this.botaoCircular1.BackColor = System.Drawing.Color.Silver;
            this.botaoCircular1.FlatAppearance.BorderSize = 0;
            this.botaoCircular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCircular1.Image = ((System.Drawing.Image)(resources.GetObject("botaoCircular1.Image")));
            this.botaoCircular1.Location = new System.Drawing.Point(11, 6);
            this.botaoCircular1.Name = "botaoCircular1";
            this.botaoCircular1.Size = new System.Drawing.Size(40, 40);
            this.botaoCircular1.TabIndex = 30;
            this.botaoCircular1.UseVisualStyleBackColor = false;
            // 
            // FrmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlConf);
            this.Controls.Add(this.btnRemoveOk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.carrinho);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDs);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroProdutos";
            this.Load += new System.EventHandler(this.FrmCadastroProdutos_Load);
            this.pnlConf.ResumeLayout(false);
            this.pnlConf.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.ListBox carrinho;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlConf;
        private System.Windows.Forms.Button btnFechaPnl;
        private System.Windows.Forms.Button btnValidaPnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaPnl;
        private System.Windows.Forms.Button btnRemoveOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private BotaoCircular botaoCircular1;
        private System.Windows.Forms.Label label9;
    }
}