using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

// Token: 0x0200006C RID: 108
internal class Class87 : Window, IComponentConnector
{
	// Token: 0x060005BB RID: 1467 RVA: 0x00006635 File Offset: 0x00004835
	private bool method_0()
	{
		return true;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00006630 File Offset: 0x00004830
	public void method_1(bool bool_2 = true)
	{
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00006630 File Offset: 0x00004830
	public void method_2()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00006630 File Offset: 0x00004830
	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00006630 File Offset: 0x00004830
	private void method_4(object sender, MouseButtonEventArgs e)
	{
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00006630 File Offset: 0x00004830
	private void method_5(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00006630 File Offset: 0x00004830
	private void method_6(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00006630 File Offset: 0x00004830
	private void method_7(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00006630 File Offset: 0x00004830
	private void method_8()
	{
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00006638 File Offset: 0x00004838
	static Class87()
	{
		Class105.smethod_20();
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_0()
	{
		return true;
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class87 smethod_1()
	{
		return null;
	}

	// Token: 0x040002F8 RID: 760
	private object object_0;

	// Token: 0x040002F9 RID: 761
	public bool bool_0;

	// Token: 0x040002FA RID: 762
	private ObservableCollection<Class66> observableCollection_0;

	// Token: 0x040002FB RID: 763
	internal object object_1;

	// Token: 0x040002FC RID: 764
	private bool bool_1;

	// Token: 0x040002FD RID: 765
	internal static object object_2;

	// Token: 0x0200006D RID: 109
	internal sealed class Delegate7 : MulticastDelegate
	{
		// Token: 0x060005C9 RID: 1481
		public extern Delegate7(object object_0, IntPtr intptr_0);

		// Token: 0x060005CA RID: 1482
		public extern void Invoke();

		// Token: 0x060005CB RID: 1483
		public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

		// Token: 0x060005CC RID: 1484
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x060005CD RID: 1485 RVA: 0x00006638 File Offset: 0x00004838
		static Delegate7()
		{
			Class105.smethod_20();
		}
	}
}
