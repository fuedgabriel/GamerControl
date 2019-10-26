namespace Locadora_Billgames
{
    partial class ControleConsole
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConsoleBoxADD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsoleBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Excluir_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalBox = new System.Windows.Forms.TextBox();
            this.TipoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TipoAlter = new System.Windows.Forms.TextBox();
            this.LocalAlter = new System.Windows.Forms.TextBox();
            this.NomeAlter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConsolePreco = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConsoleBoxADD
            // 
            this.ConsoleBoxADD.Location = new System.Drawing.Point(66, 12);
            this.ConsoleBoxADD.Name = "ConsoleBoxADD";
            this.ConsoleBoxADD.Size = new System.Drawing.Size(158, 20);
            this.ConsoleBoxADD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(384, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 587);
            this.panel1.TabIndex = 5;
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.FormattingEnabled = true;
            this.ConsoleBox.Location = new System.Drawing.Point(454, 12);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(183, 21);
            this.ConsoleBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Console:";
            // 
            // Excluir_btn
            // 
            this.Excluir_btn.Location = new System.Drawing.Point(454, 123);
            this.Excluir_btn.Name = "Excluir_btn";
            this.Excluir_btn.Size = new System.Drawing.Size(75, 23);
            this.Excluir_btn.TabIndex = 5;
            this.Excluir_btn.Text = "Excluir";
            this.Excluir_btn.UseVisualStyleBackColor = true;
            this.Excluir_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local:";
            // 
            // LocalBox
            // 
            this.LocalBox.Location = new System.Drawing.Point(66, 39);
            this.LocalBox.Name = "LocalBox";
            this.LocalBox.Size = new System.Drawing.Size(158, 20);
            this.LocalBox.TabIndex = 1;
            // 
            // TipoBox
            // 
            this.TipoBox.Location = new System.Drawing.Point(66, 67);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(158, 20);
            this.TipoBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TipoAlter
            // 
            this.TipoAlter.Location = new System.Drawing.Point(454, 97);
            this.TipoAlter.Name = "TipoAlter";
            this.TipoAlter.Size = new System.Drawing.Size(183, 20);
            this.TipoAlter.TabIndex = 15;
            // 
            // LocalAlter
            // 
            this.LocalAlter.Location = new System.Drawing.Point(454, 69);
            this.LocalAlter.Name = "LocalAlter";
            this.LocalAlter.Size = new System.Drawing.Size(183, 20);
            this.LocalAlter.TabIndex = 14;
            // 
            // NomeAlter
            // 
            this.NomeAlter.Location = new System.Drawing.Point(454, 42);
            this.NomeAlter.Name = "NomeAlter";
            this.NomeAlter.Size = new System.Drawing.Size(183, 20);
            this.NomeAlter.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Local:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Console:";
            // 
            // ConsolePreco
            // 
            this.ConsolePreco.FormattingEnabled = true;
            this.ConsolePreco.Location = new System.Drawing.Point(454, 197);
            this.ConsolePreco.Name = "ConsolePreco";
            this.ConsolePreco.Size = new System.Drawing.Size(183, 21);
            this.ConsolePreco.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Preço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 23;
            // 
            // ControleConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConsolePreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoAlter);
            this.Controls.Add(this.LocalAlter);
            this.Controls.Add(this.NomeAlter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Excluir_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsoleBoxADD);
            this.Name = "ControleConsole";
            this.Size = new System.Drawing.Size(784, 551);
            this.Load += new System.EventHandler(this.ControleConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleBoxADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ConsoleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Excluir_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalBox;
        private System.Windows.Forms.TextBox TipoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TipoAlter;
        private System.Windows.Forms.TextBox LocalAlter;
        private System.Windows.Forms.TextBox NomeAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ConsolePreco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}
