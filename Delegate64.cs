using System;

// Token: 0x020000FF RID: 255
internal sealed class Delegate64 : MulticastDelegate
{
	// Token: 0x06000E9A RID: 3738
	public extern bool Invoke(object object_0);

	// Token: 0x06000E9B RID: 3739 RVA: 0x00006E28 File Offset: 0x00005028
	public static bool smethod_0(object object_0, Delegate64 delegate64_0)
	{
		return delegate64_0(object_0);
	}

	// Token: 0x06000E9C RID: 3740
	public extern Delegate64(object object_0, IntPtr intptr_0);

	// Token: 0x06000E9D RID: 3741 RVA: 0x00006E33 File Offset: 0x00005033
	static Delegate64()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate64).TypeHandle);
	}

	// Token: 0x040004D2 RID: 1234
	internal static Delegate64 vIcXeiOdUm;
}
