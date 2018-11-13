namespace Fundamentos
{
    partial class Form04MayorMenor
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menor = new System.Windows.Forms.Label();
            this.mediano = new System.Windows.Forms.Label();
            this.mayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(99, 71);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(106, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(99, 111);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(106, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(99, 152);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(106, 20);
            this.txtNum3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menor
            // 
            this.menor.AutoSize = true;
            this.menor.Location = new System.Drawing.Point(292, 159);
            this.menor.Name = "menor";
            this.menor.Size = new System.Drawing.Size(35, 13);
            this.menor.TabIndex = 9;
            this.menor.Text = "label4";
            // 
            // mediano
            // 
            this.mediano.AutoSize = true;
            this.mediano.Location = new System.Drawing.Point(292, 118);
            this.mediano.Name = "mediano";
            this.mediano.Size = new System.Drawing.Size(35, 13);
            this.mediano.TabIndex = 8;
            this.mediano.Text = "label5";
            // 
            // mayor
            // 
            this.mayor.AutoSize = true;
            this.mayor.Location = new System.Drawing.Point(292, 78);
            this.mayor.Name = "mayor";
            this.mayor.Size = new System.Drawing.Size(35, 13);
            this.mayor.TabIndex = 7;
            this.mayor.Text = "label6";
            // 
            // Form04MayorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 275);
            this.Controls.Add(this.menor);
            this.Controls.Add(this.mediano);
            this.Controls.Add(this.mayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form04MayorMenor";
            this.Text = "Form04MayorMenor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label menor;
        private System.Windows.Forms.Label mediano;
        private System.Windows.Forms.Label mayor;
    }
}