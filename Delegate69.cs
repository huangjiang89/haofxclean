using System;

// Token: 0x02000104 RID: 260
internal sealed class Delegate69 : MulticastDelegate
{
	// Token: 0x06000EAE RID: 3758
	public extern string Invoke(string string_0, string string_1, string string_2);

	// Token: 0x06000EAF RID: 3759 RVA: 0x00006EB4 File Offset: 0x000050B4
	public static string smethod_0(string string_0, string string_1, string string_2, Delegate69 delegate69_1)
	{
		return delegate69_1(string_0, string_1, string_2);
	}

	// Token: 0x06000EB0 RID: 3760
	public extern Delegate69(object object_0, IntPtr intptr_0);

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00006EC3 File Offset: 0x000050C3
	static Delegate69()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate69).TypeHandle);
	}

	// Token: 0x040004D7 RID: 1239
	internal static Delegate69 delegate69_0;
}
