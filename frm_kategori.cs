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
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class frm_kategori : Form
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00090ED0 File Offset: 0x0008F2D0
		public frm_kategori()
		{
			base.Load += this.frm_kategori_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0009164C File Offset: 0x0008FA4C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00091660 File Offset: 0x0008FA60
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000916F8 File Offset: 0x0008FAF8
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0009170C File Offset: 0x0008FB0C
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00091718 File Offset: 0x0008FB18
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0009172C File Offset: 0x0008FB2C
		internal virtual TextBox txt_kategori_id
		{
			get
			{
				return this._txt_kategori_id;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kategori_id = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00091738 File Offset: 0x0008FB38
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0009174C File Offset: 0x0008FB4C
		internal virtual TextBox txt_kategori
		{
			get
			{
				return this._txt_kategori;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_kategori_LostFocus);
				EventHandler value3 = new EventHandler(this.txt_site_url_GotFocus);
				if (this._txt_kategori != null)
				{
					this._txt_kategori.LostFocus -= value2;
					this._txt_kategori.GotFocus -= value3;
				}
				this._txt_kategori = value;
				if (this._txt_kategori != null)
				{
					this._txt_kategori.LostFocus += value2;
					this._txt_kategori.GotFocus += value3;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000917BC File Offset: 0x0008FBBC
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000917D0 File Offset: 0x0008FBD0
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000917DC File Offset: 0x0008FBDC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000917F0 File Offset: 0x0008FBF0
		internal virtual Button btn_kaydet
		{
			get
			{
				return this._btn_kaydet;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_kaydet_Click);
				if (this._btn_kaydet != null)
				{
					this._btn_kaydet.Click -= value2;
				}
				this._btn_kaydet = value;
				if (this._btn_kaydet != null)
				{
					this._btn_kaydet.Click += value2;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0009183C File Offset: 0x0008FC3C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00091850 File Offset: 0x0008FC50
		internal virtual ListView lst_kategori
		{
			get
			{
				return this._lst_kategori;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lst_kategori_DoubleClick);
				if (this._lst_kategori != null)
				{
					this._lst_kategori.DoubleClick -= value2;
				}
				this._lst_kategori = value;
				if (this._lst_kategori != null)
				{
					this._lst_kategori.DoubleClick += value2;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0009189C File Offset: 0x0008FC9C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000918B0 File Offset: 0x0008FCB0
		internal virtual ColumnHeader kategori
		{
			get
			{
				return this._kategori;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._kategori = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000918BC File Offset: 0x0008FCBC
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000918D0 File Offset: 0x0008FCD0
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000918DC File Offset: 0x0008FCDC
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000918F0 File Offset: 0x0008FCF0
		internal virtual ToolStripMenuItem mnu_sil
		{
			get
			{
				return this._mnu_sil;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_sil_Click);
				if (this._mnu_sil != null)
				{
					this._mnu_sil.Click -= value2;
				}
				this._mnu_sil = value;
				if (this._mnu_sil != null)
				{
					this._mnu_sil.Click += value2;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0009193C File Offset: 0x0008FD3C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00091950 File Offset: 0x0008FD50
		internal virtual ImageList ımageList1
		{
			get
			{
				return this._ımageList1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ımageList1 = value;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0009195C File Offset: 0x0008FD5C
		private void frm_kategori_Load(object sender, EventArgs e)
		{
			this.TurListesi();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00091964 File Offset: 0x0008FD64
		private void TurListesi()
		{
			this.lst_kategori.Items.Clear();
			GenelModul.Cmd.CommandText = "select * from turler where tur_adi like '" + this.Ara + "%' order by tur_adi";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					this.lst_kategori.Items.Add(Conversions.ToString(oleDbDataReader["tur_adi"]), 0);
					int num;
					this.lst_kategori.Items[num].Tag = RuntimeHelpers.GetObjectValue(oleDbDataReader["tur_id"]);
					num++;
				}
				oleDbDataReader.Close();
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00091A08 File Offset: 0x0008FE08
		private void btn_kaydet_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.btn_kaydet.Text, "Ekle", false) == 0)
			{
				this.KategoriEkle();
			}
			else
			{
				this.KategoriKaydet();
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00091A34 File Offset: 0x0008FE34
		private void txt_site_url_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_kategori.Text, "Kategori Adı", false) == 0)
			{
				this.txt_kategori.Text = "";
				this.txt_kategori.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00091A7C File Offset: 0x0008FE7C
		private void txt_kategori_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_kategori.Text, "", false) == 0)
			{
				this.txt_kategori.Text = "Kategori Adı";
				this.txt_kategori.ForeColor = Color.Silver;
			}
			else
			{
				this.txt_kategori.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00091AD4 File Offset: 0x0008FED4
		private void txt_ara_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Kategori Ara", false) == 0)
			{
				this.txt_ara.Text = "";
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00091B1C File Offset: 0x0008FF1C
		private void txt_ara_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "", false) == 0)
			{
				this.txt_ara.Text = "Kategori Ara";
				this.txt_ara.ForeColor = Color.Silver;
			}
			else
			{
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00091B74 File Offset: 0x0008FF74
		private void txt_ara_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Kategori Ara", false) != 0)
			{
				this.Ara = GenelModul.StringTemizle(this.txt_ara.Text);
				this.TurListesi();
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00091BAC File Offset: 0x0008FFAC
		private void mnu_sil_Click(object sender, EventArgs e)
		{
			if (this.lst_kategori.SelectedItems.Count > 0 && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from turler where tur_id=", this.lst_kategori.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.lst_kategori.SelectedItems[0].Remove();
				this.txt_kategori.Text = "";
				this.btn_kaydet.Text = "Ekle";
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00091C54 File Offset: 0x00090054
		private void KategoriEkle()
		{
			if (Operators.CompareString(this.txt_kategori.Text, "", false) == 0 | Operators.CompareString(this.txt_kategori.Text, "Kategori Adı", false) == 0)
			{
				Interaction.MsgBox("Lütfen tüm alanları doldurunuz!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = "insert into turler (tur_adi) values ('" + GenelModul.StringTemizle(this.txt_kategori.Text) + "')";
			GenelModul.Cmd.ExecuteNonQuery();
			this.txt_kategori.Text = "";
			this.txt_kategori_id.Text = Conversions.ToString(0);
			this.TurListesi();
			Interaction.MsgBox("Kategori başarılı bir şekilde kaydedildi!", MsgBoxStyle.MsgBoxRight, "Kategori Kaydedildi");
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00091D1C File Offset: 0x0009011C
		private void KategoriKaydet()
		{
			if (Operators.CompareString(this.txt_kategori.Text, "", false) == 0 | Operators.CompareString(this.txt_kategori.Text, "Kategori Adı", false) == 0)
			{
				Interaction.MsgBox("Lütfen tüm alanları doldurunuz!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = "update turler set tur_adi='" + GenelModul.StringTemizle(this.txt_kategori.Text) + "' where tur_id=" + this.txt_kategori_id.Text;
			GenelModul.Cmd.ExecuteNonQuery();
			this.txt_kategori.Text = "";
			this.txt_kategori_id.Text = Conversions.ToString(0);
			this.TurListesi();
			this.btn_kaydet.Text = "Ekle";
			Interaction.MsgBox("Kategori başarılı bir şekilde kaydedildi!", MsgBoxStyle.MsgBoxRight, "Kategori Kaydedildi");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00091E00 File Offset: 0x00090200
		private void lst_kategori_DoubleClick(object sender, EventArgs e)
		{
			if (this.lst_kategori.SelectedItems.Count > 0)
			{
				this.txt_kategori_id.Text = Conversions.ToString(this.lst_kategori.SelectedItems[0].Tag);
				this.txt_kategori.Text = this.lst_kategori.SelectedItems[0].Text;
				this.txt_kategori.ForeColor = Color.Black;
				this.btn_kaydet.Text = "Kaydet";
			}
		}

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("txt_ara")]
		private TextBox _txt_ara;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("txt_kategori_id")]
		private TextBox _txt_kategori_id;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("txt_kategori")]
		private TextBox _txt_kategori;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("btn_kaydet")]
		private Button _btn_kaydet;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("lst_kategori")]
		private ListView _lst_kategori;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("kategori")]
		private ColumnHeader _kategori;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("mnu_sil")]
		private ToolStripMenuItem _mnu_sil;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("ımageList1")]
		private ImageList _ımageList1;

		// Token: 0x0400008F RID: 143
		private string Ara;
	}
}
