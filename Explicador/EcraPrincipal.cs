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
using System.IO;

namespace Explicador
{
	public partial class ecraPrincipal : Form
	{
		public ecraPrincipal()
		{
			InitializeComponent();
		}

		private void lbVoltar_Click(object sender, EventArgs e)
		{
			Application.Exit();
			
		}

		private void ecraPrincipal_Load(object sender, EventArgs e)
		{

		}

		private async void materiasLB_Click(object sender, EventArgs e)
		{
			try
			{
				//Open file dialog, allows you to select a txt file
				using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.docx", Multiselect = false, ValidateNames = true })
				{
					if (ofd.ShowDialog() == DialogResult.OK)
					{
						using (StreamReader sr = new StreamReader(ofd.FileName))
						{
							txtConteudo.Text = await sr.ReadToEndAsync();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
	}
}
