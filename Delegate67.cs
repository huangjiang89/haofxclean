using System;

// Token: 0x02000102 RID: 258
internal sealed class Delegate67 : MulticastDelegate
{
	// Token: 0x06000EA6 RID: 3750
	public extern bool Invoke(object object_0);

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00006E7E File Offset: 0x0000507E
	public static bool smethod_0(object object_0, Delegate67 delegate67_1)
	{
		return delegate67_1(object_0);
	}

	// Token: 0x06000EA8 RID: 3752
	public extern Delegate67(object object_0, IntPtr intptr_0);

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00006E89 File Offset: 0x00005089
	static Delegate67()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate67).TypeHandle);
	}

	// Token: 0x040004D5 RID: 1237
	internal static Delegate67 delegate67_0;
}
