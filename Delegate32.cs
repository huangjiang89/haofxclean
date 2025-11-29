using System;
using System.Reflection;

// Token: 0x020000DF RID: 223
internal sealed class Delegate32 : MulticastDelegate
{
	// Token: 0x06000E1A RID: 3610
	public extern bool Invoke(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1);

	// Token: 0x06000E1B RID: 3611 RVA: 0x00006A84 File Offset: 0x00004C84
	public static bool smethod_0(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1, Delegate32 delegate32_1)
	{
		return delegate32_1(propertyInfo_0, propertyInfo_1);
	}

	// Token: 0x06000E1C RID: 3612
	public extern Delegate32(object object_0, IntPtr intptr_0);

	// Token: 0x06000E1D RID: 3613 RVA: 0x00006A91 File Offset: 0x00004C91
	static Delegate32()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate32).TypeHandle);
	}

	// Token: 0x040004B2 RID: 1202
	internal static Delegate32 delegate32_0;
}
