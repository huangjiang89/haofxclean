using System;

// Token: 0x020000D9 RID: 217
internal sealed class Delegate26 : MulticastDelegate
{
	// Token: 0x06000E02 RID: 3586
	public extern Delegate Invoke(Delegate delegate_0, Delegate delegate_1);

	// Token: 0x06000E03 RID: 3587 RVA: 0x000069D6 File Offset: 0x00004BD6
	public static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, Delegate26 delegate26_1)
	{
		return delegate26_1(delegate_0, delegate_1);
	}

	// Token: 0x06000E04 RID: 3588
	public extern Delegate26(object object_0, IntPtr intptr_0);

	// Token: 0x06000E05 RID: 3589 RVA: 0x000069E3 File Offset: 0x00004BE3
	static Delegate26()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate26).TypeHandle);
	}

	// Token: 0x040004AC RID: 1196
	internal static Delegate26 delegate26_0;
}
