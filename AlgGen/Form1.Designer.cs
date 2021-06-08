namespace AlgoritmoGenetico
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
            this.label1 = new System.Windows.Forms.Label();
            this.NUDTamPoblacion = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.RTBPoblacion = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RTBEvaluados = new System.Windows.Forms.RichTextBox();
            this.RTBSeleccionados = new System.Windows.Forms.RichTextBox();
            this.NUDPresion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBCruzados = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.NUDProbabilidadMutacion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RTBMutados = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTamPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProbabilidadMutacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño Poblacion";
            // 
            // NUDTamPoblacion
            // 
            this.NUDTamPoblacion.Location = new System.Drawing.Point(115, 9);
            this.NUDTamPoblacion.Name = "NUDTamPoblacion";
            this.NUDTamPoblacion.Size = new System.Drawing.Size(100, 20);
            this.NUDTamPoblacion.TabIndex = 1;
            this.NUDTamPoblacion.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inicializar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBPoblacion
            // 
            this.RTBPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTBPoblacion.Location = new System.Drawing.Point(15, 68);
            this.RTBPoblacion.Name = "RTBPoblacion";
            this.RTBPoblacion.ReadOnly = true;
            this.RTBPoblacion.Size = new System.Drawing.Size(100, 370);
            this.RTBPoblacion.TabIndex = 3;
            this.RTBPoblacion.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Evaluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RTBEvaluados
            // 
            this.RTBEvaluados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTBEvaluados.Location = new System.Drawing.Point(139, 68);
            this.RTBEvaluados.Name = "RTBEvaluados";
            this.RTBEvaluados.ReadOnly = true;
            this.RTBEvaluados.Size = new System.Drawing.Size(100, 370);
            this.RTBEvaluados.TabIndex = 6;
            this.RTBEvaluados.Text = "";
            // 
            // RTBSeleccionados
            // 
            this.RTBSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTBSeleccionados.Location = new System.Drawing.Point(261, 68);
            this.RTBSeleccionados.Name = "RTBSeleccionados";
            this.RTBSeleccionados.ReadOnly = true;
            this.RTBSeleccionados.Size = new System.Drawing.Size(100, 370);
            this.RTBSeleccionados.TabIndex = 7;
            this.RTBSeleccionados.Text = "";
            // 
            // NUDPresion
            // 
            this.NUDPresion.Location = new System.Drawing.Point(283, 9);
            this.NUDPresion.Name = "NUDPresion";
            this.NUDPresion.Size = new System.Drawing.Size(100, 20);
            this.NUDPresion.TabIndex = 9;
            this.NUDPresion.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Presion";
            // 
            // RTBCruzados
            // 
            this.RTBCruzados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTBCruzados.Location = new System.Drawing.Point(381, 68);
            this.RTBCruzados.Name = "RTBCruzados";
            this.RTBCruzados.ReadOnly = true;
            this.RTBCruzados.Size = new System.Drawing.Size(100, 370);
            this.RTBCruzados.TabIndex = 11;
            this.RTBCruzados.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cruzar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NUDProbabilidadMutacion
            // 
            this.NUDProbabilidadMutacion.DecimalPlaces = 1;
            this.NUDProbabilidadMutacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDProbabilidadMutacion.Location = new System.Drawing.Point(536, 9);
            this.NUDProbabilidadMutacion.Name = "NUDProbabilidadMutacion";
            this.NUDProbabilidadMutacion.Size = new System.Drawing.Size(100, 20);
            this.NUDProbabilidadMutacion.TabIndex = 15;
            this.NUDProbabilidadMutacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Probabilidad de Mutacion";
            // 
            // RTBMutados
            // 
            this.RTBMutados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RTBMutados.Location = new System.Drawing.Point(498, 68);
            this.RTBMutados.Name = "RTBMutados";
            this.RTBMutados.ReadOnly = true;
            this.RTBMutados.Size = new System.Drawing.Size(100, 370);
            this.RTBMutados.TabIndex = 13;
            this.RTBMutados.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(509, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Mutar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUDProbabilidadMutacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTBMutados);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RTBCruzados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NUDPresion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTBSeleccionados);
            this.Controls.Add(this.RTBEvaluados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RTBPoblacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NUDTamPoblacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDTamPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProbabilidadMutacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDTamPoblacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RTBPoblacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox RTBEvaluados;
        private System.Windows.Forms.RichTextBox RTBSeleccionados;
        private System.Windows.Forms.NumericUpDown NUDPresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBCruzados;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown NUDProbabilidadMutacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTBMutados;
        private System.Windows.Forms.Button button5;
    }
}

