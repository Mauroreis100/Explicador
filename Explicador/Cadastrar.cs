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
using System.Data.OleDb;
using System.Collections;


namespace Explicador
{
	public partial class Cadastrar : Form
	{
		public Cadastrar()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
					}

		private void saltarBt_Click(object sender, EventArgs e)
		{
			ecraPrincipal Mform = new ecraPrincipal();
			Mform.Show();
			this.Hide();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Close();
			Application.Exit();
		}
		public static OleDbConnection conectar()
		{
			OleDbConnection connectio = null;
			try
			{
				String caminho = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bdaula\ExplicadorUser.accdb";
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
		//SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mauro\Documents\Explicadordb.mdf;Integrated Security=True;Connect Timeout=30");


		/* try
		{
			if (txtNome.Text=="")
			{
				MessageBox.Show("Informação incompleta");
			}
			else
			{
				Con.Open();
				SqlCommand cmd = new SqlCommand("insert into UserTbl values(" + txtNome.Text + ",'" + txtApelido.Text+"')", Con);
				cmd.ExecuteNonQuery();
				Con.Close();
				MessageBox.Show("Dados actualizados");
				ecraPrincipal Mform = new ecraPrincipal();
				Mform.Show();
				this.Hide();
			}
		}
		catch(Exception ex)
		{
			MessageBox.Show("Algo aconteceu!"+ex.Message);
		} */






		private void loginBt_Click(object sender, EventArgs e)
		{
			OleDbCommand comando = null;
			OleDbConnection conexao = conectar();
			try
			{
				conexao.Open();
				string sqlInsert = "insert into usuario(nomedousuario, classe, disciplinafav, escola, dataDeNascimento) values(?,?,?,?,?)";
				comando = new OleDbCommand(sqlInsert, conexao); 
				
				comando.Parameters.Add(new OleDbParameter("nomedousuario", txtNome.Text));       
				comando.Parameters.Add(new OleDbParameter("classe", cbClasse.SelectedItem.ToString()));
				comando.Parameters.Add(new OleDbParameter("disciplinafav",cbDisciplina.SelectedItem.ToString()));
				comando.Parameters.Add(new OleDbParameter("escola", txtEscola.Text));
				comando.Parameters.Add(new OleDbParameter("dataDeNascimento", dateTimeNascimento.Text)); 
				comando.ExecuteNonQuery();
				MessageBox.Show("CADASTRO DO USUARIO EFECTUADO COM SUCESSO");
				ecraPrincipal Mform = new ecraPrincipal();
				Mform.Show();
				this.Hide(); 
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERRO DE CADASTRO DO USUARIO " + ex.Message);
			}
			finally
			{
				conexao.Close();
				
			}
		}
	}
}
