
namespace Explicador
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.btStart = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Label();
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
			this.label1.Location = new System.Drawing.Point(102, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(374, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "EXplicador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btStart
			// 
			this.btStart.BackColor = System.Drawing.Color.Black;
			this.btStart.FlatAppearance.BorderSize = 0;
			this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btStart.ForeColor = System.Drawing.Color.White;
			this.btStart.Location = new System.Drawing.Point(164, 168);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(235, 53);
			this.btStart.TabIndex = 4;
			this.btStart.Text = "Começar";
			this.btStart.UseVisualStyleBackColor = false;
			this.btStart.Click += new System.EventHandler(this.loginBt_Click);
			// 
			// exit
			// 
			this.exit.AutoSize = true;
			this.exit.BackColor = System.Drawing.SystemColors.MenuText;
			this.exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.Location = new System.Drawing.Point(535, -1);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(40, 39);
			this.exit.TabIndex = 8;
			this.exit.Text = "X";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(574, 279);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Label exit;
	}
}