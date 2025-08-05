using System;
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

        // ------------------- Add Task Methods -------------------
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

        // ------------------- Remove Task Methods -------------------
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

        // ------------------- Bills: Add & Remove -------------------
        private void AddBill_Click(object sender, RoutedEventArgs e)
        {
            string billName = BillInput.Text.Trim();
            string amountText = BillAmount.Text.Trim();
            DateTime? dueDate = BillDueDate.SelectedDate;

            if (!string.IsNullOrWhiteSpace(billName) &&
                decimal.TryParse(amountText, out decimal amount) &&
                dueDate.HasValue)
            {
                string formatted = $"{billName} | ${amount:F2} | Due: {dueDate.Value.ToShortDateString()}";
                BillList.Items.Add(CreateCheckBox(formatted));

                BillInput.Clear();
                BillAmount.Clear();
                BillDueDate.SelectedDate = null;
            }
            else
            {
                MessageBox.Show("Please enter a bill name, valid amount, and due date.", "Invalid Input");
            }
        }

        private void RemoveBill_Click(object sender, RoutedEventArgs e)
        {
            RemoveCheckedItems(BillList);
        }

        // ------------------- Helpers -------------------
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
