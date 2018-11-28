namespace Fundamentos
{
    partial class Form16Funciones
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
            this.btnLlamarMetodo = new System.Windows.Forms.Button();
            this.lblRestultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLlamarMetodo
            // 
            this.btnLlamarMetodo.Location = new System.Drawing.Point(49, 30);
            this.btnLlamarMetodo.Name = "btnLlamarMetodo";
            this.btnLlamarMetodo.Size = new System.Drawing.Size(131, 49);
            this.btnLlamarMetodo.TabIndex = 0;
            this.btnLlamarMetodo.Text = "llamar Metodo";
            this.btnLlamarMetodo.UseVisualStyleBackColor = true;
            this.btnLlamarMetodo.Click += new System.EventHandler(this.btnLlamarMetodo_Click);
            // 
            // lblRestultado
            // 
            this.lblRestultado.AutoSize = true;
            this.lblRestultado.Location = new System.Drawing.Point(46, 108);
            this.lblRestultado.Name = "lblRestultado";
            this.lblRestultado.Size = new System.Drawing.Size(35, 13);
            this.lblRestultado.TabIndex = 1;
            this.lblRestultado.Text = "label1";
            // 
            // Form16Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.lblRestultado);
            this.Controls.Add(this.btnLlamarMetodo);
            this.Name = "Form16Funciones";
            this.Text = "Form16Funciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarMetodo;
        private System.Windows.Forms.Label lblRestultado;
    }
}