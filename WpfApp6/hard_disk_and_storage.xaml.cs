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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for hard_disk_and_storage.xaml
    /// </summary>
    public partial class hard_disk_and_storage : Window
    {
        public hard_disk_and_storage()
        {
            InitializeComponent();
        }

        private void btn_Buy_hard_Click(object sender, RoutedEventArgs e)
        {
            hard_disk_01 h1 = new hard_disk_01();
            this.Hide();
            h1.Show();
           
        }

        private void btn_Buy_hard2_Click(object sender, RoutedEventArgs e)
        {
            hard_disk_01 h1 = new hard_disk_01();
            this.Hide();
            h1.Show();

        }
    }
}
