namespace Fundamentos
{
    partial class Form27Primitiva
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.lstPremiados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pNumeros = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(339, 100);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(124, 58);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(339, 179);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(124, 58);
            this.btnSortear.TabIndex = 2;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // lstPremiados
            // 
            this.lstPremiados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstPremiados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPremiados.FormattingEnabled = true;
            this.lstPremiados.ItemHeight = 24;
            this.lstPremiados.Location = new System.Drawing.Point(518, 44);
            this.lstPremiados.Name = "lstPremiados";
            this.lstPremiados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPremiados.Size = new System.Drawing.Size(191, 388);
            this.lstPremiados.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Números Premiados";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(367, 395);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // pNumeros
            // 
            this.pNumeros.BackColor = System.Drawing.SystemColors.Control;
            this.pNumeros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNumeros.Location = new System.Drawing.Point(0, 0);
            this.pNumeros.Name = "pNumeros";
            this.pNumeros.Size = new System.Drawing.Size(308, 450);
            this.pNumeros.TabIndex = 6;
            // 
            // Form27Primitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.pNumeros);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPremiados);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form27Primitiva";
            this.Text = "Form27Primitiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.ListBox lstPremiados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.FlowLayoutPanel pNumeros;
    }
}