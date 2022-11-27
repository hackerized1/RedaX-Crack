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
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class frm_kelimeler : Form
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00091E88 File Offset: 0x00090288
		public frm_kelimeler()
		{
			base.Load += this.frm_kelimeler_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0009298C File Offset: 0x00090D8C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000929A0 File Offset: 0x00090DA0
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000929AC File Offset: 0x00090DAC
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000929C0 File Offset: 0x00090DC0
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000929CC File Offset: 0x00090DCC
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000929E0 File Offset: 0x00090DE0
		internal virtual CheckBox chk_dil_bilgisi
		{
			get
			{
				return this._chk_dil_bilgisi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chk_dil_bilgisi = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000929EC File Offset: 0x00090DEC
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00092A00 File Offset: 0x00090E00
		internal virtual TextBox txt_esanlami
		{
			get
			{
				return this._txt_esanlami;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_esanlami = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00092A0C File Offset: 0x00090E0C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00092A20 File Offset: 0x00090E20
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00092A2C File Offset: 0x00090E2C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00092A40 File Offset: 0x00090E40
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00092A4C File Offset: 0x00090E4C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00092A60 File Offset: 0x00090E60
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00092AAC File Offset: 0x00090EAC
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00092AC0 File Offset: 0x00090EC0
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00092ACC File Offset: 0x00090ECC
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00092AE0 File Offset: 0x00090EE0
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00092B2C File Offset: 0x00090F2C
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00092B40 File Offset: 0x00090F40
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00092B4C File Offset: 0x00090F4C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00092B60 File Offset: 0x00090F60
		internal virtual ComboBox cmb_tur
		{
			get
			{
				return this._cmb_tur;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmb_tur_SelectedIndexChanged);
				if (this._cmb_tur != null)
				{
					this._cmb_tur.SelectedIndexChanged -= value2;
				}
				this._cmb_tur = value;
				if (this._cmb_tur != null)
				{
					this._cmb_tur.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00092BAC File Offset: 0x00090FAC
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00092BC0 File Offset: 0x00090FC0
		internal virtual TextBox txt_tur_id
		{
			get
			{
				return this._txt_tur_id;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tur_id = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00092BCC File Offset: 0x00090FCC
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00092BE0 File Offset: 0x00090FE0
		internal virtual ListView ListView1
		{
			get
			{
				return this._ListView1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.ListView1_MouseDoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.ListView1_KeyDown);
				EventHandler value4 = new EventHandler(this.ListView1_SelectedIndexChanged);
				if (this._ListView1 != null)
				{
					this._ListView1.MouseDoubleClick -= value2;
					this._ListView1.KeyDown -= value3;
					this._ListView1.SelectedIndexChanged -= value4;
				}
				this._ListView1 = value;
				if (this._ListView1 != null)
				{
					this._ListView1.MouseDoubleClick += value2;
					this._ListView1.KeyDown += value3;
					this._ListView1.SelectedIndexChanged += value4;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00092C78 File Offset: 0x00091078
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00092C8C File Offset: 0x0009108C
		internal virtual ColumnHeader kelime
		{
			get
			{
				return this._kelime;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._kelime = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00092C98 File Offset: 0x00091098
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00092CAC File Offset: 0x000910AC
		internal virtual ColumnHeader es_anlami
		{
			get
			{
				return this._es_anlami;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._es_anlami = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00092CB8 File Offset: 0x000910B8
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00092CCC File Offset: 0x000910CC
		internal virtual ColumnHeader turu
		{
			get
			{
				return this._turu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._turu = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00092CD8 File Offset: 0x000910D8
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00092CEC File Offset: 0x000910EC
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00092CF8 File Offset: 0x000910F8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00092D0C File Offset: 0x0009110C
		internal virtual TextBox txt_ara
		{
			get
			{
				return this._txt_ara;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ara_LostFocus);
				EventHandler value3 = new EventHandler(this.txt_ara_GotFocus);
				EventHandler value4 = new EventHandler(this.txt_ara_TextChanged);
				if (this._txt_ara != null)
				{
					this._txt_ara.LostFocus -= value2;
					this._txt_ara.GotFocus -= value3;
					this._txt_ara.TextChanged -= value4;
				}
				this._txt_ara = value;
				if (this._txt_ara != null)
				{
					this._txt_ara.LostFocus += value2;
					this._txt_ara.GotFocus += value3;
					this._txt_ara.TextChanged += value4;
				}
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00092DA4 File Offset: 0x000911A4
		private void frm_kelimeler_Load(object sender, EventArgs e)
		{
			this.TurListesi();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00092DB0 File Offset: 0x000911B0
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Button1.Text, "Ekle", false) == 0)
			{
				this.KelimeEkle();
			}
			else
			{
				this.KelimeKaydet();
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00092DDC File Offset: 0x000911DC
		private void KelimeEkle()
		{
			if (Operators.CompareString(this.txt_kelime.Text, "", false) == 0 | Operators.CompareString(this.txt_esanlami.Text, "", false) == 0)
			{
				Interaction.MsgBox("Boş değer girilemez!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			string[] array = Strings.Split(this.txt_kelime.Text, " ", -1, CompareMethod.Binary);
			checked
			{
				int value = Information.UBound(array, 1) + 1;
				GenelModul.Cmd.CommandText = string.Concat(new string[]
				{
					"insert into esanlamlilar (kelime,kelime_es_anlami,kelime_adet,kelime_uzunluk,kelime_tur) values ('",
					GenelModul.StringTemizle(this.txt_kelime.Text),
					"','",
					GenelModul.StringTemizle(this.txt_esanlami.Text),
					"',",
					Conversions.ToString(value),
					",",
					Conversions.ToString(Strings.Len(this.txt_kelime.Text)),
					",",
					this.txt_tur_id.Text,
					")"
				});
				GenelModul.Cmd.ExecuteNonQuery();
				if (this.chk_dil_bilgisi.CheckState == CheckState.Unchecked)
				{
					array = Strings.Split(this.txt_esanlami.Text, " ", -1, CompareMethod.Binary);
					value = Information.UBound(array, 1) + 1;
					GenelModul.Cmd.CommandText = string.Concat(new string[]
					{
						"insert into esanlamlilar (kelime,kelime_es_anlami,kelime_adet,kelime_uzunluk,kelime_tur) values ('",
						GenelModul.StringTemizle(this.txt_esanlami.Text),
						"','",
						GenelModul.StringTemizle(this.txt_kelime.Text),
						"',",
						Conversions.ToString(value),
						",",
						Conversions.ToString(Strings.Len(this.txt_esanlami.Text)),
						",",
						this.txt_tur_id.Text,
						")"
					});
					GenelModul.Cmd.ExecuteNonQuery();
				}
				this.KelimeListesi();
				this.txt_kelime.Text = "";
				this.txt_esanlami.Text = "";
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00093004 File Offset: 0x00091404
		private void KelimeKaydet()
		{
			if (Operators.CompareString(this.txt_kelime.Text, "", false) == 0 | Operators.CompareString(this.txt_esanlami.Text, "", false) == 0)
			{
				Interaction.MsgBox("Boş değer girilemez!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			string[] array = Strings.Split(this.txt_kelime.Text, " ", -1, CompareMethod.Binary);
			int value = checked(Information.UBound(array, 1) + 1);
			GenelModul.Cmd.CommandText = string.Concat(new string[]
			{
				"update esanlamlilar set kelime='",
				GenelModul.StringTemizle(this.txt_kelime.Text),
				"',kelime_es_anlami='",
				GenelModul.StringTemizle(this.txt_esanlami.Text),
				"',kelime_adet=",
				Conversions.ToString(value),
				",kelime_uzunluk=",
				Conversions.ToString(Strings.Len(this.txt_kelime.Text)),
				",kelime_tur=",
				this.txt_tur_id.Text,
				" where kelime_id=",
				this.txt_kelime_id.Text
			});
			GenelModul.Cmd.ExecuteNonQuery();
			this.KelimeListesi();
			this.txt_kelime.Text = "";
			this.txt_esanlami.Text = "";
			this.Button1.Text = "Ekle";
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00093170 File Offset: 0x00091570
		public object KelimeListesi()
		{
			this.ListView1.Items.Clear();
			GenelModul.Cmd.CommandText = "select *,(SELECT tur_adi from turler where tur_id=esanlamlilar.kelime_tur) as Tur from esanlamlilar where kelime like '" + this.Aranan + "%' order by kelime";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					NewLateBinding.LateCall(this.ListView1.Items, null, "Add", new object[]
					{
						RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime"])
					}, null, null, null, true);
					int num;
					NewLateBinding.LateCall(this.ListView1.Items[num].SubItems, null, "Add", new object[]
					{
						RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime_es_anlami"])
					}, null, null, null, true);
					if (Operators.CompareString(oleDbDataReader["Tur"].ToString(), "0", false) != 0 & Operators.CompareString(oleDbDataReader["Tur"].ToString(), "", false) != 0)
					{
						this.ListView1.Items[num].SubItems.Add(oleDbDataReader["Tur"].ToString());
					}
					else
					{
						this.ListView1.Items[num].SubItems.Add("Genel");
					}
					this.ListView1.Items[num].Tag = RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime_id"]);
					num++;
				}
				oleDbDataReader.Close();
				object result;
				return result;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00093304 File Offset: 0x00091704
		private void mnu_kelime_sil_Click(object sender, EventArgs e)
		{
			if (this.ListView1.SelectedItems.Count > 0 && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from esanlamlilar where kelime_id=", this.ListView1.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListView1.SelectedItems[0].Remove();
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00093388 File Offset: 0x00091788
		public object TurListesi()
		{
			this.cmb_tur.Items.Clear();
			this.cmb_tur.Items.Add("Genel");
			GenelModul.Cmd.CommandText = "select * from turler order by tur_adi";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				this.cmb_tur.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["tur_adi"]));
			}
			oleDbDataReader.Close();
			object result;
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00093408 File Offset: 0x00091808
		private void cmb_tur_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(this.cmb_tur.SelectedItem, "", false))
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from turler where tur_adi='", this.cmb_tur.SelectedItem), "'"));
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				try
				{
					this.txt_tur_id.Text = Conversions.ToString(oleDbDataReader["tur_id"]);
				}
				catch (Exception ex)
				{
					this.txt_tur_id.Text = Conversions.ToString(0);
				}
				oleDbDataReader.Close();
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000934C4 File Offset: 0x000918C4
		private void ListView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from esanlamlilar where kelime_id=", this.ListView1.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListView1.SelectedItems[0].Remove();
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00093540 File Offset: 0x00091940
		private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.ListView1.SelectedItems.Count > 0)
			{
				this.txt_kelime.Text = this.ListView1.SelectedItems[0].Text;
				this.txt_esanlami.Text = this.ListView1.SelectedItems[0].SubItems[1].Text;
				this.txt_kelime_id.Text = Conversions.ToString(this.ListView1.SelectedItems[0].Tag);
				this.cmb_tur.Text = this.ListView1.SelectedItems[0].SubItems[2].Text;
				this.chk_dil_bilgisi.Checked = true;
				GenelModul.Cmd.CommandText = "select * from turler where tur_adi='" + this.ListView1.SelectedItems[0].SubItems[2].Text + "'";
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				try
				{
					this.txt_tur_id.Text = Conversions.ToString(oleDbDataReader["tur_id"]);
				}
				catch (Exception ex)
				{
					this.txt_tur_id.Text = Conversions.ToString(0);
				}
				oleDbDataReader.Close();
				this.Button1.Text = "Kaydet";
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000936BC File Offset: 0x00091ABC
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000936C0 File Offset: 0x00091AC0
		private void txt_ara_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Kelimelerde Ara", false) == 0)
			{
				this.txt_ara.Text = "";
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00093708 File Offset: 0x00091B08
		private void txt_ara_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "", false) == 0 | Operators.CompareString(this.txt_ara.Text, "Kelimelerde Ara", false) == 0)
			{
				this.txt_ara.Text = "Kelimelerde Ara";
				this.txt_ara.ForeColor = Color.Gray;
			}
			else
			{
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0009377C File Offset: 0x00091B7C
		private void txt_ara_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Kelimelerde Ara", false) != 0)
			{
				this.Aranan = GenelModul.StringTemizle(this.txt_ara.Text);
				if (Strings.Len(this.Aranan) > 1)
				{
					this.KelimeListesi();
				}
			}
		}

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("txt_kelime")]
		private TextBox _txt_kelime;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("chk_dil_bilgisi")]
		private CheckBox _chk_dil_bilgisi;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("txt_esanlami")]
		private TextBox _txt_esanlami;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("mnu_kelime_sil")]
		private ToolStripMenuItem _mnu_kelime_sil;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("cmb_tur")]
		private ComboBox _cmb_tur;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("txt_tur_id")]
		private TextBox _txt_tur_id;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;

		// Token: 0x0400009E RID: 158
		[AccessedThroughProperty("kelime")]
		private ColumnHeader _kelime;

		// Token: 0x0400009F RID: 159
		[AccessedThroughProperty("es_anlami")]
		private ColumnHeader _es_anlami;

		// Token: 0x040000A0 RID: 160
		[AccessedThroughProperty("turu")]
		private ColumnHeader _turu;

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("txt_kelime_id")]
		private TextBox _txt_kelime_id;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("txt_ara")]
		private TextBox _txt_ara;

		// Token: 0x040000A3 RID: 163
		private string Aranan;
	}
}
