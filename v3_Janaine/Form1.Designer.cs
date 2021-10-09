
namespace v3_Janaine
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtração = new System.Windows.Forms.Button();
            this.Multiplicação = new System.Windows.Forms.Button();
            this.Divisão = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(212, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Limpar.Location = new System.Drawing.Point(9, 164);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(136, 55);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Soma
            // 
            this.Soma.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Soma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Soma.Location = new System.Drawing.Point(348, 35);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(132, 29);
            this.Soma.TabIndex = 8;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtração
            // 
            this.Subtração.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Subtração.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Subtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Subtração.Location = new System.Drawing.Point(348, 70);
            this.Subtração.Name = "Subtração";
            this.Subtração.Size = new System.Drawing.Size(132, 29);
            this.Subtração.TabIndex = 9;
            this.Subtração.Text = "Subtração";
            this.Subtração.UseVisualStyleBackColor = false;
            this.Subtração.Click += new System.EventHandler(this.Subtração_Click);
            // 
            // Multiplicação
            // 
            this.Multiplicação.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Multiplicação.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Multiplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Multiplicação.Location = new System.Drawing.Point(348, 107);
            this.Multiplicação.Name = "Multiplicação";
            this.Multiplicação.Size = new System.Drawing.Size(132, 29);
            this.Multiplicação.TabIndex = 10;
            this.Multiplicação.Text = "Multiplicação";
            this.Multiplicação.UseVisualStyleBackColor = false;
            this.Multiplicação.Click += new System.EventHandler(this.Multiplicação_Click);
            // 
            // Divisão
            // 
            this.Divisão.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Divisão.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Divisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Divisão.Location = new System.Drawing.Point(348, 142);
            this.Divisão.Name = "Divisão";
            this.Divisão.Size = new System.Drawing.Size(132, 29);
            this.Divisão.TabIndex = 11;
            this.Divisão.Text = "Divisão";
            this.Divisão.UseVisualStyleBackColor = false;
            this.Divisão.Click += new System.EventHandler(this.Divisão_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calculadora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(496, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Divisão);
            this.Controls.Add(this.Multiplicação);
            this.Controls.Add(this.Subtração);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtração;
        private System.Windows.Forms.Button Multiplicação;
        private System.Windows.Forms.Button Divisão;
        private System.Windows.Forms.Label label2;
    }
}

