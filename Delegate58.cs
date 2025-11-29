using System;

// Token: 0x020000F9 RID: 249
internal sealed class Delegate58 : MulticastDelegate
{
	// Token: 0x06000E82 RID: 3714
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x06000E83 RID: 3715 RVA: 0x00006D7A File Offset: 0x00004F7A
	public static bool smethod_0(object object_0, Type type_0, Delegate58 delegate58_1)
	{
		return delegate58_1(object_0, type_0);
	}

	// Token: 0x06000E84 RID: 3716
	public extern Delegate58(object object_0, IntPtr intptr_0);

	// Token: 0x06000E85 RID: 3717 RVA: 0x00006D87 File Offset: 0x00004F87
	static Delegate58()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate58).TypeHandle);
	}

	// Token: 0x040004CC RID: 1228
	internal static Delegate58 delegate58_0;
}
