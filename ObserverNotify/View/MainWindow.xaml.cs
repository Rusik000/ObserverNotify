using ObserverNotify.Classes;
using ObserverNotify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObserverNotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Store Store { get; set; } = new Store();
        public CustomerViaGmail Customer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Store.Customers = new List<ICustomer>();
        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            Store.Customers.Add(Customer = new CustomerViaGmail { CustomerEmail = CustomerMail.Text, ProductName = ProductName.Text });
            MainListbox.Items.Add($@"Product Name : {Customer.ProductName} 
Customer Mail : {Customer.CustomerEmail}");
        }

        private void Notify_Btn_Click(object sender, RoutedEventArgs e)
        {
            Store.Notify();
        }
    }
}
