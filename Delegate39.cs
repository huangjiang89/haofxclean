using System;

// Token: 0x020000E6 RID: 230
internal sealed class Delegate39 : MulticastDelegate
{
	// Token: 0x06000E36 RID: 3638
	public extern object Invoke(object object_0, object object_1, object[] object_2);

	// Token: 0x06000E37 RID: 3639 RVA: 0x00006B4E File Offset: 0x00004D4E
	public static object smethod_0(object object_0, object object_1, object[] object_2, Delegate39 delegate39_1)
	{
		return delegate39_1(object_0, object_1, object_2);
	}

	// Token: 0x06000E38 RID: 3640
	public extern Delegate39(object object_0, IntPtr intptr_0);

	// Token: 0x06000E39 RID: 3641 RVA: 0x00006B5D File Offset: 0x00004D5D
	static Delegate39()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate39).TypeHandle);
	}

	// Token: 0x040004B9 RID: 1209
	internal static Delegate39 delegate39_0;
}
