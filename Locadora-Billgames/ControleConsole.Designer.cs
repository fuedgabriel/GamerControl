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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConsoleBoxADD
            // 
            this.ConsoleBoxADD.Location = new System.Drawing.Point(460, 39);
            this.ConsoleBoxADD.Name = "ConsoleBoxADD";
            this.ConsoleBoxADD.Size = new System.Drawing.Size(115, 20);
            this.ConsoleBoxADD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
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
            this.ConsoleBox.Location = new System.Drawing.Point(59, 42);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(121, 21);
            this.ConsoleBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Console:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local:";
            // 
            // LocalBox
            // 
            this.LocalBox.Location = new System.Drawing.Point(228, 42);
            this.LocalBox.Name = "LocalBox";
            this.LocalBox.Size = new System.Drawing.Size(121, 20);
            this.LocalBox.TabIndex = 10;
            // 
            // ControleConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalBox;
    }
}
