using System;
using System.Reflection;

// Token: 0x020000F4 RID: 244
internal sealed class Delegate53 : MulticastDelegate
{
	// Token: 0x06000E6E RID: 3694
	public extern bool Invoke(object object_0, TypeInfo typeInfo_0);

	// Token: 0x06000E6F RID: 3695 RVA: 0x00006CE4 File Offset: 0x00004EE4
	public static bool smethod_0(object object_0, TypeInfo typeInfo_0, Delegate53 delegate53_1)
	{
		return delegate53_1(object_0, typeInfo_0);
	}

	// Token: 0x06000E70 RID: 3696
	public extern Delegate53(object object_0, IntPtr intptr_0);

	// Token: 0x06000E71 RID: 3697 RVA: 0x00006CF1 File Offset: 0x00004EF1
	static Delegate53()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate53).TypeHandle);
	}

	// Token: 0x040004C7 RID: 1223
	internal static Delegate53 delegate53_0;
}
