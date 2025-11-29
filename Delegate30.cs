using System;
using System.Reflection;

// Token: 0x020000DD RID: 221
internal sealed class Delegate30 : MulticastDelegate
{
	// Token: 0x06000E12 RID: 3602
	public extern TypeInfo Invoke(Type type_0);

	// Token: 0x06000E13 RID: 3603 RVA: 0x00006A4A File Offset: 0x00004C4A
	public static TypeInfo smethod_0(Type type_0, Delegate30 delegate30_1)
	{
		return delegate30_1(type_0);
	}

	// Token: 0x06000E14 RID: 3604
	public extern Delegate30(object object_0, IntPtr intptr_0);

	// Token: 0x06000E15 RID: 3605 RVA: 0x00006A55 File Offset: 0x00004C55
	static Delegate30()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate30).TypeHandle);
	}

	// Token: 0x040004B0 RID: 1200
	internal static Delegate30 delegate30_0;
}
