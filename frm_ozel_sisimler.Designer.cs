namespace RedaX
{
	// Token: 0x02000016 RID: 22
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_ozel_sisimler : global::System.Windows.Forms.Form
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x0009543C File Offset: 0x0009383C
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

		// Token: 0x060001E8 RID: 488 RVA: 0x0009547C File Offset: 0x0009387C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_ozel_sisimler));
			this.txt_ara = new global::System.Windows.Forms.TextBox();
			this.txt_kelime_id = new global::System.Windows.Forms.TextBox();
			this.txt_kelime = new global::System.Windows.Forms.TextBox();
			this.isim = new global::System.Windows.Forms.ColumnHeader();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.mnu_kelime_sil = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.Panel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.txt_ara.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.txt_ara.ForeColor = global::System.Drawing.Color.Gray;
			global::System.Windows.Forms.Control txt_ara = this.txt_ara;
			global::System.Drawing.Point location = new global::System.Drawing.Point(3, 52);
			txt_ara.Location = location;
			this.txt_ara.Name = "txt_ara";
			global::System.Windows.Forms.Control txt_ara2 = this.txt_ara;
			global::System.Drawing.Size size = new global::System.Drawing.Size(420, 25);
			txt_ara2.Size = size;
			this.txt_ara.TabIndex = 21;
			this.txt_ara.Text = "İsimlerde Ara";
			this.txt_kelime_id.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kelime_id = this.txt_kelime_id;
			location = new global::System.Drawing.Point(331, 10);
			txt_kelime_id.Location = location;
			this.txt_kelime_id.Name = "txt_kelime_id";
			global::System.Windows.Forms.Control txt_kelime_id2 = this.txt_kelime_id;
			size = new global::System.Drawing.Size(75, 25);
			txt_kelime_id2.Size = size;
			this.txt_kelime_id.TabIndex = 17;
			this.txt_kelime_id.Text = "0";
			this.txt_kelime_id.Visible = false;
			this.txt_kelime.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control txt_kelime = this.txt_kelime;
			location = new global::System.Drawing.Point(95, 8);
			txt_kelime.Location = location;
			this.txt_kelime.Name = "txt_kelime";
			global::System.Windows.Forms.Control txt_kelime2 = this.txt_kelime;
			size = new global::System.Drawing.Size(149, 25);
			txt_kelime2.Size = size;
			this.txt_kelime.TabIndex = 3;
			this.isim.Text = "İsim";
			this.isim.Width = 380;
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txt_kelime_id);
			this.Panel1.Controls.Add(this.txt_kelime);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Button1);
			global::System.Windows.Forms.Control panel = this.Panel1;
			location = new global::System.Drawing.Point(3, 5);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(420, 45);
			panel2.Size = size;
			this.Panel1.TabIndex = 19;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(9, 14);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(59, 13);
			label2.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Özel İsim :";
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
			this.mnu_kelime_sil.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mnu_kelime_sil.Image");
			this.mnu_kelime_sil.Name = "mnu_kelime_sil";
			global::System.Windows.Forms.ToolStripItem mnu_kelime_sil = this.mnu_kelime_sil;
			size = new global::System.Drawing.Size(152, 22);
			mnu_kelime_sil.Size = size;
			this.mnu_kelime_sil.Text = "Sil";
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnu_kelime_sil
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(153, 48);
			contextMenuStrip.Size = size;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.isim
			});
			this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
			this.ListView1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.ListView1.FullRowSelect = true;
			this.ListView1.GridLines = true;
			global::System.Windows.Forms.Control listView = this.ListView1;
			location = new global::System.Drawing.Point(3, 79);
			listView.Location = location;
			this.ListView1.Name = "ListView1";
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			size = new global::System.Drawing.Size(420, 167);
			listView2.Size = size;
			this.ListView1.TabIndex = 20;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(427, 251);
			this.ClientSize = size;
			this.Controls.Add(this.txt_ara);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ListView1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_ozel_sisimler";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Özel İsimler";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000D2 RID: 210
		private global::System.ComponentModel.IContainer components;
	}
}
