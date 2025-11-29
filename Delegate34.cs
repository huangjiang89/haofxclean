using System;
using System.Reflection;

// Token: 0x020000E1 RID: 225
internal sealed class Delegate34 : MulticastDelegate
{
	// Token: 0x06000E22 RID: 3618
	public extern MemberInfo Invoke(object object_0);

	// Token: 0x06000E23 RID: 3619 RVA: 0x00006ABE File Offset: 0x00004CBE
	public static MemberInfo smethod_0(object object_0, Delegate34 delegate34_1)
	{
		return delegate34_1(object_0);
	}

	// Token: 0x06000E24 RID: 3620
	public extern Delegate34(object object_0, IntPtr intptr_0);

	// Token: 0x06000E25 RID: 3621 RVA: 0x00006AC9 File Offset: 0x00004CC9
	static Delegate34()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate34).TypeHandle);
	}

	// Token: 0x040004B4 RID: 1204
	internal static Delegate34 delegate34_0;
}
