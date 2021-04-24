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

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.Redo();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richboxLendo.SelectAll();
		}

	

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();
			richboxLendo.SelectionFont = fontDialog1.Font;
		}

		private void corToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			richboxLendo.SelectionColor = colorDialog1.Color;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Word.Application word = new Word.Application();
			word.Visible = true;
			string name = txtNome.Text + "";
			word.WindowState = Word.WdWindowState.wdWindowStateNormal;
			Word.Document doc = word.Documents.Add();
			Word.Paragraph paragraph;

			paragraph = doc.Paragraphs.Add();
			paragraph.Range.Text = richboxLendo.Text;
			string classe = cbClasse.SelectedItem.ToString();
			doc.SaveAs2("C:\\Users\\mauro\\Documents\\MATÉRIAS\\" + classe + "\\" + name + ".doc");
			doc.Close();
			word.Quit();
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