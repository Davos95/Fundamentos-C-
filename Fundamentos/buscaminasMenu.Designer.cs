namespace Fundamentos
{
    partial class buscaminasMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.txtMinas = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Minas";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(104, 27);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 20);
            this.txtTamanio.TabIndex = 2;
            this.txtTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanio_KeyPress);
            // 
            // txtMinas
            // 
            this.txtMinas.Location = new System.Drawing.Point(104, 72);
            this.txtMinas.Name = "txtMinas";
            this.txtMinas.Size = new System.Drawing.Size(100, 20);
            this.txtMinas.TabIndex = 3;
            this.txtMinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinas_KeyPress);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(104, 127);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(100, 23);
            this.btnEmpezar.TabIndex = 4;
            this.btnEmpezar.Text = "Empezar!";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // buscaminasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 183);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.txtMinas);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buscaminasMenu";
            this.Text = "buscaminasMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.TextBox txtMinas;
        private System.Windows.Forms.Button btnEmpezar;
    }
}