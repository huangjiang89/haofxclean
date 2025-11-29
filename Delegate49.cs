using System;

// Token: 0x020000F0 RID: 240
internal sealed class Delegate49 : MulticastDelegate
{
	// Token: 0x06000E5E RID: 3678
	public extern Type Invoke(RuntimeTypeHandle runtimeTypeHandle_0);

	// Token: 0x06000E5F RID: 3679 RVA: 0x00006C74 File Offset: 0x00004E74
	public static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, Delegate49 delegate49_1)
	{
		return delegate49_1(runtimeTypeHandle_0);
	}

	// Token: 0x06000E60 RID: 3680
	public extern Delegate49(object object_0, IntPtr intptr_0);

	// Token: 0x06000E61 RID: 3681 RVA: 0x00006C7F File Offset: 0x00004E7F
	static Delegate49()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate49).TypeHandle);
	}

	// Token: 0x040004C3 RID: 1219
	internal static Delegate49 delegate49_0;
}
