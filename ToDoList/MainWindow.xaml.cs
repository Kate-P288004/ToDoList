using System.Diagnostics;
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

namespace ToDoList
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

        private void AddHomeTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HomeInput.Text))
            {
                HomeList.Items.Add( HomeInput.Text);
                HomeInput.Clear();
            }
        }

        private void AddTafeTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TafeInput.Text))
            {
                TafeList.Items.Add( TafeInput.Text);
                TafeInput.Clear();
            }
        }
        private void AddHobbyTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HobbyInput.Text))
            {
                HobbyList.Items.Add( HobbyInput.Text);
                HobbyInput.Clear();
            }
        }

    }
}