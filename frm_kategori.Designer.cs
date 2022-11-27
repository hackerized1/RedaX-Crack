namespace RedaX
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_kategori : global::System.Windows.Forms.Form
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00090EF4 File Offset: 0x0008F2F4
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

		// Token: 0x0600014A RID: 330 RVA: 0x00090F34 File Offset: 0x0008F334
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_kategori));
			this.txt_ara = new global::System.Windows.Forms.TextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.txt_kategori_id = new global::System.Windows.Forms.TextBox();
			this.txt_kategori = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.btn_kaydet = new global::System.Windows.Forms.Button();
			this.lst_kategori = new global::System.Windows.Forms.ListView();
			this.kategori = new global::System.Windows.Forms.ColumnHeader();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnu_sil = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ımageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Panel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.txt_ara.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_ara.ForeColor = global::System.Drawing.Color.Gray;
			global::System.Windows.Forms.Control txt_ara = this.txt_ara;
			global::System.Drawing.Point location = new global::System.Drawing.Point(4, 52);
			txt_ara.Location = location;
			this.txt_ara.Name = "txt_ara";
			global::System.Windows.Forms.Control txt_ara2 = this.txt_ara;
			global::System.Drawing.Size size = new global::System.Drawing.Size(433, 25);
			txt_ara2.Size = size;
			this.txt_ara.TabIndex = 21;
			this.txt_ara.Text = "Kategori Ara";
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txt_kategori_id);
			this.Panel1.Controls.Add(this.txt_kategori);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.btn_kaydet);
			global::System.Windows.Forms.Control panel = this.Panel1;
			location = new global::System.Drawing.Point(4, 6);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(433, 43);
			panel2.Size = size;
			this.Panel1.TabIndex = 22;
			this.txt_kategori_id.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kategori_id = this.txt_kategori_id;
			location = new global::System.Drawing.Point(351, 41);
			txt_kategori_id.Location = location;
			this.txt_kategori_id.Name = "txt_kategori_id";
			global::System.Windows.Forms.Control txt_kategori_id2 = this.txt_kategori_id;
			size = new global::System.Drawing.Size(75, 25);
			txt_kategori_id2.Size = size;
			this.txt_kategori_id.TabIndex = 17;
			this.txt_kategori_id.TabStop = false;
			this.txt_kategori_id.Text = "0";
			this.txt_kategori_id.Visible = false;
			this.txt_kategori.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_kategori.ForeColor = global::System.Drawing.Color.Silver;
			global::System.Windows.Forms.Control txt_kategori = this.txt_kategori;
			location = new global::System.Drawing.Point(95, 8);
			txt_kategori.Location = location;
			this.txt_kategori.Name = "txt_kategori";
			global::System.Windows.Forms.Control txt_kategori2 = this.txt_kategori;
			size = new global::System.Drawing.Size(250, 25);
			txt_kategori2.Size = size;
			this.txt_kategori.TabIndex = 1;
			this.txt_kategori.Text = "Kategori Adı";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(10, 14);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(76, 13);
			label2.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Kategori Adı :";
			this.btn_kaydet.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control btn_kaydet = this.btn_kaydet;
			location = new global::System.Drawing.Point(351, 8);
			btn_kaydet.Location = location;
			this.btn_kaydet.Name = "btn_kaydet";
			global::System.Windows.Forms.Control btn_kaydet2 = this.btn_kaydet;
			size = new global::System.Drawing.Size(75, 27);
			btn_kaydet2.Size = size;
			this.btn_kaydet.TabIndex = 5;
			this.btn_kaydet.Text = "Ekle";
			this.btn_kaydet.UseVisualStyleBackColor = true;
			this.lst_kategori.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.kategori
			});
			this.lst_kategori.ContextMenuStrip = this.ContextMenuStrip1;
			this.lst_kategori.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.lst_kategori.FullRowSelect = true;
			this.lst_kategori.GridLines = true;
			this.lst_kategori.LargeImageList = this.ımageList1;
			global::System.Windows.Forms.Control lst_kategori = this.lst_kategori;
			location = new global::System.Drawing.Point(4, 79);
			lst_kategori.Location = location;
			this.lst_kategori.Name = "lst_kategori";
			global::System.Windows.Forms.Control lst_kategori2 = this.lst_kategori;
			size = new global::System.Drawing.Size(433, 162);
			lst_kategori2.Size = size;
			this.lst_kategori.SmallImageList = this.ımageList1;
			this.lst_kategori.TabIndex = 23;
			this.lst_kategori.UseCompatibleStateImageBehavior = false;
			this.lst_kategori.View = global::System.Windows.Forms.View.Details;
			this.kategori.Text = "Kategori Adı";
			this.kategori.Width = 400;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnu_sil
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(87, 26);
			contextMenuStrip.Size = size;
			this.mnu_sil.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mnu_sil.Image");
			this.mnu_sil.Name = "mnu_sil";
			global::System.Windows.Forms.ToolStripItem mnu_sil = this.mnu_sil;
			size = new global::System.Drawing.Size(86, 22);
			mnu_sil.Size = size;
			this.mnu_sil.Text = "Sil";
			this.ımageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ımageList1.ImageStream");
			this.ımageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "1379422740_category.png");
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(441, 245);
			this.ClientSize = size;
			this.Controls.Add(this.txt_ara);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.lst_kategori);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_kategori";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategoriler";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000083 RID: 131
		private global::System.ComponentModel.IContainer components;
	}
}
