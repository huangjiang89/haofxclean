using System;
using System.Reflection;

// Token: 0x02000101 RID: 257
internal sealed class Delegate66 : MulticastDelegate
{
	// Token: 0x06000EA2 RID: 3746
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00006E60 File Offset: 0x00005060
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate66 delegate66_1)
	{
		return delegate66_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x06000EA4 RID: 3748
	public extern Delegate66(object object_0, IntPtr intptr_0);

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00006E6D File Offset: 0x0000506D
	static Delegate66()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate66).TypeHandle);
	}

	// Token: 0x040004D4 RID: 1236
	internal static Delegate66 delegate66_0;
}
