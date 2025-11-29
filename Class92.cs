using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Windows;

// Token: 0x02000074 RID: 116
internal class Class92 : Application
{
	// Token: 0x06000609 RID: 1545
	[DllImport("kernel32.dll")]
	public static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

	// Token: 0x0600060A RID: 1546 RVA: 0x00006630 File Offset: 0x00004830
	public static void smethod_0()
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_0()
	{
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00006630 File Offset: 0x00004830
	[STAThread]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00006638 File Offset: 0x00004838
	static Class92()
	{
		Class105.smethod_20();
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_1()
	{
		return true;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class92 smethod_2()
	{
		return null;
	}

	// Token: 0x0400032D RID: 813
	private bool bool_0;

	// Token: 0x0400032E RID: 814
	internal static object object_0;
}
