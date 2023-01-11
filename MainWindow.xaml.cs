using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace OneUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        String builder = "";
        String Gender = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Name = txtName.Text;
            String Mail = txtMail.Text;
            dynamic Password = txtPass.Password;
            dynamic Password2 = txtPass2.Password;

            login(Name, Mail, Password, Password2);

            if (Name == "" && Mail == "" && Password == "" && Password2 == "" && Gender == "")
            {
           
                MessageBoxResult result = MessageBox.Show("Error", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    txtName.Clear();
                    txtPass.Clear();
                    txtMail.Clear();
                    txtPass2.Clear();
                    txtPass.Clear();

                }

            }
            if(RbMale.IsChecked== true)
            {
                Gender = "Male";
            }else if(RbFemale.IsChecked== true)
            {
                Gender = "Female";
            }
            else
            {
                lblGender.Visibility = Visibility;
            }

            Property.Settings1 settings = new Property.Settings1(); 

            settings.UserName= txtName.Text;
            settings.Password = txtPass2.Password.ToString();
            settings.Save();

           


        }

        private void login(String Name, String Email, String Password, String Password2)
        {
            char[] Mail = Email.ToCharArray();

            char[] chars = { '@', '.' };

            for (int i = 0; i < Mail.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Mail[i] == chars[j])
                    {

                        builder = "OK";

                    }

                }


            }

            if (Name != "" && Password == Password2 && builder == "OK" && Gender!="")
            {
                login ologin = new login();

                ologin.Show();
            }
            else
            {
                if (Name == "")
                {
                    lblName.Visibility = Visibility;
                }
                if (Password != Password2)
                {
                    lblPass2.Visibility = Visibility;
                }
                if (builder != "OK")
                {
                    lblMail.Visibility = Visibility;
                }

                
                if (Gender != "Male" && Gender != "Female")
                {
                    lblGender.Visibility = Visibility;
                }


            }





        }
    }
}
