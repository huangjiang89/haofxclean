using System;

// Token: 0x020000E4 RID: 228
internal sealed class Delegate37 : MulticastDelegate
{
	// Token: 0x06000E2E RID: 3630
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06000E2F RID: 3631 RVA: 0x00006B12 File Offset: 0x00004D12
	public static bool smethod_0(Type type_0, Type type_1, Delegate37 delegate37_1)
	{
		return delegate37_1(type_0, type_1);
	}

	// Token: 0x06000E30 RID: 3632
	public extern Delegate37(object object_0, IntPtr intptr_0);

	// Token: 0x06000E31 RID: 3633 RVA: 0x00006B1F File Offset: 0x00004D1F
	static Delegate37()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate37).TypeHandle);
	}

	// Token: 0x040004B7 RID: 1207
	internal static Delegate37 delegate37_0;
}
