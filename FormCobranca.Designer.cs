﻿namespace EasyCall
{
    partial class FormCobranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCobranca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tParaLigacao = new System.Windows.Forms.Timer(this.components);
            this.btnDesligar = new System.Windows.Forms.Button();
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
            this.txbData = new System.Windows.Forms.TextBox();
            this.onLigacao = new System.Windows.Forms.Timer(this.components);
            this.btnBoleto = new System.Windows.Forms.Button();
            this.txbValorInicial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbEmpresa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txbComissãoTotalMes = new System.Windows.Forms.TextBox();
            this.txbComissao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOcr = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gdvDevedor = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbOcr = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDevedor)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 136);
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
            this.btnDesligar.FlatAppearance.BorderSize = 0;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesligar.Image")));
            this.btnDesligar.Location = new System.Drawing.Point(234, 489);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(147, 45);
            this.btnDesligar.TabIndex = 16;
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Juros Dia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Condição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dias Atraso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor Atual";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Número do contrato";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(6, 113);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(159, 20);
            this.txbCpf.TabIndex = 17;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(6, 71);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(159, 20);
            this.txbEmail.TabIndex = 18;
            // 
            // txbDevedor
            // 
            this.txbDevedor.Location = new System.Drawing.Point(6, 29);
            this.txbDevedor.Name = "txbDevedor";
            this.txbDevedor.ReadOnly = true;
            this.txbDevedor.Size = new System.Drawing.Size(159, 20);
            this.txbDevedor.TabIndex = 19;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(6, 155);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.ReadOnly = true;
            this.txbTelefone.Size = new System.Drawing.Size(159, 20);
            this.txbTelefone.TabIndex = 20;
            // 
            // txbContrato
            // 
            this.txbContrato.Location = new System.Drawing.Point(6, 29);
            this.txbContrato.Name = "txbContrato";
            this.txbContrato.ReadOnly = true;
            this.txbContrato.Size = new System.Drawing.Size(159, 20);
            this.txbContrato.TabIndex = 21;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(183, 81);
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(159, 20);
            this.txbValor.TabIndex = 22;
            // 
            // txbJurosdia
            // 
            this.txbJurosdia.Location = new System.Drawing.Point(182, 136);
            this.txbJurosdia.Name = "txbJurosdia";
            this.txbJurosdia.ReadOnly = true;
            this.txbJurosdia.Size = new System.Drawing.Size(159, 20);
            this.txbJurosdia.TabIndex = 23;
            // 
            // txbDias
            // 
            this.txbDias.Location = new System.Drawing.Point(5, 136);
            this.txbDias.Name = "txbDias";
            this.txbDias.ReadOnly = true;
            this.txbDias.Size = new System.Drawing.Size(159, 20);
            this.txbDias.TabIndex = 24;
            // 
            // txbCondicao
            // 
            this.txbCondicao.Location = new System.Drawing.Point(183, 188);
            this.txbCondicao.Name = "txbCondicao";
            this.txbCondicao.ReadOnly = true;
            this.txbCondicao.Size = new System.Drawing.Size(159, 20);
            this.txbCondicao.TabIndex = 25;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(7, 188);
            this.txbData.Name = "txbData";
            this.txbData.ReadOnly = true;
            this.txbData.Size = new System.Drawing.Size(159, 20);
            this.txbData.TabIndex = 27;
            // 
            // onLigacao
            // 
            this.onLigacao.Interval = 1000;
            this.onLigacao.Tick += new System.EventHandler(this.onLigacao_Tick);
            // 
            // btnBoleto
            // 
            this.btnBoleto.BackColor = System.Drawing.Color.Lime;
            this.btnBoleto.FlatAppearance.BorderSize = 0;
            this.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoleto.Image")));
            this.btnBoleto.Location = new System.Drawing.Point(12, 489);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(189, 45);
            this.btnBoleto.TabIndex = 28;
            this.btnBoleto.TabStop = false;
            this.btnBoleto.UseVisualStyleBackColor = false;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // txbValorInicial
            // 
            this.txbValorInicial.Location = new System.Drawing.Point(6, 81);
            this.txbValorInicial.Name = "txbValorInicial";
            this.txbValorInicial.ReadOnly = true;
            this.txbValorInicial.Size = new System.Drawing.Size(159, 20);
            this.txbValorInicial.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Valor Inicial";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Empresa:";
            // 
            // txbEmpresa
            // 
            this.txbEmpresa.Location = new System.Drawing.Point(183, 29);
            this.txbEmpresa.Name = "txbEmpresa";
            this.txbEmpresa.ReadOnly = true;
            this.txbEmpresa.Size = new System.Drawing.Size(159, 20);
            this.txbEmpresa.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbDevedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbCpf);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbTelefone);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 185);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txbEmpresa);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txbContrato);
            this.panel2.Controls.Add(this.txbCondicao);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbValor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbData);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbJurosdia);
            this.panel2.Controls.Add(this.txbDias);
            this.panel2.Controls.Add(this.txbValorInicial);
            this.panel2.Location = new System.Drawing.Point(201, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 247);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chartreuse;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txbComissãoTotalMes);
            this.panel3.Controls.Add(this.txbComissao);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(12, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 100);
            this.panel3.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 16);
            this.label19.TabIndex = 23;
            this.label19.Text = "Comissão total no mês";
            // 
            // txbComissãoTotalMes
            // 
            this.txbComissãoTotalMes.Location = new System.Drawing.Point(3, 77);
            this.txbComissãoTotalMes.Name = "txbComissãoTotalMes";
            this.txbComissãoTotalMes.ReadOnly = true;
            this.txbComissãoTotalMes.Size = new System.Drawing.Size(159, 20);
            this.txbComissãoTotalMes.TabIndex = 22;
            // 
            // txbComissao
            // 
            this.txbComissao.Location = new System.Drawing.Point(3, 28);
            this.txbComissao.Name = "txbComissao";
            this.txbComissao.ReadOnly = true;
            this.txbComissao.Size = new System.Drawing.Size(159, 20);
            this.txbComissao.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Comissão";
            // 
            // btnOcr
            // 
            this.btnOcr.FlatAppearance.BorderSize = 0;
            this.btnOcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcr.Image = ((System.Drawing.Image)(resources.GetObject("btnOcr.Image")));
            this.btnOcr.Location = new System.Drawing.Point(414, 489);
            this.btnOcr.Name = "btnOcr";
            this.btnOcr.Size = new System.Drawing.Size(147, 45);
            this.btnOcr.TabIndex = 37;
            this.btnOcr.UseVisualStyleBackColor = true;
            this.btnOcr.Click += new System.EventHandler(this.btnOcr_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.gdvDevedor);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 132);
            this.panel4.TabIndex = 38;
            // 
            // gdvDevedor
            // 
            this.gdvDevedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDevedor.Location = new System.Drawing.Point(6, 22);
            this.gdvDevedor.Name = "gdvDevedor";
            this.gdvDevedor.ReadOnly = true;
            this.gdvDevedor.Size = new System.Drawing.Size(565, 104);
            this.gdvDevedor.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Lista de Devedores";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.lbOcr);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(610, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 352);
            this.panel5.TabIndex = 41;
            // 
            // lbOcr
            // 
            this.lbOcr.FormattingEnabled = true;
            this.lbOcr.Location = new System.Drawing.Point(6, 37);
            this.lbOcr.Name = "lbOcr";
            this.lbOcr.Size = new System.Drawing.Size(309, 290);
            this.lbOcr.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Ultimas Ocorrências";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 47;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1103, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnOcr);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBoleto);
            this.Controls.Add(this.btnDesligar);
            this.Name = "FormCobranca";
            this.Text = "Pagina Inicial - EasyCall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDevedor)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tParaLigacao;
        private System.Windows.Forms.Button btnDesligar;
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
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Timer onLigacao;
        private System.Windows.Forms.Button btnBoleto;
        private System.Windows.Forms.TextBox txbValorInicial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbComissao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOcr;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbComissãoTotalMes;
        private System.Windows.Forms.DataGridView gdvDevedor;
        private System.Windows.Forms.ListBox lbOcr;
        private System.Windows.Forms.Button button1;
    }
}