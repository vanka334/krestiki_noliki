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

namespace krestiki_noliki
{
    /// <summary>
    /// Логика взаимодействия для Choose.xaml
    /// </summary>
    public partial class Choose : Page
    {
        public static string RadioCheck;
        public Choose()
        {
            InitializeComponent();
        }

        private void AllRadio(object sender, RoutedEventArgs e)
        {
            RadioCheck = (string)(sender as RadioButton).Content;
            
        }

        private void Chooser_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Play_Ground(Krestiki.IsChecked.Value);
       
        }
           
    }
}
