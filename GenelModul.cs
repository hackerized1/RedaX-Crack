using System;
using System.Data.OleDb;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RedaX.My;

namespace RedaX
{
	// Token: 0x0200001D RID: 29
	[StandardModule]
	internal sealed class GenelModul
	{
		// Token: 0x06000262 RID: 610 RVA: 0x000894F0 File Offset: 0x000878F0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void DataConnect()
		{
			if (File.Exists(GenelModul.RedaXDataPath + "\\Data\\\\ozgundata.mdb"))
			{
				GenelModul.OleDbConnection = new OleDbConnection();
				GenelModul.OleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GenelModul.RedaXDataPath + "\\Data\\\\ozgundata.mdb;Persist Security Info=False;Jet OLEDB:Database Password=SGmafZg4vspLr6Ek7y!?;";
				GenelModul.OleDbConnection.Open();
				GenelModul.Cmd = new OleDbCommand();
				GenelModul.Cmd.Connection = GenelModul.OleDbConnection;
			}
			else
			{
				MyProject.Forms.frm_splash.Close();
				Interaction.MsgBox("RedaX veritabanı hatası, Lütfen uygulamayı yeniden kurmayı deneyin!", MsgBoxStyle.Critical, "Veritabanı Hatası!");
				ProjectData.EndApp();
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00089588 File Offset: 0x00087988
		public static string App_Path()
		{
			return AppDomain.CurrentDomain.BaseDirectory;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000895A0 File Offset: 0x000879A0
		public static string StringTemizle(string girdi)
		{
			return Strings.Replace(girdi, "'", "", 1, -1, CompareMethod.Binary);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000895C4 File Offset: 0x000879C4
		public static string HDDSerial()
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from  Win32_LogicalDisk");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			string result;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					string text = Conversions.ToString(managementObject["Volumename"]);
					string arg = Conversions.ToString(managementObject["Volumeserialnumber"]);
					string text2 = string.Format("{0}", arg);
					result = text2;
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0008965C File Offset: 0x00087A5C
		public static string MD5(string yazi)
		{
			checked
			{
				string result;
				try
				{
					MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
					byte[] bytes = Encoding.ASCII.GetBytes(yazi);
					byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
					int capacity = (int)Math.Round(unchecked((double)(checked(array.Length * 2)) + (double)array.Length / 8.0));
					StringBuilder stringBuilder = new StringBuilder(capacity);
					int num = 0;
					int num2 = array.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						stringBuilder.Append(BitConverter.ToString(array, i, 1));
					}
					result = stringBuilder.ToString().TrimEnd(new char[]
					{
						' '
					});
				}
				catch (Exception ex)
				{
					result = "0";
				}
				return result;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00089714 File Offset: 0x00087B14
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static object LisansKontrol()
		{
			try
			{
				GenelModul.DateTimeNow = Conversions.ToDate(GenelModul.TarihFormatla(Daytime.GetTime() + DateTimeOffset.Now.Offset));
			}
			catch (Exception ex)
			{
				MyProject.Forms.frm_splash.Close();
				Interaction.MsgBox("Lisans kontrolü yapılamıyor!, Lütfen internet bağlantınızın olduğundan emin olun!", MsgBoxStyle.Critical, "Lisans kontrolü yapılamadı!");
				ProjectData.EndApp();
			}
			if (!File.Exists(GenelModul.WindowsTemp1 + "rdxins.wav"))
			{
				GenelModul.SaveTextToFile(Conversions.ToString(DateTime.Today), GenelModul.WindowsTemp1 + "rdxins.wav", "");
				GenelModul.RecDate = Conversions.ToDate(GenelModul.TarihFormatla(GenelModul.DateTimeNow));
				GenelModul.LSonTar = DateAndTime.DateAdd(DateInterval.Day, 15.0, GenelModul.DateTimeNow);
			}
			else
			{
				string fullPath = GenelModul.WindowsTemp1 + "rdxins.wav";
				string text = "";
				GenelModul.RecDate = Conversions.ToDate(GenelModul.TarihFormatla(Conversions.ToDate(GenelModul.GetFileContents(fullPath, ref text))));
				GenelModul.LSonTar = Conversions.ToDate(GenelModul.TarihFormatla(DateAndTime.DateAdd(DateInterval.Day, 15.0, GenelModul.RecDate)));
			}
			object result;
			if (File.Exists(GenelModul.WindowsTemp1 + "rdxexp.wav") | File.Exists(GenelModul.WindowsTemp2 + "rdxexc.wav"))
			{
				GenelModul.LisansDurum = false;
				GenelModul.LisansBitti();
			}
			else if (File.Exists(GenelModul.RedaXDataPath + "\\libocat.bls"))
			{
				string fullPath2 = GenelModul.RedaXDataPath + "\\libocat.bls";
				string text = "";
				string fileContents = GenelModul.GetFileContents(fullPath2, ref text);
				string[] array = Strings.Split(fileContents, ",", -1, CompareMethod.Binary);
				if (Operators.CompareString(GenelModul.MD5(array[0] + GenelModul.TarihFormatla(GenelModul.RecDate) + GenelModul.MD5(GenelModul.HDDSerial())), array[1], false) != 0)
				{
					GenelModul.LisansDurum = false;
					GenelModul.LisansBitti();
				}
				else
				{
					GenelModul.LisansSahibi = array[0];
					GenelModul.LisansDurum = true;
					GenelModul.LisansKontrolEdildi = true;
				}
			}
			else
			{
				GenelModul.LisansDurum = false;
				if (File.Exists(GenelModul.WindowsTemp1 + "rdxins.wav"))
				{
					DateTime creationTime = File.GetCreationTime(GenelModul.WindowsTemp1 + "rdxins.wav");
					if (Operators.CompareString(GenelModul.TarihFormatla(creationTime), GenelModul.TarihFormatla(GenelModul.RecDate), false) != 0)
					{
						GenelModul.LisansDurum = false;
						GenelModul.LisansBitti();
						return result;
					}
				}
				if (DateAndTime.DateDiff(DateInterval.Day, GenelModul.DateTimeNow, GenelModul.LSonTar, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) <= 0L)
				{
					GenelModul.LisansBitti();
				}
				else
				{
					GenelModul.LisansKontrolEdildi = true;
				}
			}
			return result;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000899A0 File Offset: 0x00087DA0
		public static object LisansBitti()
		{
			GenelModul.SaveTextToFile(GenelModul.MD5("EXP"), GenelModul.WindowsTemp1 + "rdxexp.wav", "");
			GenelModul.SaveTextToFile(GenelModul.MD5("EXP"), GenelModul.WindowsTemp2 + "rdxexc.wav", "");
			MyProject.Forms.Form1.Enabled = false;
			GenelModul.LisansBittiMi = true;
			Interaction.MsgBox("RedaX Deneme Sürümü kullanım süresi sona ermiştir, RedaX'ı tam sürümde kullanmak için lisans anahtarı girmeniz gerekmektedir!", MsgBoxStyle.Critical, "Deneme Süresi Bitti!");
			MyProject.Forms.frm_lisans.Show();
			object result;
			return result;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00089A30 File Offset: 0x00087E30
		public static string GetFileContents(string FullPath, ref string ErrInfo = "")
		{
			string result;
			try
			{
				StreamReader streamReader = new StreamReader(FullPath);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				result = text;
			}
			catch (Exception ex)
			{
				ErrInfo = ex.Message;
			}
			return result;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00089A7C File Offset: 0x00087E7C
		public static bool SaveTextToFile(string strData, string FullPath, string ErrInfo = "")
		{
			bool result = false;
			try
			{
				StreamWriter streamWriter = new StreamWriter(FullPath);
				streamWriter.Write(strData);
				streamWriter.Close();
				result = true;
			}
			catch (Exception ex)
			{
				ErrInfo = ex.Message;
			}
			return result;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00089ACC File Offset: 0x00087ECC
		public static string TarihFormatla(DateTime GirisTarih)
		{
			string text;
			if (Strings.Len(GirisTarih.Day.ToString()) == 2)
			{
				text = Conversions.ToString(GirisTarih.Day);
			}
			else
			{
				text = "0" + GirisTarih.Day.ToString();
			}
			string text2;
			if (Strings.Len(GirisTarih.Month.ToString()) == 2)
			{
				text2 = Conversions.ToString(GirisTarih.Month);
			}
			else
			{
				text2 = "0" + GirisTarih.Month.ToString();
			}
			return string.Concat(new string[]
			{
				text,
				".",
				text2,
				".",
				GirisTarih.Year.ToString()
			});
		}

		// Token: 0x0400010A RID: 266
		public static OleDbCommand Cmd;

		// Token: 0x0400010B RID: 267
		public static OleDbConnection OleDbConnection;

		// Token: 0x0400010C RID: 268
		public static string RedaXDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.ProductName;

		// Token: 0x0400010D RID: 269
		public static string WindowsTemp1 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\";

		// Token: 0x0400010E RID: 270
		public static string WindowsTemp2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";

		// Token: 0x0400010F RID: 271
		public static bool LisansKontrolEdildi;

		// Token: 0x04000110 RID: 272
		public static DateTime RecDate;

		// Token: 0x04000111 RID: 273
		public static bool LisansDurum;

		// Token: 0x04000112 RID: 274
		public static DateTime LSonTar;

		// Token: 0x04000113 RID: 275
		public static string LisansSahibi;

		// Token: 0x04000114 RID: 276
		public static bool LisansBittiMi;

		// Token: 0x04000115 RID: 277
		public static DateTime DateTimeNow;
	}
}
