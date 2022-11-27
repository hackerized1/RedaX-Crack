using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RedaX
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class frm_splash : Form
	{
		// Token: 0x06000246 RID: 582 RVA: 0x00097C7C File Offset: 0x0009607C
		public frm_splash()
		{
			base.Load += this.frm_splash_Load;
			this.InitializeComponent();
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00098500 File Offset: 0x00096900
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00098514 File Offset: 0x00096914
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.Click -= value2;
				}
				this._PictureBox1 = value;
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.Click += value2;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00098560 File Offset: 0x00096960
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00098574 File Offset: 0x00096974
		internal virtual TextBox txt_info
		{
			get
			{
				return this._txt_info;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_info = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00098580 File Offset: 0x00096980
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00098594 File Offset: 0x00096994
		internal virtual Label lbl_app_name
		{
			get
			{
				return this._lbl_app_name;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_app_name = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000985A0 File Offset: 0x000969A0
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000985B4 File Offset: 0x000969B4
		internal virtual Label lbl_versiyon
		{
			get
			{
				return this._lbl_versiyon;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_versiyon = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000985C0 File Offset: 0x000969C0
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000985D4 File Offset: 0x000969D4
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000985E0 File Offset: 0x000969E0
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000985F4 File Offset: 0x000969F4
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00098600 File Offset: 0x00096A00
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00098614 File Offset: 0x00096A14
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00098620 File Offset: 0x00096A20
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00098634 File Offset: 0x00096A34
		internal virtual TextBox TextBox2
		{
			get
			{
				return this._TextBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox2_TextChanged);
				if (this._TextBox2 != null)
				{
					this._TextBox2.TextChanged -= value2;
				}
				this._TextBox2 = value;
				if (this._TextBox2 != null)
				{
					this._TextBox2.TextChanged += value2;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00098680 File Offset: 0x00096A80
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00098694 File Offset: 0x00096A94
		internal virtual Button btn_kapat
		{
			get
			{
				return this._btn_kapat;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_kapat_Click);
				if (this._btn_kapat != null)
				{
					this._btn_kapat.Click -= value2;
				}
				this._btn_kapat = value;
				if (this._btn_kapat != null)
				{
					this._btn_kapat.Click += value2;
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000986E0 File Offset: 0x00096AE0
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000986F4 File Offset: 0x00096AF4
		internal virtual ProgressBar ProgressBar1
		{
			get
			{
				return this._ProgressBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00098700 File Offset: 0x00096B00
		private void frm_splash_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.lbl_app_name.Text = this.ProductName;
			this.lbl_versiyon.Text = "Versiyon : " + this.ProductVersion;
			if (GenelModul.LisansKontrolEdildi)
			{
				if (!GenelModul.LisansDurum)
				{
					this.Label1.Text = "Lisans : Deneme Sürümü ( Sürenin dolmasına " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.Day, DateTime.Today, GenelModul.LSonTar, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) + " gün kaldı )";
				}
				else
				{
					this.Label1.Text = "Lisans : Lisanslı Sürüm ( " + GenelModul.LisansSahibi + " )";
				}
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000987A0 File Offset: 0x00096BA0
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000987A8 File Offset: 0x00096BA8
		private void btn_kapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000987B0 File Offset: 0x00096BB0
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("txt_info")]
		private TextBox _txt_info;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("lbl_app_name")]
		private Label _lbl_app_name;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("lbl_versiyon")]
		private Label _lbl_versiyon;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("btn_kapat")]
		private Button _btn_kapat;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;
	}
}
