using System;

// Token: 0x020000F5 RID: 245
internal sealed class Delegate54 : MulticastDelegate
{
	// Token: 0x06000E72 RID: 3698
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06000E73 RID: 3699 RVA: 0x00006D02 File Offset: 0x00004F02
	public static bool smethod_0(object object_0, object object_1, Delegate54 delegate54_1)
	{
		return delegate54_1(object_0, object_1);
	}

	// Token: 0x06000E74 RID: 3700
	public extern Delegate54(object object_0, IntPtr intptr_0);

	// Token: 0x06000E75 RID: 3701 RVA: 0x00006D0F File Offset: 0x00004F0F
	static Delegate54()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate54).TypeHandle);
	}

	// Token: 0x040004C8 RID: 1224
	internal static Delegate54 delegate54_0;
}
