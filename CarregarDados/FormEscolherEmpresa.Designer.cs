namespace EasyCall.CarregarDados
{
    partial class FormEscolherEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpresas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quer carregar dados de qual empresa ?";
            // 
            // lbEmpresas
            // 
            this.lbEmpresas.FormattingEnabled = true;
            this.lbEmpresas.Location = new System.Drawing.Point(45, 62);
            this.lbEmpresas.Name = "lbEmpresas";
            this.lbEmpresas.Size = new System.Drawing.Size(317, 160);
            this.lbEmpresas.TabIndex = 1;
            this.lbEmpresas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbEmpresas_MouseDoubleClick);
            // 
            // FormEscolherEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 284);
            this.Controls.Add(this.lbEmpresas);
            this.Controls.Add(this.label1);
            this.Name = "FormEscolherEmpresa";
            this.Text = "EscolherEmpresa";
            this.Load += new System.EventHandler(this.FormEscolherEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbEmpresas;
    }
}