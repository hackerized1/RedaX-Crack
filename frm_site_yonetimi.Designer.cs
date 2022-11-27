namespace RedaX
{
	// Token: 0x02000017 RID: 23
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_site_yonetimi : global::System.Windows.Forms.Form
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000962B8 File Offset: 0x000946B8
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

		// Token: 0x0600020B RID: 523 RVA: 0x000962F8 File Offset: 0x000946F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_site_yonetimi));
			this.site = new global::System.Windows.Forms.ColumnHeader();
			this.mnu_kelime_sil = new global::System.Windows.Forms.ToolStripMenuItem();
			this.txt_site_id = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txt_site_url = new global::System.Windows.Forms.TextBox();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.blog_url = new global::System.Windows.Forms.ColumnHeader();
			this.txt_ara = new global::System.Windows.Forms.TextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.txt_sifre = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txt_kullanici = new global::System.Windows.Forms.TextBox();
			this.txt_blog_url = new global::System.Windows.Forms.TextBox();
			this.lst_site = new global::System.Windows.Forms.ListView();
			this.ımageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.ContextMenuStrip1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.site.Text = "Site Adı";
			this.site.Width = 150;
			this.mnu_kelime_sil.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mnu_kelime_sil.Image");
			this.mnu_kelime_sil.Name = "mnu_kelime_sil";
			global::System.Windows.Forms.ToolStripItem mnu_kelime_sil = this.mnu_kelime_sil;
			global::System.Drawing.Size size = new global::System.Drawing.Size(86, 22);
			mnu_kelime_sil.Size = size;
			this.mnu_kelime_sil.Text = "Sil";
			this.txt_site_id.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_site_id = this.txt_site_id;
			global::System.Drawing.Point location = new global::System.Drawing.Point(351, 41);
			txt_site_id.Location = location;
			this.txt_site_id.Name = "txt_site_id";
			global::System.Windows.Forms.Control txt_site_id2 = this.txt_site_id;
			size = new global::System.Drawing.Size(75, 25);
			txt_site_id2.Size = size;
			this.txt_site_id.TabIndex = 17;
			this.txt_site_id.TabStop = false;
			this.txt_site_id.Text = "0";
			this.txt_site_id.Visible = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label = this.Label3;
			location = new global::System.Drawing.Point(10, 66);
			label.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label2 = this.Label3;
			size = new global::System.Drawing.Size(76, 13);
			label2.Size = size;
			this.Label3.TabIndex = 15;
			this.Label3.Text = "Kullanıcı Adı :";
			this.txt_site_url.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_site_url.ForeColor = global::System.Drawing.Color.Silver;
			global::System.Windows.Forms.Control txt_site_url = this.txt_site_url;
			location = new global::System.Drawing.Point(95, 8);
			txt_site_url.Location = location;
			this.txt_site_url.Name = "txt_site_url";
			global::System.Windows.Forms.Control txt_site_url2 = this.txt_site_url;
			size = new global::System.Drawing.Size(250, 25);
			txt_site_url2.Size = size;
			this.txt_site_url.TabIndex = 1;
			this.txt_site_url.Text = "Örnek Site";
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnu_kelime_sil
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(87, 26);
			contextMenuStrip.Size = size;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label3 = this.Label1;
			location = new global::System.Drawing.Point(10, 14);
			label3.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(52, 13);
			label4.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Site Adı :";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label5 = this.Label2;
			location = new global::System.Drawing.Point(10, 40);
			label5.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label6 = this.Label2;
			size = new global::System.Drawing.Size(48, 13);
			label6.Size = size;
			this.Label2.TabIndex = 6;
			this.Label2.Text = "WP Url :";
			this.Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(351, 8);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 27);
			button2.Size = size;
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Ekle";
			this.Button1.UseVisualStyleBackColor = true;
			this.blog_url.Text = "Wordpress Url";
			this.blog_url.Width = 250;
			this.txt_ara.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_ara.ForeColor = global::System.Drawing.Color.Gray;
			global::System.Windows.Forms.Control txt_ara = this.txt_ara;
			location = new global::System.Drawing.Point(6, 129);
			txt_ara.Location = location;
			this.txt_ara.Name = "txt_ara";
			global::System.Windows.Forms.Control txt_ara2 = this.txt_ara;
			size = new global::System.Drawing.Size(433, 25);
			txt_ara2.Size = size;
			this.txt_ara.TabIndex = 6;
			this.txt_ara.Text = "Site Ara";
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txt_sifre);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.txt_kullanici);
			this.Panel1.Controls.Add(this.txt_site_id);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txt_site_url);
			this.Panel1.Controls.Add(this.txt_blog_url);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Button1);
			global::System.Windows.Forms.Control panel = this.Panel1;
			location = new global::System.Drawing.Point(6, 8);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(433, 118);
			panel2.Size = size;
			this.Panel1.TabIndex = 19;
			this.txt_sifre.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_sifre = this.txt_sifre;
			location = new global::System.Drawing.Point(95, 86);
			txt_sifre.Location = location;
			this.txt_sifre.Name = "txt_sifre";
			this.txt_sifre.PasswordChar = '*';
			global::System.Windows.Forms.Control txt_sifre2 = this.txt_sifre;
			size = new global::System.Drawing.Size(146, 25);
			txt_sifre2.Size = size;
			this.txt_sifre.TabIndex = 4;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(10, 92);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(82, 13);
			label8.Size = size;
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Kullanıcı Şifre :";
			this.txt_kullanici.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kullanici = this.txt_kullanici;
			location = new global::System.Drawing.Point(95, 60);
			txt_kullanici.Location = location;
			this.txt_kullanici.Name = "txt_kullanici";
			global::System.Windows.Forms.Control txt_kullanici2 = this.txt_kullanici;
			size = new global::System.Drawing.Size(146, 25);
			txt_kullanici2.Size = size;
			this.txt_kullanici.TabIndex = 3;
			this.txt_blog_url.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_blog_url.ForeColor = global::System.Drawing.Color.Silver;
			global::System.Windows.Forms.Control txt_blog_url = this.txt_blog_url;
			location = new global::System.Drawing.Point(95, 34);
			txt_blog_url.Location = location;
			this.txt_blog_url.Name = "txt_blog_url";
			global::System.Windows.Forms.Control txt_blog_url2 = this.txt_blog_url;
			size = new global::System.Drawing.Size(250, 25);
			txt_blog_url2.Size = size;
			this.txt_blog_url.TabIndex = 2;
			this.txt_blog_url.Text = "http://www.orneksite.com/";
			this.lst_site.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.site,
				this.blog_url
			});
			this.lst_site.ContextMenuStrip = this.ContextMenuStrip1;
			this.lst_site.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.lst_site.FullRowSelect = true;
			this.lst_site.GridLines = true;
			this.lst_site.LargeImageList = this.ımageList1;
			global::System.Windows.Forms.Control lst_site = this.lst_site;
			location = new global::System.Drawing.Point(6, 156);
			lst_site.Location = location;
			this.lst_site.Name = "lst_site";
			global::System.Windows.Forms.Control lst_site2 = this.lst_site;
			size = new global::System.Drawing.Size(433, 162);
			lst_site2.Size = size;
			this.lst_site.SmallImageList = this.ımageList1;
			this.lst_site.TabIndex = 20;
			this.lst_site.UseCompatibleStateImageBehavior = false;
			this.lst_site.View = global::System.Windows.Forms.View.Details;
			this.ımageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ımageList1.ImageStream");
			this.ımageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "1379016101_wordpress.png");
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(446, 323);
			this.ClientSize = size;
			this.Controls.Add(this.txt_ara);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.lst_site);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_site_yonetimi";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Site Yönetimi";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000DE RID: 222
		private global::System.ComponentModel.IContainer components;
	}
}
