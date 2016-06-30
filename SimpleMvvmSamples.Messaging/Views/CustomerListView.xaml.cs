using System.Collections.ObjectModel;
using System.Windows.Controls;
using SimpleMvvmSamples.Messaging.Models;
using SimpleMvvmSamples.Messaging.ViewModels;

namespace SimpleMvvmSamples.Messaging.Views
{
    /// <summary>
    /// Interaction logic for CustomerListView.xaml
    /// </summary>
    public partial class CustomerListView : UserControl
    {
        private readonly CustomerListViewModel _vm;
        public CustomerListView()
        {
            InitializeComponent();

            // Get a reference to the view-model
            _vm = (CustomerListViewModel)DataContext;

        }

        public ObservableCollection<Customer> Customers
        {
            get { return _vm.Customers; }
            set { _vm.Customers = value; }
        }

    }
}
