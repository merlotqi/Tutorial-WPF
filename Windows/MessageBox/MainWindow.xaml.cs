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

namespace MessageBox
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

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            Window owner = (bool)ownerCheckBox.IsChecked ? this : null;
            var messageBoxTest = this.messageBoxText.Text;
            var caption = this.caption.Text;
            var button = (MessageBoxButton)Enum.Parse(typeof(MessageBoxButton), buttonComboBox.Text);
            var icon = (MessageBoxImage)Enum.Parse(typeof(MessageBoxImage), imageComboBox.Text);
            var defaultResult = (MessageBoxResult)Enum.Parse(typeof(MessageBoxResult), defaultResultComboBox.Text);
            var options = (MessageBoxOptions)Enum.Parse(typeof(MessageBoxOptions), optionsComboBox.Text);

            MessageBoxResult result;
            if (owner == null)
            {
                result = System.Windows.MessageBox.Show(messageBoxTest, caption, button, icon, defaultResult, options);
            }
            else
            {
                result = System.Windows.MessageBox.Show(owner, messageBoxTest, caption, button, icon, defaultResult, options);
            }

            resultTextBlock.Text = "Result = " + result;
        }
    }
}