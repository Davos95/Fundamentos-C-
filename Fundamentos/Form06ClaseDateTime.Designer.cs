namespace Fundamentos
{
    partial class Form06ClaseDateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.incremento = new System.Windows.Forms.GroupBox();
            this.rdbAnio = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.txtFechaResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.chbCambiarFormato = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnRestar = new System.Windows.Forms.Button();
            this.incremento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(57, 55);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(189, 20);
            this.txtFechaActual.TabIndex = 1;
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Location = new System.Drawing.Point(6, 22);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(41, 17);
            this.rdbDia.TabIndex = 2;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Dia";
            this.rdbDia.UseVisualStyleBackColor = true;
            // 
            // incremento
            // 
            this.incremento.Controls.Add(this.rdbAnio);
            this.incremento.Controls.Add(this.rdbMes);
            this.incremento.Controls.Add(this.rdbDia);
            this.incremento.Location = new System.Drawing.Point(57, 134);
            this.incremento.Name = "incremento";
            this.incremento.Size = new System.Drawing.Size(105, 130);
            this.incremento.TabIndex = 4;
            this.incremento.TabStop = false;
            this.incremento.Text = "Incremento";
            // 
            // rdbAnio
            // 
            this.rdbAnio.AutoSize = true;
            this.rdbAnio.Location = new System.Drawing.Point(6, 88);
            this.rdbAnio.Name = "rdbAnio";
            this.rdbAnio.Size = new System.Drawing.Size(44, 17);
            this.rdbAnio.TabIndex = 4;
            this.rdbAnio.TabStop = true;
            this.rdbAnio.Text = "Año";
            this.rdbAnio.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(6, 57);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(45, 17);
            this.rdbMes.TabIndex = 3;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Mes";
            this.rdbMes.UseVisualStyleBackColor = true;
            // 
            // txtFechaResultado
            // 
            this.txtFechaResultado.Location = new System.Drawing.Point(57, 322);
            this.txtFechaResultado.Name = "txtFechaResultado";
            this.txtFechaResultado.Size = new System.Drawing.Size(189, 20);
            this.txtFechaResultado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha resultado";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(212, 156);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(89, 20);
            this.txtIncremento.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Incremento";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(212, 191);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(89, 23);
            this.btnIncrementar.TabIndex = 9;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // chbCambiarFormato
            // 
            this.chbCambiarFormato.AutoSize = true;
            this.chbCambiarFormato.Location = new System.Drawing.Point(82, 98);
            this.chbCambiarFormato.Name = "chbCambiarFormato";
            this.chbCambiarFormato.Size = new System.Drawing.Size(105, 17);
            this.chbCambiarFormato.TabIndex = 10;
            this.chbCambiarFormato.Text = "Cambiar Formato";
            this.chbCambiarFormato.UseVisualStyleBackColor = true;
            this.chbCambiarFormato.CheckedChanged += new System.EventHandler(this.chbCambiarFormato_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(348, 134);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(45, 20);
            this.txtDia.TabIndex = 13;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(348, 194);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(45, 20);
            this.txtHora.TabIndex = 14;
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(348, 241);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.TabIndex = 15;
            this.btnRestar.Text = "Diferencia";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form06Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 376);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbCambiarFormato);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.incremento);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Name = "Form06Fechas";
            this.Text = "Form05Fechas";
            this.Load += new System.EventHandler(this.Form06Fechas_Load);
            this.incremento.ResumeLayout(false);
            this.incremento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.GroupBox incremento;
        private System.Windows.Forms.RadioButton rdbAnio;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.TextBox txtFechaResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.CheckBox chbCambiarFormato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnRestar;
    }
}