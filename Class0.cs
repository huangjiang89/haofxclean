using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
internal class Class0 : INotifyPropertyChanged
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000004 RID: 4 RVA: 0x00006630 File Offset: 0x00004830
	// (remove) Token: 0x06000005 RID: 5 RVA: 0x00006630 File Offset: 0x00004830
	public event PropertyChangedEventHandler PropertyChanged
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

	// Token: 0x06000006 RID: 6 RVA: 0x00006632 File Offset: 0x00004832
	protected PropertyChangedEventHandler method_0()
	{
		return null;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00006630 File Offset: 0x00004830
	[Conditional("DEBUG")]
	public void method_1(string string_0)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00006630 File Offset: 0x00004830
	protected virtual void vmethod_0([CallerMemberName] string propertyName = null)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00006630 File Offset: 0x00004830
	protected virtual void vmethod_1<T>(Expression<Func<T>> expression_0)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00006632 File Offset: 0x00004832
	protected static string smethod_0<T>(Expression<Func<T>> expression_0)
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00006635 File Offset: 0x00004835
	protected bool method_2<T>(Expression<Func<T>> expression_0, ref T gparam_0, T gparam_1)
	{
		return true;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00006635 File Offset: 0x00004835
	protected bool method_3<T>(string string_0, ref T gparam_0, T gparam_1)
	{
		return true;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00006635 File Offset: 0x00004835
	protected bool method_4<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string propertyName = null)
	{
		return true;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00006638 File Offset: 0x00004838
	static Class0()
	{
		Class105.smethod_20();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_1()
	{
		return true;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class0 smethod_2()
	{
		return null;
	}

	// Token: 0x04000001 RID: 1
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x04000002 RID: 2
	internal static object object_0;
}
