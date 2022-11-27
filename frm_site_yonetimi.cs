using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CookComputing.XmlRpc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RedaX
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class frm_site_yonetimi : Form
	{
		// Token: 0x06000209 RID: 521 RVA: 0x00096284 File Offset: 0x00094684
		public frm_site_yonetimi()
		{
			base.Load += this.frm_site_yonetimi_Load;
			this.Kategoriler = new string[1001];
			this.InitializeComponent();
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00096E20 File Offset: 0x00095220
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00096E34 File Offset: 0x00095234
		internal virtual ColumnHeader site
		{
			get
			{
				return this._site;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._site = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00096E40 File Offset: 0x00095240
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00096E54 File Offset: 0x00095254
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00096EA0 File Offset: 0x000952A0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00096EB4 File Offset: 0x000952B4
		internal virtual TextBox txt_site_id
		{
			get
			{
				return this._txt_site_id;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_site_id = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00096EC0 File Offset: 0x000952C0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00096ED4 File Offset: 0x000952D4
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00096EE0 File Offset: 0x000952E0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00096EF4 File Offset: 0x000952F4
		internal virtual TextBox txt_site_url
		{
			get
			{
				return this._txt_site_url;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_site_url_GotFocus);
				EventHandler value3 = new EventHandler(this.txt_site_url_TextChanged);
				EventHandler value4 = new EventHandler(this.txt_site_url_LostFocus);
				LayoutEventHandler value5 = new LayoutEventHandler(this.txt_site_url_Layout);
				if (this._txt_site_url != null)
				{
					this._txt_site_url.GotFocus -= value2;
					this._txt_site_url.TextChanged -= value3;
					this._txt_site_url.LostFocus -= value4;
					this._txt_site_url.Layout -= value5;
				}
				this._txt_site_url = value;
				if (this._txt_site_url != null)
				{
					this._txt_site_url.GotFocus += value2;
					this._txt_site_url.TextChanged += value3;
					this._txt_site_url.LostFocus += value4;
					this._txt_site_url.Layout += value5;
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00096FB0 File Offset: 0x000953B0
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00096FC4 File Offset: 0x000953C4
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00096FD0 File Offset: 0x000953D0
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00096FE4 File Offset: 0x000953E4
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00096FF0 File Offset: 0x000953F0
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00097004 File Offset: 0x00095404
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00097010 File Offset: 0x00095410
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00097024 File Offset: 0x00095424
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00097070 File Offset: 0x00095470
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00097084 File Offset: 0x00095484
		internal virtual ColumnHeader blog_url
		{
			get
			{
				return this._blog_url;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._blog_url = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00097090 File Offset: 0x00095490
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000970A4 File Offset: 0x000954A4
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0009713C File Offset: 0x0009553C
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00097150 File Offset: 0x00095550
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0009715C File Offset: 0x0009555C
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00097170 File Offset: 0x00095570
		internal virtual TextBox txt_blog_url
		{
			get
			{
				return this._txt_blog_url;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_blog_url_GotFocus);
				EventHandler value3 = new EventHandler(this.txt_blog_url_LostFocus);
				if (this._txt_blog_url != null)
				{
					this._txt_blog_url.GotFocus -= value2;
					this._txt_blog_url.LostFocus -= value3;
				}
				this._txt_blog_url = value;
				if (this._txt_blog_url != null)
				{
					this._txt_blog_url.GotFocus += value2;
					this._txt_blog_url.LostFocus += value3;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000971E0 File Offset: 0x000955E0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000971F4 File Offset: 0x000955F4
		internal virtual ListView lst_site
		{
			get
			{
				return this._lst_site;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lst_site_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.lst_site_ParentChanged);
				MouseEventHandler value4 = new MouseEventHandler(this.lst_site_MouseDoubleClick);
				if (this._lst_site != null)
				{
					this._lst_site.SelectedIndexChanged -= value2;
					this._lst_site.ParentChanged -= value3;
					this._lst_site.MouseDoubleClick -= value4;
				}
				this._lst_site = value;
				if (this._lst_site != null)
				{
					this._lst_site.SelectedIndexChanged += value2;
					this._lst_site.ParentChanged += value3;
					this._lst_site.MouseDoubleClick += value4;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0009728C File Offset: 0x0009568C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000972A0 File Offset: 0x000956A0
		internal virtual TextBox txt_sifre
		{
			get
			{
				return this._txt_sifre;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sifre = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000972AC File Offset: 0x000956AC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x000972C0 File Offset: 0x000956C0
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000972CC File Offset: 0x000956CC
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000972E0 File Offset: 0x000956E0
		internal virtual TextBox txt_kullanici
		{
			get
			{
				return this._txt_kullanici;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kullanici = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000972EC File Offset: 0x000956EC
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00097300 File Offset: 0x00095700
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

		// Token: 0x06000230 RID: 560 RVA: 0x0009730C File Offset: 0x0009570C
		private void frm_site_yonetimi_Load(object sender, EventArgs e)
		{
			this.WPListesi();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00097314 File Offset: 0x00095714
		private void WPListesi()
		{
			this.lst_site.Items.Clear();
			GenelModul.Cmd.CommandText = "select * from siteler where site_url like '" + this.Ara + "%'";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					this.lst_site.Items.Add(Conversions.ToString(oleDbDataReader["site_url"]), 0);
					int num;
					NewLateBinding.LateCall(this.lst_site.Items[num].SubItems, null, "Add", new object[]
					{
						RuntimeHelpers.GetObjectValue(oleDbDataReader["site_wordpress_url"])
					}, null, null, null, true);
					this.lst_site.Items[num].Tag = RuntimeHelpers.GetObjectValue(oleDbDataReader["site_id"]);
					num++;
				}
				oleDbDataReader.Close();
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00097400 File Offset: 0x00095800
		public bool SiteKontrol(string siteurl, string kullaniciadi, string sifre)
		{
			frm_site_yonetimi.IWP iwp = XmlRpcProxyGen.Create<frm_site_yonetimi.IWP>();
			iwp.Url = siteurl;
			bool result;
			try
			{
				string[] args = new string[]
				{
					siteurl,
					kullaniciadi,
					sifre
				};
				frm_site_yonetimi.category[] array = iwp.getCategories(args);
				frm_site_yonetimi.category[] array2 = array;
				int num = 0;
				if (num < array2.Length)
				{
					frm_site_yonetimi.category category = array2[num];
					result = true;
				}
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00097484 File Offset: 0x00095884
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(Strings.Mid(this.txt_blog_url.Text, 1, 7), "http://", false) != 0)
			{
				this.txt_blog_url.Text = "http://" + this.txt_blog_url.Text;
			}
			if (Operators.CompareString(Strings.Mid(this.txt_blog_url.Text, Strings.Len(this.txt_blog_url.Text), 1), "/", false) != 0)
			{
				this.txt_blog_url.Text = this.txt_blog_url.Text + "/";
			}
			if (this.SiteKontrol(this.txt_blog_url.Text + "xmlrpc.php", this.txt_kullanici.Text, this.txt_sifre.Text))
			{
				if (Operators.CompareString(this.Button1.Text, "Ekle", false) == 0)
				{
					this.SiteEkle();
				}
				else
				{
					this.SiteKaydet();
				}
			}
			else
			{
				Interaction.MsgBox("Girilen bilgiler geçersiz, Lütfen Wordpress yolu, kullanıcı adı ve şifresinin doğru olduğundan emin olun!", MsgBoxStyle.Critical, "Bilgiler Hatalı!");
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00097590 File Offset: 0x00095990
		private void SiteKaydet()
		{
			if (Operators.CompareString(this.txt_site_url.Text, "", false) == 0 | Operators.CompareString(this.txt_blog_url.Text, "", false) == 0 | Operators.CompareString(this.txt_kullanici.Text, "", false) == 0 | Operators.CompareString(this.txt_sifre.Text, "", false) == 0)
			{
				Interaction.MsgBox("Lütfen tüm alanları doldurunuz!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = string.Concat(new string[]
			{
				"update siteler set site_url='",
				GenelModul.StringTemizle(this.txt_site_url.Text),
				"',site_wordpress_url='",
				GenelModul.StringTemizle(this.txt_blog_url.Text),
				"',site_kullanici_adi='",
				GenelModul.StringTemizle(this.txt_kullanici.Text),
				"',site_sifre='",
				GenelModul.StringTemizle(this.txt_sifre.Text),
				"' where site_id=",
				this.txt_site_id.Text
			});
			GenelModul.Cmd.ExecuteNonQuery();
			this.AlanlariTemizile();
			this.WPListesi();
			this.Button1.Text = "Ekle";
			Interaction.MsgBox("Site başarılı bir şekilde doğrulamadan geçti ve kaydedildi!", MsgBoxStyle.MsgBoxRight, "Site Kaydedildi");
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000976F4 File Offset: 0x00095AF4
		private void SiteEkle()
		{
			if (Operators.CompareString(this.txt_site_url.Text, "", false) == 0 | Operators.CompareString(this.txt_blog_url.Text, "", false) == 0 | Operators.CompareString(this.txt_kullanici.Text, "", false) == 0 | Operators.CompareString(this.txt_sifre.Text, "", false) == 0)
			{
				Interaction.MsgBox("Lütfen tüm alanları doldurunuz!", (MsgBoxStyle)128, "Hata Oluştu");
				return;
			}
			GenelModul.Cmd.CommandText = string.Concat(new string[]
			{
				"insert into siteler (site_url,site_wordpress_url,site_kullanici_adi,site_sifre) values ('",
				GenelModul.StringTemizle(this.txt_site_url.Text),
				"','",
				GenelModul.StringTemizle(this.txt_blog_url.Text),
				"','",
				GenelModul.StringTemizle(this.txt_kullanici.Text),
				"','",
				GenelModul.StringTemizle(this.txt_sifre.Text),
				"')"
			});
			GenelModul.Cmd.ExecuteNonQuery();
			this.AlanlariTemizile();
			this.WPListesi();
			Interaction.MsgBox("Site başarılı bir şekilde doğrulamadan geçti ve kaydedildi!", MsgBoxStyle.MsgBoxRight, "Site Kaydedildi");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00097838 File Offset: 0x00095C38
		private void AlanlariTemizile()
		{
			this.txt_blog_url.Text = "";
			this.txt_kullanici.Text = "";
			this.txt_sifre.Text = "";
			this.txt_site_url.Text = "";
			this.txt_site_id.Text = "";
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00097898 File Offset: 0x00095C98
		private void lst_site_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.lst_site.Items.Count > 0 && this.lst_site.SelectedItems.Count > 0)
			{
				this.txt_blog_url.ForeColor = Color.Black;
				this.txt_site_url.ForeColor = Color.Black;
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("select * from siteler where site_id=", this.lst_site.SelectedItems[0].Tag));
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				this.txt_site_url.Text = Conversions.ToString(oleDbDataReader["site_url"]);
				this.txt_blog_url.Text = Conversions.ToString(oleDbDataReader["site_wordpress_url"]);
				this.txt_kullanici.Text = Conversions.ToString(oleDbDataReader["site_kullanici_adi"]);
				this.txt_sifre.Text = Conversions.ToString(oleDbDataReader["site_sifre"]);
				this.txt_site_id.Text = Conversions.ToString(oleDbDataReader["site_id"]);
				oleDbDataReader.Close();
				this.Button1.Text = "Kaydet";
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000979D0 File Offset: 0x00095DD0
		private void lst_site_ParentChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000979D4 File Offset: 0x00095DD4
		private void lst_site_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000979D8 File Offset: 0x00095DD8
		private void mnu_kelime_sil_Click(object sender, EventArgs e)
		{
			if (this.lst_site.SelectedItems.Count > 0 && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject("delete from siteler where site_id=", this.lst_site.SelectedItems[0].Tag));
				GenelModul.Cmd.ExecuteNonQuery();
				this.lst_site.SelectedItems[0].Remove();
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00097A5C File Offset: 0x00095E5C
		private void txt_blog_url_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_blog_url.Text, "http://www.orneksite.com/", false) == 0)
			{
				this.txt_blog_url.Text = "";
				this.txt_blog_url.ForeColor = Color.Black;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00097AA4 File Offset: 0x00095EA4
		private void txt_blog_url_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_blog_url.Text, "", false) == 0)
			{
				this.txt_blog_url.Text = "http://www.orneksite.com/";
				this.txt_blog_url.ForeColor = Color.Silver;
			}
			else
			{
				this.txt_blog_url.ForeColor = Color.Black;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00097AFC File Offset: 0x00095EFC
		private void txt_site_url_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_site_url.Text, "Örnek Site", false) == 0)
			{
				this.txt_site_url.Text = "";
				this.txt_site_url.ForeColor = Color.Black;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00097B44 File Offset: 0x00095F44
		private void txt_site_url_Layout(object sender, LayoutEventArgs e)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00097B48 File Offset: 0x00095F48
		private void txt_site_url_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_site_url.Text, "", false) == 0)
			{
				this.txt_site_url.Text = "Örnek Site";
				this.txt_site_url.ForeColor = Color.Silver;
			}
			else
			{
				this.txt_site_url.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00097BA0 File Offset: 0x00095FA0
		private void txt_ara_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Site Ara", false) == 0)
			{
				this.txt_ara.Text = "";
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00097BE8 File Offset: 0x00095FE8
		private void txt_ara_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "", false) == 0)
			{
				this.txt_ara.Text = "Site Ara";
				this.txt_ara.ForeColor = Color.Silver;
			}
			else
			{
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00097C40 File Offset: 0x00096040
		private void txt_ara_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Site Ara", false) != 0)
			{
				this.Ara = GenelModul.StringTemizle(this.txt_ara.Text);
				this.WPListesi();
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00097C78 File Offset: 0x00096078
		private void txt_site_url_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("site")]
		private ColumnHeader _site;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("mnu_kelime_sil")]
		private ToolStripMenuItem _mnu_kelime_sil;

		// Token: 0x040000E1 RID: 225
		[AccessedThroughProperty("txt_site_id")]
		private TextBox _txt_site_id;

		// Token: 0x040000E2 RID: 226
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("txt_site_url")]
		private TextBox _txt_site_url;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("blog_url")]
		private ColumnHeader _blog_url;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("txt_ara")]
		private TextBox _txt_ara;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("txt_blog_url")]
		private TextBox _txt_blog_url;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("lst_site")]
		private ListView _lst_site;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("txt_sifre")]
		private TextBox _txt_sifre;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("txt_kullanici")]
		private TextBox _txt_kullanici;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("ımageList1")]
		private ImageList _ımageList1;

		// Token: 0x040000F1 RID: 241
		private string[] Kategoriler;

		// Token: 0x040000F2 RID: 242
		public XmlRpcClientProtocol clientProtocol;

		// Token: 0x040000F3 RID: 243
		public frm_site_yonetimi.IgetCatList categories;

		// Token: 0x040000F4 RID: 244
		private string Ara;

		// Token: 0x02000018 RID: 24
		public struct category
		{
			// Token: 0x040000F5 RID: 245
			public object categoryId;

			// Token: 0x040000F6 RID: 246
			public object parentId;

			// Token: 0x040000F7 RID: 247
			public object description;

			// Token: 0x040000F8 RID: 248
			public object categoryName;

			// Token: 0x040000F9 RID: 249
			public object htmlUrl;

			// Token: 0x040000FA RID: 250
			public object rssUrl;
		}

		// Token: 0x02000019 RID: 25
		public interface IWP : IXmlRpcProxy
		{
			// Token: 0x06000244 RID: 580
			[XmlRpcMethod("wp.getCategories")]
			frm_site_yonetimi.category[] getCategories(string[] args);
		}

		// Token: 0x0200001A RID: 26
		public struct blogInfo
		{
			// Token: 0x040000FB RID: 251
			public string title;

			// Token: 0x040000FC RID: 252
			public string description;

			// Token: 0x040000FD RID: 253
			public string[] categories;

			// Token: 0x040000FE RID: 254
			public string mt_keywords;
		}

		// Token: 0x0200001B RID: 27
		public interface IgetCatList
		{
			// Token: 0x06000245 RID: 581
			[XmlRpcMethod("metaWeblog.newPost")]
			string NewPage(int blogId, string strUserName, string strPassword, frm_site_yonetimi.blogInfo content, int publish);
		}
	}
}
