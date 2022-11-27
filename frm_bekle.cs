using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RedaX
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class frm_bekle : Form
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00090C14 File Offset: 0x0008F014
		public frm_bekle()
		{
			base.Load += this.frm_bekle_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00090E8C File Offset: 0x0008F28C
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00090EA0 File Offset: 0x0008F2A0
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00090EAC File Offset: 0x0008F2AC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00090EC0 File Offset: 0x0008F2C0
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00090ECC File Offset: 0x0008F2CC
		private void frm_bekle_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;
	}
}
