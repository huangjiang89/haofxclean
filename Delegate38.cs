using System;
using System.Reflection;

// Token: 0x020000E5 RID: 229
internal sealed class Delegate38 : MulticastDelegate
{
	// Token: 0x06000E32 RID: 3634
	public extern bool Invoke(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1);

	// Token: 0x06000E33 RID: 3635 RVA: 0x00006B30 File Offset: 0x00004D30
	public static bool smethod_0(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1, Delegate38 delegate38_1)
	{
		return delegate38_1(propertyInfo_0, propertyInfo_1);
	}

	// Token: 0x06000E34 RID: 3636
	public extern Delegate38(object object_0, IntPtr intptr_0);

	// Token: 0x06000E35 RID: 3637 RVA: 0x00006B3D File Offset: 0x00004D3D
	static Delegate38()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate38).TypeHandle);
	}

	// Token: 0x040004B8 RID: 1208
	internal static Delegate38 delegate38_0;
}
