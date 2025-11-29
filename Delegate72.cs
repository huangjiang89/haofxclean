using System;

// Token: 0x02000107 RID: 263
internal sealed class Delegate72 : MulticastDelegate
{
	// Token: 0x06000EBA RID: 3770
	public extern void Invoke(object object_0);

	// Token: 0x06000EBB RID: 3771 RVA: 0x00006F0E File Offset: 0x0000510E
	public static void smethod_0(object object_0, Delegate72 delegate72_1)
	{
		delegate72_1(object_0);
	}

	// Token: 0x06000EBC RID: 3772
	public extern Delegate72(object object_0, IntPtr intptr_0);

	// Token: 0x06000EBD RID: 3773 RVA: 0x00006F19 File Offset: 0x00005119
	static Delegate72()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate72).TypeHandle);
	}

	// Token: 0x040004DA RID: 1242
	internal static Delegate72 delegate72_0;
}
