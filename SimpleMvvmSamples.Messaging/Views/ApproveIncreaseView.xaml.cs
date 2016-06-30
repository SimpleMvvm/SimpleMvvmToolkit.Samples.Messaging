using System.Windows;
using SimpleMvvmSamples.Messaging.Models;

namespace SimpleMvvmSamples.Messaging.Views
{
    /// <summary>
    /// Interaction logic for ApproveIncreaseView.xaml
    /// </summary>
    public partial class ApproveIncreaseView : Window
    {
        public ApproveIncreaseView(IncreaseInfo info)
        {
            InitializeComponent();
            QuantityText.Text = info.Amount.ToString();
            CustomerText.Text = info.CustomerName;
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
