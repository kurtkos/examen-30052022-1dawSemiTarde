﻿namespace JoseSanchezTomas24
{
    partial class Form2
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
            this.lblSeleccionPregunta = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeleccionPregunta
            // 
            this.lblSeleccionPregunta.AutoSize = true;
            this.lblSeleccionPregunta.Location = new System.Drawing.Point(145, 56);
            this.lblSeleccionPregunta.Name = "lblSeleccionPregunta";
            this.lblSeleccionPregunta.Size = new System.Drawing.Size(274, 16);
            this.lblSeleccionPregunta.TabIndex = 0;
            this.lblSeleccionPregunta.Text = "Seleccione la opción correcta de la pregunta";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(145, 112);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(138, 32);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Pregunta";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblSeleccionPregunta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionPregunta;
        private System.Windows.Forms.Label lblPregunta;
    }
}