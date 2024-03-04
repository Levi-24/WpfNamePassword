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

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> NamePasswordPair = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Name and Password Length Check
            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("A felhasználónév túl rövid!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //Name Check
            if (NamePasswordPair.Keys.Contains(txtName.Text))
            {
                MessageBox.Show("A felhasználónév már foglalt!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            NamePasswordPair.Add(txtName.Text, txtPassword.Password.ToString());

            //ListBox Write
            lbx.Items.Clear();
            foreach (var item in NamePasswordPair)
            {
                lbx.Items.Add(item.Key);
            }

            //TextBox Clear
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}
