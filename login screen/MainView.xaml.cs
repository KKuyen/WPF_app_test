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
using login_screen.ViewModels;

namespace login_screen
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataContext = new MenuVM();
        }
        Border a = new Border();
        Border b = new Border();
        int main = 1;
        public MainView()
        {
            InitializeComponent();
            DataContext = new MenuVM();
            a.Background = Home.Background;
            b.Background = Product.Background;

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();

        }
        private void btnMinisize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }





        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow mainView = new MainWindow();
            mainView.Show();
            this.Close();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Mainname.Text = "ORDER";
            DataContext = new Oder();
            Product.Background = b.Background;
            Orderbtn.Background = a.Background;
            Product.Background = b.Background;
            Customer.Background = b.Background;
            Import.Background = b.Background;
            Home.Background = b.Background;
            main = 2;

        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Mainname.Text = "PRODUCT";
            Product.Background = b.Background;
            Orderbtn.Background = b.Background;
            Product.Background = a.Background;
            Customer.Background = b.Background;
            Import.Background = b.Background;
            Home.Background = b.Background;
            main = 3;
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Mainname.Text = "CUSTOMER";
            Product.Background = b.Background;
            Orderbtn.Background = b.Background;
            Product.Background = b.Background;
            Customer.Background = a.Background;
            Import.Background = b.Background;
            Home.Background = b.Background;
            main = 4;
        }

        private void Border_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Mainname.Text = "IMPORT";
            Product.Background = b.Background;
            Orderbtn.Background = b.Background;
            Product.Background = b.Background;
            Customer.Background = b.Background;
            Import.Background = a.Background;
            Home.Background = b.Background;
            main = 5;
        }

        private void Border_MouseDown_4(object sender, MouseButtonEventArgs e)
        {

            Mainname.Text = "HOME";
            DataContext = new MenuVM();
            Product.Background = b.Background;
            Orderbtn.Background = b.Background;
            Product.Background = b.Background;
            Customer.Background = b.Background;
            Import.Background = b.Background;
            Home.Background = a.Background;
            main = 1;


        }


        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Mainname.Text = "PROFILE";
            DataContext = new InfoVM();
        }

        private void Home_MouseEnter(object sender, MouseEventArgs e)
        {

            Home.Background = a.Background;

        }

        private void Home_MouseLeave(object sender, MouseEventArgs e)
        {
            if (main == 1)
            {

            }
            else
            {
                Home.Background = b.Background;
            }

        }

        private void Orderbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Orderbtn.Background = a.Background;
        }

        private void Orderbtn_MouseLeave(object sender, MouseEventArgs e)
        {

            if (main == 2)
            {

            }
            else
            {
                Orderbtn.Background = b.Background;
            }
        }

        private void Product_MouseEnter(object sender, MouseEventArgs e)
        {
            Product.Background = a.Background;
        }

        private void Product_MouseLeave(object sender, MouseEventArgs e)
        {
            if (main == 3)
            {

            }
            else
            {
               Product.Background = b.Background;
            }
        }

        private void Customer_MouseEnter(object sender, MouseEventArgs e)
        {
            Customer.Background = a.Background;
        }

        private void Customer_MouseLeave(object sender, MouseEventArgs e)
        {
            if (main == 4)
            {

            }
            else
            {
                Customer.Background = b.Background;
            }
        }

        private void Import_MouseEnter(object sender, MouseEventArgs e)
        {
            Import.Background = a.Background;
        }

        private void Import_MouseLeave(object sender, MouseEventArgs e)
        {
            if (main == 5)
            {

            }
            else
            {
                Import.Background = b.Background;
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
