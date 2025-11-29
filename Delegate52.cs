using System;

// Token: 0x020000F3 RID: 243
internal sealed class Delegate52 : MulticastDelegate
{
	// Token: 0x06000E6A RID: 3690
	public extern Type Invoke(object object_0);

	// Token: 0x06000E6B RID: 3691 RVA: 0x00006CC8 File Offset: 0x00004EC8
	public static Type smethod_0(object object_0, Delegate52 delegate52_1)
	{
		return delegate52_1(object_0);
	}

	// Token: 0x06000E6C RID: 3692
	public extern Delegate52(object object_0, IntPtr intptr_0);

	// Token: 0x06000E6D RID: 3693 RVA: 0x00006CD3 File Offset: 0x00004ED3
	static Delegate52()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate52).TypeHandle);
	}

	// Token: 0x040004C6 RID: 1222
	internal static Delegate52 delegate52_0;
}
