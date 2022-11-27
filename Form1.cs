using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RedaX.My;

namespace RedaX
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0008A304 File Offset: 0x00088704
		public Form1()
		{
			base.Resize += this.Form1_Resize;
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0008C9F0 File Offset: 0x0008ADF0
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0008CA04 File Offset: 0x0008AE04
		internal virtual RichTextBox txt_orjinal
		{
			get
			{
				return this._txt_orjinal;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_orjinal_TextChanged);
				EventHandler value3 = new EventHandler(this.txt_orjinal_LostFocus);
				EventHandler value4 = new EventHandler(this.txt_orjinal_GotFocus);
				if (this._txt_orjinal != null)
				{
					this._txt_orjinal.TextChanged -= value2;
					this._txt_orjinal.LostFocus -= value3;
					this._txt_orjinal.GotFocus -= value4;
				}
				this._txt_orjinal = value;
				if (this._txt_orjinal != null)
				{
					this._txt_orjinal.TextChanged += value2;
					this._txt_orjinal.LostFocus += value3;
					this._txt_orjinal.GotFocus += value4;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0008CA9C File Offset: 0x0008AE9C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0008CAB0 File Offset: 0x0008AEB0
		internal virtual RichTextBox txt_ozgun
		{
			get
			{
				return this._txt_ozgun;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ozgun_TextChanged);
				EventHandler value3 = new EventHandler(this.txt_ozgun_LostFocus);
				EventHandler value4 = new EventHandler(this.txt_ozgun_GotFocus);
				if (this._txt_ozgun != null)
				{
					this._txt_ozgun.TextChanged -= value2;
					this._txt_ozgun.LostFocus -= value3;
					this._txt_ozgun.GotFocus -= value4;
				}
				this._txt_ozgun = value;
				if (this._txt_ozgun != null)
				{
					this._txt_ozgun.TextChanged += value2;
					this._txt_ozgun.LostFocus += value3;
					this._txt_ozgun.GotFocus += value4;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0008CB48 File Offset: 0x0008AF48
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0008CB5C File Offset: 0x0008AF5C
		internal virtual ListBox ListBox1
		{
			get
			{
				return this._ListBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListBox1 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0008CB68 File Offset: 0x0008AF68
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0008CB7C File Offset: 0x0008AF7C
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0008CB88 File Offset: 0x0008AF88
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0008CB9C File Offset: 0x0008AF9C
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0008CBE8 File Offset: 0x0008AFE8
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0008CBFC File Offset: 0x0008AFFC
		internal virtual StatusStrip StatusStrip1
		{
			get
			{
				return this._StatusStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0008CC08 File Offset: 0x0008B008
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0008CC1C File Offset: 0x0008B01C
		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0008CC28 File Offset: 0x0008B028
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0008CC3C File Offset: 0x0008B03C
		internal virtual ToolStripButton btn_ozgunlestir
		{
			get
			{
				return this._btn_ozgunlestir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ozgunlestir_Click);
				if (this._btn_ozgunlestir != null)
				{
					this._btn_ozgunlestir.Click -= value2;
				}
				this._btn_ozgunlestir = value;
				if (this._btn_ozgunlestir != null)
				{
					this._btn_ozgunlestir.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0008CC88 File Offset: 0x0008B088
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0008CC9C File Offset: 0x0008B09C
		internal virtual MenuStrip MenuStrip1
		{
			get
			{
				return this._MenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0008CCA8 File Offset: 0x0008B0A8
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0008CCBC File Offset: 0x0008B0BC
		internal virtual ToolStripMenuItem DosyaToolStripMenuItem
		{
			get
			{
				return this._DosyaToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DosyaToolStripMenuItem = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0008CCC8 File Offset: 0x0008B0C8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0008CCDC File Offset: 0x0008B0DC
		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0008CCE8 File Offset: 0x0008B0E8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0008CCFC File Offset: 0x0008B0FC
		internal virtual Panel Panel3
		{
			get
			{
				return this._Panel3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel3 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0008CD08 File Offset: 0x0008B108
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0008CD1C File Offset: 0x0008B11C
		internal virtual ToolStripButton btn_yeni
		{
			get
			{
				return this._btn_yeni;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_yeni_Click);
				if (this._btn_yeni != null)
				{
					this._btn_yeni.Click -= value2;
				}
				this._btn_yeni = value;
				if (this._btn_yeni != null)
				{
					this._btn_yeni.Click += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0008CD68 File Offset: 0x0008B168
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0008CD7C File Offset: 0x0008B17C
		internal virtual ContextMenuStrip sag_menu_2
		{
			get
			{
				return this._sag_menu_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.sag_menu_2_Opening);
				if (this._sag_menu_2 != null)
				{
					this._sag_menu_2.Opening -= value2;
				}
				this._sag_menu_2 = value;
				if (this._sag_menu_2 != null)
				{
					this._sag_menu_2.Opening += value2;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0008CDC8 File Offset: 0x0008B1C8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0008CDDC File Offset: 0x0008B1DC
		internal virtual ToolStripMenuItem mnu_orjinal_kopyala
		{
			get
			{
				return this._mnu_orjinal_kopyala;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_orjinal_kopyala_Click);
				if (this._mnu_orjinal_kopyala != null)
				{
					this._mnu_orjinal_kopyala.Click -= value2;
				}
				this._mnu_orjinal_kopyala = value;
				if (this._mnu_orjinal_kopyala != null)
				{
					this._mnu_orjinal_kopyala.Click += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0008CE28 File Offset: 0x0008B228
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0008CE3C File Offset: 0x0008B23C
		internal virtual ToolStripMenuItem mnu_yapistir
		{
			get
			{
				return this._mnu_yapistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yapistir_Click);
				if (this._mnu_yapistir != null)
				{
					this._mnu_yapistir.Click -= value2;
				}
				this._mnu_yapistir = value;
				if (this._mnu_yapistir != null)
				{
					this._mnu_yapistir.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0008CE88 File Offset: 0x0008B288
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0008CE9C File Offset: 0x0008B29C
		internal virtual ToolStripButton btn_kelimeler
		{
			get
			{
				return this._btn_kelimeler;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_kelimeler_Click);
				if (this._btn_kelimeler != null)
				{
					this._btn_kelimeler.Click -= value2;
				}
				this._btn_kelimeler = value;
				if (this._btn_kelimeler != null)
				{
					this._btn_kelimeler.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0008CEE8 File Offset: 0x0008B2E8
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0008CEFC File Offset: 0x0008B2FC
		internal virtual ToolStripComboBox btn_tur
		{
			get
			{
				return this._btn_tur;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_tur_TextChanged);
				EventHandler value3 = new EventHandler(this.btn_tur_Click);
				if (this._btn_tur != null)
				{
					this._btn_tur.TextChanged -= value2;
					this._btn_tur.Click -= value3;
				}
				this._btn_tur = value;
				if (this._btn_tur != null)
				{
					this._btn_tur.TextChanged += value2;
					this._btn_tur.Click += value3;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0008CF6C File Offset: 0x0008B36C
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0008CF80 File Offset: 0x0008B380
		internal virtual ContextMenuStrip sag_menu_3
		{
			get
			{
				return this._sag_menu_3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.sag_menu_3_Opening);
				if (this._sag_menu_3 != null)
				{
					this._sag_menu_3.Opening -= value2;
				}
				this._sag_menu_3 = value;
				if (this._sag_menu_3 != null)
				{
					this._sag_menu_3.Opening += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0008CFCC File Offset: 0x0008B3CC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0008CFE0 File Offset: 0x0008B3E0
		internal virtual ToolStripMenuItem mnu_karistir
		{
			get
			{
				return this._mnu_karistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_karistir_Click);
				if (this._mnu_karistir != null)
				{
					this._mnu_karistir.Click -= value2;
				}
				this._mnu_karistir = value;
				if (this._mnu_karistir != null)
				{
					this._mnu_karistir.Click += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0008D02C File Offset: 0x0008B42C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0008D040 File Offset: 0x0008B440
		internal virtual ToolStripMenuItem mnu_ozel_isim
		{
			get
			{
				return this._mnu_ozel_isim;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_ozel_isim_Click);
				if (this._mnu_ozel_isim != null)
				{
					this._mnu_ozel_isim.Click -= value2;
				}
				this._mnu_ozel_isim = value;
				if (this._mnu_ozel_isim != null)
				{
					this._mnu_ozel_isim.Click += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0008D08C File Offset: 0x0008B48C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0008D0A0 File Offset: 0x0008B4A0
		internal virtual ToolStripMenuItem mnu_kopyala_2
		{
			get
			{
				return this._mnu_kopyala_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_kopyala_2_Click);
				if (this._mnu_kopyala_2 != null)
				{
					this._mnu_kopyala_2.Click -= value2;
				}
				this._mnu_kopyala_2 = value;
				if (this._mnu_kopyala_2 != null)
				{
					this._mnu_kopyala_2.Click += value2;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0008D0EC File Offset: 0x0008B4EC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0008D100 File Offset: 0x0008B500
		internal virtual ToolStripMenuItem mnu_yapistir_2
		{
			get
			{
				return this._mnu_yapistir_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yapistir_2_Click);
				if (this._mnu_yapistir_2 != null)
				{
					this._mnu_yapistir_2.Click -= value2;
				}
				this._mnu_yapistir_2 = value;
				if (this._mnu_yapistir_2 != null)
				{
					this._mnu_yapistir_2.Click += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0008D14C File Offset: 0x0008B54C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0008D160 File Offset: 0x0008B560
		internal virtual ToolStripSeparator ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0008D16C File Offset: 0x0008B56C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0008D180 File Offset: 0x0008B580
		internal virtual ToolStripMenuItem mnu_tumunu_sec
		{
			get
			{
				return this._mnu_tumunu_sec;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_tumunu_sec_Click);
				if (this._mnu_tumunu_sec != null)
				{
					this._mnu_tumunu_sec.Click -= value2;
				}
				this._mnu_tumunu_sec = value;
				if (this._mnu_tumunu_sec != null)
				{
					this._mnu_tumunu_sec.Click += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0008D1CC File Offset: 0x0008B5CC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0008D1E0 File Offset: 0x0008B5E0
		internal virtual ToolStripSeparator ToolStripMenuItem2
		{
			get
			{
				return this._ToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0008D1EC File Offset: 0x0008B5EC
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0008D200 File Offset: 0x0008B600
		internal virtual ToolStripButton btn_ac
		{
			get
			{
				return this._btn_ac;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ac_Click);
				if (this._btn_ac != null)
				{
					this._btn_ac.Click -= value2;
				}
				this._btn_ac = value;
				if (this._btn_ac != null)
				{
					this._btn_ac.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0008D24C File Offset: 0x0008B64C
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0008D260 File Offset: 0x0008B660
		internal virtual ToolStripButton btn_kaydet
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0008D2AC File Offset: 0x0008B6AC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0008D2C0 File Offset: 0x0008B6C0
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0008D2CC File Offset: 0x0008B6CC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0008D2E0 File Offset: 0x0008B6E0
		internal virtual ToolStripStatusLabel lbl_orjinal_kelime_say
		{
			get
			{
				return this._lbl_orjinal_kelime_say;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_orjinal_kelime_say = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0008D2EC File Offset: 0x0008B6EC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0008D300 File Offset: 0x0008B700
		internal virtual ToolStripStatusLabel lbl_ozgun_kelime_say
		{
			get
			{
				return this._lbl_ozgun_kelime_say;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_ozgun_kelime_say = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0008D30C File Offset: 0x0008B70C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0008D320 File Offset: 0x0008B720
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel1 = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0008D32C File Offset: 0x0008B72C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0008D340 File Offset: 0x0008B740
		internal virtual ToolStripMenuItem mnu_yeni_belge
		{
			get
			{
				return this._mnu_yeni_belge;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yeni_belge_Click);
				if (this._mnu_yeni_belge != null)
				{
					this._mnu_yeni_belge.Click -= value2;
				}
				this._mnu_yeni_belge = value;
				if (this._mnu_yeni_belge != null)
				{
					this._mnu_yeni_belge.Click += value2;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0008D38C File Offset: 0x0008B78C
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0008D3A0 File Offset: 0x0008B7A0
		internal virtual ToolStripMenuItem mnu_dosyadan_ac
		{
			get
			{
				return this._mnu_dosyadan_ac;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_dosyadan_ac_Click);
				if (this._mnu_dosyadan_ac != null)
				{
					this._mnu_dosyadan_ac.Click -= value2;
				}
				this._mnu_dosyadan_ac = value;
				if (this._mnu_dosyadan_ac != null)
				{
					this._mnu_dosyadan_ac.Click += value2;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0008D3EC File Offset: 0x0008B7EC
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0008D400 File Offset: 0x0008B800
		internal virtual ToolStripMenuItem mnu_belge_kaydet
		{
			get
			{
				return this._mnu_belge_kaydet;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_belge_kaydet_Click);
				if (this._mnu_belge_kaydet != null)
				{
					this._mnu_belge_kaydet.Click -= value2;
				}
				this._mnu_belge_kaydet = value;
				if (this._mnu_belge_kaydet != null)
				{
					this._mnu_belge_kaydet.Click += value2;
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0008D44C File Offset: 0x0008B84C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0008D460 File Offset: 0x0008B860
		internal virtual ToolStripSeparator ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem3 = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0008D46C File Offset: 0x0008B86C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0008D480 File Offset: 0x0008B880
		internal virtual ToolStripMenuItem mnu_ozgunlestir
		{
			get
			{
				return this._mnu_ozgunlestir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_ozgunlestir_Click);
				if (this._mnu_ozgunlestir != null)
				{
					this._mnu_ozgunlestir.Click -= value2;
				}
				this._mnu_ozgunlestir = value;
				if (this._mnu_ozgunlestir != null)
				{
					this._mnu_ozgunlestir.Click += value2;
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0008D4CC File Offset: 0x0008B8CC
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0008D4E0 File Offset: 0x0008B8E0
		internal virtual ToolStripMenuItem DüzenToolStripMenuItem
		{
			get
			{
				return this._DüzenToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DüzenToolStripMenuItem_Click);
				if (this._DüzenToolStripMenuItem != null)
				{
					this._DüzenToolStripMenuItem.Click -= value2;
				}
				this._DüzenToolStripMenuItem = value;
				if (this._DüzenToolStripMenuItem != null)
				{
					this._DüzenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0008D52C File Offset: 0x0008B92C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0008D540 File Offset: 0x0008B940
		internal virtual ToolStripMenuItem YardımToolStripMenuItem
		{
			get
			{
				return this._YardımToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._YardımToolStripMenuItem = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0008D54C File Offset: 0x0008B94C
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0008D560 File Offset: 0x0008B960
		internal virtual ToolStripSeparator ToolStripMenuItem4
		{
			get
			{
				return this._ToolStripMenuItem4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem4 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0008D56C File Offset: 0x0008B96C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0008D580 File Offset: 0x0008B980
		internal virtual ToolStripMenuItem mnu_tumunu_sec_2
		{
			get
			{
				return this._mnu_tumunu_sec_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_tumunu_sec_2_Click);
				if (this._mnu_tumunu_sec_2 != null)
				{
					this._mnu_tumunu_sec_2.Click -= value2;
				}
				this._mnu_tumunu_sec_2 = value;
				if (this._mnu_tumunu_sec_2 != null)
				{
					this._mnu_tumunu_sec_2.Click += value2;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0008D5CC File Offset: 0x0008B9CC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0008D5E0 File Offset: 0x0008B9E0
		internal virtual ToolStripButton btn_yazim_denetimi
		{
			get
			{
				return this._btn_yazim_denetimi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_yazim_denetimi_Click);
				if (this._btn_yazim_denetimi != null)
				{
					this._btn_yazim_denetimi.Click -= value2;
				}
				this._btn_yazim_denetimi = value;
				if (this._btn_yazim_denetimi != null)
				{
					this._btn_yazim_denetimi.Click += value2;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0008D62C File Offset: 0x0008BA2C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0008D640 File Offset: 0x0008BA40
		internal virtual ToolStripMenuItem mnu_sozluge_ekle
		{
			get
			{
				return this._mnu_sozluge_ekle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_sozluge_ekle_Click);
				if (this._mnu_sozluge_ekle != null)
				{
					this._mnu_sozluge_ekle.Click -= value2;
				}
				this._mnu_sozluge_ekle = value;
				if (this._mnu_sozluge_ekle != null)
				{
					this._mnu_sozluge_ekle.Click += value2;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0008D68C File Offset: 0x0008BA8C
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0008D6A0 File Offset: 0x0008BAA0
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0008D6AC File Offset: 0x0008BAAC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0008D6C0 File Offset: 0x0008BAC0
		internal virtual ToolStripMenuItem mnu_degistir
		{
			get
			{
				return this._mnu_degistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.mnu_degistir_DropDownItemClicked);
				if (this._mnu_degistir != null)
				{
					this._mnu_degistir.DropDownItemClicked -= value2;
				}
				this._mnu_degistir = value;
				if (this._mnu_degistir != null)
				{
					this._mnu_degistir.DropDownItemClicked += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0008D70C File Offset: 0x0008BB0C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0008D720 File Offset: 0x0008BB20
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0008D72C File Offset: 0x0008BB2C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0008D740 File Offset: 0x0008BB40
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0008D74C File Offset: 0x0008BB4C
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0008D760 File Offset: 0x0008BB60
		internal virtual ListBox ListBox2
		{
			get
			{
				return this._ListBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListBox2_SelectedIndexChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.ListBox2_KeyDown);
				if (this._ListBox2 != null)
				{
					this._ListBox2.SelectedIndexChanged -= value2;
					this._ListBox2.KeyDown -= value3;
				}
				this._ListBox2 = value;
				if (this._ListBox2 != null)
				{
					this._ListBox2.SelectedIndexChanged += value2;
					this._ListBox2.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0008D7D0 File Offset: 0x0008BBD0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0008D7E4 File Offset: 0x0008BBE4
		internal virtual TextBox txt_ara
		{
			get
			{
				return this._txt_ara;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ara_TextChanged);
				EventHandler value3 = new EventHandler(this.txt_ara_LostFocus);
				EventHandler value4 = new EventHandler(this.txt_ara_GotFocus);
				if (this._txt_ara != null)
				{
					this._txt_ara.TextChanged -= value2;
					this._txt_ara.LostFocus -= value3;
					this._txt_ara.GotFocus -= value4;
				}
				this._txt_ara = value;
				if (this._txt_ara != null)
				{
					this._txt_ara.TextChanged += value2;
					this._txt_ara.LostFocus += value3;
					this._txt_ara.GotFocus += value4;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0008D87C File Offset: 0x0008BC7C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0008D890 File Offset: 0x0008BC90
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0008D89C File Offset: 0x0008BC9C
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0008D8B0 File Offset: 0x0008BCB0
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0008D8BC File Offset: 0x0008BCBC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0008D8D0 File Offset: 0x0008BCD0
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0008D8DC File Offset: 0x0008BCDC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0008D8F0 File Offset: 0x0008BCF0
		internal virtual ToolStripMenuItem AyarlarToolStripMenuItem
		{
			get
			{
				return this._AyarlarToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AyarlarToolStripMenuItem = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0008D8FC File Offset: 0x0008BCFC
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0008D910 File Offset: 0x0008BD10
		internal virtual ToolStripMenuItem mnu_kelime_yonetimi
		{
			get
			{
				return this._mnu_kelime_yonetimi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_kelime_yonetimi_Click_1);
				if (this._mnu_kelime_yonetimi != null)
				{
					this._mnu_kelime_yonetimi.Click -= value2;
				}
				this._mnu_kelime_yonetimi = value;
				if (this._mnu_kelime_yonetimi != null)
				{
					this._mnu_kelime_yonetimi.Click += value2;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0008D95C File Offset: 0x0008BD5C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0008D970 File Offset: 0x0008BD70
		internal virtual ToolStripMenuItem mnu_yazim_denetimi
		{
			get
			{
				return this._mnu_yazim_denetimi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yazim_denetimi_Click);
				if (this._mnu_yazim_denetimi != null)
				{
					this._mnu_yazim_denetimi.Click -= value2;
				}
				this._mnu_yazim_denetimi = value;
				if (this._mnu_yazim_denetimi != null)
				{
					this._mnu_yazim_denetimi.Click += value2;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0008D9BC File Offset: 0x0008BDBC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0008D9D0 File Offset: 0x0008BDD0
		internal virtual ToolStripMenuItem mnu_hakkinda
		{
			get
			{
				return this._mnu_hakkinda;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_hakkinda_Click);
				if (this._mnu_hakkinda != null)
				{
					this._mnu_hakkinda.Click -= value2;
				}
				this._mnu_hakkinda = value;
				if (this._mnu_hakkinda != null)
				{
					this._mnu_hakkinda.Click += value2;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0008DA1C File Offset: 0x0008BE1C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0008DA30 File Offset: 0x0008BE30
		internal virtual ToolStripMenuItem mnu_ozel_isimler
		{
			get
			{
				return this._mnu_ozel_isimler;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_ozel_isimler_Click);
				if (this._mnu_ozel_isimler != null)
				{
					this._mnu_ozel_isimler.Click -= value2;
				}
				this._mnu_ozel_isimler = value;
				if (this._mnu_ozel_isimler != null)
				{
					this._mnu_ozel_isimler.Click += value2;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0008DA7C File Offset: 0x0008BE7C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0008DA90 File Offset: 0x0008BE90
		internal virtual ToolStripButton btn_ozel_isimler
		{
			get
			{
				return this._btn_ozel_isimler;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ozel_isimler_Click);
				if (this._btn_ozel_isimler != null)
				{
					this._btn_ozel_isimler.Click -= value2;
				}
				this._btn_ozel_isimler = value;
				if (this._btn_ozel_isimler != null)
				{
					this._btn_ozel_isimler.Click += value2;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0008DADC File Offset: 0x0008BEDC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0008DAF0 File Offset: 0x0008BEF0
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0008DAFC File Offset: 0x0008BEFC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0008DB10 File Offset: 0x0008BF10
		internal virtual ToolStripMenuItem OrijinalİçerikToolStripMenuItem
		{
			get
			{
				return this._OrijinalİçerikToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OrijinalİçerikToolStripMenuItem = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0008DB1C File Offset: 0x0008BF1C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0008DB30 File Offset: 0x0008BF30
		internal virtual ToolStripMenuItem duzen_orj_kopyala
		{
			get
			{
				return this._duzen_orj_kopyala;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.duzen_orj_kopyala_Click);
				if (this._duzen_orj_kopyala != null)
				{
					this._duzen_orj_kopyala.Click -= value2;
				}
				this._duzen_orj_kopyala = value;
				if (this._duzen_orj_kopyala != null)
				{
					this._duzen_orj_kopyala.Click += value2;
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0008DB7C File Offset: 0x0008BF7C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0008DB90 File Offset: 0x0008BF90
		internal virtual ToolStripMenuItem duzen_orj_yapistir
		{
			get
			{
				return this._duzen_orj_yapistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.duzen_orj_yapistir_Click);
				if (this._duzen_orj_yapistir != null)
				{
					this._duzen_orj_yapistir.Click -= value2;
				}
				this._duzen_orj_yapistir = value;
				if (this._duzen_orj_yapistir != null)
				{
					this._duzen_orj_yapistir.Click += value2;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0008DBDC File Offset: 0x0008BFDC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0008DBF0 File Offset: 0x0008BFF0
		internal virtual ToolStripSeparator ToolStripMenuItem5
		{
			get
			{
				return this._ToolStripMenuItem5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem5 = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0008DBFC File Offset: 0x0008BFFC
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0008DC10 File Offset: 0x0008C010
		internal virtual ToolStripMenuItem duzen_orj_tumunu_sec
		{
			get
			{
				return this._duzen_orj_tumunu_sec;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.duzen_orj_tumunu_sec_Click);
				if (this._duzen_orj_tumunu_sec != null)
				{
					this._duzen_orj_tumunu_sec.Click -= value2;
				}
				this._duzen_orj_tumunu_sec = value;
				if (this._duzen_orj_tumunu_sec != null)
				{
					this._duzen_orj_tumunu_sec.Click += value2;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0008DC5C File Offset: 0x0008C05C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0008DC70 File Offset: 0x0008C070
		internal virtual ToolStripMenuItem ÖzgünİçerikToolStripMenuItem
		{
			get
			{
				return this._ÖzgünİçerikToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ÖzgünİçerikToolStripMenuItem = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0008DC7C File Offset: 0x0008C07C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0008DC90 File Offset: 0x0008C090
		internal virtual ToolStripMenuItem duzen_oz_kopyala
		{
			get
			{
				return this._duzen_oz_kopyala;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.duzen_oz_kopyala_Click);
				if (this._duzen_oz_kopyala != null)
				{
					this._duzen_oz_kopyala.Click -= value2;
				}
				this._duzen_oz_kopyala = value;
				if (this._duzen_oz_kopyala != null)
				{
					this._duzen_oz_kopyala.Click += value2;
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0008DCDC File Offset: 0x0008C0DC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0008DCF0 File Offset: 0x0008C0F0
		internal virtual ToolStripMenuItem duzen_oz_yapistir
		{
			get
			{
				return this._duzen_oz_yapistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.duzen_oz_yapistir_Click);
				if (this._duzen_oz_yapistir != null)
				{
					this._duzen_oz_yapistir.Click -= value2;
				}
				this._duzen_oz_yapistir = value;
				if (this._duzen_oz_yapistir != null)
				{
					this._duzen_oz_yapistir.Click += value2;
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0008DD3C File Offset: 0x0008C13C
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0008DD50 File Offset: 0x0008C150
		internal virtual ToolStripSeparator ToolStripMenuItem6
		{
			get
			{
				return this._ToolStripMenuItem6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem6 = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0008DD5C File Offset: 0x0008C15C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0008DD70 File Offset: 0x0008C170
		internal virtual ToolStripMenuItem mnu_duzen_oz_tumunu_sec
		{
			get
			{
				return this._mnu_duzen_oz_tumunu_sec;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_duzen_oz_tumunu_sec_Click);
				if (this._mnu_duzen_oz_tumunu_sec != null)
				{
					this._mnu_duzen_oz_tumunu_sec.Click -= value2;
				}
				this._mnu_duzen_oz_tumunu_sec = value;
				if (this._mnu_duzen_oz_tumunu_sec != null)
				{
					this._mnu_duzen_oz_tumunu_sec.Click += value2;
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0008DDBC File Offset: 0x0008C1BC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0008DDD0 File Offset: 0x0008C1D0
		internal virtual ToolStripSeparator ToolStripMenuItem7
		{
			get
			{
				return this._ToolStripMenuItem7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem7 = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0008DDDC File Offset: 0x0008C1DC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0008DDF0 File Offset: 0x0008C1F0
		internal virtual ToolStripMenuItem mnu_duzen_tersine_cevir
		{
			get
			{
				return this._mnu_duzen_tersine_cevir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_duzen_tersine_cevir_Click);
				if (this._mnu_duzen_tersine_cevir != null)
				{
					this._mnu_duzen_tersine_cevir.Click -= value2;
				}
				this._mnu_duzen_tersine_cevir = value;
				if (this._mnu_duzen_tersine_cevir != null)
				{
					this._mnu_duzen_tersine_cevir.Click += value2;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0008DE3C File Offset: 0x0008C23C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0008DE50 File Offset: 0x0008C250
		internal virtual ToolStripMenuItem mnu_duzen_oz_ozel_isim
		{
			get
			{
				return this._mnu_duzen_oz_ozel_isim;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_duzen_oz_ozel_isim_Click);
				if (this._mnu_duzen_oz_ozel_isim != null)
				{
					this._mnu_duzen_oz_ozel_isim.Click -= value2;
				}
				this._mnu_duzen_oz_ozel_isim = value;
				if (this._mnu_duzen_oz_ozel_isim != null)
				{
					this._mnu_duzen_oz_ozel_isim.Click += value2;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0008DE9C File Offset: 0x0008C29C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0008DEB0 File Offset: 0x0008C2B0
		internal virtual ToolStripMenuItem mnu_duzen_oz_sozluge_ekle
		{
			get
			{
				return this._mnu_duzen_oz_sozluge_ekle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_duzen_oz_sozluge_ekle_Click);
				if (this._mnu_duzen_oz_sozluge_ekle != null)
				{
					this._mnu_duzen_oz_sozluge_ekle.Click -= value2;
				}
				this._mnu_duzen_oz_sozluge_ekle = value;
				if (this._mnu_duzen_oz_sozluge_ekle != null)
				{
					this._mnu_duzen_oz_sozluge_ekle.Click += value2;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0008DEFC File Offset: 0x0008C2FC
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0008DF10 File Offset: 0x0008C310
		internal virtual ToolStripMenuItem mnu_duzen_oz_kelimeyi_degistir
		{
			get
			{
				return this._mnu_duzen_oz_kelimeyi_degistir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_duzen_oz_kelimeyi_degistir_Click);
				if (this._mnu_duzen_oz_kelimeyi_degistir != null)
				{
					this._mnu_duzen_oz_kelimeyi_degistir.Click -= value2;
				}
				this._mnu_duzen_oz_kelimeyi_degistir = value;
				if (this._mnu_duzen_oz_kelimeyi_degistir != null)
				{
					this._mnu_duzen_oz_kelimeyi_degistir.Click += value2;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0008DF5C File Offset: 0x0008C35C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0008DF70 File Offset: 0x0008C370
		internal virtual ToolStripButton btn_makale_gonder
		{
			get
			{
				return this._btn_makale_gonder;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_makale_gonder_Click);
				if (this._btn_makale_gonder != null)
				{
					this._btn_makale_gonder.Click -= value2;
				}
				this._btn_makale_gonder = value;
				if (this._btn_makale_gonder != null)
				{
					this._btn_makale_gonder.Click += value2;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0008DFBC File Offset: 0x0008C3BC
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0008DFD0 File Offset: 0x0008C3D0
		internal virtual ToolStripMenuItem mnu_site_yonetimi
		{
			get
			{
				return this._mnu_site_yonetimi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_site_yonetimi_Click);
				if (this._mnu_site_yonetimi != null)
				{
					this._mnu_site_yonetimi.Click -= value2;
				}
				this._mnu_site_yonetimi = value;
				if (this._mnu_site_yonetimi != null)
				{
					this._mnu_site_yonetimi.Click += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0008E01C File Offset: 0x0008C41C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0008E030 File Offset: 0x0008C430
		internal virtual ToolStripMenuItem mnu_lisans
		{
			get
			{
				return this._mnu_lisans;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_lisans_Click);
				if (this._mnu_lisans != null)
				{
					this._mnu_lisans.Click -= value2;
				}
				this._mnu_lisans = value;
				if (this._mnu_lisans != null)
				{
					this._mnu_lisans.Click += value2;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0008E07C File Offset: 0x0008C47C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0008E090 File Offset: 0x0008C490
		internal virtual ToolStripMenuItem mnu_kategori_yonetimi
		{
			get
			{
				return this._mnu_kategori_yonetimi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_kategori_yonetimi_Click);
				if (this._mnu_kategori_yonetimi != null)
				{
					this._mnu_kategori_yonetimi.Click -= value2;
				}
				this._mnu_kategori_yonetimi = value;
				if (this._mnu_kategori_yonetimi != null)
				{
					this._mnu_kategori_yonetimi.Click += value2;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0008E0DC File Offset: 0x0008C4DC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0008E0F0 File Offset: 0x0008C4F0
		internal virtual ToolStripMenuItem mnu_yardim
		{
			get
			{
				return this._mnu_yardim;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yardim_Click);
				if (this._mnu_yardim != null)
				{
					this._mnu_yardim.Click -= value2;
				}
				this._mnu_yardim = value;
				if (this._mnu_yardim != null)
				{
					this._mnu_yardim.Click += value2;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0008E13C File Offset: 0x0008C53C
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0008E150 File Offset: 0x0008C550
		internal virtual ToolStripMenuItem mnu_karsilik_ekle
		{
			get
			{
				return this._mnu_karsilik_ekle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_karsilik_ekle_Click);
				if (this._mnu_karsilik_ekle != null)
				{
					this._mnu_karsilik_ekle.Click -= value2;
				}
				this._mnu_karsilik_ekle = value;
				if (this._mnu_karsilik_ekle != null)
				{
					this._mnu_karsilik_ekle.Click += value2;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0008E19C File Offset: 0x0008C59C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0008E1B0 File Offset: 0x0008C5B0
		internal virtual ToolStripMenuItem mnu_karsilik_ekle_2
		{
			get
			{
				return this._mnu_karsilik_ekle_2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_karsilik_ekle_2_Click);
				if (this._mnu_karsilik_ekle_2 != null)
				{
					this._mnu_karsilik_ekle_2.Click -= value2;
				}
				this._mnu_karsilik_ekle_2 = value;
				if (this._mnu_karsilik_ekle_2 != null)
				{
					this._mnu_karsilik_ekle_2.Click += value2;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0008E1FC File Offset: 0x0008C5FC
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0008E210 File Offset: 0x0008C610
		internal virtual ToolStripSeparator ToolStripMenuItem8
		{
			get
			{
				return this._ToolStripMenuItem8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem8 = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0008E21C File Offset: 0x0008C61C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0008E230 File Offset: 0x0008C630
		internal virtual ToolStripMenuItem mnu_yedekle
		{
			get
			{
				return this._mnu_yedekle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yedekle_Click);
				if (this._mnu_yedekle != null)
				{
					this._mnu_yedekle.Click -= value2;
				}
				this._mnu_yedekle = value;
				if (this._mnu_yedekle != null)
				{
					this._mnu_yedekle.Click += value2;
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0008E27C File Offset: 0x0008C67C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0008E290 File Offset: 0x0008C690
		internal virtual ToolStripMenuItem mnu_yedek_yukle
		{
			get
			{
				return this._mnu_yedek_yukle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_yedek_yukle_Click);
				if (this._mnu_yedek_yukle != null)
				{
					this._mnu_yedek_yukle.Click -= value2;
				}
				this._mnu_yedek_yukle = value;
				if (this._mnu_yedek_yukle != null)
				{
					this._mnu_yedek_yukle.Click += value2;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0008E2DC File Offset: 0x0008C6DC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0008E2F0 File Offset: 0x0008C6F0
		internal virtual ToolStripSeparator ToolStripMenuItem10
		{
			get
			{
				return this._ToolStripMenuItem10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem10 = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0008E2FC File Offset: 0x0008C6FC
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0008E310 File Offset: 0x0008C710
		internal virtual ToolStripMenuItem mnu_guncelle
		{
			get
			{
				return this._mnu_guncelle;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mnu_guncelle_Click);
				if (this._mnu_guncelle != null)
				{
					this._mnu_guncelle.Click -= value2;
				}
				this._mnu_guncelle = value;
				if (this._mnu_guncelle != null)
				{
					this._mnu_guncelle.Click += value2;
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0008E35C File Offset: 0x0008C75C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0008E370 File Offset: 0x0008C770
		internal virtual Timer Timer1
		{
			get
			{
				return this._Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0008E3BC File Offset: 0x0008C7BC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Visible = false;
			GenelModul.LisansKontrol();
			GenelModul.DataConnect();
			this.TurListesi();
			this.KelimeListesi();
			if (GenelModul.LisansDurum)
			{
				this.Text = this.ProductName + " " + this.ProductVersion;
				this.mnu_lisans.Visible = false;
			}
			else
			{
				this.Text = string.Concat(new string[]
				{
					this.ProductName,
					" ",
					this.ProductVersion,
					" (Deneme Sürümü : ",
					Conversions.ToString(DateAndTime.DateDiff(DateInterval.Day, DateTime.Today, GenelModul.LSonTar, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)),
					" gün kaldı)"
				});
				this.mnu_lisans.Visible = true;
			}
			this.Visible = true;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0008E484 File Offset: 0x0008C884
		public void findTextAndHighlight(string searchtext, string replacetext, RichTextBox rtb, RichTextBox rtb2)
		{
			int textLength = rtb.TextLength;
			int i = 0;
			Font selectionFont = new Font(rtb.Font, FontStyle.Bold);
			int num = rtb.Text.LastIndexOf(searchtext);
			checked
			{
				while (i < num)
				{
					rtb.Find(searchtext, i, textLength, RichTextBoxFinds.None);
					rtb.SelectionFont = selectionFont;
					rtb.SelectionLength = searchtext.Length;
					rtb.SelectionColor = Color.Red;
					rtb.SelectionBackColor = Color.Cyan;
					i = rtb.Text.IndexOf(searchtext, i) + 1;
				}
				if (i > 0)
				{
					this.Say++;
					this.ListBox1.Items.Add(replacetext);
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0008E524 File Offset: 0x0008C924
		public void findTextAndHighlight2(string searchtext, string replacetext, RichTextBox rtb, RichTextBox rtb2)
		{
			int textLength = rtb.TextLength;
			int i = 0;
			Font selectionFont = new Font(rtb.Font, FontStyle.Bold);
			int num = rtb.Text.LastIndexOf(searchtext);
			while (i < num)
			{
				rtb.Find(searchtext, i, textLength, RichTextBoxFinds.None);
				rtb.SelectionFont = selectionFont;
				rtb.SelectionLength = searchtext.Length;
				rtb.SelectionColor = Color.Red;
				rtb.SelectionBackColor = Color.Cyan;
				i = checked(rtb.Text.IndexOf(searchtext, i) + 1);
			}
			this.ReplaceALL(searchtext, replacetext, rtb, false, false);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0008E5AC File Offset: 0x0008C9AC
		public void findTextAndHighlight3(string searchtext, string replacetext, RichTextBox rtb, RichTextBox rtb2)
		{
			int textLength = rtb.TextLength;
			int i = 0;
			Font selectionFont = new Font(rtb.Font, FontStyle.Bold);
			int num = rtb.Text.LastIndexOf(searchtext);
			while (i < num)
			{
				rtb.Find(searchtext, i, textLength, RichTextBoxFinds.None);
				rtb.SelectionFont = selectionFont;
				rtb.SelectionLength = searchtext.Length;
				rtb.SelectionColor = Color.Red;
				rtb.SelectionBackColor = Color.Cyan;
				i = checked(rtb.Text.IndexOf(searchtext, i) + 1);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0008E628 File Offset: 0x0008CA28
		public void ReplaceALL(string MatchString, string ReplaceString, RichTextBox Source, bool bMatchCase = true, bool bPromptReplace = false)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.iFindCount == 0)
				{
					goto IL_15;
				}
				checked
				{
					for (;;)
					{
						IL_108:
						num2 = 6;
						if (this.iFindCount <= 0)
						{
							break;
						}
						IL_2C:
						num2 = 7;
						if (bPromptReplace)
						{
							IL_32:
							num2 = 8;
							int num3;
							num3++;
							IL_38:
							num2 = 9;
							Source.Text = Source.Text.Substring(0, this.iStartPosition) + ReplaceString + Source.Text.Substring(this.iStartPosition + MatchString.Length);
							IL_71:
							num2 = 10;
							this.iStartPosition += ReplaceString.Length;
							IL_87:
							num2 = 11;
							this.FindWord(MatchString, Source, bMatchCase, !bPromptReplace, true);
							IL_9A:;
						}
						else
						{
							IL_9C:
							num2 = 13;
							IL_9F:
							num2 = 14;
							int num3;
							num3++;
							IL_A6:
							num2 = 15;
							Source.Text = Source.Text.Substring(0, this.iStartPosition) + ReplaceString + Source.Text.Substring(this.iStartPosition + MatchString.Length);
							IL_DF:
							num2 = 16;
							this.iStartPosition += ReplaceString.Length;
							IL_F5:
							num2 = 17;
							this.FindWord(MatchString, Source, bMatchCase, !bPromptReplace, true);
						}
					}
					IL_116:
					goto IL_1B8;
					IL_15:
					num2 = 3;
					this.FindWord(MatchString, Source, bMatchCase, !bPromptReplace, true);
					IL_27:
					goto IL_108;
					IL_11B:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_179:
				goto IL_1AD;
				IL_17B:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_18B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_17B;
			}
			IL_1AD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1B8:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0008E814 File Offset: 0x0008CC14
		public void FindWord(string MatchString, RichTextBox Source, bool bMatchCase = true, bool bNoSelect = false, bool bHaltMSG = false)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (bMatchCase)
				{
					goto IL_24;
				}
				IL_0D:
				num2 = 3;
				this.RegXMatch = new Regex(Regex.Escape(MatchString), RegexOptions.IgnoreCase);
				IL_22:
				goto IL_3B;
				IL_24:
				num2 = 5;
				IL_27:
				num2 = 6;
				this.RegXMatch = new Regex(Regex.Escape(MatchString));
				IL_3B:
				num2 = 8;
				if (!this.RegXMatch.IsMatch(Source.Text.Substring(this.iStartPosition)))
				{
					goto IL_ED;
				}
				IL_5F:
				num2 = 9;
				string[] array = this.RegXMatch.Split(Source.Text.Substring(this.iStartPosition));
				IL_80:
				num2 = 10;
				checked
				{
					this.iFindCount++;
					IL_92:
					num2 = 11;
					int num3 = 0;
					int num4 = array.Length - 1;
					int num5 = num3;
					IL_E4:
					if (num5 > num4)
					{
						goto IL_E8;
					}
					IL_A0:
					num2 = 12;
					this.iStartPosition += array[num5].Length;
					IL_B9:
					num2 = 13;
					if (bNoSelect)
					{
						goto IL_D7;
					}
					IL_C1:
					num2 = 14;
					Source.Select(this.iStartPosition, MatchString.Length);
					IL_D7:
					IL_E8:
					goto IL_221;
					IL_ED:
					num2 = 19;
					IL_F1:
					num2 = 20;
					if (bHaltMSG)
					{
						goto IL_138;
					}
					IL_F9:
					num2 = 21;
					if (this.iFindCount <= 0)
					{
						goto IL_11E;
					}
					IL_106:
					num2 = 22;
					Interaction.MsgBox("No more matches found", MsgBoxStyle.Information, "Find/Replace");
					IL_11C:
					goto IL_138;
					IL_11E:
					num2 = 24;
					IL_122:
					num2 = 25;
					Interaction.MsgBox("No matches found", MsgBoxStyle.Information, "Find/Replace");
					IL_138:
					num2 = 28;
					this.iStartPosition = 0;
					IL_143:
					num2 = 29;
					this.iFindCount = 0;
					IL_14E:
					goto IL_221;
					IL_DC:
					num2 = 17;
					num5++;
					goto IL_E4;
					IL_153:;
				}
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_1DF:
				goto IL_216;
				IL_1E1:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1F3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1E1;
			}
			IL_216:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_221:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0008EA68 File Offset: 0x0008CE68
		private void Form1_Resize(object sender, EventArgs e)
		{
			this.Panel1.Left = 5;
			checked
			{
				this.Panel2.Left = this.Panel1.Left + this.Panel1.Width;
				this.Panel2.Width = (int)Math.Round((double)(this.Width - (38 + this.Panel1.Width)) / 2.0);
				this.Panel3.Width = this.Panel2.Width;
				this.Panel3.Left = this.Panel2.Left + this.Panel2.Width + 10;
				this.Panel2.Height = this.Height - (this.StatusStrip1.Height + this.MenuStrip1.Height + this.Label3.Height + 90);
				this.Panel3.Height = this.Panel2.Height;
				this.txt_orjinal.Height = this.Panel2.Height - 8;
				this.txt_orjinal.Width = this.Panel2.Width - 8;
				this.txt_ozgun.Height = this.Panel3.Height - 8;
				this.txt_ozgun.Width = this.Panel3.Width - 8;
				this.Panel1.Height = this.Panel2.Height + this.Label4.Height;
				this.Label3.Left = this.Panel2.Left;
				this.Label4.Left = this.Panel3.Left;
				this.ListBox2.Height = this.Panel1.Height - (this.Label2.Height + this.ListBox1.Height + this.Label1.Height + this.txt_ara.Height + this.Label4.Height);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0008EC60 File Offset: 0x0008D060
		private void btn_ozgunlestir_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_orjinal.Text, "Bu alana orijinal içerik yazılacaktır", false) != 0 & Operators.CompareString(this.txt_orjinal.Text, "", false) != 0)
			{
				this.SecimiSifirla(this.txt_orjinal);
				this.MakaleOzgunlestir();
			}
			else
			{
				Interaction.MsgBox("Özgünleştirme işlemi için öncelikle Orijinal içerik gereklidir!", MsgBoxStyle.Information, "İçerik Boş");
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0008ECD0 File Offset: 0x0008D0D0
		private void MakaleOzgunlestir()
		{
			this.ListBox1.Items.Clear();
			this.txt_ozgun.Text = "";
			this.Say = 0;
			this.Say2 = 0;
			this.iStartPosition = 0;
			this.iFindCount = 0;
			this.ListBox1.Items.Clear();
			MyProject.Forms.frm_bekle.Show();
			MyProject.Forms.frm_bekle.PictureBox1.Refresh();
			MyProject.Forms.frm_bekle.Label1.Refresh();
			this.txt_ozgun.ForeColor = Color.Black;
			this.txt_orjinal.Enabled = false;
			this.txt_ozgun.Enabled = false;
			if (Operators.CompareString(Strings.Mid(this.txt_orjinal.Text, 1, 1), " ", false) != 0)
			{
				this.txt_orjinal.Text = " " + this.txt_orjinal.Text;
			}
			else
			{
				this.txt_orjinal.Text = this.txt_orjinal.Text;
			}
			this.txt_ozgun.Text = this.txt_orjinal.Text;
			this.Ozelisimler();
			if (this.MakaleTuru == 0)
			{
				GenelModul.Cmd.CommandText = "select * from esanlamlilar order by kelime_adet desc,kelime_uzunluk desc";
			}
			else
			{
				GenelModul.Cmd.CommandText = "select * from esanlamlilar where kelime_tur=0 or kelime_tur=" + Conversions.ToString(this.MakaleTuru) + " order by kelime_adet desc,kelime_uzunluk desc";
			}
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			checked
			{
				while (oleDbDataReader.Read())
				{
					this.findTextAndHighlight(Conversions.ToString(oleDbDataReader["kelime"]), Conversions.ToString(oleDbDataReader["kelime_es_anlami"]), this.txt_orjinal, this.txt_ozgun);
					this.ReplaceALL(Conversions.ToString(oleDbDataReader["kelime"]), "[" + Conversions.ToString(this.Say - 1) + "]", this.txt_ozgun, true, false);
				}
				oleDbDataReader.Close();
				int num = 0;
				int num2 = this.ListBox1.Items.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					this.ReplaceALL("[" + Conversions.ToString(i) + "]", Conversions.ToString(this.ListBox1.Items[i]), this.txt_ozgun, true, false);
				}
				int num3 = 0;
				int num4 = this.ListBox1.Items.Count - 1;
				for (int j = num3; j <= num4; j++)
				{
					this.findTextAndHighlight3(Conversions.ToString(this.ListBox1.Items[j]), Conversions.ToString(this.ListBox1.Items[j]), this.txt_ozgun, this.txt_orjinal);
				}
				this.txt_orjinal.SelectionStart = 0;
				this.txt_orjinal.SelectionLength = 1;
				this.txt_orjinal.SelectedText = "";
				this.txt_ozgun.SelectionStart = 0;
				this.txt_ozgun.SelectionLength = 1;
				this.txt_ozgun.SelectedText = "";
				this.txt_orjinal.Enabled = true;
				this.txt_ozgun.Enabled = true;
				MyProject.Forms.frm_bekle.Close();
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0008EFF4 File Offset: 0x0008D3F4
		private void btn_yeni_Click(object sender, EventArgs e)
		{
			this.YeniBelge();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0008EFFC File Offset: 0x0008D3FC
		private void YeniBelge()
		{
			this.txt_orjinal.Text = "";
			this.txt_ozgun.Text = "";
			this.ListBox1.Items.Clear();
			this.Say = 0;
			this.Say2 = 0;
			this.iStartPosition = 0;
			this.iFindCount = 0;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0008F058 File Offset: 0x0008D458
		private void mnu_yapistir_Click(object sender, EventArgs e)
		{
			this.txt_orjinal.SelectedText = Clipboard.GetText();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0008F06C File Offset: 0x0008D46C
		private void mnu_orjinal_kopyala_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.txt_orjinal.SelectedText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0008F0AC File Offset: 0x0008D4AC
		private void btn_kelimeler_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_kelimeler.Show();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0008F0C0 File Offset: 0x0008D4C0
		public object TurListesi()
		{
			this.btn_tur.Items.Clear();
			this.btn_tur.Items.Add("Genel");
			GenelModul.Cmd.CommandText = "select * from turler order by tur_adi";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				this.btn_tur.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["tur_adi"]));
			}
			oleDbDataReader.Close();
			object result;
			return result;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0008F140 File Offset: 0x0008D540
		private void btn_tur_ButtonClick(object sender, EventArgs e)
		{
			Interaction.MsgBox(e.ToString(), MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0008F150 File Offset: 0x0008D550
		private void btn_tur_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0008F154 File Offset: 0x0008D554
		private void btn_tur_TextChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(this.btn_tur.SelectedItem, "", false))
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from turler where tur_adi='", this.btn_tur.SelectedItem), "'"));
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				try
				{
					this.MakaleTuru = Conversions.ToInteger(oleDbDataReader["tur_id"]);
				}
				catch (Exception ex)
				{
					this.MakaleTuru = 0;
				}
				oleDbDataReader.Close();
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0008F1FC File Offset: 0x0008D5FC
		private void sag_menu_3_Opening(object sender, CancelEventArgs e)
		{
			this.mnu_degistir.DropDownItems.Clear();
			this.mnu_duzen_oz_kelimeyi_degistir.DropDownItems.Clear();
			if (Operators.CompareString(Clipboard.GetText(), "", false) != 0)
			{
				this.mnu_yapistir_2.Enabled = true;
			}
			else
			{
				this.mnu_yapistir_2.Enabled = false;
			}
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				this.mnu_kopyala_2.Enabled = true;
				this.mnu_karistir.Enabled = true;
				this.mnu_ozel_isim.Enabled = true;
				this.mnu_sozluge_ekle.Enabled = true;
				this.mnu_karsilik_ekle.Enabled = true;
				if (Strings.Len(this.txt_ozgun.SelectedText) < 255)
				{
					if (this.MakaleTuru == 0)
					{
						GenelModul.Cmd.CommandText = "select * from esanlamlilar where kelime_tur=0 and kelime_es_anlami='" + Strings.Trim(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)) + "'";
					}
					else
					{
						GenelModul.Cmd.CommandText = string.Concat(new string[]
						{
							"select * from esanlamlilar where (kelime_tur=0 or kelime_tur=",
							Conversions.ToString(this.MakaleTuru),
							") and kelime_es_anlami='",
							Strings.Trim(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)),
							"'"
						});
					}
					OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
					while (oleDbDataReader.Read())
					{
						NewLateBinding.LateCall(this.mnu_degistir.DropDownItems, null, "Add", new object[]
						{
							RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime"])
						}, null, null, null, true);
						NewLateBinding.LateCall(this.mnu_duzen_oz_kelimeyi_degistir.DropDownItems, null, "Add", new object[]
						{
							RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime"])
						}, null, null, null, true);
					}
					oleDbDataReader.Close();
					if (this.mnu_degistir.DropDownItems.Count > 0)
					{
						this.mnu_degistir.Enabled = true;
						this.mnu_duzen_oz_kelimeyi_degistir.Enabled = true;
					}
					else
					{
						this.mnu_degistir.Enabled = false;
						this.mnu_duzen_oz_kelimeyi_degistir.Enabled = false;
					}
				}
			}
			else
			{
				this.mnu_degistir.Enabled = false;
				this.mnu_kopyala_2.Enabled = false;
				this.mnu_karistir.Enabled = false;
				this.mnu_ozel_isim.Enabled = false;
				this.mnu_sozluge_ekle.Enabled = false;
				this.mnu_karsilik_ekle.Enabled = false;
				this.mnu_duzen_oz_kelimeyi_degistir.Enabled = false;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0008F478 File Offset: 0x0008D878
		private void mnu_karistir_Click(object sender, EventArgs e)
		{
			checked
			{
				if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
				{
					string[] array = Strings.Split(this.txt_ozgun.SelectedText, ",", -1, CompareMethod.Binary);
					Array.Reverse(array);
					int num = 0;
					int num2 = Information.UBound(array, 1);
					string text;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(array[i], "", false) != 0)
						{
							text = text + Strings.Trim(array[i]) + ", ";
						}
					}
					this.txt_ozgun.SelectedText = Strings.Mid(text, 1, Strings.Len(text) - 2);
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0008F510 File Offset: 0x0008D910
		private void mnu_ozel_isim_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				GenelModul.Cmd.CommandText = "insert into ozelisimler (ozelisim) values ('" + Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)) + "')";
				GenelModul.Cmd.ExecuteNonQuery();
				this.txt_ozgun.SelectedText = Strings.StrConv(this.txt_ozgun.SelectedText, VbStrConv.ProperCase, 0);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0008F58C File Offset: 0x0008D98C
		private void mnu_kopyala_2_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.txt_ozgun.SelectedText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0008F5CC File Offset: 0x0008D9CC
		private void mnu_yapistir_2_Click(object sender, EventArgs e)
		{
			this.txt_ozgun.SelectedText = Clipboard.GetText();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0008F5E0 File Offset: 0x0008D9E0
		private void Ozelisimler()
		{
			GenelModul.Cmd.CommandText = "select * from ozelisimler";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				this.ReplaceALL(Conversions.ToString(oleDbDataReader["ozelisim"]), Strings.StrConv(Conversions.ToString(oleDbDataReader["ozelisim"]), VbStrConv.ProperCase, 0), this.txt_ozgun, true, false);
			}
			oleDbDataReader.Close();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0008F64C File Offset: 0x0008DA4C
		private void mnu_tumunu_sec_Click(object sender, EventArgs e)
		{
			this.txt_ozgun.SelectAll();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0008F65C File Offset: 0x0008DA5C
		private void btn_ac_Click(object sender, EventArgs e)
		{
			this.DosyaAc();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0008F668 File Offset: 0x0008DA68
		public object DosyaAc()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Metin Dosyası|*.txt";
			openFileDialog.Title = "Lütfen bir dosya seçin";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txt_orjinal.Text = "";
				this.txt_ozgun.Text = "";
				this.ListBox1.Items.Clear();
				this.Say = 0;
				this.Say2 = 0;
				this.iStartPosition = 0;
				this.iFindCount = 0;
				this.txt_orjinal.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
			}
			object result;
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0008F6FC File Offset: 0x0008DAFC
		private void btn_kaydet_Click(object sender, EventArgs e)
		{
			this.DosyaKaydet();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0008F708 File Offset: 0x0008DB08
		public object DosyaKaydet()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Metin Dosyası|*.txt";
			saveFileDialog.Title = "Lütfen bir dosya seçin";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txt_ozgun.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
			}
			object result;
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0008F750 File Offset: 0x0008DB50
		private void txt_orjinal_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_orjinal.Text, "", false) == 0 | Operators.CompareString(this.txt_orjinal.Text, "Bu alana orijinal içerik yazılacaktır", false) == 0)
			{
				this.txt_orjinal.Text = "";
				this.txt_orjinal.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0008F7B4 File Offset: 0x0008DBB4
		private void txt_orjinal_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_orjinal.Text, "", false) == 0 | Operators.CompareString(this.txt_orjinal.Text, "Bu alana orijinal içerik yazılacaktır", false) == 0)
			{
				this.txt_orjinal.Text = "Bu alana orijinal içerik yazılacaktır";
				this.txt_orjinal.ForeColor = Color.Gray;
			}
			else
			{
				this.txt_orjinal.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0008F828 File Offset: 0x0008DC28
		private void txt_orjinal_TextChanged(object sender, EventArgs e)
		{
			this.lbl_orjinal_kelime_say.Text = "Orijinal Metin : " + Conversions.ToString(Form1.WordCount(this.txt_orjinal.Text)) + " kelime";
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0008F85C File Offset: 0x0008DC5C
		public static int WordCount(string s)
		{
			return s.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries).Length;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0008F880 File Offset: 0x0008DC80
		private void txt_ozgun_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.Text, "", false) == 0 | Operators.CompareString(this.txt_ozgun.Text, "Bu alanda özgün içerik oluşturulacaktır", false) == 0)
			{
				this.txt_ozgun.Text = "";
				this.txt_ozgun.ForeColor = Color.Black;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0008F8E4 File Offset: 0x0008DCE4
		private void txt_ozgun_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.Text, "", false) == 0 | Operators.CompareString(this.txt_ozgun.Text, "Bu alanda özgün içerik oluşturulacaktır", false) == 0)
			{
				this.txt_ozgun.Text = "Bu alanda özgün içerik oluşturulacaktır";
				this.txt_ozgun.ForeColor = Color.Gray;
			}
			else
			{
				this.txt_ozgun.ForeColor = Color.Black;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0008F958 File Offset: 0x0008DD58
		private void txt_ozgun_TextChanged(object sender, EventArgs e)
		{
			this.lbl_ozgun_kelime_say.Text = "Özgün Metin : " + Conversions.ToString(Form1.WordCount(this.txt_ozgun.Text)) + " kelime";
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0008F98C File Offset: 0x0008DD8C
		private void mnu_yeni_belge_Click(object sender, EventArgs e)
		{
			this.YeniBelge();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0008F994 File Offset: 0x0008DD94
		private void mnu_dosyadan_ac_Click(object sender, EventArgs e)
		{
			this.DosyaAc();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0008F9A0 File Offset: 0x0008DDA0
		private void mnu_belge_kaydet_Click(object sender, EventArgs e)
		{
			this.DosyaKaydet();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0008F9AC File Offset: 0x0008DDAC
		private void mnu_ozgunlestir_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_orjinal.Text, "Bu alana orijinal içerik yazılacaktır", false) != 0 & Operators.CompareString(this.txt_orjinal.Text, "", false) != 0)
			{
				this.MakaleOzgunlestir();
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0008F9FC File Offset: 0x0008DDFC
		private void mnu_kelime_yonetimi_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_kelimeler.Show();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0008FA10 File Offset: 0x0008DE10
		private void mnu_tumunu_sec_2_Click(object sender, EventArgs e)
		{
			this.txt_orjinal.SelectAll();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0008FA20 File Offset: 0x0008DE20
		private void btn_yazim_denetimi_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.Text, "", false) != 0 & Operators.CompareString(this.txt_ozgun.Text, "Bu alanda özgün içerik oluşturulacaktır", false) != 0)
			{
				this.YazimDenetimi();
			}
			else
			{
				Interaction.MsgBox("Yazım denetimi için öncelikle özgünleştirme işlemini başlatınız!", MsgBoxStyle.Information, "İçerik Boş");
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0008FA84 File Offset: 0x0008DE84
		private void YazimDenetimi()
		{
			MyProject.Forms.frm_bekle.Show();
			MyProject.Forms.frm_bekle.Label1.Refresh();
			MyProject.Forms.frm_bekle.PictureBox1.Refresh();
			string[] array = Strings.Split(this.NoktalamaTemizle(this.txt_ozgun.Text), " ", -1, CompareMethod.Binary);
			int num = 0;
			int num2 = Information.UBound(array, 1);
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					if (Strings.Len(array[i]) > 1 & Operators.CompareString(array[i], " ", false) != 0 & !Versioned.IsNumeric(array[i]))
					{
						string text = array[i];
						GenelModul.Cmd.CommandText = "select count(*) as Total from sozluk where kelime='" + text + "'";
						OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
						oleDbDataReader.Read();
						if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Total"], 0, false))
						{
							this.findTextAndUnderline(text, this.txt_ozgun);
						}
						oleDbDataReader.Close();
					}
				}
				MyProject.Forms.frm_bekle.Close();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0008FB9C File Offset: 0x0008DF9C
		public string NoktalamaTemizle(string icerik)
		{
			string expression = Strings.Replace(icerik, "'", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "`", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "´", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, Conversions.ToString(Strings.Chr(145)), " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, Conversions.ToString(Strings.Chr(147)), " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, Conversions.ToString(Strings.Chr(148)), " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "!", "", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "\"", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, ",", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "(", "", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, ")", "", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "-", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, ".", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, ";", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, ":", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "\n", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "’", " ", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "*", "", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "/", "", 1, -1, CompareMethod.Binary);
			expression = Strings.Replace(expression, "?", "", 1, -1, CompareMethod.Binary);
			return Strings.Replace(expression, "•", "", 1, -1, CompareMethod.Binary);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0008FD6C File Offset: 0x0008E16C
		public void findTextAndUnderline(string searchtext, RichTextBox rtb)
		{
			int textLength = rtb.TextLength;
			int i = 0;
			Font selectionFont = new Font(rtb.Font, FontStyle.Underline);
			int num = rtb.Text.LastIndexOf(searchtext);
			while (i < num)
			{
				rtb.Find(searchtext, i, textLength, RichTextBoxFinds.None);
				rtb.SelectionFont = selectionFont;
				rtb.SelectionLength = searchtext.Length;
				rtb.SelectionColor = Color.Gray;
				i = checked(rtb.Text.IndexOf(searchtext, i) + 1);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0008FDDC File Offset: 0x0008E1DC
		private void mnu_sozluge_ekle_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				GenelModul.Cmd.CommandText = "select count(*) as Total from sozluk where kelime='" + Strings.Trim(Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText))) + "'";
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				bool flag = Operators.ConditionalCompareObjectEqual(oleDbDataReader["Total"], 0, false);
				oleDbDataReader.Close();
				if (flag)
				{
					GenelModul.Cmd.CommandText = "insert into sozluk (kelime) values ('" + Strings.Trim(Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText))) + "')";
					GenelModul.Cmd.ExecuteNonQuery();
				}
				Font selectionFont = new Font(this.txt_ozgun.Font, FontStyle.Regular);
				this.txt_ozgun.SelectionColor = Color.Black;
				this.txt_ozgun.SelectionFont = selectionFont;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0008FEE0 File Offset: 0x0008E2E0
		private void UcaseFirstWordinSentence()
		{
			string[] array = Strings.Split(this.txt_ozgun.Text, "\n", -1, CompareMethod.Binary);
			int num = 0;
			int num2 = Information.UBound(array, 1);
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					Interaction.MsgBox(array[i], MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0008FF24 File Offset: 0x0008E324
		private void mnu_degistir_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.txt_ozgun.SelectedText = e.ClickedItem.Text;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0008FF3C File Offset: 0x0008E33C
		private void sag_menu_2_Opening(object sender, CancelEventArgs e)
		{
			if (Operators.CompareString(Clipboard.GetText(), "", false) != 0)
			{
				this.mnu_yapistir.Enabled = true;
			}
			else
			{
				this.mnu_yapistir.Enabled = false;
			}
			if (Operators.CompareString(this.txt_orjinal.SelectedText, "", false) != 0)
			{
				this.mnu_orjinal_kopyala.Enabled = true;
			}
			else
			{
				this.mnu_orjinal_kopyala.Enabled = false;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0008FFAC File Offset: 0x0008E3AC
		public object KelimeListesi()
		{
			this.ListBox2.Items.Clear();
			GenelModul.Cmd.CommandText = "select top 20 * from sozluk where kelime like '" + this.Aranan + "%' order by kelime";
			OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
			while (oleDbDataReader.Read())
			{
				this.ListBox2.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime"]));
			}
			oleDbDataReader.Close();
			object result;
			return result;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00090028 File Offset: 0x0008E428
		private void ListBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sozluk where kelime='", this.ListBox2.SelectedItem), "'"));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListBox2.Items.Remove(RuntimeHelpers.GetObjectValue(this.ListBox2.SelectedItem));
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000900AC File Offset: 0x0008E4AC
		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000900B0 File Offset: 0x0008E4B0
		private void txt_ara_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Sözlükte Ara", false) != 0 & Operators.CompareString(this.txt_ara.Text, "", false) != 0)
			{
				this.Aranan = GenelModul.StringTemizle(this.txt_ara.Text);
				this.KelimeListesi();
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00090118 File Offset: 0x0008E518
		private void mnu_kelime_yonetimi_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.frm_kelimeler.Show();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0009012C File Offset: 0x0008E52C
		private void mnu_yazim_denetimi_Click(object sender, EventArgs e)
		{
			this.YazimDenetimi();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00090134 File Offset: 0x0008E534
		private void mnu_hakkinda_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_splash.Show();
			MyProject.Forms.frm_splash.btn_kapat.Visible = true;
			MyProject.Forms.frm_splash.ProgressBar1.Visible = false;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00090170 File Offset: 0x0008E570
		private void mnu_ozel_isimler_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_ozel_sisimler.Show();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00090184 File Offset: 0x0008E584
		private void mnu_kelime_sil_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("Seçilen kayıt silinecek onaylıyor musunuz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Kayıt Silinsin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.Cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sozluk where kelime='", this.ListBox2.SelectedItem), "'"));
				GenelModul.Cmd.ExecuteNonQuery();
				this.ListBox2.Items.Remove(RuntimeHelpers.GetObjectValue(this.ListBox2.SelectedItem));
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00090200 File Offset: 0x0008E600
		private void btn_ozel_isimler_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_ozel_sisimler.Show();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00090214 File Offset: 0x0008E614
		private void txt_ara_GotFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "Sözlükte Ara", false) == 0)
			{
				this.txt_ara.Text = "";
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0009025C File Offset: 0x0008E65C
		private void txt_ara_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ara.Text, "", false) == 0 | Operators.CompareString(this.txt_ara.Text, "Sözlükte Ara", false) == 0)
			{
				this.txt_ara.Text = "Sözlükte Ara";
				this.txt_ara.ForeColor = Color.Gray;
			}
			else
			{
				this.txt_ara.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000902D0 File Offset: 0x0008E6D0
		private void duzen_orj_kopyala_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.txt_orjinal.SelectedText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00090310 File Offset: 0x0008E710
		private void duzen_orj_yapistir_Click(object sender, EventArgs e)
		{
			this.txt_orjinal.SelectedText = Clipboard.GetText();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00090324 File Offset: 0x0008E724
		private void duzen_orj_tumunu_sec_Click(object sender, EventArgs e)
		{
			this.txt_orjinal.SelectAll();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00090334 File Offset: 0x0008E734
		private void duzen_oz_kopyala_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.txt_ozgun.SelectedText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00090374 File Offset: 0x0008E774
		private void duzen_oz_yapistir_Click(object sender, EventArgs e)
		{
			this.txt_ozgun.SelectedText = Clipboard.GetText();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00090388 File Offset: 0x0008E788
		private void mnu_duzen_oz_tumunu_sec_Click(object sender, EventArgs e)
		{
			this.txt_ozgun.SelectAll();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00090398 File Offset: 0x0008E798
		private void mnu_duzen_tersine_cevir_Click(object sender, EventArgs e)
		{
			checked
			{
				if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
				{
					string[] array = Strings.Split(this.txt_ozgun.SelectedText, ",", -1, CompareMethod.Binary);
					Array.Reverse(array);
					int num = 0;
					int num2 = Information.UBound(array, 1);
					string text;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(array[i], "", false) != 0)
						{
							text = text + Strings.Trim(array[i]) + ", ";
						}
					}
					this.txt_ozgun.SelectedText = Strings.Mid(text, 1, Strings.Len(text) - 2);
				}
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00090430 File Offset: 0x0008E830
		private void mnu_duzen_oz_ozel_isim_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				GenelModul.Cmd.CommandText = "insert into ozelisimler (ozelisim) values ('" + Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)) + "')";
				GenelModul.Cmd.ExecuteNonQuery();
				this.txt_ozgun.SelectedText = Strings.StrConv(this.txt_ozgun.SelectedText, VbStrConv.ProperCase, 0);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000904AC File Offset: 0x0008E8AC
		private void mnu_duzen_oz_sozluge_ekle_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				GenelModul.Cmd.CommandText = "select count(*) as Total from sozluk where kelime='" + Strings.Trim(Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText))) + "'";
				OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
				oleDbDataReader.Read();
				bool flag = Operators.ConditionalCompareObjectEqual(oleDbDataReader["Total"], 0, false);
				oleDbDataReader.Close();
				if (flag)
				{
					GenelModul.Cmd.CommandText = "insert into sozluk (kelime) values ('" + Strings.Trim(Strings.LCase(GenelModul.StringTemizle(this.txt_ozgun.SelectedText))) + "')";
					GenelModul.Cmd.ExecuteNonQuery();
				}
				Font selectionFont = new Font(this.txt_ozgun.Font, FontStyle.Regular);
				this.txt_ozgun.SelectionColor = Color.Black;
				this.txt_ozgun.SelectionFont = selectionFont;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000905B0 File Offset: 0x0008E9B0
		private void mnu_duzen_oz_kelimeyi_degistir_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000905B4 File Offset: 0x0008E9B4
		private void DüzenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mnu_duzen_oz_kelimeyi_degistir.DropDownItems.Clear();
			if (Operators.CompareString(Clipboard.GetText(), "", false) != 0)
			{
				this.duzen_oz_yapistir.Enabled = true;
			}
			else
			{
				this.duzen_oz_yapistir.Enabled = false;
			}
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				this.duzen_oz_kopyala.Enabled = true;
				this.mnu_duzen_tersine_cevir.Enabled = true;
				this.mnu_duzen_oz_ozel_isim.Enabled = true;
				this.mnu_duzen_oz_sozluge_ekle.Enabled = true;
				this.mnu_karsilik_ekle_2.Enabled = true;
				if (Strings.Len(this.txt_ozgun.SelectedText) < 255)
				{
					if (this.MakaleTuru == 0)
					{
						GenelModul.Cmd.CommandText = "select * from esanlamlilar where kelime_tur=0 and kelime_es_anlami='" + Strings.Trim(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)) + "'";
					}
					else
					{
						GenelModul.Cmd.CommandText = string.Concat(new string[]
						{
							"select * from esanlamlilar where (kelime_tur=0 or kelime_tur=",
							Conversions.ToString(this.MakaleTuru),
							") and kelime_es_anlami='",
							Strings.Trim(GenelModul.StringTemizle(this.txt_ozgun.SelectedText)),
							"'"
						});
					}
					OleDbDataReader oleDbDataReader = GenelModul.Cmd.ExecuteReader();
					while (oleDbDataReader.Read())
					{
						NewLateBinding.LateCall(this.mnu_duzen_oz_kelimeyi_degistir.DropDownItems, null, "Add", new object[]
						{
							RuntimeHelpers.GetObjectValue(oleDbDataReader["kelime"])
						}, null, null, null, true);
					}
					oleDbDataReader.Close();
					if (this.mnu_degistir.DropDownItems.Count > 0)
					{
						this.mnu_duzen_oz_kelimeyi_degistir.Enabled = true;
					}
					else
					{
						this.mnu_duzen_oz_kelimeyi_degistir.Enabled = false;
					}
				}
			}
			else
			{
				this.duzen_oz_kopyala.Enabled = false;
				this.mnu_duzen_tersine_cevir.Enabled = false;
				this.mnu_duzen_oz_ozel_isim.Enabled = false;
				this.mnu_duzen_oz_sozluge_ekle.Enabled = false;
				this.mnu_duzen_oz_kelimeyi_degistir.Enabled = false;
				this.mnu_karsilik_ekle_2.Enabled = false;
			}
			if (Operators.CompareString(Clipboard.GetText(), "", false) != 0)
			{
				this.duzen_orj_yapistir.Enabled = true;
			}
			else
			{
				this.duzen_orj_yapistir.Enabled = false;
			}
			if (Operators.CompareString(this.txt_orjinal.SelectedText, "", false) != 0)
			{
				this.duzen_orj_kopyala.Enabled = true;
			}
			else
			{
				this.duzen_orj_kopyala.Enabled = false;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00090828 File Offset: 0x0008EC28
		private void btn_makale_gonder_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_makale_gonder.Show();
			if (Operators.CompareString(this.txt_ozgun.Text, "Bu alanda özgün içerik oluşturulacaktır", false) != 0)
			{
				MyProject.Forms.frm_makale_gonder.txtpost.Text = this.txt_ozgun.Text;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0009087C File Offset: 0x0008EC7C
		private void mnu_site_yonetimi_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_site_yonetimi.Show();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00090890 File Offset: 0x0008EC90
		private void mnu_lisans_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_lisans.Show();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000908A4 File Offset: 0x0008ECA4
		private void mnu_kategori_yonetimi_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_kategori.Show();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000908B8 File Offset: 0x0008ECB8
		private void mnu_yardim_Click(object sender, EventArgs e)
		{
			string fileName = "http://redax.edisteknoloji.com/yardim/yardim.html";
			Process.Start(fileName);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000908D4 File Offset: 0x0008ECD4
		public object SecimiSifirla(RichTextBox rtb)
		{
			int textLength = rtb.TextLength;
			Font selectionFont = new Font(rtb.Font, FontStyle.Regular);
			rtb.SelectAll();
			rtb.SelectionFont = selectionFont;
			rtb.SelectionColor = Color.Black;
			rtb.SelectionBackColor = Color.White;
			object result;
			return result;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0009091C File Offset: 0x0008ED1C
		private void mnu_karsilik_ekle_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				MyProject.Forms.frm_kelimeler.Show();
				MyProject.Forms.frm_kelimeler.txt_kelime.Text = this.txt_ozgun.SelectedText;
				MyProject.Forms.frm_kelimeler.txt_esanlami.Focus();
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00090988 File Offset: 0x0008ED88
		private void mnu_karsilik_ekle_2_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txt_ozgun.SelectedText, "", false) != 0)
			{
				MyProject.Forms.frm_kelimeler.Show();
				MyProject.Forms.frm_kelimeler.txt_kelime.Text = this.txt_ozgun.SelectedText;
				MyProject.Forms.frm_kelimeler.txt_esanlami.Focus();
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000909F4 File Offset: 0x0008EDF4
		private void mnu_yedekle_Click(object sender, EventArgs e)
		{
			this.Yedekle();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00090A00 File Offset: 0x0008EE00
		public object Yedekle()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Yedek Dosyası|*.bak";
			saveFileDialog.Title = "Lütfen bir yedek dosyası seçin";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.Copy(GenelModul.RedaXDataPath + "\\Data\\\\ozgundata.mdb", saveFileDialog.FileName, true);
				Interaction.MsgBox("Veritabanı başarıyla yedeklendi", MsgBoxStyle.Information, "Veritabanı Yedeklendi");
			}
			object result;
			return result;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00090A60 File Offset: 0x0008EE60
		public object YedekAc()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Yedek Dosyası|*.bak";
			openFileDialog.Title = "Lütfen bir yedek dosyası seçin";
			if (openFileDialog.ShowDialog() == DialogResult.OK && Interaction.MsgBox("Bu işlem mevcut verilerinizin kaybolmasına neden olacaktır, işleme devam etmek istediğinizden emin misiniz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Yedek Yüklensin mi?") == MsgBoxResult.Yes)
			{
				GenelModul.OleDbConnection.Close();
				File.Copy(openFileDialog.FileName, GenelModul.RedaXDataPath + "\\Data\\\\ozgundata.mdb", true);
				GenelModul.OleDbConnection.Open();
				Interaction.MsgBox("Yedek dosyası başarıyla yüklendi", MsgBoxStyle.Information, "Veritabanı Güncellendi");
			}
			object result;
			return result;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00090AE8 File Offset: 0x0008EEE8
		private void mnu_yedek_yukle_Click(object sender, EventArgs e)
		{
			this.YedekAc();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00090AF4 File Offset: 0x0008EEF4
		private void mnu_guncelle_Click(object sender, EventArgs e)
		{
			this.GuncellemeDenetle(false);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00090B00 File Offset: 0x0008EF00
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void GuncellemeDenetle(bool Otomatik)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://redax.edisteknoloji.com/versiyon.txt");
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string number = streamReader.ReadToEnd();
				if (Operators.ConditionalCompareObjectNotEqual(Conversion.Int(number), Conversion.Int(this.ProductVersion.Substring(6)), false))
				{
					if (Interaction.MsgBox("RedaX'ın şu anda kullandığınız sürümünden daha güncel bir sürüm mevcut, güncellemek ister misiniz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Güncelleme Bulundu") == MsgBoxResult.Yes)
					{
						Process.Start(Application.StartupPath + "\\Updater.exe", Conversions.ToString(1));
						ProjectData.EndApp();
					}
				}
				else if (!Otomatik)
				{
					Interaction.MsgBox("Şu anda kullandığınız sürüm güncel", MsgBoxStyle.Information, "Güncelleme Gerekmiyor");
				}
			}
			catch (Exception ex)
			{
				if (!Otomatik)
				{
					Interaction.MsgBox("Güncelleme denetimi yapılamadı, Lütfen daha sonra tekrar deneyin.", MsgBoxStyle.Exclamation, "Güncelleme Hatası");
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00090BE4 File Offset: 0x0008EFE4
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (this.GuncellemeKontrol < 60)
				{
					this.GuncellemeKontrol++;
				}
				else
				{
					this.Timer1.Enabled = false;
					this.GuncellemeDenetle(true);
				}
			}
		}

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("txt_orjinal")]
		private RichTextBox _txt_orjinal;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("txt_ozgun")]
		private RichTextBox _txt_ozgun;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("ListBox1")]
		private ListBox _ListBox1;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("mnu_kelime_sil")]
		private ToolStripMenuItem _mnu_kelime_sil;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("btn_ozgunlestir")]
		private ToolStripButton _btn_ozgunlestir;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("DosyaToolStripMenuItem")]
		private ToolStripMenuItem _DosyaToolStripMenuItem;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("btn_yeni")]
		private ToolStripButton _btn_yeni;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("sag_menu_2")]
		private ContextMenuStrip _sag_menu_2;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("mnu_orjinal_kopyala")]
		private ToolStripMenuItem _mnu_orjinal_kopyala;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("mnu_yapistir")]
		private ToolStripMenuItem _mnu_yapistir;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("btn_kelimeler")]
		private ToolStripButton _btn_kelimeler;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("btn_tur")]
		private ToolStripComboBox _btn_tur;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("sag_menu_3")]
		private ContextMenuStrip _sag_menu_3;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("mnu_karistir")]
		private ToolStripMenuItem _mnu_karistir;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("mnu_ozel_isim")]
		private ToolStripMenuItem _mnu_ozel_isim;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("mnu_kopyala_2")]
		private ToolStripMenuItem _mnu_kopyala_2;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("mnu_yapistir_2")]
		private ToolStripMenuItem _mnu_yapistir_2;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripSeparator _ToolStripMenuItem1;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("mnu_tumunu_sec")]
		private ToolStripMenuItem _mnu_tumunu_sec;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripSeparator _ToolStripMenuItem2;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("btn_ac")]
		private ToolStripButton _btn_ac;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("btn_kaydet")]
		private ToolStripButton _btn_kaydet;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("lbl_orjinal_kelime_say")]
		private ToolStripStatusLabel _lbl_orjinal_kelime_say;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("lbl_ozgun_kelime_say")]
		private ToolStripStatusLabel _lbl_ozgun_kelime_say;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("mnu_yeni_belge")]
		private ToolStripMenuItem _mnu_yeni_belge;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("mnu_dosyadan_ac")]
		private ToolStripMenuItem _mnu_dosyadan_ac;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("mnu_belge_kaydet")]
		private ToolStripMenuItem _mnu_belge_kaydet;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripSeparator _ToolStripMenuItem3;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("mnu_ozgunlestir")]
		private ToolStripMenuItem _mnu_ozgunlestir;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("DüzenToolStripMenuItem")]
		private ToolStripMenuItem _DüzenToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("YardımToolStripMenuItem")]
		private ToolStripMenuItem _YardımToolStripMenuItem;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripSeparator _ToolStripMenuItem4;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("mnu_tumunu_sec_2")]
		private ToolStripMenuItem _mnu_tumunu_sec_2;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("btn_yazim_denetimi")]
		private ToolStripButton _btn_yazim_denetimi;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("mnu_sozluge_ekle")]
		private ToolStripMenuItem _mnu_sozluge_ekle;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("mnu_degistir")]
		private ToolStripMenuItem _mnu_degistir;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("ListBox2")]
		private ListBox _ListBox2;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("txt_ara")]
		private TextBox _txt_ara;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("AyarlarToolStripMenuItem")]
		private ToolStripMenuItem _AyarlarToolStripMenuItem;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("mnu_kelime_yonetimi")]
		private ToolStripMenuItem _mnu_kelime_yonetimi;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("mnu_yazim_denetimi")]
		private ToolStripMenuItem _mnu_yazim_denetimi;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("mnu_hakkinda")]
		private ToolStripMenuItem _mnu_hakkinda;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("mnu_ozel_isimler")]
		private ToolStripMenuItem _mnu_ozel_isimler;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("btn_ozel_isimler")]
		private ToolStripButton _btn_ozel_isimler;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("OrijinalİçerikToolStripMenuItem")]
		private ToolStripMenuItem _OrijinalİçerikToolStripMenuItem;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("duzen_orj_kopyala")]
		private ToolStripMenuItem _duzen_orj_kopyala;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("duzen_orj_yapistir")]
		private ToolStripMenuItem _duzen_orj_yapistir;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripSeparator _ToolStripMenuItem5;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("duzen_orj_tumunu_sec")]
		private ToolStripMenuItem _duzen_orj_tumunu_sec;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("ÖzgünİçerikToolStripMenuItem")]
		private ToolStripMenuItem _ÖzgünİçerikToolStripMenuItem;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("duzen_oz_kopyala")]
		private ToolStripMenuItem _duzen_oz_kopyala;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("duzen_oz_yapistir")]
		private ToolStripMenuItem _duzen_oz_yapistir;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("ToolStripMenuItem6")]
		private ToolStripSeparator _ToolStripMenuItem6;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("mnu_duzen_oz_tumunu_sec")]
		private ToolStripMenuItem _mnu_duzen_oz_tumunu_sec;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("ToolStripMenuItem7")]
		private ToolStripSeparator _ToolStripMenuItem7;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("mnu_duzen_tersine_cevir")]
		private ToolStripMenuItem _mnu_duzen_tersine_cevir;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("mnu_duzen_oz_ozel_isim")]
		private ToolStripMenuItem _mnu_duzen_oz_ozel_isim;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("mnu_duzen_oz_sozluge_ekle")]
		private ToolStripMenuItem _mnu_duzen_oz_sozluge_ekle;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("mnu_duzen_oz_kelimeyi_degistir")]
		private ToolStripMenuItem _mnu_duzen_oz_kelimeyi_degistir;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("btn_makale_gonder")]
		private ToolStripButton _btn_makale_gonder;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("mnu_site_yonetimi")]
		private ToolStripMenuItem _mnu_site_yonetimi;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("mnu_lisans")]
		private ToolStripMenuItem _mnu_lisans;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("mnu_kategori_yonetimi")]
		private ToolStripMenuItem _mnu_kategori_yonetimi;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("mnu_yardim")]
		private ToolStripMenuItem _mnu_yardim;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("mnu_karsilik_ekle")]
		private ToolStripMenuItem _mnu_karsilik_ekle;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("mnu_karsilik_ekle_2")]
		private ToolStripMenuItem _mnu_karsilik_ekle_2;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("ToolStripMenuItem8")]
		private ToolStripSeparator _ToolStripMenuItem8;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("mnu_yedekle")]
		private ToolStripMenuItem _mnu_yedekle;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("mnu_yedek_yukle")]
		private ToolStripMenuItem _mnu_yedek_yukle;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("ToolStripMenuItem10")]
		private ToolStripSeparator _ToolStripMenuItem10;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("mnu_guncelle")]
		private ToolStripMenuItem _mnu_guncelle;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000075 RID: 117
		private Regex RegXMatch;

		// Token: 0x04000076 RID: 118
		private int Say;

		// Token: 0x04000077 RID: 119
		private int Say2;

		// Token: 0x04000078 RID: 120
		public int iStartPosition;

		// Token: 0x04000079 RID: 121
		public int iFindCount;

		// Token: 0x0400007A RID: 122
		private int MakaleTuru;

		// Token: 0x0400007B RID: 123
		private int DegisenKelimeSay;

		// Token: 0x0400007C RID: 124
		private int SecimBasla;

		// Token: 0x0400007D RID: 125
		private int SecimBitir;

		// Token: 0x0400007E RID: 126
		private string Aranan;

		// Token: 0x0400007F RID: 127
		private int GuncellemeKontrol;
	}
}
