using System;
using System.Linq.Expressions;

// Token: 0x020000E0 RID: 224
internal sealed class Delegate33 : MulticastDelegate
{
	// Token: 0x06000E1E RID: 3614
	public extern Expression Invoke(object object_0);

	// Token: 0x06000E1F RID: 3615 RVA: 0x00006AA2 File Offset: 0x00004CA2
	public static Expression smethod_0(object object_0, Delegate33 delegate33_1)
	{
		return delegate33_1(object_0);
	}

	// Token: 0x06000E20 RID: 3616
	public extern Delegate33(object object_0, IntPtr intptr_0);

	// Token: 0x06000E21 RID: 3617 RVA: 0x00006AAD File Offset: 0x00004CAD
	static Delegate33()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate33).TypeHandle);
	}

	// Token: 0x040004B3 RID: 1203
	internal static Delegate33 delegate33_0;
}
