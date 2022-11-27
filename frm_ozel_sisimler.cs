using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RedaX
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class frm_ozel_sisimler : Form
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00095418 File Offset: 0x00093818
		public frm_ozel_sisimler()
		{
			base.Load += this.frm_ozel_sisimler_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00095AFC File Offset: 0x00093EFC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00095B10 File Offset: 0x00093F10
		internal virtual TextBox txt_ara
		{
			get
			{
				return this._txt_ara;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ara_GotFocus);
				EventHandler value3 = new EventHandler(this.txt_ara_TextChanged);
				EventHandler value4 = new EventHandler(this.txt_ara_LostFocus);
				if (this._txt_ara != null)
				{
					this._txt_ara.GotFocus -= value2;
					this._txt_ara.TextChanged -= value3;
					this._txt_ara.LostFocus -= value4;
				}
				this._txt_ara = value;
				if (this._txt_ara != null)
				{
					this._txt_ara.GotFocus += value2;
					this._txt_ara.TextChanged += value3;
					this._txt_ara.LostFocus += value4;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00095BA8 File Offset: 0x00093FA8
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00095BBC File Offset: 0x00093FBC
		internal virtual TextBox txt_kelime_id
		{
			get
			{
				return this._txt_kelime_id;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kelime_id = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00095BC8 File Offset: 0x00093FC8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00095BDC File Offset: 0x00093FDC
		internal virtual TextBox txt_kelime
		{
			get
			{
				return this._txt_kelime;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kelime = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00095BE8 File Offset: 0x00093FE8
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00095BFC File Offset: 0x00093FFC
		internal virtual ColumnHeader isim
		{
			get
			{
				return this._isim;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isim = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00095C08 File Offset: 0x00094008
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00095C1C File Offset: 0x0009401C
		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00095C28 File Offset: 0x00094028
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00095C3C File Offset: 0x0009403C
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00095C48 File Offset: 0x00094048
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00095C5C File Offset: 0x0009405C
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00095CA8 File Offset: 0x000940A8
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00095CBC File Offset: 0x000940BC
		internal virtual ToolStripMenuItem mnu_kelime_sil
		{
			get
			{
				return this._mnu_kelime_sil;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_kelime_sil_Click);
				if (this._mnu_kelime_sil != null)
				{
					this._mnu_kelime_sil.Click -= value2;
				}
				this._mnu_kelime_sil = value;
				if (this._mnu_kelime_sil != null)
				{
					this._mnu_kelime_sil.Click += value2;
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00095D08 File Offset: 0x00094108
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00095D1C File Offset: 0x0009411C
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this._ContextMenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00095D28 File Offset: 0x00094128
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00095D3C File Offset: 0x0009413C
		internal virtual ListView ListView1
		{
			get
			{
				return this._ListView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListView1_SelectedIndexChanged);
				MouseEventHandler value3 = new MouseEventHandler(this.ListView1_MouseDoubleClick);
				KeyEventHandler value4 = new KeyEventHandler(this.ListView1_KeyDown);
				if (this._ListView1 != null)
				{
					this._ListView1.SelectedIndexChanged -= value2;
					this._ListView1.MouseDoubleClick -= value3;
					this._ListView1.KeyDown -= value4;
				}
				this._ListView1 = value;
				if (this._ListView1 != null)
				{
					this._ListView1.SelectedIndexChanged += value2;
					this._ListView1.MouseDoubleClick += value3;
					this._ListView1.KeyDown += value4;
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00095DD4 File Offset: 0x000941D4
		private void frm_ozel_sisimler_Load(object sender, EventArgs e)
		{
			this.IsimListesi();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00095DE0 File Offset: 0x000941E0
		public object IsimListesi()
		{
			this.ListView1.Items.Clear();
			GenelModul.Cmd.CommandText = "select * from ozelisimler where ozelisim like '" + this.Aranan + "%' order by ozelisim";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					this.ListView1.Items.Add(Strings.StrConv(Conversions.ToString(oleDbDataReader["ozelisim"]), VbStrConv.ProperCase, 0));
					int num;
					this.ListView1.Items[num].Tag = RuntimeHelpers.GetObjectValue(oleDbDataReader["ozelisim_id"]);
					num++;
				}
				oleDbDataReader.Close();
				object result;
				return result;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00095E8C File Offset: 0x0009428C
		private void txt_ara_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "İsimlerde Ara", false) == 0)
			{
				this.txt_ara.Text = "";
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00095ED4 File Offset: 0x000942D4
		private void txt_ara_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "", false) == 0 | Operators.CompareString(this.txt_ara.Text, "İsimlerde Ara", false) == 0)
			{
				this.txt_ara.Text = "İsimlerde Ara";
				this.txt_ara.ForeColor = Color.Gray;
			}
			else
			{
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00095F48 File Offset: 0x00094348
		private void IsimEkle()
		{
			if (Operators.CompareString(this.txt_kelime.Text, "", false) == 0)
			{
				Interaction.MsgBox("Boş değer girilemez!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = "insert into ozelisimler (ozelisim) values ('" + Strings.LCase(GenelModul.StringTemizle(this.txt_kelime.Text)) + "')";
			GenelModul.Cmd.ExecuteNonQuery();
			this.IsimListesi();
			this.txt_kelime.Text = "";
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00095FD4 File Offset: 0x000943D4
		private void IsimKaydet()
		{
			if (Operators.CompareString(this.txt_kelime.Text, "", false) == 0)
			{
				Interaction.MsgBox("Boş değer girilemez!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = "update ozelisimler set ozelisim='" + Strings.LCase(GenelModul.StringTemizle(this.txt_kelime.Text)) + "' where kelime_id=" + this.txt_kelime_id.Text;
			GenelModul.Cmd.ExecuteNonQuery();
			this.IsimListesi();
			this.txt_kelime.Text = "";
			this.Button1.Text = "Ekle";
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0009607C File Offset: 0x0009447C
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Button1.Text, "Ekle", false) == 0)
			{
				this.IsimEkle();
			}
			else
			{
				this.IsimKaydet();
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000960A8 File Offset: 0x000944A8
		private void ListView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from ozelisimler where ozelisim_id=", this.ListView1.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListView1.Items.Remove(this.ListView1.SelectedItems[0]);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00096130 File Offset: 0x00094530
		private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.ListView1.SelectedItems.Count > 0)
			{
				this.txt_kelime.Text = this.ListView1.SelectedItems[0].Text;
				this.txt_kelime_id.Text = Conversions.ToString(this.ListView1.SelectedItems[0].Tag);
				this.Button1.Text = "Kaydet";
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000961A8 File Offset: 0x000945A8
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000961AC File Offset: 0x000945AC
		private void txt_ara_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "İsimlerde Ara", false) != 0)
			{
				this.Aranan = GenelModul.StringTemizle(this.txt_ara.Text);
				if (Strings.Len(this.Aranan) > 1)
				{
					this.IsimListesi();
				}
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00096200 File Offset: 0x00094600
		private void mnu_kelime_sil_Click(object sender, EventArgs e)
		{
			if (this.ListView1.SelectedItems.Count > 0 && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from ozelisimler where ozelisim_id=", this.ListView1.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListView1.SelectedItems[0].Remove();
			}
		}

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("txt_ara")]
		private TextBox _txt_ara;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("txt_kelime_id")]
		private TextBox _txt_kelime_id;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("txt_kelime")]
		private TextBox _txt_kelime;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("isim")]
		private ColumnHeader _isim;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("mnu_kelime_sil")]
		private ToolStripMenuItem _mnu_kelime_sil;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;

		// Token: 0x040000DD RID: 221
		private string Aranan;
	}
}
