using System;

// Token: 0x020000F2 RID: 242
internal sealed class Delegate51 : MulticastDelegate
{
	// Token: 0x06000E66 RID: 3686
	public extern void Invoke(object object_0);

	// Token: 0x06000E67 RID: 3687 RVA: 0x00006CAC File Offset: 0x00004EAC
	public static void smethod_0(object object_0, Delegate51 delegate51_1)
	{
		delegate51_1(object_0);
	}

	// Token: 0x06000E68 RID: 3688
	public extern Delegate51(object object_0, IntPtr intptr_0);

	// Token: 0x06000E69 RID: 3689 RVA: 0x00006CB7 File Offset: 0x00004EB7
	static Delegate51()
	{
		Class105.smethod_20();
		Class105.smethod_13(typeof(Delegate51).TypeHandle);
	}

	// Token: 0x040004C5 RID: 1221
	internal static Delegate51 delegate51_0;
}
