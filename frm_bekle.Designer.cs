namespace RedaX
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frm_bekle : global::System.Windows.Forms.Form
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00090C38 File Offset: 0x0008F038
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

		// Token: 0x06000142 RID: 322 RVA: 0x00090C78 File Offset: 0x0008F078
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RedaX.frm_bekle));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Label1.ForeColor = global::System.Drawing.Color.Gray;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(51, 32);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(273, 21);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "İşlem devam ederken lütfen bekleyin...";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(15, 27);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(34, 35);
			pictureBox2.Size = size;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.PaleGreen;
			size = new global::System.Drawing.Size(334, 85);
			this.ClientSize = size;
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_bekle";
			this.Opacity = 0.95;
			this.ShowIcon = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_bekle";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000080 RID: 128
		private global::System.ComponentModel.IContainer components;
	}
}
