using System;

// Token: 0x020000FC RID: 252
internal sealed class Delegate61 : MulticastDelegate
{
	// Token: 0x06000E8E RID: 3726
	public extern bool Invoke(Type type_0, Type type_1);

	// Token: 0x06000E8F RID: 3727 RVA: 0x00006DD0 File Offset: 0x00004FD0
	public static bool smethod_0(Type type_0, Type type_1, Delegate61 delegate61_0)
	{
		return delegate61_0(type_0, type_1);
	}

	// Token: 0x06000E90 RID: 3728
	public extern Delegate61(object object_0, IntPtr intptr_0);

	// Token: 0x06000E91 RID: 3729 RVA: 0x00006DDD File Offset: 0x00004FDD
	static Delegate61()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate61).TypeHandle);
	}

	// Token: 0x040004CF RID: 1231
	internal static Delegate61 zBqXqsuvup;
}
