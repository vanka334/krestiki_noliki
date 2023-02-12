using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
    /// Логика взаимодействия для Play_Ground.xaml
    /// </summary>
    public partial class Play_Ground : Page
    {
        public static List<int> buttons = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static bool yaXrestik;
        public int winner;

        public Play_Ground(bool yaKto)
        {
            yaXrestik = yaKto;
            InitializeComponent();
            if (yaXrestik == false)
            {
                Play_LogicBot();
            }



        }

        public void Play_LogicBot()
        {
            Random rnd = new();
            int i = rnd.Next(buttons.Count);
            buttons.Remove(i);
            switch (i)
            {
                case 0:
                    {
                        this.Button1.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X1.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O1.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 1:
                    {
                        this.Button2.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O2.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 2:
                    {
                        this.Button3.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X3.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O3.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 3:
                    {
                        this.Button4.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X4.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O4.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 4:
                    {
                        this.Button5.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X5.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O5.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 5:
                    {
                        this.Button6.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X6.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O6.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 6:
                    {
                        this.Button7.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X7.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O7.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 7:
                    {
                        this.Button8.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X8.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O8.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case 8:
                    {
                        this.Button9.Visibility = Visibility.Hidden;
                        if (yaXrestik == false)
                        {
                            this.X9.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            this.O9.Visibility = Visibility.Visible;
                        }
                        break;
                    }

            }

        }
        /*public static void Click_Buttons(object sender, RoutedEventArgs e)
        {
            
            if (yaXrestik)
            {
               
                 string but = (string)(sender as Button).Content;            
                 Play_Logic(but);
                 Play_LogicBot();
                
            }
            else if (yaXrestik == false)
            {
                
                Play_LogicBot();
                string but = (string)(sender as Button).Content;
                Play_Logic(but);
                
            }
        }*/
        public void Play_Logic(string but)
        {


            if (but == "Button1")
            {
                buttons.Remove(1);
                this.Button1.Visibility = Visibility.Hidden;
                if (yaXrestik == false)
                {
                    this.O1.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X1.Visibility = Visibility.Visible;
                }
            }

            if (but == "Button2")
            {
                this.Button2.Visibility = Visibility.Hidden;
                buttons.Remove(2);
                if (yaXrestik == false)
                {
                    this.O2.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X2.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button3")
            {
                this.Button3.Visibility = Visibility.Hidden;
                buttons.Remove(3);
                if (yaXrestik == false)
                {
                    this.O3.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X3.Visibility = Visibility.Visible;
                }

            }
            if (but == "Button4")
            {
                this.Button4.Visibility = Visibility.Hidden;
                buttons.Remove(4);
                if (yaXrestik == false)
                {
                    this.O4.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X4.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button5")
            {
                this.Button5.Visibility = Visibility.Hidden;
                buttons.Remove(5);
                if (yaXrestik == false)
                {
                    this.O5.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X5.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button6")
            {
                this.Button6.Visibility = Visibility.Hidden;
                buttons.Remove(6);
                if (yaXrestik == false)
                {
                    this.O6.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X6.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button7")
            {
                this.Button7.Visibility = Visibility.Hidden;
                buttons.Remove(7);
                if (yaXrestik == false)
                {
                    this.O7.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X7.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button8")
            {

                this.Button8.Visibility = Visibility.Hidden;
                buttons.Remove(8);
                if (yaXrestik == false)
                {
                    this.O8.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X8.Visibility = Visibility.Visible;
                }
            }
            if (but == "Button9")
            {
                this.Button9.Visibility = Visibility.Hidden;
                buttons.Remove(9);
                if (yaXrestik == false)
                {
                    this.O9.Visibility = Visibility.Visible;
                }
                else
                {
                    this.X9.Visibility = Visibility.Visible;
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {



            string but = (string)(sender as Button).Name;
            Play_Logic(but);
            Play_LogicBot();
            
                if ((X1.Visibility == Visibility.Visible && X5.Visibility == Visibility.Visible && X9.Visibility == Visibility.Visible) || (X3.Visibility == Visibility.Visible && X5.Visibility == Visibility.Visible && X7.Visibility == Visibility.Visible) || (X1.Visibility == Visibility.Visible && X4.Visibility == Visibility.Visible && X7.Visibility == Visibility.Visible) || (X2.Visibility == Visibility.Visible && X5.Visibility == Visibility.Visible && X8.Visibility == Visibility.Visible) || (X3.Visibility == Visibility.Visible && X6.Visibility == Visibility.Visible && X9.Visibility == Visibility.Visible) || (X1.Visibility == Visibility.Visible && X2.Visibility == Visibility.Visible && X3.Visibility == Visibility.Visible) || (X4.Visibility == Visibility.Visible && X5.Visibility == Visibility.Visible && X6.Visibility == Visibility.Visible) || (X7.Visibility == Visibility.Visible && X8.Visibility == Visibility.Visible && X9.Visibility == Visibility.Visible))
                {
                    winner = 1;
                    Winner window = new(winner);
                    window.Show();

                }
                else if ((O1.Visibility == Visibility.Visible && O5.Visibility == Visibility.Visible && O9.Visibility == Visibility.Visible) || (O3.Visibility == Visibility.Visible && O5.Visibility == Visibility.Visible && O7.Visibility == Visibility.Visible) || (O1.Visibility == Visibility.Visible && O4.Visibility == Visibility.Visible && O7.Visibility == Visibility.Visible) || (O2.Visibility == Visibility.Visible && O5.Visibility == Visibility.Visible && O8.Visibility == Visibility.Visible) || (O3.Visibility == Visibility.Visible && O6.Visibility == Visibility.Visible && O9.Visibility == Visibility.Visible) || (O1.Visibility == Visibility.Visible && O2.Visibility == Visibility.Visible && O3.Visibility == Visibility.Visible) || (O4.Visibility == Visibility.Visible && O5.Visibility == Visibility.Visible && O6.Visibility == Visibility.Visible) || (O7.Visibility == Visibility.Visible && O8.Visibility == Visibility.Visible && O9.Visibility == Visibility.Visible))
                {
                    winner = -1;
                    Winner window = new(winner);
                    window.Show();
                }
                else if(buttons.Count == 0 ) 
                {
                    winner = 0;
                    Winner window = new(winner);
                    window.Show();





                }
                else { }
            
            
        }
    }
}
