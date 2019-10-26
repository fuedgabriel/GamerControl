using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Locadora_Billgames
{
    public partial class Dashboard : Form
    {
        public static string UserId { get; set; }


        string Nome = Connection.Verificar(UserId, 0);
        string Turno = Connection.Verificar(UserId, 2);
        string Hierarquia = Connection.Verificar(UserId, 3);
 
        public Dashboard()
        {
            InitializeComponent();
            LabelConta.Text = Nome;
            if(Turno == "T") { LabelTurno.Text = "Tarde"; } else if(Turno == "M") { LabelTurno.Text = "Manhã"; }
            if (Hierarquia == "0") { LabelHierarquia.Text = "Administrador"; }else { LabelHierarquia.Text = "Rei"; }
            
        }


        private void Close()
        {
            controlePreco1.Hide();
            controleConsole1.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void Games_btn_Click(object sender, EventArgs e)
        {
            
            controlePreco1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleConsole1.Reload();
            controleConsole1.Show();
            
        }
    }
}
