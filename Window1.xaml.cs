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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String NewUserName = txtUpName.Text;

            String Password1 = UpPass.Password.ToString();
            String Password2 = UpPass2.Password.ToString();

            Property.Settings1 settings = new Property.Settings1();

            String Name1 = "";
            String Pass1 = "";

                if (Password1 == Password2)
                {

                    if (Password2 == settings.Password)
                    {
                        MessageBox.Show("Please enter new Password","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                    }
                    else
                    {
                        settings.Password = Password2;
                        settings.Save();
                    Name1 = "OK";
                    }
                }
                else
                {
                    lblPass.Visibility = Visibility;
                }


                if (NewUserName == settings.UserName)
                {
                    logName.Visibility = Visibility;
                }
                else
                {
                    settings.UserName = NewUserName;
                    settings.Save();
                Pass1 = "OK";
                }
            
            if(Name1 =="OK" && Pass1 == "OK" ) {

                MessageBox.Show("Your Name and Password is Successfully Updated", "Updation",MessageBoxButton.OK,MessageBoxImage.None);
            
            }

            

            
        }
    }
}
