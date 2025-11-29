using System;
using System.Reflection;

// Token: 0x020000DE RID: 222
internal sealed class Delegate31 : MulticastDelegate
{
	// Token: 0x06000E16 RID: 3606
	public extern PropertyInfo Invoke(object object_0, string string_0);

	// Token: 0x06000E17 RID: 3607 RVA: 0x00006A66 File Offset: 0x00004C66
	public static PropertyInfo smethod_0(object object_0, string string_0, Delegate31 delegate31_1)
	{
		return delegate31_1(object_0, string_0);
	}

	// Token: 0x06000E18 RID: 3608
	public extern Delegate31(object object_0, IntPtr intptr_0);

	// Token: 0x06000E19 RID: 3609 RVA: 0x00006A73 File Offset: 0x00004C73
	static Delegate31()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate31).TypeHandle);
	}

	// Token: 0x040004B1 RID: 1201
	internal static Delegate31 delegate31_0;
}
