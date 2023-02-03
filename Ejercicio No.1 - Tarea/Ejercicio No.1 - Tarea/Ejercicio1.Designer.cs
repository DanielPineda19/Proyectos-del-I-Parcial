namespace Ejercicio_No._1___Tarea
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.PositivoNegativoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParImparTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAREA 1: ANÁLISIS DE NÚMEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número:";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTextBox.Location = new System.Drawing.Point(295, 82);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(156, 26);
            this.NumeroTextBox.TabIndex = 2;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EjecutarButton.Location = new System.Drawing.Point(295, 123);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(156, 33);
            this.EjecutarButton.TabIndex = 3;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // PositivoNegativoTextBox
            // 
            this.PositivoNegativoTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositivoNegativoTextBox.Location = new System.Drawing.Point(295, 226);
            this.PositivoNegativoTextBox.Name = "PositivoNegativoTextBox";
            this.PositivoNegativoTextBox.Size = new System.Drawing.Size(281, 26);
            this.PositivoNegativoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿El número es par o impar?";
            // 
            // ParImparTextBox
            // 
            this.ParImparTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParImparTextBox.Location = new System.Drawing.Point(295, 180);
            this.ParImparTextBox.Name = "ParImparTextBox";
            this.ParImparTextBox.Size = new System.Drawing.Size(281, 26);
            this.ParImparTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿El número es positivo o negativo?";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 295);
            this.Controls.Add(this.ParImparTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PositivoNegativoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.TextBox PositivoNegativoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParImparTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
    }
}

