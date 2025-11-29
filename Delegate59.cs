using System;
using System.Threading;

// Token: 0x020000FA RID: 250
internal sealed class Delegate59 : MulticastDelegate
{
	// Token: 0x06000E86 RID: 3718
	public extern SynchronizationContext Invoke();

	// Token: 0x06000E87 RID: 3719 RVA: 0x00006D98 File Offset: 0x00004F98
	public static SynchronizationContext smethod_0(Delegate59 delegate59_1)
	{
		return delegate59_1();
	}

	// Token: 0x06000E88 RID: 3720
	public extern Delegate59(object object_0, IntPtr intptr_0);

	// Token: 0x06000E89 RID: 3721 RVA: 0x00006DA1 File Offset: 0x00004FA1
	static Delegate59()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate59).TypeHandle);
	}

	// Token: 0x040004CD RID: 1229
	internal static Delegate59 delegate59_0;
}
