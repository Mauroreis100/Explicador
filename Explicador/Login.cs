using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Explicador
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Close();
			Application.Exit();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\Documents\Explicadordb.mdf;Integrated Security=True;Connect Timeout=30");

		private void loginBt_Click(object sender, EventArgs e)
		{
			Cadastrar Mform = new Cadastrar();
			Mform.Show();
			this.Hide();
		}
	}
}
