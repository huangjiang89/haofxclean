using System;

// Token: 0x020000FB RID: 251
internal sealed class Delegate60 : MulticastDelegate
{
	// Token: 0x06000E8A RID: 3722
	public extern object Invoke(object object_0, object[] object_1);

	// Token: 0x06000E8B RID: 3723 RVA: 0x00006DB2 File Offset: 0x00004FB2
	public static object smethod_0(object object_0, object[] object_1, Delegate60 delegate60_1)
	{
		return delegate60_1(object_0, object_1);
	}

	// Token: 0x06000E8C RID: 3724
	public extern Delegate60(object object_0, IntPtr intptr_0);

	// Token: 0x06000E8D RID: 3725 RVA: 0x00006DBF File Offset: 0x00004FBF
	static Delegate60()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate60).TypeHandle);
	}

	// Token: 0x040004CE RID: 1230
	internal static Delegate60 delegate60_0;
}
