namespace ProjetoCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Val1 = new System.Windows.Forms.TextBox();
            this.tbox_Val2 = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira o valor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira o valor 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // tbox_Val1
            // 
            this.tbox_Val1.Location = new System.Drawing.Point(172, 74);
            this.tbox_Val1.Name = "tbox_Val1";
            this.tbox_Val1.Size = new System.Drawing.Size(111, 26);
            this.tbox_Val1.TabIndex = 4;

            // 
            // tbox_Val2
            // 
            this.tbox_Val2.Location = new System.Drawing.Point(172, 128);
            this.tbox_Val2.Name = "tbox_Val2";
            this.tbox_Val2.Size = new System.Drawing.Size(111, 26);
            this.tbox_Val2.TabIndex = 5;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(102, 230);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(24, 20);
            this.lb_Total.TabIndex = 6;
            this.lb_Total.Text = "...";
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(43, 169);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(43, 23);
            this.btn_Somar.TabIndex = 7;
            this.btn_Somar.Text = "+";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.Location = new System.Drawing.Point(93, 169);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(43, 23);
            this.btn_Subtrair.TabIndex = 12;
            this.btn_Subtrair.Text = "-";
            this.btn_Subtrair.UseVisualStyleBackColor = true;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(143, 169);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(43, 23);
            this.btn_Multiplicar.TabIndex = 13;
            this.btn_Multiplicar.Text = "X";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Location = new System.Drawing.Point(193, 169);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(43, 23);
            this.btn_Dividir.TabIndex = 15;
            this.btn_Dividir.Text = "/";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Limpar.Location = new System.Drawing.Point(272, 164);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(83, 32);
            this.btn_Limpar.TabIndex = 16;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(388, 288);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.tbox_Val2);
            this.Controls.Add(this.tbox_Val1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_Val1;
        private System.Windows.Forms.TextBox tbox_Val2;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

