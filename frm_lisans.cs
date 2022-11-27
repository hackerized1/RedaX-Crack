using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RedaX.My;

namespace RedaX
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class frm_lisans : Form
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x000937D0 File Offset: 0x00091BD0
		public frm_lisans()
		{
			base.Load += this.frm_lisans_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00093F74 File Offset: 0x00092374
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00093F88 File Offset: 0x00092388
		internal virtual TextBox txt_lisans_sahibi
		{
			get
			{
				return this._txt_lisans_sahibi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_lisans_sahibi = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00093F94 File Offset: 0x00092394
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00093FA8 File Offset: 0x000923A8
		internal virtual TextBox txt_lisans_anahtari
		{
			get
			{
				return this._txt_lisans_anahtari;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_lisans_anahtari = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00093FB4 File Offset: 0x000923B4
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00093FC8 File Offset: 0x000923C8
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00093FD4 File Offset: 0x000923D4
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00093FE8 File Offset: 0x000923E8
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00093FF4 File Offset: 0x000923F4
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00094008 File Offset: 0x00092408
		internal virtual TextBox txt_urun_anahtari
		{
			get
			{
				return this._txt_urun_anahtari;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_urun_anahtari = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00094014 File Offset: 0x00092414
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00094028 File Offset: 0x00092428
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00094034 File Offset: 0x00092434
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00094048 File Offset: 0x00092448
		internal virtual TextBox TextBox2
		{
			get
			{
				return this._TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00094054 File Offset: 0x00092454
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00094068 File Offset: 0x00092468
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000940B4 File Offset: 0x000924B4
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000940C8 File Offset: 0x000924C8
		internal virtual TextBox TextBox3
		{
			get
			{
				return this._TextBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000940D4 File Offset: 0x000924D4
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000940E8 File Offset: 0x000924E8
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00094134 File Offset: 0x00092534
		private void frm_lisans_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.txt_urun_anahtari.Text = GenelModul.MD5(GenelModul.HDDSerial());
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00094154 File Offset: 0x00092554
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button2_Click(object sender, EventArgs e)
		{
			if (GenelModul.LisansBittiMi)
			{
				ProjectData.EndApp();
			}
			else
			{
				this.Close();
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0009416C File Offset: 0x0009256C
		private void Button1_Click(object sender, EventArgs e)
		{
			string text = GenelModul.MD5(this.txt_lisans_sahibi.Text + GenelModul.TarihFormatla(GenelModul.DateTimeNow) + this.txt_urun_anahtari.Text);
			if (Operators.CompareString(this.txt_lisans_anahtari.Text, text, false) == 0)
			{
				if (File.Exists(GenelModul.RedaXDataPath + "\\libocat.bls"))
				{
					File.Delete(GenelModul.RedaXDataPath + "\\libocat.bls");
				}
				if (File.Exists(GenelModul.WindowsTemp1 + "rdxins.wav"))
				{
					File.Delete(GenelModul.WindowsTemp1 + "rdxins.wav");
				}
				GenelModul.SaveTextToFile(Conversions.ToString(GenelModul.DateTimeNow), GenelModul.WindowsTemp1 + "rdxins.wav", "");
				if (File.Exists(GenelModul.WindowsTemp1 + "rdxexp.wav"))
				{
					File.Delete(GenelModul.WindowsTemp1 + "rdxexp.wav");
				}
				if (File.Exists(GenelModul.WindowsTemp2 + "rdxexc.wav"))
				{
					File.Delete(GenelModul.WindowsTemp2 + "rdxexc.wav");
				}
				GenelModul.SaveTextToFile(this.txt_lisans_sahibi.Text + "," + text, GenelModul.RedaXDataPath + "\\libocat.bls", "");
				Interaction.MsgBox("Lisans kaydınız başarıyla yapılmıştır!, Lisanızın geçerli olabilmesi için uygulamayı kapatıp yeniden başlatınız!", MsgBoxStyle.Information, "Lisans Kaydı Yapıldı");
				MyProject.Forms.Form1.Enabled = true;
				this.Close();
			}
			else
			{
				Interaction.MsgBox("Lisans bilgileri geçersiz lütfen kontrol edip tekrar deneyiniz!", MsgBoxStyle.Critical, "Lisans Bilgileri Geçersiz!");
			}
		}

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("txt_lisans_sahibi")]
		private TextBox _txt_lisans_sahibi;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("txt_lisans_anahtari")]
		private TextBox _txt_lisans_anahtari;

		// Token: 0x040000A7 RID: 167
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000A8 RID: 168
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("txt_urun_anahtari")]
		private TextBox _txt_urun_anahtari;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("Button2")]
		private Button _Button2;
	}
}
