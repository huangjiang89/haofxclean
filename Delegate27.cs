using System;

// Token: 0x020000DA RID: 218
internal sealed class Delegate27 : MulticastDelegate
{
	// Token: 0x06000E06 RID: 3590
	public extern Delegate Invoke(Delegate delegate_0, Delegate delegate_1);

	// Token: 0x06000E07 RID: 3591 RVA: 0x000069F4 File Offset: 0x00004BF4
	public static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, Delegate27 delegate27_1)
	{
		return delegate27_1(delegate_0, delegate_1);
	}

	// Token: 0x06000E08 RID: 3592
	public extern Delegate27(object object_0, IntPtr intptr_0);

	// Token: 0x06000E09 RID: 3593 RVA: 0x00006A01 File Offset: 0x00004C01
	static Delegate27()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate27).TypeHandle);
	}

	// Token: 0x040004AD RID: 1197
	internal static Delegate27 delegate27_0;
}
