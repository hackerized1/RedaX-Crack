namespace RedaX
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_kelimeler : global::System.Windows.Forms.Form
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00091EAC File Offset: 0x000902AC
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

		// Token: 0x0600016F RID: 367 RVA: 0x00091EEC File Offset: 0x000902EC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_kelimeler));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.txt_kelime_id = new global::System.Windows.Forms.TextBox();
			this.txt_tur_id = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cmb_tur = new global::System.Windows.Forms.ComboBox();
			this.txt_kelime = new global::System.Windows.Forms.TextBox();
			this.chk_dil_bilgisi = new global::System.Windows.Forms.CheckBox();
			this.txt_esanlami = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnu_kelime_sil = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.kelime = new global::System.Windows.Forms.ColumnHeader();
			this.es_anlami = new global::System.Windows.Forms.ColumnHeader();
			this.turu = new global::System.Windows.Forms.ColumnHeader();
			this.txt_ara = new global::System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txt_kelime_id);
			this.Panel1.Controls.Add(this.txt_tur_id);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.cmb_tur);
			this.Panel1.Controls.Add(this.txt_kelime);
			this.Panel1.Controls.Add(this.chk_dil_bilgisi);
			this.Panel1.Controls.Add(this.txt_esanlami);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Button1);
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(4, 7);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(420, 95);
			panel2.Size = size;
			this.Panel1.TabIndex = 16;
			this.txt_kelime_id.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kelime_id = this.txt_kelime_id;
			location = new global::System.Drawing.Point(331, 36);
			txt_kelime_id.Location = location;
			this.txt_kelime_id.Name = "txt_kelime_id";
			global::System.Windows.Forms.Control txt_kelime_id2 = this.txt_kelime_id;
			size = new global::System.Drawing.Size(75, 25);
			txt_kelime_id2.Size = size;
			this.txt_kelime_id.TabIndex = 17;
			this.txt_kelime_id.Text = "0";
			this.txt_kelime_id.Visible = false;
			this.txt_tur_id.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_tur_id = this.txt_tur_id;
			location = new global::System.Drawing.Point(250, 36);
			txt_tur_id.Location = location;
			this.txt_tur_id.Name = "txt_tur_id";
			global::System.Windows.Forms.Control txt_tur_id2 = this.txt_tur_id;
			size = new global::System.Drawing.Size(75, 25);
			txt_tur_id2.Size = size;
			this.txt_tur_id.TabIndex = 16;
			this.txt_tur_id.Text = "0";
			this.txt_tur_id.Visible = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label = this.Label3;
			location = new global::System.Drawing.Point(9, 67);
			label.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label2 = this.Label3;
			size = new global::System.Drawing.Size(36, 13);
			label2.Size = size;
			this.Label3.TabIndex = 15;
			this.Label3.Text = "Türü :";
			this.cmb_tur.Font = new global::System.Drawing.Font("Segoe UI", 9.75f);
			this.cmb_tur.FormattingEnabled = true;
			global::System.Windows.Forms.Control cmb_tur = this.cmb_tur;
			location = new global::System.Drawing.Point(61, 61);
			cmb_tur.Location = location;
			this.cmb_tur.Name = "cmb_tur";
			global::System.Windows.Forms.Control cmb_tur2 = this.cmb_tur;
			size = new global::System.Drawing.Size(183, 25);
			cmb_tur2.Size = size;
			this.cmb_tur.TabIndex = 14;
			this.txt_kelime.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kelime = this.txt_kelime;
			location = new global::System.Drawing.Point(61, 8);
			txt_kelime.Location = location;
			this.txt_kelime.Name = "txt_kelime";
			global::System.Windows.Forms.Control txt_kelime2 = this.txt_kelime;
			size = new global::System.Drawing.Size(183, 25);
			txt_kelime2.Size = size;
			this.txt_kelime.TabIndex = 3;
			this.chk_dil_bilgisi.AutoSize = true;
			global::System.Windows.Forms.Control chk_dil_bilgisi = this.chk_dil_bilgisi;
			location = new global::System.Drawing.Point(250, 67);
			chk_dil_bilgisi.Location = location;
			this.chk_dil_bilgisi.Name = "chk_dil_bilgisi";
			global::System.Windows.Forms.Control chk_dil_bilgisi2 = this.chk_dil_bilgisi;
			size = new global::System.Drawing.Size(96, 17);
			chk_dil_bilgisi2.Size = size;
			this.chk_dil_bilgisi.TabIndex = 13;
			this.chk_dil_bilgisi.Text = "Tek taraflı ekle";
			this.chk_dil_bilgisi.UseVisualStyleBackColor = true;
			this.txt_esanlami.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_esanlami = this.txt_esanlami;
			location = new global::System.Drawing.Point(61, 34);
			txt_esanlami.Location = location;
			this.txt_esanlami.Name = "txt_esanlami";
			global::System.Windows.Forms.Control txt_esanlami2 = this.txt_esanlami;
			size = new global::System.Drawing.Size(183, 25);
			txt_esanlami2.Size = size;
			this.txt_esanlami.TabIndex = 4;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label3 = this.Label1;
			location = new global::System.Drawing.Point(9, 14);
			label3.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(46, 13);
			label4.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Kelime :";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label5 = this.Label2;
			location = new global::System.Drawing.Point(9, 40);
			label5.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label6 = this.Label2;
			size = new global::System.Drawing.Size(53, 13);
			label6.Size = size;
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Karşılığı :";
			this.Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(250, 8);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 27);
			button2.Size = size;
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Ekle";
			this.Button1.UseVisualStyleBackColor = true;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnu_kelime_sil
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(87, 26);
			contextMenuStrip.Size = size;
			this.mnu_kelime_sil.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mnu_kelime_sil.Image");
			this.mnu_kelime_sil.Name = "mnu_kelime_sil";
			global::System.Windows.Forms.ToolStripItem mnu_kelime_sil = this.mnu_kelime_sil;
			size = new global::System.Drawing.Size(86, 22);
			mnu_kelime_sil.Size = size;
			this.mnu_kelime_sil.Text = "Sil";
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.kelime,
				this.es_anlami,
				this.turu
			});
			this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
			this.ListView1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.ListView1.FullRowSelect = true;
			this.ListView1.GridLines = true;
			global::System.Windows.Forms.Control listView = this.ListView1;
			location = new global::System.Drawing.Point(4, 131);
			listView.Location = location;
			this.ListView1.Name = "ListView1";
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			size = new global::System.Drawing.Size(420, 167);
			listView2.Size = size;
			this.ListView1.TabIndex = 17;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.kelime.Text = "Kelime";
			this.kelime.Width = 130;
			this.es_anlami.Text = "Eşanlamı";
			this.es_anlami.Width = 120;
			this.turu.Text = "Türü";
			this.turu.Width = 140;
			this.txt_ara.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_ara.ForeColor = global::System.Drawing.Color.Gray;
			global::System.Windows.Forms.Control txt_ara = this.txt_ara;
			location = new global::System.Drawing.Point(4, 104);
			txt_ara.Location = location;
			this.txt_ara.Name = "txt_ara";
			global::System.Windows.Forms.Control txt_ara2 = this.txt_ara;
			size = new global::System.Drawing.Size(420, 25);
			txt_ara2.Size = size;
			this.txt_ara.TabIndex = 18;
			this.txt_ara.Text = "Kelimelerde Ara";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(427, 300);
			this.ClientSize = size;
			this.Controls.Add(this.txt_ara);
			this.Controls.Add(this.ListView1);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_kelimeler";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Değişim Tablosu";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;
	}
}
