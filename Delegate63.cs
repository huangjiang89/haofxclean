using System;

// Token: 0x020000FE RID: 254
internal sealed class Delegate63 : MulticastDelegate
{
	// Token: 0x06000E96 RID: 3734
	public extern object Invoke(object object_0);

	// Token: 0x06000E97 RID: 3735 RVA: 0x00006E0C File Offset: 0x0000500C
	public static object smethod_0(object object_0, Delegate63 delegate63_1)
	{
		return delegate63_1(object_0);
	}

	// Token: 0x06000E98 RID: 3736
	public extern Delegate63(object object_0, IntPtr intptr_0);

	// Token: 0x06000E99 RID: 3737 RVA: 0x00006E17 File Offset: 0x00005017
	static Delegate63()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate63).TypeHandle);
	}

	// Token: 0x040004D1 RID: 1233
	internal static Delegate63 delegate63_0;
}
