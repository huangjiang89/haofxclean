using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

// Token: 0x02000023 RID: 35
internal class Class30<T> : ICommand
{
	// Token: 0x0600010E RID: 270 RVA: 0x00006630 File Offset: 0x00004830
	public Class30(Action<T> action_0)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00006630 File Offset: 0x00004830
	public Class30(Action<T> action_0, Func<T, bool> func_0)
	{
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000110 RID: 272 RVA: 0x00006630 File Offset: 0x00004830
	// (remove) Token: 0x06000111 RID: 273 RVA: 0x00006630 File Offset: 0x00004830
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

	// Token: 0x06000112 RID: 274 RVA: 0x00006630 File Offset: 0x00004830
	public void YvnkcDimXu()
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00006635 File Offset: 0x00004835
	public bool CanExecute(object parameter)
	{
		return true;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00006630 File Offset: 0x00004830
	public virtual void Execute(object parameter)
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00006638 File Offset: 0x00004838
	static Class30()
	{
		Class105.smethod_20();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_0()
	{
		return true;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00006632 File Offset: 0x00004832
	internal static object smethod_1()
	{
		return null;
	}

	// Token: 0x04000044 RID: 68
	private readonly Class26<T> class26_0;

	// Token: 0x04000045 RID: 69
	private readonly Class28<T, bool> class28_0;

	// Token: 0x04000046 RID: 70
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x04000047 RID: 71
	internal static object object_0;
}
