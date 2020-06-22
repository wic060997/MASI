using System.Windows;

namespace Uniterm
{
    /// <summary>
    /// Interaction logic for AddElem.xaml
    /// </summary>
    public partial class AddElem : Window
    {
        public AddElem()
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
