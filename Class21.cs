using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02000018 RID: 24
internal static class Class21
{
	// Token: 0x060000B1 RID: 177 RVA: 0x00006632 File Offset: 0x00004832
	public static Task smethod_0()
	{
		return null;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000A84C File Offset: 0x00008A4C
	static Class21()
	{
		Class105.smethod_20();
		for (;;)
		{
			IL_51:
			for (;;)
			{
				IL_45:
				int num = 10;
				while (num != 10)
				{
					if (num != 991)
					{
						goto Block_1;
					}
					switch (num)
					{
					case 0:
						goto IL_55;
					case 1:
						return;
					case 2:
						goto IL_45;
					case 3:
						goto IL_51;
					}
				}
				goto IL_54;
			}
		}
		Block_1:
		return;
		IL_54:
		IL_55:
		Class21.task_0 = new Task(new Action(Class21.Class22.class22_0.method_0));
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_1()
	{
		return true;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class21 smethod_2()
	{
		return null;
	}

	// Token: 0x0400002B RID: 43
	private static readonly Task task_0;

	// Token: 0x0400002C RID: 44
	private static object object_0;

	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	[Serializable]
	private sealed class Class22
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		static Class22()
		{
			Class105.smethod_20();
			for (;;)
			{
				IL_60:
				for (;;)
				{
					IL_5D:
					for (;;)
					{
						IL_5A:
						for (;;)
						{
							IL_45:
							Class21.Class22.class22_0 = new Class21.Class22();
							int num = 10;
							while (num != 10)
							{
								if (num != 991)
								{
									goto Block_1;
								}
								switch (num)
								{
								case 0:
									goto IL_5D;
								case 1:
									goto IL_60;
								case 2:
									goto IL_45;
								case 3:
									goto IL_5A;
								}
							}
							return;
						}
					}
				}
				Block_1:;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006630 File Offset: 0x00004830
		internal void method_0()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006635 File Offset: 0x00004835
		internal static bool smethod_0()
		{
			return true;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006632 File Offset: 0x00004832
		internal static Class21.Class22 smethod_1()
		{
			return null;
		}

		// Token: 0x0400002D RID: 45
		public static readonly Class21.Class22 class22_0;

		// Token: 0x0400002E RID: 46
		internal static Class21.Class22 class22_1;
	}
}
