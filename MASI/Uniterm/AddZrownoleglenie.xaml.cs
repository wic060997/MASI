using System.Windows;

namespace Uniterm
{
    /// <summary>
    /// Interaction logic for AddZrownoleglenie.xaml
    /// </summary>
    public partial class AddZrownoleglenie : Window
    {
        public AddZrownoleglenie()
        {
            InitializeComponent();
        }

        public Window1 Window1
        {
            get => default;
            set
            {
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
