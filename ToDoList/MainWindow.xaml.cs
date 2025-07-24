using System.Windows;
using System.Windows.Controls;
namespace CuteToDoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Add Task Methods
        private void AddHomeTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HomeInput.Text))
            {
                HomeList.Items.Add(CreateCheckBox(HomeInput.Text));
                HomeInput.Clear();
            }
        }
        private void AddTafeTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TafeInput.Text))
            {
                TafeList.Items.Add(CreateCheckBox(TafeInput.Text));
                TafeInput.Clear();
            }
        }
        private void AddHobbyTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HobbyInput.Text))
            {
                HobbyList.Items.Add(CreateCheckBox(HobbyInput.Text));
                HobbyInput.Clear();
            }
        }
        // Remove Task Methods
        private void RemoveHomeTask_Click(object sender, RoutedEventArgs e)
        {
            RemoveCheckedItems(HomeList);
        }
        private void RemoveTafeTask_Click(object sender, RoutedEventArgs e)
        {
            RemoveCheckedItems(TafeList);
        }
        private void RemoveHobbyTask_Click(object sender, RoutedEventArgs e)
        {
            RemoveCheckedItems(HobbyList);
        }
        
        private CheckBox CreateCheckBox(string text)
        {
            return new CheckBox
            {
                Content = text,
                FontSize = 14,
                Margin = new Thickness(2)
            };
        }
        private void RemoveCheckedItems(ListBox listBox)
        {
            for (int i = listBox.Items.Count - 1; i >= 0; i--)
            {
                if (listBox.Items[i] is CheckBox cb && cb.IsChecked == true)
                {
                    listBox.Items.RemoveAt(i);
                }
            }
        }
    }
}