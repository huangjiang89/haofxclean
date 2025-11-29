using System;

// Token: 0x02000103 RID: 259
internal sealed class Delegate68 : MulticastDelegate
{
	// Token: 0x06000EAA RID: 3754
	public extern string Invoke();

	// Token: 0x06000EAB RID: 3755 RVA: 0x00006E9A File Offset: 0x0000509A
	public static string smethod_0(Delegate68 delegate68_1)
	{
		return delegate68_1();
	}

	// Token: 0x06000EAC RID: 3756
	public extern Delegate68(object object_0, IntPtr intptr_0);

	// Token: 0x06000EAD RID: 3757 RVA: 0x00006EA3 File Offset: 0x000050A3
	static Delegate68()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate68).TypeHandle);
	}

	// Token: 0x040004D6 RID: 1238
	internal static Delegate68 delegate68_0;
}
