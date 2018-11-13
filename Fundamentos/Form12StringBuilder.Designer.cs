namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(282, 416);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(333, 24);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(175, 91);
            this.btnString.TabIndex = 1;
            this.btnString.Text = "Invertir String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(333, 144);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(175, 91);
            this.btnStringBuilder.TabIndex = 2;
            this.btnStringBuilder.Text = "Invertir StringBuilder";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(330, 358);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "label1";
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnStringBuilder);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StreamBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Label lblTiempo;
    }
}