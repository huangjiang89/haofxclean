using System;
using System.Reflection;

// Token: 0x020000F6 RID: 246
internal sealed class Delegate55 : MulticastDelegate
{
	// Token: 0x06000E76 RID: 3702
	public extern MethodInfo Invoke(Delegate delegate_0);

	// Token: 0x06000E77 RID: 3703 RVA: 0x00006D20 File Offset: 0x00004F20
	public static MethodInfo smethod_0(Delegate delegate_0, Delegate55 delegate55_1)
	{
		return delegate55_1(delegate_0);
	}

	// Token: 0x06000E78 RID: 3704
	public extern Delegate55(object object_0, IntPtr intptr_0);

	// Token: 0x06000E79 RID: 3705 RVA: 0x00006D2B File Offset: 0x00004F2B
	static Delegate55()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate55).TypeHandle);
	}

	// Token: 0x040004C9 RID: 1225
	internal static Delegate55 delegate55_0;
}
