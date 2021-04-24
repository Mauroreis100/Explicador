using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

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
		public static OleDbConnection conectar()
		{
			OleDbConnection connectio = null;
			try
			{
				String caminho = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mauro\Documents\TESTING\Materia.accdb";
				connectio = new OleDbConnection(caminho);
				MessageBox.Show("CONNECTOU COM SUCESSSO");
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERRO DE CONEXAO " + ex.Message);
			}
			finally
			{
				connectio.Close();
			}
			return connectio;
		}
		void FillCombo() { }
		private void ecraPrincipal_Load(object sender, EventArgs e)
		{
			/* textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
			textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
	
			textBox1.AutoCompleteCustomSource = DataCollection; */
		}

		private async void materiasLB_Click(object sender, EventArgs e)
		{
			try
			{
				//Open file dialog, allows you to select a txt file
				using 
					(OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", Multiselect = false, ValidateNames = true })
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

		private void searchBT_Click(object sender, EventArgs e)
		{
			string classe = cbClasse.SelectedItem.ToString();
			string materia = disciplina.SelectedItem.ToString() + "";
			StreamReader dr = new StreamReader("C:\\Users\\mauro\\Documents\\"+classe+"\\"+materia+".doc");
			string s;
			s = dr.ReadToEnd();
			txtConteudo.Text = s;
		}

		private void materiaNova_Click(object sender, EventArgs e)
		{
			Leitura Mform = new Leitura();
			Mform.Show();
			this.Hide();
		}

		/* private void textBox1_TextChanged(object sender, EventArgs e)
		{
			TextBox t = sender as TextBox;
			if (t != null)
			{
				//say you want to do a search when user types 3 or more chars
				if (t.Text.Length >= 1)
				{
					//SuggestStrings will have the logic to return array of strings either from cache/db
					string[] arr = SuggestStrings(t.Text);

					AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
					collection.AddRange(arr);

					this.textBox1.AutoCompleteCustomSource = collection;
				}
			}
		} */
		/* private void getData(AutoCompleteStringCollection dataCollection)
	{
		string connetionString = null;
		SqlConnection connection;
		SqlCommand command;
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataSet ds = new DataSet();
		String caminho = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mauro\Documents\TESTING\Materia.accbd";
		string sql = "SELECT Disciplina FROM Materia";
		connection = new SqlConnection(connetionString);
		try
		{
			connection.Open();
			command = new SqlCommand(sql, connection);
			adapter.SelectCommand = command;
			adapter.Fill(ds);
			adapter.Dispose();
			command.Dispose();
			connection.Close();
			foreach (DataRow row in ds.Tables[0].Rows)
			{
				dataCollection.Add(row[0].ToString());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Can not open connection ! ");
		}
	} */


	}
}
