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

namespace login_screen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            


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


        private void txt_pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
                if (txt_pass.Password != "")
                    eye.Visibility = Visibility.Visible;
                else
                    eye.Visibility = Visibility.Hidden;
           

        }

        private void eye_MouseDown(object sender, MouseButtonEventArgs e)
        {

            txt_pass.Visibility = Visibility.Hidden;
            txt_passwordun.Visibility = Visibility.Visible;
            txt_passwordun.Text = txt_pass.Password;
            eye.Visibility = Visibility.Hidden;
            eyeopen.Visibility = Visibility.Visible;


        }

        private void eyeopen_MouseDown(object sender, MouseButtonEventArgs e)
        {

            txt_pass.Visibility = Visibility.Visible;
            txt_passwordun.Visibility = Visibility.Hidden;
            txt_pass.Password = txt_passwordun.Text;
            eyeopen.Visibility = Visibility.Hidden;
            eye.Visibility = Visibility.Visible;
        }

        private void txt_passwordun_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                if (txt_passwordun.Text != "")

                    eyeopen.Visibility = Visibility.Visible;
                else
                    eyeopen.Visibility = Visibility.Hidden;
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        Border bldr = new Border();
        TextBlock txtfg=new TextBlock();    
        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
           
            bldr.Background = bolderlogin.Background;
            bolderlogin.Background = new SolidColorBrush(Colors.MediumPurple);
        }

        private void bolderlogin_MouseLeave(object sender, MouseEventArgs e)
        {
            bolderlogin.Background=bldr.Background;
        }

      

       
        private void TextBlock_MouseEnter_1(object sender, MouseEventArgs e)
        {
           
        }

        private void signup_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }
    }
}
