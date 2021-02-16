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
		
		private void loginBt_Click(object sender, EventArgs e)
		{
			Cadastrar Mform = new Cadastrar();
			Mform.Show();
			this.Hide();
		}
	}
}
