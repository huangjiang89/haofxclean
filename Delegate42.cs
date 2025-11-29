using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x020000E9 RID: 233
internal sealed class Delegate42 : MulticastDelegate
{
	// Token: 0x06000E42 RID: 3650
	public extern IEnumerable<MethodInfo> Invoke(object object_0, string string_0);

	// Token: 0x06000E43 RID: 3651 RVA: 0x00006BAA File Offset: 0x00004DAA
	public static IEnumerable<MethodInfo> smethod_0(object object_0, string string_0, Delegate42 delegate42_1)
	{
		return delegate42_1(object_0, string_0);
	}

	// Token: 0x06000E44 RID: 3652
	public extern Delegate42(object object_0, IntPtr intptr_0);

	// Token: 0x06000E45 RID: 3653 RVA: 0x00006BB7 File Offset: 0x00004DB7
	static Delegate42()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate42).TypeHandle);
	}

	// Token: 0x040004BC RID: 1212
	internal static Delegate42 delegate42_0;
}
