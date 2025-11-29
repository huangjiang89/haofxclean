using System;

// Token: 0x020000F1 RID: 241
internal sealed class Delegate50 : MulticastDelegate
{
	// Token: 0x06000E62 RID: 3682
	public extern bool Invoke(object object_0);

	// Token: 0x06000E63 RID: 3683 RVA: 0x00006C90 File Offset: 0x00004E90
	public static bool smethod_0(object object_0, Delegate50 delegate50_1)
	{
		return delegate50_1(object_0);
	}

	// Token: 0x06000E64 RID: 3684
	public extern Delegate50(object object_0, IntPtr intptr_0);

	// Token: 0x06000E65 RID: 3685 RVA: 0x00006C9B File Offset: 0x00004E9B
	static Delegate50()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate50).TypeHandle);
	}

	// Token: 0x040004C4 RID: 1220
	internal static Delegate50 delegate50_0;
}
