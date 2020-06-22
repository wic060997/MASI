using System.Windows;

namespace Uniterm
{
    /// <summary>
    /// Interaction logic for ChooseChange.xaml
    /// </summary>
    public partial class ChooseChange : Window
    {
        public bool anuluj;
        public ChooseChange()
        {
            anuluj = false;
            InitializeComponent();
        }

        public Window1 Window1
        {
            get => default;
            set
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            anuluj = true;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
