﻿namespace Fundamentos
{
    partial class Form29MesesWeb
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.Máxima = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(216, 290);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 51);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar Meses";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(216, 171);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Media";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(216, 106);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(100, 20);
            this.txtMinima.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(216, 46);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 20);
            this.txtMaxima.TabIndex = 10;
            // 
            // Máxima
            // 
            this.Máxima.AutoSize = true;
            this.Máxima.Location = new System.Drawing.Point(213, 30);
            this.Máxima.Name = "Máxima";
            this.Máxima.Size = new System.Drawing.Size(43, 13);
            this.Máxima.TabIndex = 9;
            this.Máxima.Text = "Máxima";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(12, 12);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(176, 329);
            this.lstMeses.TabIndex = 8;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // Form29MesesWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 361);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.Máxima);
            this.Controls.Add(this.lstMeses);
            this.Name = "Form29MesesWeb";
            this.Text = "Form29MesesWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label Máxima;
        private System.Windows.Forms.ListBox lstMeses;
    }
}