using System;
using System.Reflection;

// Token: 0x02000088 RID: 136
internal class Class104
{
	// Token: 0x06000A44 RID: 2628 RVA: 0x00006630 File Offset: 0x00004830
	internal static void smethod_0(int typemdt)
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00015164 File Offset: 0x00013364
	static Class104()
	{
		Class105.smethod_20();
		for (;;)
		{
			IL_54:
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
							goto IL_45;
						}
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_45;
						case 2:
							goto IL_51;
						case 3:
							goto IL_54;
						}
					}
					goto IL_57;
				}
			}
		}
		IL_57:
		Class104.module_0 = Delegate467.smethod_0(Delegate458.smethod_0(Delegate49.smethod_0(typeof(Class104).TypeHandle, Delegate49.delegate49_0), Delegate458.delegate458_0), Delegate467.delegate467_0);
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_1()
	{
		return true;
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class104 smethod_2()
	{
		return null;
	}

	// Token: 0x040003BF RID: 959
	internal static Module module_0;

	// Token: 0x040003C0 RID: 960
	private static object object_0;

	// Token: 0x02000089 RID: 137
	internal sealed class Delegate10 : MulticastDelegate
	{
		// Token: 0x06000A49 RID: 2633
		public extern Delegate10(object object_0, IntPtr intptr_0);

		// Token: 0x06000A4A RID: 2634
		public extern void Invoke(object o);

		// Token: 0x06000A4B RID: 2635
		public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

		// Token: 0x06000A4C RID: 2636
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06000A4D RID: 2637 RVA: 0x00006638 File Offset: 0x00004838
		static Delegate10()
		{
			Class105.smethod_20();
		}
	}
}
