namespace EasyCall
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label4 = new System.Windows.Forms.Label();
            this.lbBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnGerarR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(311, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 49);
            this.label4.TabIndex = 9;
            this.label4.Text = "ADM";
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBemVindo.AutoSize = true;
            this.lbBemVindo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbBemVindo.Font = new System.Drawing.Font("MV Boli", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.lbBemVindo.Location = new System.Drawing.Point(265, 0);
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(203, 46);
            this.lbBemVindo.TabIndex = 8;
            this.lbBemVindo.Text = "Bem Vindo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbBemVindo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 130);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(130, 58);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.FlatAppearance.BorderSize = 0;
            this.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnArquivo.Image")));
            this.btnArquivo.Location = new System.Drawing.Point(436, 130);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(174, 58);
            this.btnArquivo.TabIndex = 12;
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnGerarR
            // 
            this.btnGerarR.FlatAppearance.BorderSize = 0;
            this.btnGerarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarR.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarR.Image")));
            this.btnGerarR.Location = new System.Drawing.Point(204, 130);
            this.btnGerarR.Name = "btnGerarR";
            this.btnGerarR.Size = new System.Drawing.Size(179, 58);
            this.btnGerarR.TabIndex = 13;
            this.btnGerarR.UseVisualStyleBackColor = true;
            this.btnGerarR.Click += new System.EventHandler(this.btnGerarR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGerarR);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnGerarR;
        private System.Windows.Forms.Button button1;
    }
}