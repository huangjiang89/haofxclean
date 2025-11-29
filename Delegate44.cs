using System;

// Token: 0x020000EB RID: 235
internal sealed class Delegate44 : MulticastDelegate
{
	// Token: 0x06000E4A RID: 3658
	public extern bool Invoke(object object_0);

	// Token: 0x06000E4B RID: 3659 RVA: 0x00006BE6 File Offset: 0x00004DE6
	public static bool smethod_0(object object_0, Delegate44 delegate44_1)
	{
		return delegate44_1(object_0);
	}

	// Token: 0x06000E4C RID: 3660
	public extern Delegate44(object object_0, IntPtr intptr_0);

	// Token: 0x06000E4D RID: 3661 RVA: 0x00006BF1 File Offset: 0x00004DF1
	static Delegate44()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate44).TypeHandle);
	}

	// Token: 0x040004BE RID: 1214
	internal static Delegate44 delegate44_0;
}
