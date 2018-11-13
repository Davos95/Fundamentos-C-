namespace Fundamentos
{
    partial class Form13ColeccionListBox
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
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimipiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.lblMostrarTodos = new System.Windows.Forms.Label();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(45, 78);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstElementos.Size = new System.Drawing.Size(120, 342);
            this.lstElementos.TabIndex = 0;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elemento:";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(208, 97);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(206, 20);
            this.txtElemento.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(208, 133);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 39);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo Elemento";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(314, 133);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 39);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar Elemento";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimipiar
            // 
            this.btnLimipiar.Location = new System.Drawing.Point(208, 178);
            this.btnLimipiar.Name = "btnLimipiar";
            this.btnLimipiar.Size = new System.Drawing.Size(100, 41);
            this.btnLimipiar.TabIndex = 6;
            this.btnLimipiar.Text = "Limpiar lista";
            this.btnLimipiar.UseVisualStyleBackColor = true;
            this.btnLimipiar.Click += new System.EventHandler(this.btnLimipiar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(314, 176);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 43);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(205, 299);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(77, 13);
            this.lblSeleccionados.TabIndex = 8;
            this.lblSeleccionados.Text = "Seleccionados";
            // 
            // lblMostrarTodos
            // 
            this.lblMostrarTodos.AutoSize = true;
            this.lblMostrarTodos.Location = new System.Drawing.Point(205, 337);
            this.lblMostrarTodos.Name = "lblMostrarTodos";
            this.lblMostrarTodos.Size = new System.Drawing.Size(41, 13);
            this.lblMostrarTodos.TabIndex = 9;
            this.lblMostrarTodos.Text = "ListBox";
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(208, 238);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(100, 39);
            this.btnSeleccionados.TabIndex = 10;
            this.btnSeleccionados.Text = "Mostrar Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form13ColeccionListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 451);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblMostrarTodos);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLimipiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstElementos);
            this.Name = "Form13ColeccionListBox";
            this.Text = "Form13ArraysColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimipiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.Label lblMostrarTodos;
        private System.Windows.Forms.Button btnSeleccionados;
    }
}