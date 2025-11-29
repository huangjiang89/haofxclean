using System;
using System.Data.OleDb;

// Token: 0x02000109 RID: 265
internal sealed class Delegate74 : MulticastDelegate
{
	// Token: 0x06000EC2 RID: 3778
	public extern void Invoke(object object_0, OleDbConnection oleDbConnection_0);

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00006F46 File Offset: 0x00005146
	public static void smethod_0(object object_0, OleDbConnection oleDbConnection_0, Delegate74 delegate74_1)
	{
		delegate74_1(object_0, oleDbConnection_0);
	}

	// Token: 0x06000EC4 RID: 3780
	public extern Delegate74(object object_0, IntPtr intptr_0);

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00006F53 File Offset: 0x00005153
	static Delegate74()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate74).TypeHandle);
	}

	// Token: 0x040004DC RID: 1244
	internal static Delegate74 delegate74_0;
}
