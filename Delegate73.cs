using System;
using System.Data;

// Token: 0x02000108 RID: 264
internal sealed class Delegate73 : MulticastDelegate
{
	// Token: 0x06000EBE RID: 3774
	public extern ConnectionState Invoke(object object_0);

	// Token: 0x06000EBF RID: 3775 RVA: 0x00006F2A File Offset: 0x0000512A
	public static ConnectionState smethod_0(object object_0, Delegate73 delegate73_1)
	{
		return delegate73_1(object_0);
	}

	// Token: 0x06000EC0 RID: 3776
	public extern Delegate73(object object_0, IntPtr intptr_0);

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00006F35 File Offset: 0x00005135
	static Delegate73()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate73).TypeHandle);
	}

	// Token: 0x040004DB RID: 1243
	internal static Delegate73 delegate73_0;
}
