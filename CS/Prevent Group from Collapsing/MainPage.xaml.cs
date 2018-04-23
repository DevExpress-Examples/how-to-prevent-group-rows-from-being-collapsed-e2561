using System.Windows.Controls;
using DevExpress.Xpf.Grid;
using DXExample.DemoData;

namespace Prevent_Group_from_Collapsing {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            gridControl1.ItemsSource = Invoice.GetData();
        }
        private void gridControl1_GroupRowCollapsing(object sender, RowAllowEventArgs e) {
            if(e.Row == null ||
                ((Invoice)e.Row).Status == InvoiceStatus.Invalidated &&
                gridControl1.Columns["Status"].GroupIndex != -1)
                e.Allow = false;
        }
    }
}
