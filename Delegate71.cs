using System;

// Token: 0x02000106 RID: 262
internal sealed class Delegate71 : MulticastDelegate
{
	// Token: 0x06000EB6 RID: 3766
	public extern string Invoke(string[] string_0);

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00006EF2 File Offset: 0x000050F2
	public static string smethod_0(string[] string_0, Delegate71 delegate71_1)
	{
		return delegate71_1(string_0);
	}

	// Token: 0x06000EB8 RID: 3768
	public extern Delegate71(object object_0, IntPtr intptr_0);

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00006EFD File Offset: 0x000050FD
	static Delegate71()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate71).TypeHandle);
	}

	// Token: 0x040004D9 RID: 1241
	internal static Delegate71 delegate71_0;
}
