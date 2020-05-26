namespace EasyCall.Relatorio
{
    partial class FormOptions
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
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(195, 23);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.cbBuscarPor.TabIndex = 1;
            this.cbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPor_SelectedIndexChanged);
            // 
            // listOptions
            // 
            this.listOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOptions.FormattingEnabled = true;
            this.listOptions.ItemHeight = 20;
            this.listOptions.Location = new System.Drawing.Point(12, 73);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(776, 344);
            this.listOptions.TabIndex = 2;
            this.listOptions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOptions_MouseDoubleClick);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOptions);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.label1);
            this.Name = "FormOptions";
            this.Text = "Opções de relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.ListBox listOptions;
    }
}