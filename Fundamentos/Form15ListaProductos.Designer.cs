namespace Fundamentos
{
    partial class Form15ListaProductos
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPasarSeleccion = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lstTienda = new System.Windows.Forms.ListBox();
            this.lstAlmacen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Almacen";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(36, 41);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(36, 76);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(36, 167);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPasarSeleccion
            // 
            this.btnPasarSeleccion.Location = new System.Drawing.Point(340, 57);
            this.btnPasarSeleccion.Name = "btnPasarSeleccion";
            this.btnPasarSeleccion.Size = new System.Drawing.Size(95, 41);
            this.btnPasarSeleccion.TabIndex = 8;
            this.btnPasarSeleccion.Text = "Selección -->";
            this.btnPasarSeleccion.UseVisualStyleBackColor = true;
            this.btnPasarSeleccion.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(609, 127);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(75, 32);
            this.btnBajar.TabIndex = 9;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.Location = new System.Drawing.Point(340, 121);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(95, 45);
            this.btnPasarTodos.TabIndex = 10;
            this.btnPasarTodos.Text = "Todos -->";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(609, 63);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 29);
            this.btnSubir.TabIndex = 11;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // lstTienda
            // 
            this.lstTienda.FormattingEnabled = true;
            this.lstTienda.Location = new System.Drawing.Point(200, 44);
            this.lstTienda.Name = "lstTienda";
            this.lstTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTienda.Size = new System.Drawing.Size(120, 264);
            this.lstTienda.TabIndex = 12;
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.Location = new System.Drawing.Point(458, 44);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(120, 264);
            this.lstAlmacen.TabIndex = 13;
            this.lstAlmacen.SelectedIndexChanged += new System.EventHandler(this.lstAlmacen_SelectedIndexChanged);
            // 
            // Form15ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 345);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.lstTienda);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnPasarSeleccion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form15ListaProductos";
            this.Text = "Form15ListaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPasarSeleccion;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.ListBox lstTienda;
        private System.Windows.Forms.ListBox lstAlmacen;
    }
}