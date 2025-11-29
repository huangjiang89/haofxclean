using System;

// Token: 0x020000E8 RID: 232
internal sealed class Delegate41 : MulticastDelegate
{
	// Token: 0x06000E3E RID: 3646
	public extern object Invoke(object object_0, object object_1);

	// Token: 0x06000E3F RID: 3647 RVA: 0x00006B8C File Offset: 0x00004D8C
	public static object smethod_0(object object_0, object object_1, Delegate41 delegate41_1)
	{
		return delegate41_1(object_0, object_1);
	}

	// Token: 0x06000E40 RID: 3648
	public extern Delegate41(object object_0, IntPtr intptr_0);

	// Token: 0x06000E41 RID: 3649 RVA: 0x00006B99 File Offset: 0x00004D99
	static Delegate41()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate41).TypeHandle);
	}

	// Token: 0x040004BB RID: 1211
	internal static Delegate41 delegate41_0;
}
