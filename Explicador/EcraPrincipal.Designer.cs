
namespace Explicador
{
	partial class ecraPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ecraPrincipal));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbClasse = new System.Windows.Forms.ComboBox();
			this.searchBT = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbVoltar = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.materiasLB = new System.Windows.Forms.Label();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.materiaNova = new System.Windows.Forms.Label();
			this.cbDisciplina = new System.Windows.Forms.ComboBox();
			this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox1.Controls.Add(this.axAcroPDF1);
			this.groupBox1.Controls.Add(this.cbDisciplina);
			this.groupBox1.Controls.Add(this.cbClasse);
			this.groupBox1.Controls.Add(this.searchBT);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// cbClasse
			// 
			this.cbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbClasse.FormattingEnabled = true;
			this.cbClasse.Items.AddRange(new object[] {
            resources.GetString("cbClasse.Items"),
            resources.GetString("cbClasse.Items1"),
            resources.GetString("cbClasse.Items2"),
            resources.GetString("cbClasse.Items3"),
            resources.GetString("cbClasse.Items4"),
            resources.GetString("cbClasse.Items5"),
            resources.GetString("cbClasse.Items6"),
            resources.GetString("cbClasse.Items7"),
            resources.GetString("cbClasse.Items8"),
            resources.GetString("cbClasse.Items9"),
            resources.GetString("cbClasse.Items10"),
            resources.GetString("cbClasse.Items11")});
			resources.ApplyResources(this.cbClasse, "cbClasse");
			this.cbClasse.Name = "cbClasse";
			// 
			// searchBT
			// 
			resources.ApplyResources(this.searchBT, "searchBT");
			this.searchBT.Name = "searchBT";
			this.searchBT.UseVisualStyleBackColor = true;
			this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.splitContainer1);
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lbVoltar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			// 
			// lbVoltar
			// 
			resources.ApplyResources(this.lbVoltar, "lbVoltar");
			this.lbVoltar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbVoltar.Name = "lbVoltar";
			this.lbVoltar.Click += new System.EventHandler(this.lbVoltar_Click);
			// 
			// splitContainer2
			// 
			resources.ApplyResources(this.splitContainer2, "splitContainer2");
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.materiasLB);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			// 
			// materiasLB
			// 
			resources.ApplyResources(this.materiasLB, "materiasLB");
			this.materiasLB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.materiasLB.Name = "materiasLB";
			this.materiasLB.Click += new System.EventHandler(this.materiasLB_Click);
			// 
			// splitContainer3
			// 
			resources.ApplyResources(this.splitContainer3, "splitContainer3");
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.materiaNova);
			// 
			// materiaNova
			// 
			resources.ApplyResources(this.materiaNova, "materiaNova");
			this.materiaNova.Name = "materiaNova";
			this.materiaNova.Click += new System.EventHandler(this.materiaNova_Click);
			// 
			// cbDisciplina
			// 
			this.cbDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbDisciplina.FormattingEnabled = true;
			this.cbDisciplina.Items.AddRange(new object[] {
            resources.GetString("cbDisciplina.Items"),
            resources.GetString("cbDisciplina.Items1"),
            resources.GetString("cbDisciplina.Items2"),
            resources.GetString("cbDisciplina.Items3"),
            resources.GetString("cbDisciplina.Items4"),
            resources.GetString("cbDisciplina.Items5"),
            resources.GetString("cbDisciplina.Items6"),
            resources.GetString("cbDisciplina.Items7"),
            resources.GetString("cbDisciplina.Items8"),
            resources.GetString("cbDisciplina.Items9"),
            resources.GetString("cbDisciplina.Items10"),
            resources.GetString("cbDisciplina.Items11")});
			resources.ApplyResources(this.cbDisciplina, "cbDisciplina");
			this.cbDisciplina.Name = "cbDisciplina";
			// 
			// axAcroPDF1
			// 
			resources.ApplyResources(this.axAcroPDF1, "axAcroPDF1");
			this.axAcroPDF1.Name = "axAcroPDF1";
			this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
			// 
			// ecraPrincipal
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Name = "ecraPrincipal";
			this.Load += new System.EventHandler(this.ecraPrincipal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbVoltar;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label materiasLB;
		private System.Windows.Forms.Button searchBT;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Label materiaNova;
		private System.Windows.Forms.ComboBox cbClasse;
		private System.Windows.Forms.ComboBox cbDisciplina;
		private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
	}
}