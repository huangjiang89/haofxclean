using System;

// Token: 0x02000100 RID: 256
internal sealed class Delegate65 : MulticastDelegate
{
	// Token: 0x06000E9E RID: 3742
	public extern object Invoke(object object_0);

	// Token: 0x06000E9F RID: 3743 RVA: 0x00006E44 File Offset: 0x00005044
	public static object smethod_0(object object_0, Delegate65 delegate65_1)
	{
		return delegate65_1(object_0);
	}

	// Token: 0x06000EA0 RID: 3744
	public extern Delegate65(object object_0, IntPtr intptr_0);

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00006E4F File Offset: 0x0000504F
	static Delegate65()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate65).TypeHandle);
	}

	// Token: 0x040004D3 RID: 1235
	internal static Delegate65 delegate65_0;
}
