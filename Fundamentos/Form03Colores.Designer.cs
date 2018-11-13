namespace Fundamentos
{
    partial class Form03Colores
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
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rojo";
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(91, 54);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 20);
            this.txtRojo.TabIndex = 1;
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(91, 91);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 20);
            this.txtVerde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verde";
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(91, 129);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 20);
            this.txtAzul.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Azul";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(228, 54);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(166, 95);
            this.btnCambiar.TabIndex = 6;
            this.btnCambiar.Text = "Cambiar color del fondo";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Form03Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 225);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.label1);
            this.Name = "Form03Colores";
            this.Text = "Form03Colorescs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiar;
    }
}