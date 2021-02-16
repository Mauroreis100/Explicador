
namespace Explicador
{
	partial class Cadastrar
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
			this.txtEscola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txtApelido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.dateTimeNascimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbDisciplina = new System.Windows.Forms.ComboBox();
			this.cbClasse = new System.Windows.Forms.ComboBox();
			this.loginBt = new System.Windows.Forms.Button();
			this.saltarBt = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtEscola
			// 
			this.txtEscola.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtEscola.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEscola.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtEscola.ForeColor = System.Drawing.Color.White;
			this.txtEscola.HintForeColor = System.Drawing.Color.White;
			this.txtEscola.HintText = "";
			this.txtEscola.isPassword = false;
			this.txtEscola.LineFocusedColor = System.Drawing.Color.Blue;
			this.txtEscola.LineIdleColor = System.Drawing.Color.Black;
			this.txtEscola.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txtEscola.LineThickness = 3;
			this.txtEscola.Location = new System.Drawing.Point(76, 115);
			this.txtEscola.Margin = new System.Windows.Forms.Padding(4);
			this.txtEscola.Name = "txtEscola";
			this.txtEscola.Size = new System.Drawing.Size(235, 33);
			this.txtEscola.TabIndex = 6;
			this.txtEscola.Text = "Escola (Opcional)";
			this.txtEscola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txtApelido
			// 
			this.txtApelido.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtApelido.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtApelido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtApelido.ForeColor = System.Drawing.Color.White;
			this.txtApelido.HintForeColor = System.Drawing.Color.White;
			this.txtApelido.HintText = "";
			this.txtApelido.isPassword = false;
			this.txtApelido.LineFocusedColor = System.Drawing.Color.Blue;
			this.txtApelido.LineIdleColor = System.Drawing.Color.Black;
			this.txtApelido.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txtApelido.LineThickness = 3;
			this.txtApelido.Location = new System.Drawing.Point(76, 74);
			this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
			this.txtApelido.Name = "txtApelido";
			this.txtApelido.Size = new System.Drawing.Size(235, 33);
			this.txtApelido.TabIndex = 8;
			this.txtApelido.Text = "Apelido";
			this.txtApelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// dateTimeNascimento
			// 
			this.dateTimeNascimento.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.dateTimeNascimento.CheckedState.Parent = this.dateTimeNascimento;
			this.dateTimeNascimento.FillColor = System.Drawing.SystemColors.MenuHighlight;
			this.dateTimeNascimento.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dateTimeNascimento.HoverState.Parent = this.dateTimeNascimento;
			this.dateTimeNascimento.Location = new System.Drawing.Point(80, 156);
			this.dateTimeNascimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimeNascimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimeNascimento.Name = "dateTimeNascimento";
			this.dateTimeNascimento.ShadowDecoration.Parent = this.dateTimeNascimento;
			this.dateTimeNascimento.Size = new System.Drawing.Size(231, 36);
			this.dateTimeNascimento.TabIndex = 9;
			this.dateTimeNascimento.Value = new System.DateTime(2021, 2, 9, 15, 39, 41, 649);
			// 
			// cbDisciplina
			// 
			this.cbDisciplina.BackColor = System.Drawing.Color.Blue;
			this.cbDisciplina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDisciplina.ForeColor = System.Drawing.SystemColors.Info;
			this.cbDisciplina.FormattingEnabled = true;
			this.cbDisciplina.Items.AddRange(new object[] {
            "Matemática",
            "Biologia",
            "Ciências Naturais",
            "Ciências Sociais",
            "Desenho",
            "Filosofia",
            "Fisíca",
            "Geografia",
            "História",
            "Português",
            "Quimísca",
            "TICs"});
			this.cbDisciplina.Location = new System.Drawing.Point(80, 268);
			this.cbDisciplina.Name = "cbDisciplina";
			this.cbDisciplina.Size = new System.Drawing.Size(231, 25);
			this.cbDisciplina.TabIndex = 10;
			this.cbDisciplina.Text = "Disciplina Favorita";
			// 
			// cbClasse
			// 
			this.cbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.cbClasse.BackColor = System.Drawing.Color.Blue;
			this.cbClasse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbClasse.ForeColor = System.Drawing.SystemColors.Window;
			this.cbClasse.FormattingEnabled = true;
			this.cbClasse.Items.AddRange(new object[] {
            "1ª Classe",
            "2ª Classe",
            "3ª Classe",
            "4ª Classe",
            "5ª Classe",
            "6ª Classe",
            "7ª Classe",
            "8ª Classe",
            "9ª Classe",
            "10ª Classe",
            "11ª Classe",
            "12ª Classe"});
			this.cbClasse.Location = new System.Drawing.Point(80, 215);
			this.cbClasse.Name = "cbClasse";
			this.cbClasse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbClasse.Size = new System.Drawing.Size(231, 25);
			this.cbClasse.TabIndex = 11;
			this.cbClasse.Text = "Classe";
			// 
			// loginBt
			// 
			this.loginBt.BackColor = System.Drawing.Color.Black;
			this.loginBt.FlatAppearance.BorderSize = 0;
			this.loginBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.loginBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBt.ForeColor = System.Drawing.Color.White;
			this.loginBt.Location = new System.Drawing.Point(213, 330);
			this.loginBt.Name = "loginBt";
			this.loginBt.Size = new System.Drawing.Size(192, 43);
			this.loginBt.TabIndex = 14;
			this.loginBt.Text = "Avançar";
			this.loginBt.UseVisualStyleBackColor = false;
			this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
			// 
			// saltarBt
			// 
			this.saltarBt.BackColor = System.Drawing.Color.Black;
			this.saltarBt.FlatAppearance.BorderSize = 0;
			this.saltarBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saltarBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saltarBt.ForeColor = System.Drawing.Color.White;
			this.saltarBt.Location = new System.Drawing.Point(16, 330);
			this.saltarBt.Name = "saltarBt";
			this.saltarBt.Size = new System.Drawing.Size(192, 43);
			this.saltarBt.TabIndex = 15;
			this.saltarBt.Text = "Saltar";
			this.saltarBt.UseVisualStyleBackColor = false;
			this.saltarBt.Click += new System.EventHandler(this.saltarBt_Click);
			// 
			// exit
			// 
			this.exit.AutoSize = true;
			this.exit.BackColor = System.Drawing.SystemColors.MenuText;
			this.exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.Location = new System.Drawing.Point(379, -1);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(40, 39);
			this.exit.TabIndex = 16;
			this.exit.Text = "X";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(80, 31);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(220, 20);
			this.txtNome.TabIndex = 17;
			// 
			// Cadastrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(417, 385);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.saltarBt);
			this.Controls.Add(this.loginBt);
			this.Controls.Add(this.cbClasse);
			this.Controls.Add(this.cbDisciplina);
			this.Controls.Add(this.dateTimeNascimento);
			this.Controls.Add(this.txtApelido);
			this.Controls.Add(this.txtEscola);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Cadastrar";
			this.Text = "Cadastrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtEscola;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtApelido;
		private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeNascimento;
		private System.Windows.Forms.ComboBox cbDisciplina;
		private System.Windows.Forms.ComboBox cbClasse;
		private System.Windows.Forms.Button loginBt;
		private System.Windows.Forms.Button saltarBt;
		private System.Windows.Forms.Label exit;
		private System.Windows.Forms.TextBox txtNome;
	}
}