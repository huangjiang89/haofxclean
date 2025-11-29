using System;

// Token: 0x020000EC RID: 236
internal sealed class Delegate45 : MulticastDelegate
{
	// Token: 0x06000E4E RID: 3662
	public extern bool Invoke(object object_0);

	// Token: 0x06000E4F RID: 3663 RVA: 0x00006C02 File Offset: 0x00004E02
	public static bool smethod_0(object object_0, Delegate45 delegate45_1)
	{
		return delegate45_1(object_0);
	}

	// Token: 0x06000E50 RID: 3664
	public extern Delegate45(object object_0, IntPtr intptr_0);

	// Token: 0x06000E51 RID: 3665 RVA: 0x00006C0D File Offset: 0x00004E0D
	static Delegate45()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate45).TypeHandle);
	}

	// Token: 0x040004BF RID: 1215
	internal static Delegate45 delegate45_0;
}
