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
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class frm_makale_gonder : Form
	{
		// Token: 0x060001BC RID: 444 RVA: 0x000942F4 File Offset: 0x000926F4
		public frm_makale_gonder()
		{
			base.Load += this.frm_makale_gonder_Load;
			this.Kategoriler = new string[1001];
			this.InitializeComponent();
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00094D3C File Offset: 0x0009313C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00094D50 File Offset: 0x00093150
		internal virtual TextBox txtTitle
		{
			get
			{
				return this._txtTitle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTitle = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00094D5C File Offset: 0x0009315C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00094D70 File Offset: 0x00093170
		internal virtual Button btnPost
		{
			get
			{
				return this._btnPost;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnPost_Click);
				if (this._btnPost != null)
				{
					this._btnPost.Click -= value2;
				}
				this._btnPost = value;
				if (this._btnPost != null)
				{
					this._btnPost.Click += value2;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00094DBC File Offset: 0x000931BC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00094DD0 File Offset: 0x000931D0
		internal virtual ComboBox cmb_site
		{
			get
			{
				return this._cmb_site;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmb_site_SelectedIndexChanged);
				if (this._cmb_site != null)
				{
					this._cmb_site.SelectedIndexChanged -= value2;
				}
				this._cmb_site = value;
				if (this._cmb_site != null)
				{
					this._cmb_site.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00094E1C File Offset: 0x0009321C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00094E30 File Offset: 0x00093230
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00094E3C File Offset: 0x0009323C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00094E50 File Offset: 0x00093250
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00094E5C File Offset: 0x0009325C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00094E70 File Offset: 0x00093270
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00094E7C File Offset: 0x0009327C
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00094E90 File Offset: 0x00093290
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00094E9C File Offset: 0x0009329C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00094EB0 File Offset: 0x000932B0
		internal virtual ComboBox cmb_kategori
		{
			get
			{
				return this._cmb_kategori;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmb_kategori_SelectedIndexChanged);
				if (this._cmb_kategori != null)
				{
					this._cmb_kategori.SelectedIndexChanged -= value2;
				}
				this._cmb_kategori = value;
				if (this._cmb_kategori != null)
				{
					this._cmb_kategori.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00094EFC File Offset: 0x000932FC
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00094F10 File Offset: 0x00093310
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00094F1C File Offset: 0x0009331C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00094F30 File Offset: 0x00093330
		internal virtual TextBox txt_etiketler
		{
			get
			{
				return this._txt_etiketler;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_etiketler = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00094F3C File Offset: 0x0009333C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00094F50 File Offset: 0x00093350
		internal virtual Button btn_iptal
		{
			get
			{
				return this._btn_iptal;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_iptal_Click);
				if (this._btn_iptal != null)
				{
					this._btn_iptal.Click -= value2;
				}
				this._btn_iptal = value;
				if (this._btn_iptal != null)
				{
					this._btn_iptal.Click += value2;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00094F9C File Offset: 0x0009339C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00094FB0 File Offset: 0x000933B0
		internal virtual CheckBox chk_taslak
		{
			get
			{
				return this._chk_taslak;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chk_taslak_CheckedChanged);
				if (this._chk_taslak != null)
				{
					this._chk_taslak.CheckedChanged -= value2;
				}
				this._chk_taslak = value;
				if (this._chk_taslak != null)
				{
					this._chk_taslak.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00094FFC File Offset: 0x000933FC
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00095010 File Offset: 0x00093410
		internal virtual RichTextBox txtpost
		{
			get
			{
				return this._txtpost;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtpost_TextChanged);
				if (this._txtpost != null)
				{
					this._txtpost.TextChanged -= value2;
				}
				this._txtpost = value;
				if (this._txtpost != null)
				{
					this._txtpost.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0009505C File Offset: 0x0009345C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00095070 File Offset: 0x00093470
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

		// Token: 0x060001DB RID: 475 RVA: 0x0009507C File Offset: 0x0009347C
		private void btnPost_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.WordpressURL, "", false) == 0)
			{
				Interaction.MsgBox("Lütfen geçerli bir Wordpress site seçin!", MsgBoxStyle.Information, "Site Seçilmedi");
				return;
			}
			frm_makale_gonder.blogInfo content;
			content.title = this.txtTitle.Text;
			content.description = this.txtpost.Text;
			content.mt_keywords = this.txt_etiketler.Text;
			content.categories = new string[]
			{
				this.cmb_kategori.Text
			};
			this.categories = (frm_makale_gonder.IgetCatList)XmlRpcProxyGen.Create(typeof(frm_makale_gonder.IgetCatList));
			this.clientProtocol = (XmlRpcClientProtocol)this.categories;
			this.clientProtocol.Url = this.WordpressURL;
			try
			{
				string text = this.categories.NewPage(1, this.Kullaniciadi, this.Sifre, content, this.Taslak);
				Interaction.MsgBox("Yazı başarıyla siteye gönderildi!", MsgBoxStyle.Information, "Gönderim Başarılı");
				this.txtpost.Text = "";
				this.txtTitle.Text = "";
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			this.Close();
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000951CC File Offset: 0x000935CC
		private void frm_makale_gonder_Load(object sender, EventArgs e)
		{
			this.WPListesi();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000951D4 File Offset: 0x000935D4
		private void WPListesi()
		{
			this.cmb_site.Items.Clear();
			GenelModul.Cmd.CommandText = "select * from siteler";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				this.cmb_site.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["site_url"]));
			}
			oleDbDataReader.Close();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0009523C File Offset: 0x0009363C
		private void cmb_site_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cmb_kategori.Items.Clear();
			GenelModul.Cmd.CommandText = "select * from siteler where site_url='" + this.cmb_site.Text + "'";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			oleDbDataReader.Read();
			checked
			{
				try
				{
					this.WordpressURL = Conversions.ToString(Operators.ConcatenateObject(oleDbDataReader["site_wordpress_url"], "xmlrpc.php"));
					this.Kullaniciadi = Conversions.ToString(oleDbDataReader["site_kullanici_adi"]);
					this.Sifre = Conversions.ToString(oleDbDataReader["site_sifre"]);
					frm_makale_gonder.IWP iwp = XmlRpcProxyGen.Create<frm_makale_gonder.IWP>();
					iwp.Url = Conversions.ToString(Operators.ConcatenateObject(oleDbDataReader["site_wordpress_url"], "xmlrpc.php"));
					string[] args = new string[]
					{
						this.WordpressURL,
						this.Kullaniciadi,
						this.Sifre
					};
					frm_makale_gonder.category[] array = iwp.getCategories(args);
					foreach (frm_makale_gonder.category category in array)
					{
						this.cmb_kategori.Items.Add(RuntimeHelpers.GetObjectValue(category.categoryName));
						int num;
						this.Kategoriler[num] = Conversions.ToString(category.categoryId);
						num++;
					}
				}
				catch (Exception ex)
				{
				}
				oleDbDataReader.Close();
				this.cmb_kategori.SelectedIndex = 0;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000953D0 File Offset: 0x000937D0
		private void cmb_kategori_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.KategoriId = this.Kategoriler[this.cmb_kategori.SelectedIndex];
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000953EC File Offset: 0x000937EC
		private void chk_taslak_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chk_taslak.CheckState == CheckState.Checked)
			{
				this.Taslak = 0;
			}
			else
			{
				this.Taslak = 1;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0009540C File Offset: 0x0009380C
		private void btn_iptal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00095414 File Offset: 0x00093814
		private void txtpost_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040000B0 RID: 176
		[AccessedThroughProperty("txtTitle")]
		private TextBox _txtTitle;

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("btnPost")]
		private Button _btnPost;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("cmb_site")]
		private ComboBox _cmb_site;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("cmb_kategori")]
		private ComboBox _cmb_kategori;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("txt_etiketler")]
		private TextBox _txt_etiketler;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("btn_iptal")]
		private Button _btn_iptal;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("chk_taslak")]
		private CheckBox _chk_taslak;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("txtpost")]
		private RichTextBox _txtpost;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040000BE RID: 190
		private string WordpressURL;

		// Token: 0x040000BF RID: 191
		private string Kullaniciadi;

		// Token: 0x040000C0 RID: 192
		private string Sifre;

		// Token: 0x040000C1 RID: 193
		private string KategoriId;

		// Token: 0x040000C2 RID: 194
		private string[] Kategoriler;

		// Token: 0x040000C3 RID: 195
		public XmlRpcClientProtocol clientProtocol;

		// Token: 0x040000C4 RID: 196
		public frm_makale_gonder.IgetCatList categories;

		// Token: 0x040000C5 RID: 197
		private int Taslak;

		// Token: 0x02000010 RID: 16
		public struct category
		{
			// Token: 0x040000C6 RID: 198
			public object categoryId;

			// Token: 0x040000C7 RID: 199
			public object parentId;

			// Token: 0x040000C8 RID: 200
			public object description;

			// Token: 0x040000C9 RID: 201
			public object categoryName;

			// Token: 0x040000CA RID: 202
			public object htmlUrl;

			// Token: 0x040000CB RID: 203
			public object rssUrl;
		}

		// Token: 0x02000011 RID: 17
		public interface IWP : IXmlRpcProxy
		{
			// Token: 0x060001E3 RID: 483
			[XmlRpcMethod("wp.getCategories")]
			frm_makale_gonder.category[] getCategories(string[] args);
		}

		// Token: 0x02000012 RID: 18
		public struct blogInfo
		{
			// Token: 0x040000CC RID: 204
			public string title;

			// Token: 0x040000CD RID: 205
			public string description;

			// Token: 0x040000CE RID: 206
			public string[] categories;

			// Token: 0x040000CF RID: 207
			public string mt_keywords;
		}

		// Token: 0x02000013 RID: 19
		public interface IgetCatList
		{
			// Token: 0x060001E4 RID: 484
			[XmlRpcMethod("metaWeblog.newPost")]
			string NewPage(int blogId, string strUserName, string strPassword, frm_makale_gonder.blogInfo content, int publish);
		}
	}
}
