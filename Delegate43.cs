using System;
using System.Reflection;

// Token: 0x020000EA RID: 234
internal sealed class Delegate43 : MulticastDelegate
{
	// Token: 0x06000E46 RID: 3654
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06000E47 RID: 3655 RVA: 0x00006BC8 File Offset: 0x00004DC8
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate43 delegate43_1)
	{
		return delegate43_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x06000E48 RID: 3656
	public extern Delegate43(object object_0, IntPtr intptr_0);

	// Token: 0x06000E49 RID: 3657 RVA: 0x00006BD5 File Offset: 0x00004DD5
	static Delegate43()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate43).TypeHandle);
	}

	// Token: 0x040004BD RID: 1213
	internal static Delegate43 delegate43_0;
}
