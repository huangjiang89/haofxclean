using System;
using System.Reflection;

// Token: 0x020000FD RID: 253
internal sealed class Delegate62 : MulticastDelegate
{
	// Token: 0x06000E92 RID: 3730
	public extern MethodInfo Invoke(object object_0, string string_0);

	// Token: 0x06000E93 RID: 3731 RVA: 0x00006DEE File Offset: 0x00004FEE
	public static MethodInfo smethod_0(object object_0, string string_0, Delegate62 delegate62_1)
	{
		return delegate62_1(object_0, string_0);
	}

	// Token: 0x06000E94 RID: 3732
	public extern Delegate62(object object_0, IntPtr intptr_0);

	// Token: 0x06000E95 RID: 3733 RVA: 0x00006DFB File Offset: 0x00004FFB
	static Delegate62()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate62).TypeHandle);
	}

	// Token: 0x040004D0 RID: 1232
	internal static Delegate62 delegate62_0;
}
