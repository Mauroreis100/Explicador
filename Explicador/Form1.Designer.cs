
namespace Explicador
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
			this.Myprogressbar = new Bunifu.Framework.UI.BunifuProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.MenuText;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Monument Extended Ultrabold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(144, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "EXplicador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(453, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Versão 1.0";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// bunifuProgressBar1
			// 
			this.bunifuProgressBar1.BackColor = System.Drawing.SystemColors.Highlight;
			this.bunifuProgressBar1.BorderRadius = 5;
			this.bunifuProgressBar1.Location = new System.Drawing.Point(2, 257);
			this.bunifuProgressBar1.MaximumValue = 100;
			this.bunifuProgressBar1.Name = "bunifuProgressBar1";
			this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
			this.bunifuProgressBar1.Size = new System.Drawing.Size(662, 10);
			this.bunifuProgressBar1.TabIndex = 2;
			this.bunifuProgressBar1.Value = 0;
			// 
			// Myprogressbar
			// 
			this.Myprogressbar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Myprogressbar.BorderRadius = 5;
			this.Myprogressbar.Location = new System.Drawing.Point(2, 257);
			this.Myprogressbar.MaximumValue = 100;
			this.Myprogressbar.Name = "Myprogressbar";
			this.Myprogressbar.ProgressColor = System.Drawing.Color.White;
			this.Myprogressbar.Size = new System.Drawing.Size(674, 10);
			this.Myprogressbar.TabIndex = 3;
			this.Myprogressbar.Value = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(664, 279);
			this.Controls.Add(this.Myprogressbar);
			this.Controls.Add(this.bunifuProgressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Chocolate;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
		private Bunifu.Framework.UI.BunifuProgressBar Myprogressbar;
	}
}

