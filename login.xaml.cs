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

namespace OneUser
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String UserName = txtLogName.Text;
            String LoginPass = logPass.Password.ToString();


           Property.Settings1 settings = new Property.Settings1();

            if(UserName == settings.UserName && LoginPass == settings.Password)
            {
                Window1 oUpdate = new Window1();
                oUpdate.ShowDialog();
            }
            else
            {
             MessageBoxResult result = MessageBox.Show("Enter a Valid UserName and Password","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                if(result == MessageBoxResult.OK)
                {
                    txtLogName.Clear();
                    logPass.Clear();
                }
            }
        }
    }
}
