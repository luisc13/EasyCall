namespace EasyCall
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tParaLigacao = new System.Windows.Forms.Timer(this.components);
            this.btnDesligar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDevedor = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbContrato = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbJurosdia = new System.Windows.Forms.TextBox();
            this.txbDias = new System.Windows.Forms.TextBox();
            this.txbCondicao = new System.Windows.Forms.TextBox();
            this.txbParcelas = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone";
            // 
            // tParaLigacao
            // 
            this.tParaLigacao.Interval = 1000;
            this.tParaLigacao.Tick += new System.EventHandler(this.tParaLigacao_Tick);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(714, 368);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(102, 45);
            this.btnDesligar.TabIndex = 16;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Parcelas em Atraso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Juros Dia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Condição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dias Atraso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Número do contrato";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(451, 28);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(159, 20);
            this.txbCpf.TabIndex = 17;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(235, 28);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(159, 20);
            this.txbEmail.TabIndex = 18;
            // 
            // txbDevedor
            // 
            this.txbDevedor.Location = new System.Drawing.Point(6, 28);
            this.txbDevedor.Name = "txbDevedor";
            this.txbDevedor.ReadOnly = true;
            this.txbDevedor.Size = new System.Drawing.Size(159, 20);
            this.txbDevedor.TabIndex = 19;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(646, 28);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.ReadOnly = true;
            this.txbTelefone.Size = new System.Drawing.Size(159, 20);
            this.txbTelefone.TabIndex = 20;
            // 
            // txbContrato
            // 
            this.txbContrato.Location = new System.Drawing.Point(6, 100);
            this.txbContrato.Name = "txbContrato";
            this.txbContrato.ReadOnly = true;
            this.txbContrato.Size = new System.Drawing.Size(159, 20);
            this.txbContrato.TabIndex = 21;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(6, 141);
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(159, 20);
            this.txbValor.TabIndex = 22;
            // 
            // txbJurosdia
            // 
            this.txbJurosdia.Location = new System.Drawing.Point(6, 228);
            this.txbJurosdia.Name = "txbJurosdia";
            this.txbJurosdia.ReadOnly = true;
            this.txbJurosdia.Size = new System.Drawing.Size(159, 20);
            this.txbJurosdia.TabIndex = 23;
            // 
            // txbDias
            // 
            this.txbDias.Location = new System.Drawing.Point(6, 183);
            this.txbDias.Name = "txbDias";
            this.txbDias.ReadOnly = true;
            this.txbDias.Size = new System.Drawing.Size(159, 20);
            this.txbDias.TabIndex = 24;
            // 
            // txbCondicao
            // 
            this.txbCondicao.Location = new System.Drawing.Point(7, 357);
            this.txbCondicao.Name = "txbCondicao";
            this.txbCondicao.ReadOnly = true;
            this.txbCondicao.Size = new System.Drawing.Size(159, 20);
            this.txbCondicao.TabIndex = 25;
            // 
            // txbParcelas
            // 
            this.txbParcelas.Location = new System.Drawing.Point(6, 270);
            this.txbParcelas.Name = "txbParcelas";
            this.txbParcelas.ReadOnly = true;
            this.txbParcelas.Size = new System.Drawing.Size(159, 20);
            this.txbParcelas.TabIndex = 26;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(7, 315);
            this.txbData.Name = "txbData";
            this.txbData.ReadOnly = true;
            this.txbData.Size = new System.Drawing.Size(159, 20);
            this.txbData.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(817, 425);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbParcelas);
            this.Controls.Add(this.txbCondicao);
            this.Controls.Add(this.txbDias);
            this.Controls.Add(this.txbJurosdia);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbContrato);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbDevedor);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tParaLigacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDevedor;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbContrato;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbJurosdia;
        private System.Windows.Forms.TextBox txbDias;
        private System.Windows.Forms.TextBox txbCondicao;
        private System.Windows.Forms.TextBox txbParcelas;
        private System.Windows.Forms.TextBox txbData;
    }
}