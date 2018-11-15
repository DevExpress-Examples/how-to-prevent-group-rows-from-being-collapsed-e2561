<!-- default file list -->
*Files to look at*:

* [DataSource.cs](./CS/Prevent Group from Collapsing/DataSource.cs) (VB: [DataSource.vb](./VB/Prevent Group from Collapsing/DataSource.vb))
* [MainPage.xaml](./CS/Prevent Group from Collapsing/MainPage.xaml) (VB: [MainPage.xaml](./VB/Prevent Group from Collapsing/MainPage.xaml))
* [MainPage.xaml.cs](./CS/Prevent Group from Collapsing/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/Prevent Group from Collapsing/MainPage.xaml))
<!-- default file list end -->
# How to Prevent Group Rows from being Collapsed


<p>The following example shows how to customize whether a particular group row can be collapsed.</p><p>In this example, the 'Status: Invalidated' group row is prevented from being collapsed, and the full collapsing is disabled. To do this, the GroupRowCollapsing event is handled, and the event parameter's Allow property is set to false when the RowHandle property returns the 'Status: Invalidated' row's handle, or an invalid handle (this happens when all group rows are about to be collapsed).</p>

<br/>


