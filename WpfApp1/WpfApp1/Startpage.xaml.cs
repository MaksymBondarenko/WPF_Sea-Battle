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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int Kol_One=4, Kol_Two=3, Kol_Three=2, Kol_Four=1, n=0;
        Random RND = new Random();
        List<Button> Buttons;
        public Window1()
        {
            InitializeComponent();
            Loaded += MainWindow_Loadded;
            Buttons = new List<Button>();
            foreach (var item in grid.Children)
            {

                if (item is Grid)
                {
                    foreach (var child1 in (item as Grid).Children)
                    {
                        if (item is Grid)
                        {
                            foreach (var child in (item as Grid).Children)
                            {

                                if (child is Button)
                                {
                                    if ((child as Button).Tag.ToString() != "0")
                                    {
                                        Buttons.Add(child as Button);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MainWindow_Loadded(object sender, RoutedEventArgs e)
        {
            int i=0;
            while (i!=10)
            {
                int Shot = RND.Next(0, 100);
                if (Buttons[Shot].Tag.ToString() == "false")
                {
                    Buttons[Shot].Template = Resources["ButtonWound"] as ControlTemplate;
                }
                else { Buttons[Shot].Template = Resources["ButtonShot"] as ControlTemplate; }
                i++;
            }


        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
           
            ////if (dialog.ShowDialog() == true)
            ////{
            ////    // Пользователь разрешил действие. Продолжить1
            ////}
            ////else
            ////{
            ////    // Пользователь отменил действие.
            ////}
            this.Close();
            
        }
    }
}
