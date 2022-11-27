namespace RedaX
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_makale_gonder : global::System.Windows.Forms.Form
	{
		// Token: 0x060001BD RID: 445 RVA: 0x00094328 File Offset: 0x00092728
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

		// Token: 0x060001BE RID: 446 RVA: 0x00094368 File Offset: 0x00092768
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_makale_gonder));
			this.txtTitle = new global::System.Windows.Forms.TextBox();
			this.btnPost = new global::System.Windows.Forms.Button();
			this.cmb_site = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cmb_kategori = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txt_etiketler = new global::System.Windows.Forms.TextBox();
			this.btn_iptal = new global::System.Windows.Forms.Button();
			this.chk_taslak = new global::System.Windows.Forms.CheckBox();
			this.txtpost = new global::System.Windows.Forms.RichTextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.txtTitle.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txtTitle = this.txtTitle;
			global::System.Drawing.Point location = new global::System.Drawing.Point(5, 76);
			txtTitle.Location = location;
			this.txtTitle.Name = "txtTitle";
			global::System.Windows.Forms.Control txtTitle2 = this.txtTitle;
			global::System.Drawing.Size size = new global::System.Drawing.Size(585, 25);
			txtTitle2.Size = size;
			this.txtTitle.TabIndex = 0;
			this.btnPost.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.btnPost.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnPost.Image");
			this.btnPost.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			global::System.Windows.Forms.Control btnPost = this.btnPost;
			location = new global::System.Drawing.Point(169, 395);
			btnPost.Location = location;
			this.btnPost.Name = "btnPost";
			global::System.Windows.Forms.Control btnPost2 = this.btnPost;
			size = new global::System.Drawing.Size(123, 36);
			btnPost2.Size = size;
			this.btnPost.TabIndex = 2;
			this.btnPost.Text = "Gönder";
			this.btnPost.UseVisualStyleBackColor = true;
			this.cmb_site.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.cmb_site.FormattingEnabled = true;
			global::System.Windows.Forms.Control cmb_site = this.cmb_site;
			location = new global::System.Drawing.Point(5, 24);
			cmb_site.Location = location;
			this.cmb_site.Name = "cmb_site";
			global::System.Windows.Forms.Control cmb_site2 = this.cmb_site;
			size = new global::System.Drawing.Size(284, 25);
			cmb_site2.Size = size;
			this.cmb_site.TabIndex = 5;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(2, 4);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(107, 17);
			label2.Size = size;
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Wordpress Site :";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(2, 56);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(49, 17);
			label4.Size = size;
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Başlık :";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(2, 104);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(47, 17);
			label6.Size = size;
			this.Label3.TabIndex = 8;
			this.Label3.Text = "İçerik :";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(295, 4);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(66, 17);
			label8.Size = size;
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Kategori :";
			this.cmb_kategori.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.cmb_kategori.FormattingEnabled = true;
			global::System.Windows.Forms.Control cmb_kategori = this.cmb_kategori;
			location = new global::System.Drawing.Point(298, 24);
			cmb_kategori.Location = location;
			this.cmb_kategori.Name = "cmb_kategori";
			global::System.Windows.Forms.Control cmb_kategori2 = this.cmb_kategori;
			size = new global::System.Drawing.Size(292, 25);
			cmb_kategori2.Size = size;
			this.cmb_kategori.TabIndex = 9;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label9 = this.Label5;
			location = new global::System.Drawing.Point(1, 346);
			label9.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label10 = this.Label5;
			size = new global::System.Drawing.Size(64, 17);
			label10.Size = size;
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Etiketler :";
			this.txt_etiketler.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_etiketler = this.txt_etiketler;
			location = new global::System.Drawing.Point(4, 366);
			txt_etiketler.Location = location;
			this.txt_etiketler.Name = "txt_etiketler";
			global::System.Windows.Forms.Control txt_etiketler2 = this.txt_etiketler;
			size = new global::System.Drawing.Size(585, 25);
			txt_etiketler2.Size = size;
			this.txt_etiketler.TabIndex = 11;
			this.btn_iptal.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.btn_iptal.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btn_iptal.Image");
			this.btn_iptal.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			global::System.Windows.Forms.Control btn_iptal = this.btn_iptal;
			location = new global::System.Drawing.Point(298, 395);
			btn_iptal.Location = location;
			this.btn_iptal.Name = "btn_iptal";
			global::System.Windows.Forms.Control btn_iptal2 = this.btn_iptal;
			size = new global::System.Drawing.Size(123, 36);
			btn_iptal2.Size = size;
			this.btn_iptal.TabIndex = 13;
			this.btn_iptal.Text = "İptal";
			this.btn_iptal.UseVisualStyleBackColor = true;
			this.chk_taslak.AutoSize = true;
			this.chk_taslak.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control chk_taslak = this.chk_taslak;
			location = new global::System.Drawing.Point(5, 322);
			chk_taslak.Location = location;
			this.chk_taslak.Name = "chk_taslak";
			global::System.Windows.Forms.Control chk_taslak2 = this.chk_taslak;
			size = new global::System.Drawing.Size(149, 21);
			chk_taslak2.Size = size;
			this.chk_taslak.TabIndex = 14;
			this.chk_taslak.Text = "Taslak Olarak Kaydet";
			this.chk_taslak.UseVisualStyleBackColor = true;
			this.txtpost.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtpost.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txtpost = this.txtpost;
			location = new global::System.Drawing.Point(5, 4);
			txtpost.Location = location;
			this.txtpost.Name = "txtpost";
			global::System.Windows.Forms.Control txtpost2 = this.txtpost;
			size = new global::System.Drawing.Size(576, 185);
			txtpost2.Size = size;
			this.txtpost.TabIndex = 15;
			this.txtpost.Text = "";
			this.Panel1.BackColor = global::System.Drawing.Color.White;
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txtpost);
			global::System.Windows.Forms.Control panel = this.Panel1;
			location = new global::System.Drawing.Point(5, 124);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(584, 192);
			panel2.Size = size;
			this.Panel1.TabIndex = 16;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(594, 435);
			this.ClientSize = size;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.chk_taslak);
			this.Controls.Add(this.btn_iptal);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.txt_etiketler);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cmb_kategori);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmb_site);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.txtTitle);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_makale_gonder";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wordpress Gönderi";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000AF RID: 175
		private global::System.ComponentModel.IContainer components;
	}
}
