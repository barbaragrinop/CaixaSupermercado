
namespace CaixaSupermercado
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoCircular1 = new CaixaSupermercado.BotaoCircular();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoCircular2 = new CaixaSupermercado.BotaoCircular();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.rdbSim.Location = new System.Drawing.Point(354, 209);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(59, 29);
            this.rdbSim.TabIndex = 3;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota Fiscal Paulista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.rdbNao.Location = new System.Drawing.Point(419, 209);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(62, 29);
            this.rdbNao.TabIndex = 5;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtCpf.Location = new System.Drawing.Point(284, 279);
            this.txtCpf.Mask = "000\\.000\\.000-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(272, 32);
            this.txtCpf.TabIndex = 7;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.botaoCircular1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-7, -1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(47, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "   Sistema de Caixa     ";
            // 
            // botaoCircular2
            // 
            this.botaoCircular2.BackColor = System.Drawing.Color.Silver;
            this.botaoCircular2.FlatAppearance.BorderSize = 0;
            this.botaoCircular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCircular2.Image = global::CaixaSupermercado.Properties.Resources.next_right_52px;
            this.botaoCircular2.Location = new System.Drawing.Point(772, 480);
            this.botaoCircular2.Name = "botaoCircular2";
            this.botaoCircular2.Size = new System.Drawing.Size(53, 55);
            this.botaoCircular2.TabIndex = 31;
            this.botaoCircular2.UseVisualStyleBackColor = false;
            this.botaoCircular2.Click += new System.EventHandler(this.botaoCircular2_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(848, 547);
            this.Controls.Add(this.botaoCircular2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private BotaoCircular botaoCircular1;
        private System.Windows.Forms.Label label3;
        private BotaoCircular botaoCircular2;
    }
}

