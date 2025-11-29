using System;
using System.Threading;

// Token: 0x020000F8 RID: 248
internal sealed class Delegate57 : MulticastDelegate
{
	// Token: 0x06000E7E RID: 3710
	public extern void Invoke(object object_0, SendOrPostCallback sendOrPostCallback_0, object object_1);

	// Token: 0x06000E7F RID: 3711 RVA: 0x00006D5A File Offset: 0x00004F5A
	public static void smethod_0(object object_0, SendOrPostCallback sendOrPostCallback_0, object object_1, Delegate57 delegate57_1)
	{
		delegate57_1(object_0, sendOrPostCallback_0, object_1);
	}

	// Token: 0x06000E80 RID: 3712
	public extern Delegate57(object object_0, IntPtr intptr_0);

	// Token: 0x06000E81 RID: 3713 RVA: 0x00006D69 File Offset: 0x00004F69
	static Delegate57()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate57).TypeHandle);
	}

	// Token: 0x040004CB RID: 1227
	internal static Delegate57 delegate57_0;
}
