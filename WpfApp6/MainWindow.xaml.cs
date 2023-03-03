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
using System.Text.RegularExpressions;

namespace WpfApp6
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
        
        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {

            SignUp s1 = new SignUp();
            s1.ShowDialog();
           
         
             
        }

        private void Btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
           

            try
            {
                if (txt_UserName.Text.Length == 0 || txt_UserName.Text.Any(Char.IsDigit) )
                {
                    MessageBox.Show("User name can not be blank or have numbers","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                } 
                
                else if(txt_UserName.Text.Any(Char.IsPunctuation))

                {
                    MessageBox.Show("User name can not have any punctuation marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
               else if(txt_UserName.Text.Any(Char.IsSymbol))
                {
                    MessageBox.Show("You can not use symbols for user name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else if (txt_Password.Password.Length <= 8)
                {
                    MessageBox.Show("Your password is incorrect and can not havs less than eight numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if(txt_Password.Password.Length==0)
                {
                    MessageBox.Show("Password can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Items i1 = new Items();
                    i1.ShowDialog();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter words only", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong please check again ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
    }
}
