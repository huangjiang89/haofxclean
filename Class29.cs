using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

// Token: 0x02000022 RID: 34
internal class Class29 : ICommand
{
	// Token: 0x06000104 RID: 260 RVA: 0x00006630 File Offset: 0x00004830
	public Class29(Action action_0)
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00006630 File Offset: 0x00004830
	public Class29(Action action_0, Func<bool> func_0)
	{
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000106 RID: 262 RVA: 0x00006630 File Offset: 0x00004830
	// (remove) Token: 0x06000107 RID: 263 RVA: 0x00006630 File Offset: 0x00004830
	public event EventHandler CanExecuteChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00006630 File Offset: 0x00004830
	public void method_0()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00006635 File Offset: 0x00004835
	public bool CanExecute(object parameter)
	{
		return true;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00006630 File Offset: 0x00004830
	public virtual void Execute(object parameter)
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00006638 File Offset: 0x00004838
	static Class29()
	{
		Class105.smethod_20();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_0()
	{
		return true;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class29 smethod_1()
	{
		return null;
	}

	// Token: 0x04000040 RID: 64
	private readonly object object_0;

	// Token: 0x04000041 RID: 65
	private readonly Class27<bool> class27_0;

	// Token: 0x04000042 RID: 66
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x04000043 RID: 67
	internal static object object_1;
}
