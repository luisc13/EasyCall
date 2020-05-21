namespace EasyCall
{
    partial class FormRelatorio
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
            this.listRelatorio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listRelatorio
            // 
            this.listRelatorio.FormattingEnabled = true;
            this.listRelatorio.Location = new System.Drawing.Point(0, -2);
            this.listRelatorio.Name = "listRelatorio";
            this.listRelatorio.Size = new System.Drawing.Size(806, 420);
            this.listRelatorio.TabIndex = 0;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listRelatorio);
            this.Name = "FormRelatorio";
            this.Text = "Rlatorio - visualizar";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRelatorio;
    }
}