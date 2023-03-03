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
using System.Text.RegularExpressions;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            txt_Fname.Clear(); 
            txt_Lname.Clear(); 
            txt_Email.Clear();
            txt_Password.Clear();
            txt_ConPassword.Clear();
            txt_Address.Clear();
            txt_Tp.Clear();

        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Fname.Text.Length == 0)
            {
                MessageBox.Show("First name can not be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Fname.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("First name can not have numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Fname.Text.Any(Char.IsPunctuation))
            {
                MessageBox.Show("First name can not have punctuation marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Fname.Text.Any(Char.IsSymbol))
            {
                MessageBox.Show("First name can not have symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Lname.Text.Length == 0 || txt_Lname.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Last name can not be emty or can not have digits", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Lname.Text.Any(Char.IsPunctuation) || txt_Lname.Text.Any(Char.IsSymbol))
            {
                MessageBox.Show("Last name can not have punctuations and Symbols", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txt_Email.Text.Length == 0)
            {
                MessageBox.Show("Email can not be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email.Ex:name@gmail.com", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (!Regex.IsMatch(txt_Password.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                MessageBox.Show("Password must have at least 8 characters at least one uppercase letter one lowercase letter one digit and at least one special character", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_ConPassword.Password != txt_Password.Password)
            {
                MessageBox.Show(" Confirm password must be same as password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_Address.Text.Length == 0)
            {
                MessageBox.Show("Address can not be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (txt_Tp.Text.Length != 10 || txt_Tp.Text.Any(char.IsLetter))
            {
                MessageBox.Show("TP must have 10 numbers and can not have letters", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {
                MessageBox.Show("You have successfuly Registerd", "Error", MessageBoxButton.OK, MessageBoxImage.Information);

                Items i1 = new Items();
                i1.ShowDialog(); 
            }
           

        }
    }
}
