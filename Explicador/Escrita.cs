using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace Explicador
{
	public partial class Leitura : Form
	{
		public Leitura()
		{
			InitializeComponent();
		}

		private void pdfButton_Click(object sender, EventArgs e)
		{
			
		}

		
	}
}
//QUANDO EU TIVER UMA VERSÃO DE WINDOWS QUE FUNCIONA
//
/* Word.Application word = new Word.Application();
word.Visible = true;
word.WindowState = Word.WdWindowState.wdWindowStateNormal;
Word.Document doc = word.Documents.Add();
Word.Paragraph paragraph;
paragraph = doc.Paragraphs.Add();
paragraph.Range.Text = richboxLendo.Text;
string classe = cbClasse.SelectedItem.ToString();
doc.SaveAs2(@"C:\Users\mauro\Documents\MATÉRIAS\" + classe + txtNome.Text + ".doc");
doc.Close();
word.Quit(); */


/*
 * txt FUNCIONOU
 * 13/03/21
 * Problema: Ao invés de BARRRA estava a usar outro tipo de formatação erro em cima
			try
			{
			string classe = cbClasse.SelectedItem.ToString();
				string name = txtNome.Text + "";
				string path = "C:\\Users\\mauro\\Documents\\MATÉRIAS\\"+classe+"\\"+name+".txt";

				string text = richboxLendo.Text+"";
				File.WriteAllText(path, text);
				MessageBox.Show("ENTROU");

			
			}
			catch (Exception wc)
			{
				MessageBox.Show("opa"+wc.Message);
			}
			*/