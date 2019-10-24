namespace Locadora_Billgames
{
    partial class Dashboard
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
            this.FDC_btn = new System.Windows.Forms.Button();
            this.ControleU_bnt = new System.Windows.Forms.Button();
            this.Games_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContaLabel = new System.Windows.Forms.Label();
            this.LabelConta = new System.Windows.Forms.Label();
            this.HierarquiaLabel = new System.Windows.Forms.Label();
            this.LabelHierarquia = new System.Windows.Forms.Label();
            this.TurnoLabel = new System.Windows.Forms.Label();
            this.LabelTurno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.controlePreco1 = new Locadora_Billgames.ControlePreco();
            this.controleConsole1 = new Locadora_Billgames.ControleConsole();
            this.SuspendLayout();
            // 
            // FDC_btn
            // 
            this.FDC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FDC_btn.Location = new System.Drawing.Point(12, 119);
            this.FDC_btn.Name = "FDC_btn";
            this.FDC_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FDC_btn.Size = new System.Drawing.Size(142, 34);
            this.FDC_btn.TabIndex = 0;
            this.FDC_btn.Text = "Fechamento de caixa";
            this.FDC_btn.UseVisualStyleBackColor = true;
            // 
            // ControleU_bnt
            // 
            this.ControleU_bnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControleU_bnt.Location = new System.Drawing.Point(12, 486);
            this.ControleU_bnt.Name = "ControleU_bnt";
            this.ControleU_bnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ControleU_bnt.Size = new System.Drawing.Size(142, 34);
            this.ControleU_bnt.TabIndex = 1;
            this.ControleU_bnt.Text = "Controle de usuário";
            this.ControleU_bnt.UseVisualStyleBackColor = true;
            // 
            // Games_btn
            // 
            this.Games_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Games_btn.Location = new System.Drawing.Point(12, 79);
            this.Games_btn.Name = "Games_btn";
            this.Games_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Games_btn.Size = new System.Drawing.Size(142, 34);
            this.Games_btn.TabIndex = 3;
            this.Games_btn.Text = "Games";
            this.Games_btn.UseVisualStyleBackColor = true;
            this.Games_btn.Click += new System.EventHandler(this.Games_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(171, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 587);
            this.panel1.TabIndex = 4;
            // 
            // ContaLabel
            // 
            this.ContaLabel.AutoSize = true;
            this.ContaLabel.Location = new System.Drawing.Point(12, 9);
            this.ContaLabel.Name = "ContaLabel";
            this.ContaLabel.Size = new System.Drawing.Size(38, 13);
            this.ContaLabel.TabIndex = 5;
            this.ContaLabel.Text = "Conta:";
            // 
            // LabelConta
            // 
            this.LabelConta.AutoSize = true;
            this.LabelConta.Location = new System.Drawing.Point(76, 9);
            this.LabelConta.Name = "LabelConta";
            this.LabelConta.Size = new System.Drawing.Size(34, 13);
            this.LabelConta.TabIndex = 6;
            this.LabelConta.Text = "         ";
            // 
            // HierarquiaLabel
            // 
            this.HierarquiaLabel.AutoSize = true;
            this.HierarquiaLabel.Location = new System.Drawing.Point(12, 53);
            this.HierarquiaLabel.Name = "HierarquiaLabel";
            this.HierarquiaLabel.Size = new System.Drawing.Size(58, 13);
            this.HierarquiaLabel.TabIndex = 7;
            this.HierarquiaLabel.Text = "Hierarquia:";
            // 
            // LabelHierarquia
            // 
            this.LabelHierarquia.AutoSize = true;
            this.LabelHierarquia.Location = new System.Drawing.Point(76, 53);
            this.LabelHierarquia.Name = "LabelHierarquia";
            this.LabelHierarquia.Size = new System.Drawing.Size(43, 13);
            this.LabelHierarquia.TabIndex = 8;
            this.LabelHierarquia.Text = "            ";
            // 
            // TurnoLabel
            // 
            this.TurnoLabel.AutoSize = true;
            this.TurnoLabel.Location = new System.Drawing.Point(12, 31);
            this.TurnoLabel.Name = "TurnoLabel";
            this.TurnoLabel.Size = new System.Drawing.Size(38, 13);
            this.TurnoLabel.TabIndex = 9;
            this.TurnoLabel.Text = "Turno:";
            // 
            // LabelTurno
            // 
            this.LabelTurno.AutoSize = true;
            this.LabelTurno.Location = new System.Drawing.Point(76, 31);
            this.LabelTurno.Name = "LabelTurno";
            this.LabelTurno.Size = new System.Drawing.Size(43, 13);
            this.LabelTurno.TabIndex = 10;
            this.LabelTurno.Text = "            ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 526);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Controle de console";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlePreco1
            // 
            this.controlePreco1.Location = new System.Drawing.Point(193, 12);
            this.controlePreco1.Name = "controlePreco1";
            this.controlePreco1.Size = new System.Drawing.Size(784, 551);
            this.controlePreco1.TabIndex = 11;
            // 
            // controleConsole1
            // 
            this.controleConsole1.Location = new System.Drawing.Point(193, 12);
            this.controleConsole1.Name = "controleConsole1";
            this.controleConsole1.Size = new System.Drawing.Size(784, 551);
            this.controleConsole1.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 572);
            this.Controls.Add(this.controleConsole1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlePreco1);
            this.Controls.Add(this.LabelTurno);
            this.Controls.Add(this.TurnoLabel);
            this.Controls.Add(this.LabelHierarquia);
            this.Controls.Add(this.HierarquiaLabel);
            this.Controls.Add(this.LabelConta);
            this.Controls.Add(this.ContaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Games_btn);
            this.Controls.Add(this.ControleU_bnt);
            this.Controls.Add(this.FDC_btn);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FDC_btn;
        private System.Windows.Forms.Button ControleU_bnt;
        private System.Windows.Forms.Button Games_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ContaLabel;
        private System.Windows.Forms.Label LabelConta;
        private System.Windows.Forms.Label HierarquiaLabel;
        private System.Windows.Forms.Label TurnoLabel;
        private System.Windows.Forms.Label LabelTurno;
        private System.Windows.Forms.Label LabelHierarquia;
        private ControlePreco controlePreco1;
        private System.Windows.Forms.Button button1;
        private ControleConsole controleConsole1;
    }
}