namespace JoseSanchezTomas24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.txtBoxNombreJug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.Location = new System.Drawing.Point(206, 239);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(141, 57);
            this.btnPreguntas.TabIndex = 0;
            this.btnPreguntas.Text = "Añadir Preguntas y respuestas";
            this.btnPreguntas.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(206, 320);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(141, 38);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(441, 81);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(57, 16);
            this.lblJugador.TabIndex = 2;
            this.lblJugador.Text = "Jugador";
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Location = new System.Drawing.Point(441, 140);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(73, 16);
            this.lblPuntuación.TabIndex = 3;
            this.lblPuntuación.Text = "Puntuación";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(641, 127);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(27, 29);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "0";
            // 
            // txtBoxNombreJug
            // 
            this.txtBoxNombreJug.Location = new System.Drawing.Point(556, 79);
            this.txtBoxNombreJug.Name = "txtBoxNombreJug";
            this.txtBoxNombreJug.Size = new System.Drawing.Size(208, 22);
            this.txtBoxNombreJug.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxNombreJug);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblPuntuación);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnPreguntas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblPuntuación;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.TextBox txtBoxNombreJug;
    }
}

