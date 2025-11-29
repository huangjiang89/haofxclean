using System;

// Token: 0x020000E2 RID: 226
internal sealed class Delegate35 : MulticastDelegate
{
	// Token: 0x06000E26 RID: 3622
	public extern string Invoke(object object_0);

	// Token: 0x06000E27 RID: 3623 RVA: 0x00006ADA File Offset: 0x00004CDA
	public static string smethod_0(object object_0, Delegate35 delegate35_1)
	{
		return delegate35_1(object_0);
	}

	// Token: 0x06000E28 RID: 3624
	public extern Delegate35(object object_0, IntPtr intptr_0);

	// Token: 0x06000E29 RID: 3625 RVA: 0x00006AE5 File Offset: 0x00004CE5
	static Delegate35()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate35).TypeHandle);
	}

	// Token: 0x040004B5 RID: 1205
	internal static Delegate35 delegate35_0;
}
