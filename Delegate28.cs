using System;

// Token: 0x020000DB RID: 219
internal sealed class Delegate28 : MulticastDelegate
{
	// Token: 0x06000E0A RID: 3594
	public extern Type Invoke(object object_0);

	// Token: 0x06000E0B RID: 3595 RVA: 0x00006A12 File Offset: 0x00004C12
	public static Type smethod_0(object object_0, Delegate28 delegate28_1)
	{
		return delegate28_1(object_0);
	}

	// Token: 0x06000E0C RID: 3596
	public extern Delegate28(object object_0, IntPtr intptr_0);

	// Token: 0x06000E0D RID: 3597 RVA: 0x00006A1D File Offset: 0x00004C1D
	static Delegate28()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate28).TypeHandle);
	}

	// Token: 0x040004AE RID: 1198
	internal static Delegate28 delegate28_0;
}
