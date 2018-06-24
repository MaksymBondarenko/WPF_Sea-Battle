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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
            foreach (var item in playerShips.Children)
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
                                    (child as Button).Click += Button_Click;
                                   
                                }
                            }
                        }
                    }
                }
            }
           
            Window1 Startpage = new Window1();
            //Startpage.Owner = this;
            Startpage.ShowDialog();
           this.Close();
        }    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        
    }
}
