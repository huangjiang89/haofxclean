using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

// Token: 0x0200005C RID: 92
internal class Class75 : Window, IComponentConnector
{
	// Token: 0x06000522 RID: 1314 RVA: 0x00006630 File Offset: 0x00004830
	public Class75(string string_0 = "0")
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00006630 File Offset: 0x00004830
	public void method_0()
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00006630 File Offset: 0x00004830
	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00006630 File Offset: 0x00004830
	private void method_2(object sender, MouseButtonEventArgs e)
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00006630 File Offset: 0x00004830
	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00006630 File Offset: 0x00004830
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00006638 File Offset: 0x00004838
	static Class75()
	{
		Class105.smethod_20();
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00006635 File Offset: 0x00004835
	internal static bool smethod_0()
	{
		return true;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00006632 File Offset: 0x00004832
	internal static Class75 smethod_1()
	{
		return null;
	}

	// Token: 0x0400027E RID: 638
	private object object_0;

	// Token: 0x0400027F RID: 639
	private object object_1;

	// Token: 0x04000280 RID: 640
	public object object_2;

	// Token: 0x04000281 RID: 641
	private int int_0;

	// Token: 0x04000282 RID: 642
	private ObservableCollection<Class65> observableCollection_0;

	// Token: 0x04000283 RID: 643
	internal object object_3;

	// Token: 0x04000284 RID: 644
	private bool bool_0;

	// Token: 0x04000285 RID: 645
	private static object object_4;

	// Token: 0x0200005D RID: 93
	internal sealed class Delegate3 : MulticastDelegate
	{
		// Token: 0x0600052C RID: 1324
		public extern Delegate3(object object_0, IntPtr intptr_0);

		// Token: 0x0600052D RID: 1325
		public extern void Invoke();

		// Token: 0x0600052E RID: 1326
		public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

		// Token: 0x0600052F RID: 1327
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06000530 RID: 1328 RVA: 0x00006638 File Offset: 0x00004838
		static Delegate3()
		{
			Class105.smethod_20();
		}
	}
}
