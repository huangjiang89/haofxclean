using System;

// Token: 0x020000F7 RID: 247
internal sealed class Delegate56 : MulticastDelegate
{
	// Token: 0x06000E7A RID: 3706
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06000E7B RID: 3707 RVA: 0x00006D3C File Offset: 0x00004F3C
	public static bool smethod_0(string string_0, string string_1, Delegate56 delegate56_1)
	{
		return delegate56_1(string_0, string_1);
	}

	// Token: 0x06000E7C RID: 3708
	public extern Delegate56(object object_0, IntPtr intptr_0);

	// Token: 0x06000E7D RID: 3709 RVA: 0x00006D49 File Offset: 0x00004F49
	static Delegate56()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate56).TypeHandle);
	}

	// Token: 0x040004CA RID: 1226
	internal static Delegate56 delegate56_0;
}
