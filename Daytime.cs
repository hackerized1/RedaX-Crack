using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using RedaX.My;

namespace RedaX
{
	// Token: 0x02000008 RID: 8
	public class Daytime
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000891AC File Offset: 0x000875AC
		public static DateTime GetTime()
		{
			Daytime.LastHost = "";
			DateTime result;
			foreach (string text in Daytime.Servers)
			{
				if (MyProject.Computer.Network.Ping(text))
				{
					Daytime.LastHost = text;
					result = Daytime.GetNISTTime(text);
				}
			}
			if (Operators.CompareString(Daytime.LastHost, "", false) == 0)
			{
				result = DateTime.UtcNow;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00089218 File Offset: 0x00087618
		public static int SecondsDifference(DateTime dt1, DateTime dt2)
		{
			TimeSpan timeSpan = dt1.Subtract(dt2);
			return checked(timeSpan.Seconds + timeSpan.Minutes * 60 + timeSpan.Hours * 360);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00089250 File Offset: 0x00087650
		public static bool WindowsClockIncorrect()
		{
			DateTime time = Daytime.GetTime();
			return Math.Abs(Daytime.SecondsDifference(time, Daytime.LastSysTime)) > 3;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0008927C File Offset: 0x0008767C
		private static DateTime GetNISTTime(string host)
		{
			string text;
			try
			{
				StreamReader streamReader = new StreamReader(new TcpClient(host, 13).GetStream());
				Daytime.LastSysTime = DateTime.UtcNow;
				text = streamReader.ReadToEnd();
				streamReader.Close();
			}
			catch (SocketException ex)
			{
				return DateTime.MinValue;
			}
			catch (Exception ex2)
			{
				return DateTime.MinValue;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				return DateTime.MinValue;
			}
			if (Operators.CompareString(text.Substring(38, 9), "UTC(NIST)", false) != 0)
			{
				return DateTime.MinValue;
			}
			if (Operators.CompareString(text.Substring(30, 1), "0", false) != 0)
			{
				return DateTime.MinValue;
			}
			int num = int.Parse(text.Substring(1, 5));
			int num2 = int.Parse(text.Substring(7, 2));
			int month = int.Parse(text.Substring(10, 2));
			int day = int.Parse(text.Substring(13, 2));
			int hour = int.Parse(text.Substring(16, 2));
			int minute = int.Parse(text.Substring(19, 2));
			int second = int.Parse(text.Substring(22, 2));
			if (num < 15020)
			{
				return DateTime.MinValue;
			}
			checked
			{
				if (num > 51544)
				{
					num2 += 2000;
				}
				else
				{
					num2 += 1900;
				}
				DateTime result = new DateTime(num2, month, day, hour, minute, second);
				return result;
			}
		}

		// Token: 0x06000034 RID: 52
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetSystemTime(ref Daytime.SYSTEMTIME stru);

		// Token: 0x06000035 RID: 53
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetSystemTime(ref Daytime.SYSTEMTIME stru);

		// Token: 0x06000036 RID: 54 RVA: 0x0008940C File Offset: 0x0008780C
		public static void SetWindowsClock(DateTime dt)
		{
			checked
			{
				Daytime.SYSTEMTIME systemtime;
				systemtime.wYear = (short)dt.Year;
				systemtime.wMonth = (short)dt.Month;
				systemtime.wDay = (short)dt.Day;
				systemtime.wDayOfWeek = (short)dt.DayOfWeek;
				systemtime.wHour = (short)dt.Hour;
				systemtime.wMinute = (short)dt.Minute;
				systemtime.wSecond = (short)dt.Second;
				systemtime.wMilliseconds = (short)dt.Millisecond;
				int num = Daytime.SetSystemTime(ref systemtime);
			}
		}

		// Token: 0x04000011 RID: 17
		private const int THRESHOLD_SECONDS = 3;

		// Token: 0x04000012 RID: 18
		private static string[] Servers = new string[]
		{
			"129.6.15.28"
		};

		// Token: 0x04000013 RID: 19
		public static string LastHost = "";

		// Token: 0x04000014 RID: 20
		public static DateTime LastSysTime;

		// Token: 0x02000009 RID: 9
		public struct SYSTEMTIME
		{
			// Token: 0x04000015 RID: 21
			public short wYear;

			// Token: 0x04000016 RID: 22
			public short wMonth;

			// Token: 0x04000017 RID: 23
			public short wDayOfWeek;

			// Token: 0x04000018 RID: 24
			public short wDay;

			// Token: 0x04000019 RID: 25
			public short wHour;

			// Token: 0x0400001A RID: 26
			public short wMinute;

			// Token: 0x0400001B RID: 27
			public short wSecond;

			// Token: 0x0400001C RID: 28
			public short wMilliseconds;
		}
	}
}
