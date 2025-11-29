using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200009B RID: 155
internal class Class110
{
	// Token: 0x06000AC9 RID: 2761 RVA: 0x0001978C File Offset: 0x0001798C
	internal static void smethod_0()
	{
		if (!Class110.bool_1)
		{
			Class110.bool_1 = true;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Class110.bool_0 = false;
			currentDomain.AssemblyResolve += Class110.smethod_1;
		}
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x000197C4 File Offset: 0x000179C4
	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Hashtable obj = Class110.hashtable_0;
		Assembly result;
		lock (obj)
		{
			string text = resolveEventArgs_0.Name.Trim();
			object obj2 = Class110.hashtable_0[text];
			if (obj2 == null)
			{
				try
				{
					string text2 = Class110.smethod_2(text);
					foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
					{
						if (assembly.GetName().Name.ToUpper() == text2.ToUpper())
						{
							if (!Class110.bool_0)
							{
								return assembly;
							}
							if (text.Contains(assembly.GetName().Version.ToString()))
							{
								return assembly;
							}
						}
					}
				}
				catch
				{
				}
			}
			if (obj2 == null)
			{
				try
				{
					RSACryptoServiceProvider.UseMachineKeyStore = true;
					string text3 = Class110.smethod_2(text);
					byte[] bytes = Encoding.Unicode.GetBytes(text3);
					string text4 = "b0494a1f-4bd3-" + Convert.ToBase64String(Class105.smethod_9(bytes));
					Stream manifestResourceStream = typeof(Class110).Assembly.GetManifestResourceStream(text4);
					if (manifestResourceStream != null)
					{
						try
						{
							Class105.Class108 @class = new Class105.Class108(manifestResourceStream);
							@class.method_0().Position = 0L;
							byte[] array = new byte[manifestResourceStream.Length];
							@class.method_2(array, 0, array.Length);
							@class.method_4();
							bool flag2 = false;
							Assembly assembly2 = null;
							try
							{
								assembly2 = Assembly.Load(array);
							}
							catch (FileLoadException)
							{
								flag2 = true;
							}
							catch (BadImageFormatException)
							{
								flag2 = true;
							}
							if (flag2)
							{
								string text5 = Class110.hashtable_1[text4] as string;
								if (text5 == null)
								{
									text5 = "b0494a1f-4bd3n-" + Convert.ToBase64String(Class105.smethod_9(array));
									Class110.hashtable_1.Add(text4, text5);
								}
								string text6 = Path.Combine(Path.Combine(Path.GetTempPath(), text5.ToString()), text3 + ".dll");
								if (!File.Exists(text6) || !Class110.hashtable_2.ContainsKey(text6))
								{
									try
									{
										Class110.hashtable_2[text6] = null;
										if (!Directory.Exists(Path.GetDirectoryName(text6)))
										{
											Directory.CreateDirectory(Path.GetDirectoryName(text6));
										}
										FileStream fileStream = new FileStream(text6, FileMode.Create, FileAccess.Write);
										fileStream.Write(array, 0, array.Length);
										fileStream.Close();
									}
									catch (Exception)
									{
									}
								}
								assembly2 = Assembly.LoadFile(text6);
								Class110.hashtable_0.Add(text, assembly2);
							}
							else
							{
								Class110.hashtable_0.Add(text, assembly2);
							}
							return assembly2;
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				result = null;
			}
			else
			{
				result = (Assembly)obj2;
			}
		}
		return result;
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00019B04 File Offset: 0x00017D04
	private static string smethod_2(string string_0)
	{
		string text = string_0.Trim();
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	// Token: 0x040003EF RID: 1007
	private static Hashtable hashtable_0 = new Hashtable();

	// Token: 0x040003F0 RID: 1008
	private static Hashtable hashtable_1 = new Hashtable();

	// Token: 0x040003F1 RID: 1009
	private static Hashtable hashtable_2 = new Hashtable();

	// Token: 0x040003F2 RID: 1010
	private static bool bool_0 = false;

	// Token: 0x040003F3 RID: 1011
	private static bool bool_1 = false;
}
