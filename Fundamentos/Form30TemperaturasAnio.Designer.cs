namespace Fundamentos
{
    partial class Form30TemperaturasAnio
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
            this.lstAnioTemp = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtNumAnios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxAnual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinAnual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.lstAnio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMediaMen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMilisegundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // lstAnioTemp
            // 
            this.lstAnioTemp.FormattingEnabled = true;
            this.lstAnioTemp.Location = new System.Drawing.Point(12, 134);
            this.lstAnioTemp.Name = "lstAnioTemp";
            this.lstAnioTemp.Size = new System.Drawing.Size(242, 225);
            this.lstAnioTemp.TabIndex = 1;
            this.lstAnioTemp.SelectedIndexChanged += new System.EventHandler(this.lstAnioTemp_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 61);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(216, 29);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar temperaturas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtNumAnios
            // 
            this.txtNumAnios.Location = new System.Drawing.Point(299, 21);
            this.txtNumAnios.Name = "txtNumAnios";
            this.txtNumAnios.Size = new System.Drawing.Size(100, 20);
            this.txtNumAnios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de años:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max anual";
            // 
            // txtMaxAnual
            // 
            this.txtMaxAnual.Location = new System.Drawing.Point(281, 102);
            this.txtMaxAnual.Name = "txtMaxAnual";
            this.txtMaxAnual.Size = new System.Drawing.Size(43, 20);
            this.txtMaxAnual.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min anual";
            // 
            // txtMinAnual
            // 
            this.txtMinAnual.Location = new System.Drawing.Point(364, 102);
            this.txtMinAnual.Name = "txtMinAnual";
            this.txtMinAnual.Size = new System.Drawing.Size(43, 20);
            this.txtMinAnual.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Media anual";
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(304, 150);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(61, 20);
            this.txtMediaAnual.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Temp. Maxima";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(304, 220);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(61, 20);
            this.txtTempMax.TabIndex = 12;
            // 
            // lstAnio
            // 
            this.lstAnio.FormattingEnabled = true;
            this.lstAnio.Location = new System.Drawing.Point(53, 18);
            this.lstAnio.Name = "lstAnio";
            this.lstAnio.Size = new System.Drawing.Size(121, 21);
            this.lstAnio.TabIndex = 14;
            this.lstAnio.SelectedIndexChanged += new System.EventHandler(this.lstAnio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Media mensual";
            // 
            // txtMediaMen
            // 
            this.txtMediaMen.Location = new System.Drawing.Point(304, 335);
            this.txtMediaMen.Name = "txtMediaMen";
            this.txtMediaMen.Size = new System.Drawing.Size(61, 20);
            this.txtMediaMen.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Temp. Minima";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(304, 277);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(61, 20);
            this.txtTempMin.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tiempo (milisegundos):";
            // 
            // lblMilisegundos
            // 
            this.lblMilisegundos.AutoSize = true;
            this.lblMilisegundos.Location = new System.Drawing.Point(130, 379);
            this.lblMilisegundos.Name = "lblMilisegundos";
            this.lblMilisegundos.Size = new System.Drawing.Size(0, 13);
            this.lblMilisegundos.TabIndex = 20;
            // 
            // Form30TemperaturasAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 422);
            this.Controls.Add(this.lblMilisegundos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTempMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMediaMen);
            this.Controls.Add(this.lstAnio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTempMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMediaAnual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinAnual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxAnual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumAnios);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstAnioTemp);
            this.Controls.Add(this.label1);
            this.Name = "Form30TemperaturasAnio";
            this.Text = "Form30TemperaturasAnio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAnioTemp;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNumAnios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxAnual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinAnual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMediaAnual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.ComboBox lstAnio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMediaMen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMilisegundos;
    }
}