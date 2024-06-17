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

namespace ChatSP
{
    /// <summary>
    /// Логика взаимодействия для Registratio.xaml
    /// </summary>
    public partial class Registratio : Page
    {
        public Registratio()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.NameLogin = Tname.Text;
            user.Password = Convert.ToInt32(Passwords.Text);
           
        }

       
    }
}
