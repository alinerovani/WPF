using System;
using System.Windows;
using System.Windows.Controls;

namespace Names
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDelete.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Hidden;
        }

        private enum Operation
        {
            Update = 1,
            Delete = 2
        }

        private void ValidateName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                throw new Exception("Name isn't defined!");

            if (lstNames.Items.Contains(txtName.Text))
                throw new Exception("Name cannot be duplicated!");
        }

        private void AddName()
        {
            try
            {
                ValidateName();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            lstNames.Items.Add(txtName.Text);
            txtName.Clear();
        }

        private void ChangeName(Operation operation)
        {
            switch (operation)
            {
                case Operation.Update:
                    try
                    {
                        if (!lstNames.Items[lstNames.SelectedIndex].Equals(txtName.Text))
                            ValidateName();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }

                    lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
                    break;
                case Operation.Delete:
                    lstNames.Items.RemoveAt(lstNames.SelectedIndex);
                    break;
            }

            txtName.Clear();

            btnDelete.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Hidden;
            btnAdd.Visibility = Visibility.Visible;
        }

        private void lstNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstNames.SelectedItem == null)
                return;

            txtName.Text = lstNames.SelectedItem.ToString();

            btnAdd.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Visible;
            btnUpdate.Visibility = Visibility.Visible;
        }

        protected void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddName();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ChangeName(Operation.Update);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ChangeName(Operation.Delete);
        }
    }
}
