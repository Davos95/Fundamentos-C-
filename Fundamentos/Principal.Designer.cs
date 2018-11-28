namespace Fundamentos
{
    partial class Principal
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
            this.btnPersona = new System.Windows.Forms.Button();
            this.lstPersona = new System.Windows.Forms.ListBox();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.btnEjecutivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(72, 27);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(136, 23);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Crear Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // lstPersona
            // 
            this.lstPersona.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.Location = new System.Drawing.Point(0, 160);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(326, 108);
            this.lstPersona.TabIndex = 1;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(72, 56);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(136, 23);
            this.btnCrearEmpleado.TabIndex = 2;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // btnEjecutivo
            // 
            this.btnEjecutivo.Location = new System.Drawing.Point(72, 85);
            this.btnEjecutivo.Name = "btnEjecutivo";
            this.btnEjecutivo.Size = new System.Drawing.Size(136, 23);
            this.btnEjecutivo.TabIndex = 3;
            this.btnEjecutivo.Text = "Crear Ejecutivo";
            this.btnEjecutivo.UseVisualStyleBackColor = true;
            this.btnEjecutivo.Click += new System.EventHandler(this.btnEjecutivo_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 268);
            this.Controls.Add(this.btnEjecutivo);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.lstPersona);
            this.Controls.Add(this.btnPersona);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.ListBox lstPersona;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnEjecutivo;
    }
}