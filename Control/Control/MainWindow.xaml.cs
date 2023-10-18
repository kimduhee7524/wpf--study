using System;
using System.Collections;
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

namespace Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lbx.ItemsSource = GetSample();
        }

        private IEnumerable GetSample()
        {
            List<User> users = new();
            users.Add(new User().GenData("Duyi", "Seoullllllll"));
            users.Add(new User().GenData("James", "Busan"));
            users.Add(new User().GenData("Harry", "Jeju"));
            users.Add(new User().GenData("Luka", "Seoulllll"));
            
            return users;
        }
    }
}
