using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace petplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PasswordBox password;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("приветули жди докс");

            //    string password = PasswordBox.Password;

            //    if (password == "rodipit")
            //    {
            //        FirstWindow firstWindow = new FirstWindow();
            //        firstWindow.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("приветули жди докс");
            //    }
            //}
            //public string Password
            //{
            //    get { return password.Password; }
            //    set
            //    {
            //        password.Password = value;
            //    }
            //
        }


    }
}
