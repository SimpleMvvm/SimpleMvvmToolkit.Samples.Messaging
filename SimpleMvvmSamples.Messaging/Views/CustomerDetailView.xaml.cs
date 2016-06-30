using System.Windows.Controls;
using SimpleMvvmSamples.Messaging.Models;
using SimpleMvvmSamples.Messaging.ViewModels;

namespace SimpleMvvmSamples.Messaging.Views
{
    /// <summary>
    /// Interaction logic for CustomerDetailView.xaml
    /// </summary>
    public partial class CustomerDetailView : UserControl
    {
        private readonly CustomerDetailViewModel _vm;
        public CustomerDetailView()
        {
            InitializeComponent();

            // Get a reference to the view-model
            _vm = (CustomerDetailViewModel)DataContext;
        }

        private int _customerIndex;
        public int CustomerIndex
        {
            get { return _customerIndex; }
            set
            {
                _customerIndex = value;
                _vm.Customer = Customer.CustomersList[value];
            }
        }

    }
}
