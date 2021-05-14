
namespace CaixaSupermercado
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.lbltt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcTroco = new System.Windows.Forms.Button();
            this.pnlTroco = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.botaoCircular1 = new CaixaSupermercado.BotaoCircular();
            this.panel2.SuspendLayout();
            this.pnlTroco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOTAL DA COMPRA: R$";
            // 
            // lbltt
            // 
            this.lbltt.AutoSize = true;
            this.lbltt.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbltt.Location = new System.Drawing.Point(533, 114);
            this.lbltt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltt.Name = "lbltt";
            this.lbltt.Size = new System.Drawing.Size(28, 33);
            this.lbltt.TabIndex = 4;
            this.lbltt.Text = "s";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.botaoCircular1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-6, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 53);
            this.panel2.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(47, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "   Formas de Pagamento     ";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(122, 65);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(118, 29);
            this.txtEntrada.TabIndex = 9;
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label5.Location = new System.Drawing.Point(112, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Pago:";
            // 
            // btnCalcTroco
            // 
            this.btnCalcTroco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcTroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcTroco.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTroco.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalcTroco.Location = new System.Drawing.Point(120, 117);
            this.btnCalcTroco.Name = "btnCalcTroco";
            this.btnCalcTroco.Size = new System.Drawing.Size(181, 35);
            this.btnCalcTroco.TabIndex = 25;
            this.btnCalcTroco.Text = "CALCULAR TROCO";
            this.btnCalcTroco.UseVisualStyleBackColor = false;
            this.btnCalcTroco.Click += new System.EventHandler(this.btnCalcTroco_Click);
            // 
            // pnlTroco
            // 
            this.pnlTroco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTroco.Controls.Add(this.btnFechar);
            this.pnlTroco.Controls.Add(this.label3);
            this.pnlTroco.Controls.Add(this.txtEntrada);
            this.pnlTroco.Controls.Add(this.btnCalcTroco);
            this.pnlTroco.Controls.Add(this.label5);
            this.pnlTroco.Location = new System.Drawing.Point(283, 286);
            this.pnlTroco.Name = "pnlTroco";
            this.pnlTroco.Size = new System.Drawing.Size(323, 170);
            this.pnlTroco.TabIndex = 26;
            this.pnlTroco.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Maroon;
            this.btnFechar.Location = new System.Drawing.Point(18, 117);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 35);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label3.Location = new System.Drawing.Point(87, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "R$";
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebito.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.ForeColor = System.Drawing.Color.Black;
            this.btnDebito.Location = new System.Drawing.Point(326, 245);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(181, 35);
            this.btnDebito.TabIndex = 27;
            this.btnDebito.Text = "DÉBITO";
            this.btnDebito.UseVisualStyleBackColor = false;
            this.btnDebito.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinheiro.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.ForeColor = System.Drawing.Color.Black;
            this.btnDinheiro.Location = new System.Drawing.Point(26, 245);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(181, 35);
            this.btnDinheiro.TabIndex = 28;
            this.btnDinheiro.Text = "DINHEIRO";
            this.btnDinheiro.UseVisualStyleBackColor = false;
            this.btnDinheiro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.Black;
            this.btnCredito.Location = new System.Drawing.Point(638, 245);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(181, 35);
            this.btnCredito.TabIndex = 29;
            this.btnCredito.Text = "CRÉDITO";
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.button3_Click);
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
            this.botaoCircular1.Click += new System.EventHandler(this.botaoCircular1_Click);
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 547);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.pnlTroco);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbltt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagamento";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTroco.ResumeLayout(false);
            this.pnlTroco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcTroco;
        private System.Windows.Forms.Panel pnlTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnFechar;
        private BotaoCircular botaoCircular1;
        private System.Windows.Forms.Button button1;
    }
}