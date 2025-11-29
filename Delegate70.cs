using System;

// Token: 0x02000105 RID: 261
internal sealed class Delegate70 : MulticastDelegate
{
	// Token: 0x06000EB2 RID: 3762
	public extern string Invoke(string string_0, string string_1);

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00006ED4 File Offset: 0x000050D4
	public static string smethod_0(string string_0, string string_1, Delegate70 delegate70_1)
	{
		return delegate70_1(string_0, string_1);
	}

	// Token: 0x06000EB4 RID: 3764
	public extern Delegate70(object object_0, IntPtr intptr_0);

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00006EE1 File Offset: 0x000050E1
	static Delegate70()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate70).TypeHandle);
	}

	// Token: 0x040004D8 RID: 1240
	internal static Delegate70 delegate70_0;
}
