namespace WindowsFormsApp1
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
            this.numeroa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numerob = new System.Windows.Forms.Label();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "SANRIO CALCULATOR";
            // 
            // numeroa
            // 
            this.numeroa.AutoSize = true;
            this.numeroa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroa.Location = new System.Drawing.Point(203, 127);
            this.numeroa.Name = "numeroa";
            this.numeroa.Size = new System.Drawing.Size(74, 16);
            this.numeroa.TabIndex = 1;
            this.numeroa.Text = "NumeroA";
            this.numeroa.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox1.Location = new System.Drawing.Point(336, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox2.Location = new System.Drawing.Point(336, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numerob
            // 
            this.numerob.AutoSize = true;
            this.numerob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerob.Location = new System.Drawing.Point(203, 189);
            this.numerob.Name = "numerob";
            this.numerob.Size = new System.Drawing.Size(74, 16);
            this.numerob.TabIndex = 4;
            this.numerob.Text = "NumeroB";
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSuma.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonSuma.Location = new System.Drawing.Point(306, 263);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(131, 58);
            this.buttonSuma.TabIndex = 5;
            this.buttonSuma.Text = "SUMA";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.DarkKhaki;
            this.resultado.Location = new System.Drawing.Point(538, 139);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(180, 40);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "Resultado";
            this.resultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(453, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.numerob);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numeroa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeroa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label numerob;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label5;
    }
}

