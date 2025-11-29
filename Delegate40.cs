using System;
using System.Reflection;

// Token: 0x020000E7 RID: 231
internal sealed class Delegate40 : MulticastDelegate
{
	// Token: 0x06000E3A RID: 3642
	public extern FieldInfo Invoke(object object_0, string string_0);

	// Token: 0x06000E3B RID: 3643 RVA: 0x00006B6E File Offset: 0x00004D6E
	public static FieldInfo smethod_0(object object_0, string string_0, Delegate40 delegate40_1)
	{
		return delegate40_1(object_0, string_0);
	}

	// Token: 0x06000E3C RID: 3644
	public extern Delegate40(object object_0, IntPtr intptr_0);

	// Token: 0x06000E3D RID: 3645 RVA: 0x00006B7B File Offset: 0x00004D7B
	static Delegate40()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate40).TypeHandle);
	}

	// Token: 0x040004BA RID: 1210
	internal static Delegate40 delegate40_0;
}
