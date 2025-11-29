using System;

// Token: 0x020000EE RID: 238
internal sealed class Delegate47 : MulticastDelegate
{
	// Token: 0x06000E56 RID: 3670
	public extern void Invoke(object object_0, ref bool bool_0);

	// Token: 0x06000E57 RID: 3671 RVA: 0x00006C3A File Offset: 0x00004E3A
	public static void smethod_0(object object_0, ref bool bool_0, Delegate47 delegate47_1)
	{
		delegate47_1(object_0, ref bool_0);
	}

	// Token: 0x06000E58 RID: 3672
	public extern Delegate47(object object_0, IntPtr intptr_0);

	// Token: 0x06000E59 RID: 3673 RVA: 0x00006C47 File Offset: 0x00004E47
	static Delegate47()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate47).TypeHandle);
	}

	// Token: 0x040004C1 RID: 1217
	internal static Delegate47 delegate47_0;
}
