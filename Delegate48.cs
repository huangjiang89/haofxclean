using System;

// Token: 0x020000EF RID: 239
internal sealed class Delegate48 : MulticastDelegate
{
	// Token: 0x06000E5A RID: 3674
	public extern void Invoke(object object_0);

	// Token: 0x06000E5B RID: 3675 RVA: 0x00006C58 File Offset: 0x00004E58
	public static void smethod_0(object object_0, Delegate48 delegate48_1)
	{
		delegate48_1(object_0);
	}

	// Token: 0x06000E5C RID: 3676
	public extern Delegate48(object object_0, IntPtr intptr_0);

	// Token: 0x06000E5D RID: 3677 RVA: 0x00006C63 File Offset: 0x00004E63
	static Delegate48()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate48).TypeHandle);
	}

	// Token: 0x040004C2 RID: 1218
	internal static Delegate48 delegate48_0;
}
