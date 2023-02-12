using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace krestiki_noliki
{
    /// <summary>
    /// Логика взаимодействия для Winner.xaml
    /// </summary>
    public partial class Winner : Window
    {
        public int Win;
        public Winner(int winner)
        {
            Win = winner;
            InitializeComponent();
            if (Win == 1)
            {
                X_Winner.Visibility= Visibility.Visible;
            }
            else if(Win == -1)
            {
                O_Winner.Visibility= Visibility.Visible;
            }
            else
            {
                No_Win.Visibility= Visibility.Visible;
            }
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Choose();
        }
    }
}
