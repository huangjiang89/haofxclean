using System;
using System.Reflection;

// Token: 0x020000ED RID: 237
internal sealed class Delegate46 : MulticastDelegate
{
	// Token: 0x06000E52 RID: 3666
	public extern ParameterInfo[] Invoke(object object_0);

	// Token: 0x06000E53 RID: 3667 RVA: 0x00006C1E File Offset: 0x00004E1E
	public static ParameterInfo[] smethod_0(object object_0, Delegate46 delegate46_1)
	{
		return delegate46_1(object_0);
	}

	// Token: 0x06000E54 RID: 3668
	public extern Delegate46(object object_0, IntPtr intptr_0);

	// Token: 0x06000E55 RID: 3669 RVA: 0x00006C29 File Offset: 0x00004E29
	static Delegate46()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate46).TypeHandle);
	}

	// Token: 0x040004C0 RID: 1216
	internal static Delegate46 delegate46_0;
}
