using System;

// Token: 0x020000DC RID: 220
internal sealed class Delegate29 : MulticastDelegate
{
	// Token: 0x06000E0E RID: 3598
	public extern bool Invoke(string string_0);

	// Token: 0x06000E0F RID: 3599 RVA: 0x00006A2E File Offset: 0x00004C2E
	public static bool smethod_0(string string_0, Delegate29 delegate29_1)
	{
		return delegate29_1(string_0);
	}

	// Token: 0x06000E10 RID: 3600
	public extern Delegate29(object object_0, IntPtr intptr_0);

	// Token: 0x06000E11 RID: 3601 RVA: 0x00006A39 File Offset: 0x00004C39
	static Delegate29()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate29).TypeHandle);
	}

	// Token: 0x040004AF RID: 1199
	internal static Delegate29 delegate29_0;
}
