using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalesManSys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Butt_CustMan_Click(object sender, RoutedEventArgs e)//顧客管理
        {
            CustomerManagement window = new CustomerManagement();
            window.Show();
        }

        private void Butt_PrudMan_Click(object sender, RoutedEventArgs e)//商品管理
        {
            ProductManagement window = new ProductManagement();
            window.Show();
        }

        private void Butt_InveMan_Click(object sender, RoutedEventArgs e)//在庫管理
        {
            InventoryManagement windows = new InventoryManagement();
            windows.Show();
        }

        private void Butt_EmplMan_Click(object sender, RoutedEventArgs e)//社員管理
        {
            EmployeeManagement windows =new EmployeeManagement();
            windows.Show();
        }

        private void Butt_SalesMan_Click(object sender, RoutedEventArgs e)//売上管理
        {
            SalesManagement windows= new SalesManagement();
            windows.Show();
        }

        private void Butt_OrdeMan_Click(object sender, RoutedEventArgs e)//受注管理
        {
            OrderManagement windows = new OrderManagement();
            windows.Show();
        }

        private void Butt_CustOrdeMan_Click(object sender, RoutedEventArgs e)//注文管理
        {
            CustomerOrder windows = new CustomerOrder();
            windows.Show();
        }

        private void Butt_PurcOrdeMan_Click(object sender, RoutedEventArgs e)//発注管理 
        {
            PurchaseOrderManagement windows = new PurchaseOrderManagement();
            windows.Show();
        }

        private void Butt_StockReceiMan_Click(object sender, RoutedEventArgs e)//入庫管理
        {
            StockReceiptManagement windows=new StockReceiptManagement();
            windows.Show();
        }

        private void Butt_StockIssueMan_Click(object sender, RoutedEventArgs e)//出庫管理
        {
            StockIssueManagement windwos=new StockIssueManagement();
            windwos.Show();
        }

        private void Butt_GoodsReceMan_Click(object sender, RoutedEventArgs e)//入荷管理
        {
            GoodsReceivingManagement windows=new    GoodsReceivingManagement();
            windows.Show();
        }

        private void Butt_ShipMan_Click(object sender, RoutedEventArgs e)//出荷管理
        {
            ShippingManagement windows=new ShippingManagement();
            windows.Show();
        }
    }
}