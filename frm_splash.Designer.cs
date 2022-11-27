namespace RedaX
{
	// Token: 0x0200001C RID: 28
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_splash : global::System.Windows.Forms.Form
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00097CA0 File Offset: 0x000960A0
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00097CE0 File Offset: 0x000960E0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_splash));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.txt_info = new global::System.Windows.Forms.TextBox();
			this.lbl_app_name = new global::System.Windows.Forms.Label();
			this.lbl_versiyon = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.btn_kapat = new global::System.Windows.Forms.Button();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(3, 5);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(63, 60);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.txt_info.BackColor = global::System.Drawing.Color.DarkSlateGray;
			this.txt_info.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txt_info.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.txt_info.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_info.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control txt_info = this.txt_info;
			location = new global::System.Drawing.Point(12, 88);
			txt_info.Location = location;
			this.txt_info.Multiline = true;
			this.txt_info.Name = "txt_info";
			this.txt_info.ReadOnly = true;
			global::System.Windows.Forms.Control txt_info2 = this.txt_info;
			size = new global::System.Drawing.Size(421, 39);
			txt_info2.Size = size;
			this.txt_info.TabIndex = 1;
			this.txt_info.TabStop = false;
			this.txt_info.Text = "Programın tüm hakları Edis Teknoloji'ye aittir ve tamamı ya da herhangi bir parçası izinsiz olarak çoğaltılamaz ya da satılamaz.";
			this.lbl_app_name.AutoSize = true;
			this.lbl_app_name.Font = new global::System.Drawing.Font("Arial Narrow", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.lbl_app_name.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control lbl_app_name = this.lbl_app_name;
			location = new global::System.Drawing.Point(71, 9);
			lbl_app_name.Location = location;
			this.lbl_app_name.Name = "lbl_app_name";
			global::System.Windows.Forms.Control lbl_app_name2 = this.lbl_app_name;
			size = new global::System.Drawing.Size(49, 20);
			lbl_app_name2.Size = size;
			this.lbl_app_name.TabIndex = 2;
			this.lbl_app_name.Text = "Label1";
			this.lbl_versiyon.AutoSize = true;
			this.lbl_versiyon.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.lbl_versiyon.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control lbl_versiyon = this.lbl_versiyon;
			location = new global::System.Drawing.Point(72, 30);
			lbl_versiyon.Location = location;
			this.lbl_versiyon.Name = "lbl_versiyon";
			global::System.Windows.Forms.Control lbl_versiyon2 = this.lbl_versiyon;
			size = new global::System.Drawing.Size(56, 16);
			lbl_versiyon2.Size = size;
			this.lbl_versiyon.TabIndex = 3;
			this.lbl_versiyon.Text = "Versiyon :";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Label1.ForeColor = global::System.Drawing.Color.DimGray;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(72, 47);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(126, 16);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Lisans : Kontrol ediliyor...";
			this.Panel1.BackColor = global::System.Drawing.Color.Gainsboro;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.lbl_app_name);
			this.Panel1.Controls.Add(this.lbl_versiyon);
			global::System.Windows.Forms.Control panel = this.Panel1;
			location = new global::System.Drawing.Point(0, 0);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(446, 70);
			panel2.Size = size;
			this.Panel1.TabIndex = 5;
			this.TextBox1.BackColor = global::System.Drawing.Color.DarkSlateGray;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.TextBox1.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(12, 195);
			textBox.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(320, 21);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 6;
			this.TextBox1.TabStop = false;
			this.TextBox1.Text = "© 2013 Edis Teknoloji.";
			this.TextBox2.BackColor = global::System.Drawing.Color.DarkSlateGray;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextBox2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.TextBox2.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.TextBox2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			location = new global::System.Drawing.Point(12, 212);
			textBox3.Location = location;
			this.TextBox2.Multiline = true;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.ReadOnly = true;
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(320, 21);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 7;
			this.TextBox2.TabStop = false;
			this.TextBox2.Text = "Tüm hakları saklıdır.";
			global::System.Windows.Forms.Control btn_kapat = this.btn_kapat;
			location = new global::System.Drawing.Point(338, 202);
			btn_kapat.Location = location;
			this.btn_kapat.Name = "btn_kapat";
			global::System.Windows.Forms.Control btn_kapat2 = this.btn_kapat;
			size = new global::System.Drawing.Size(87, 28);
			btn_kapat2.Size = size;
			this.btn_kapat.TabIndex = 8;
			this.btn_kapat.Text = "Kapat";
			this.btn_kapat.UseVisualStyleBackColor = true;
			this.btn_kapat.Visible = false;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new global::System.Drawing.Point(15, 162);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(409, 23);
			progressBar2.Size = size;
			this.ProgressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.ProgressBar1.TabIndex = 9;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkSlateGray;
			size = new global::System.Drawing.Size(437, 241);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.btn_kapat);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.txt_info);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_splash";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_splash";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000FF RID: 255
		private global::System.ComponentModel.IContainer components;
	}
}
