using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Names
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

        protected void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddName();
        }

        private void AddName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name isn't defined!");
                return;
            }

            if (lstNames.Items.Contains(txtName.Text))
            {
                MessageBox.Show("Name cannot be duplicated!");
                return;
            }

            lstNames.Items.Add(txtName.Text);
            txtName.Clear();
        }
    }
}
