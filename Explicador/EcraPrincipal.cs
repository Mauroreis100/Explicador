using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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

		
			
		private void searchBT_Click(object sender, EventArgs e)
		{

			try { 
			string classe = cbClasse.SelectedItem.ToString();
		string materia = cbDisciplina.SelectedItem.ToString() + "";
			string lerficheirotodo = "C:\\Users\\mauro\\Documents\\MATÉRIAS\\"+classe+"\\"+ materia +".pdf";
				// "C:\\Users\\mauro\\Documents\\MATÉRIAS" + classe + "\\" + materia + ".pdf";
				axAcroPDF1.src=lerficheirotodo;
				
			}
			catch (Exception c)
			{
				Console.WriteLine(c.Message);
			}
			/*string classe = cbClasse.SelectedItem.ToString();
			string materia = cbDisciplina.SelectedItem.ToString() + "";
		
			
			Process myProcess = new Process();

			try
			{
				myProcess.StartInfo.UseShellExecute = false;
				// You can start any process, HelloWorld is a do-nothing example.
				myProcess.StartInfo.FileName = "C:\\Users\\mauro\\Documents\\MATÉRIAS" + classe + "\\" + materia + ".pdf";
				myProcess.StartInfo.CreateNoWindow = true;
				myProcess.Start();
				// This code assumes the process you are starting will terminate itself. 
				// Given that is is started without a window so you cannot terminate it 
				// on the desktop, it must terminate itself or you can do it programmatically
				// from this application using the Kill method.
			}
			catch (Exception c) 
			{
				Console.WriteLine(c.Message);
			}*/


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
