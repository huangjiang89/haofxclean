using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

// Token: 0x0200005A RID: 90
internal class Class74 : Window, IComponentConnector, IStyleConnector
{
	// Token: 0x06000509 RID: 1289 RVA: 0x00006630 File Offset: 0x00004830
	private void method_0(int int_1)
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00006635 File Offset: 0x00004835
	private bool method_1(string string_0)
	{
		return true;
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00006630 File Offset: 0x00004830
	public void method_2()
	{
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00006630 File Offset: 0x00004830
	public void method_3()
	{
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00006630 File Offset: 0x00004830
	private void method_4(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00006630 File Offset: 0x00004830
	private void method_5(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00006630 File Offset: 0x00004830
	private void method_6(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00006630 File Offset: 0x00004830
	private void method_7(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00006630 File Offset: 0x00004830
	private void method_8(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00006630 File Offset: 0x00004830
	private void method_9(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00006630 File Offset: 0x00004830
	private void method_10(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00006630 File Offset: 0x00004830
	private void method_11(object sender, MouseButtonEventArgs e)
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00006630 File Offset: 0x00004830
	private void method_12(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00006630 File Offset: 0x00004830
	private void method_13(object sender, MouseButtonEventArgs e)
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00006630 File Offset: 0x00004830
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00006638 File Offset: 0x00004838
	static Class74()
	{
		Class105.smethod_20();
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_0()
	{
		return true;
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class74 smethod_1()
	{
		return null;
	}

	// Token: 0x04000274 RID: 628
	private object object_0;

	// Token: 0x04000275 RID: 629
	private object object_1;

	// Token: 0x04000276 RID: 630
	public object object_2;

	// Token: 0x04000277 RID: 631
	private int int_0;

	// Token: 0x04000278 RID: 632
	private ObservableCollection<Class62> observableCollection_0;

	// Token: 0x04000279 RID: 633
	private ObservableCollection<Class61> observableCollection_1;

	// Token: 0x0400027A RID: 634
	internal object object_3;

	// Token: 0x0400027B RID: 635
	internal object object_4;

	// Token: 0x0400027C RID: 636
	private bool bool_0;

	// Token: 0x0400027D RID: 637
	internal static object object_5;

	// Token: 0x0200005B RID: 91
	internal sealed class Delegate2 : MulticastDelegate
	{
		// Token: 0x0600051D RID: 1309
		public extern Delegate2(object object_0, IntPtr intptr_0);

		// Token: 0x0600051E RID: 1310
		public extern void Invoke();

		// Token: 0x0600051F RID: 1311
		public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

		// Token: 0x06000520 RID: 1312
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06000521 RID: 1313 RVA: 0x00006638 File Offset: 0x00004838
		static Delegate2()
		{
			Class105.smethod_20();
		}
	}
}
