using System;

// Token: 0x020000E3 RID: 227
internal sealed class Delegate36 : MulticastDelegate
{
	// Token: 0x06000E2A RID: 3626
	public extern Type Invoke(string string_0);

	// Token: 0x06000E2B RID: 3627 RVA: 0x00006AF6 File Offset: 0x00004CF6
	public static Type smethod_0(string string_0, Delegate36 delegate36_1)
	{
		return delegate36_1(string_0);
	}

	// Token: 0x06000E2C RID: 3628
	public extern Delegate36(object object_0, IntPtr intptr_0);

	// Token: 0x06000E2D RID: 3629 RVA: 0x00006B01 File Offset: 0x00004D01
	static Delegate36()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate36).TypeHandle);
	}

	// Token: 0x040004B6 RID: 1206
	internal static Delegate36 delegate36_0;
}
