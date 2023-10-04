using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using Microsoft.Win32;



namespace login_screen.Views
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        Image early = new Image();
        Border a = new Border();
        public SignUp()
        {
            InitializeComponent();
            early.Source = avt.ImageSource;
            lastgrid.Height = 70;
            lastgrid.VerticalAlignment = VerticalAlignment.Top;
            a.Background = signUpbutton.Background;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            avt.ImageSource = early.Source;
            Microsoft.Win32.OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image to set avatar";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.bmp;*.jpg;*.png|JPG Files|*.jpg|PNG Files|*.png|JPEG Files|*.jpeg";
            ofd.ShowDialog();
            avt.ImageSource = early.Source;

            if (ofd.FileName != "")
            {
                tb_uri.Text = ofd.FileName;
                Uri image_Path = new Uri(tb_uri.Text);
                avt.ImageSource = new BitmapImage(image_Path);
                avt.Stretch = System.Windows.Media.Stretch.UniformToFill;
                early.Source = avt.ImageSource;

            }
            else
            {
            }

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {



        }

        private void DatePickerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        bool gender = false;
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Male.Background = System.Windows.Media.Brushes.Blue;
            txtMale.Foreground = System.Windows.Media.Brushes.White;
            Male.BorderBrush = System.Windows.Media.Brushes.Blue;
            ic_male.Visibility = Visibility.Visible;
            fm.Background = System.Windows.Media.Brushes.Transparent;
            fm.BorderBrush = System.Windows.Media.Brushes.DeepPink;
            TXTfM.Foreground = System.Windows.Media.Brushes.DeepPink;
            FMIMG.Visibility = Visibility.Hidden;
            other.Background = System.Windows.Media.Brushes.Transparent;
            other.BorderBrush = System.Windows.Media.Brushes.ForestGreen;
            TXTother.Foreground = System.Windows.Media.Brushes.ForestGreen;
            otherimg.Visibility = Visibility.Hidden;
            gender = true;


        }

        private void Male_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Male.Background != System.Windows.Media.Brushes.Blue)
            {
                Male.Background = System.Windows.Media.Brushes.White;
                Male.BorderBrush = System.Windows.Media.Brushes.White;
            }
        }

        private void Male_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Male.Background != System.Windows.Media.Brushes.Blue)
            {

                Male.Background = System.Windows.Media.Brushes.Transparent;
                Male.BorderBrush = new SolidColorBrush(Colors.Blue);


            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            fm.Background = System.Windows.Media.Brushes.DeepPink;
            TXTfM.Foreground = new SolidColorBrush(Colors.White);
            fm.BorderBrush = System.Windows.Media.Brushes.DeepPink;
            FMIMG.Visibility = Visibility.Visible;
            Male.Background = System.Windows.Media.Brushes.Transparent;
            Male.BorderBrush = System.Windows.Media.Brushes.Blue;
            txtMale.Foreground = System.Windows.Media.Brushes.Blue;
            ic_male.Visibility = Visibility.Hidden;
            other.Background = System.Windows.Media.Brushes.Transparent;
            other.BorderBrush = System.Windows.Media.Brushes.ForestGreen;
            TXTother.Foreground = System.Windows.Media.Brushes.ForestGreen;
            otherimg.Visibility = Visibility.Hidden;
            gender = true;


        }

        private void fm_MouseEnter(object sender, MouseEventArgs e)
        {

            if (fm.Background != System.Windows.Media.Brushes.DeepPink)
            {
                fm.Background = new SolidColorBrush(Colors.White);
                fm.BorderBrush = new SolidColorBrush(Colors.White);
            }

        }

        private void fm_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fm.Background != System.Windows.Media.Brushes.DeepPink)
            {
                fm.Background = System.Windows.Media.Brushes.Transparent;
                fm.BorderBrush = new SolidColorBrush(Colors.DeepPink);
            }
        }

        private void other_MouseDown(object sender, MouseButtonEventArgs e)
        {


        }

        private void other_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            other.Background = System.Windows.Media.Brushes.ForestGreen;
            TXTother.Foreground = System.Windows.Media.Brushes.White;
            other.BorderBrush = System.Windows.Media.Brushes.ForestGreen;
            otherimg.Visibility = Visibility.Visible;
            fm.Background = System.Windows.Media.Brushes.Transparent;
            fm.BorderBrush = System.Windows.Media.Brushes.DeepPink;
            TXTfM.Foreground = System.Windows.Media.Brushes.DeepPink;
            FMIMG.Visibility = Visibility.Hidden;
            Male.Background = System.Windows.Media.Brushes.Transparent;
            Male.BorderBrush = System.Windows.Media.Brushes.Blue;
            txtMale.Foreground = System.Windows.Media.Brushes.Blue;
            ic_male.Visibility = Visibility.Hidden;
            gender = true;
        }

        private void other_MouseEnter(object sender, MouseEventArgs e)
        {
            if (other.Background != System.Windows.Media.Brushes.ForestGreen)
            {
                other.Background = new SolidColorBrush(Colors.White);
                other.BorderBrush = new SolidColorBrush(Colors.White);
            }
        }

        private void other_MouseLeave(object sender, MouseEventArgs e)
        {
            if (other.Background != System.Windows.Media.Brushes.ForestGreen)
            {
                other.Background = System.Windows.Media.Brushes.Transparent;
                other.BorderBrush = new SolidColorBrush(Colors.ForestGreen);
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            pass.Visibility = Visibility.Hidden;
            unpass.Visibility = Visibility.Visible;
            view.Visibility = Visibility.Hidden;
            unview.Visibility = Visibility.Visible;
            unpass.Text = pass.Password;
        }

        private void unview_MouseDown(object sender, MouseButtonEventArgs e)
        {
            unpass.Visibility = Visibility.Hidden;
            pass.Visibility = Visibility.Visible;
            unview.Visibility = Visibility.Hidden;
            view.Visibility = Visibility.Visible;
            pass.Password = unpass.Text;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            rpass.Visibility = Visibility.Hidden;
            runpass.Visibility = Visibility.Visible;
            rview.Visibility = Visibility.Hidden;
            runview.Visibility = Visibility.Visible;
            runpass.Text = rpass.Password;
        }

        private void unview_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            runpass.Visibility = Visibility.Hidden;
            rpass.Visibility = Visibility.Visible;
            runview.Visibility = Visibility.Hidden;
            rview.Visibility = Visibility.Visible;
            rpass.Password = runpass.Text;

        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        { 
           
            bdName.BorderThickness=new Thickness(0,0,0,0);
            bdEmail.BorderThickness = new Thickness(0, 0, 0, 0);
            bdPhone.BorderThickness = new Thickness(0, 0, 0, 0);
            bdpass.BorderThickness = new Thickness(0, 0, 0, 0); 
            bdrpass.BorderThickness = new Thickness(0, 0, 0, 0);
            bdDate.BorderThickness = new Thickness(0, 0, 0, 0);
            bdPos.BorderThickness = new Thickness(0, 0, 0, 0);
            bdws.BorderThickness = new Thickness(0, 0, 0, 0);
            TextBlock[] arr=new TextBlock[20];
            int ersum = 0;
            arr[0] = er1;
            arr[1] = er2;
            arr[2] = er3;
            arr[3] = er4;    
            arr[4] = er5;
            arr[5] = er6;   
            arr[6] = er7;   
            arr[7] = er8;   
                arr[8] = er9;
            arr[9] = er10;
            for (int i = 0; i < 10; i++)
            {
                arr[i].Visibility = Visibility.Collapsed;
                arr[i].Text = "";
                
            }
            string[] str = new string[20];
            bool dk = false;
            TextBlock[] res=new TextBlock[20];
            DateTime? selectedDate = dpk.SelectedDate;
            if (name.Text=="")
            {
                ersum++;
                str[ersum - 1] = "*Please enter the *Name box";
                res[ersum - 1] = er1;
                bdName.BorderThickness = new Thickness(2, 2, 2, 2);
                bdName.BorderBrush= System.Windows.Media.Brushes.Red;
            }


            if (email.Text == "")
            {
                ersum++;
                str[ersum - 1] = "*Please enter the *Email box";
                res[ersum - 1] = er2;
                bdEmail.BorderThickness = new Thickness(2, 2, 2, 2);
                bdEmail.BorderBrush = System.Windows.Media.Brushes.Red;
            }

            if (phone.Text == "")
            {
                ersum++;
                str[ersum - 1] = "*Please enter the *Phone number box";
                res[ersum - 1] = er3;
                bdPhone.BorderThickness = new Thickness(2, 2, 2, 2);
                bdPhone.BorderBrush = System.Windows.Media.Brushes.Red;
            }
           
            if (pass.Password=="")
            {
                ersum++;
                str[ersum - 1] = "*Please enter the Passwork";
                res[ersum - 1] = er4;
                bdpass.BorderThickness = new Thickness(2, 2, 2, 2);
                bdpass.BorderBrush = System.Windows.Media.Brushes.Red;
            }
        
            if (rpass.Password=="")
            {
                ersum++;
                str[ersum - 1] = "*Please enter the Repeat Password";
                res[ersum - 1] = er5;
                bdrpass.BorderThickness = new Thickness(2, 2, 2, 2);
                bdrpass.BorderBrush = System.Windows.Media.Brushes.Red;


            }
            if (selectedDate == null)
            {
                ersum++;
                str[ersum - 1] = "*Please choose your birthday";
                res[ersum - 1] = er6;
                bdDate.BorderThickness = new Thickness(2, 2, 2, 2);
                bdDate.BorderBrush = System.Windows.Media.Brushes.Red;

            }
            if (gender == false)
            {
                ersum++;
                str[ersum - 1] = "*Please select your gender";
                res[ersum - 1] = er7;
                
            }



          
            if (CV.Text == "Select your position")
            {
                ersum++;
                str[ersum - 1] = "*Please select your position";
                res[ersum - 1] = er8;
                bdPos.BorderThickness = new Thickness(2, 2, 2, 2);
                bdPos.BorderBrush = System.Windows.Media.Brushes.Red;
            }

            if (SC.Text == "Select your work schedule")
            {
                ersum++;
                str[ersum - 1] = "*Please select your work schedule";
                res[ersum - 1] = er9;
                bdws.BorderThickness = new Thickness(2, 2, 2, 2);
                bdws.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            if(pass.Password!=rpass.Password)

            {
                ersum++;
                str[ersum - 1] = "*Password doesn't match";
                res[ersum - 1] = er10;
                bdrpass.BorderThickness = new Thickness(2, 2, 2, 2);
                bdrpass.BorderBrush = System.Windows.Media.Brushes.Red;
            }
         
        
            
         
          for(int i=0;i<ersum;i++)
            {
                arr[i].Visibility=Visibility.Visible;
                arr[i].Text = str[i];
                }
            //điều kiện để đăng ký thành công
            if (pass.Password != "")
            {
                unpass.Text = pass.Password;
            }
            else
                pass.Password = unpass.Text;
            if (rpass.Password != "")
            {
                runpass.Text = rpass.Password;
            }
            else
                rpass.Password = runpass.Text;
        
          if (pass.Password == rpass.Password&& CV.Text != "Select your position" && SC.Text != "Select your work schedule" && name.Text != "" && email.Text != "" && phone.Text != "" && unpass.Text != "" && runpass.Text != "" && gender == true && selectedDate !=null )
            {
                dk = true;
            }

            if (dk == false)
            {
                lastgrid.Height = 180;
                SystemSounds.Beep.Play();

            }    
            else
            {
                this.Close();
                MessageBox.Show("Sign up Sucessfully");

            }
          

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CV.Foreground = System.Windows.Media.Brushes.Black;
            CV.Text = "CV1";

        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            CV.Foreground = System.Windows.Media.Brushes.Black;
            CV.Text = "CV2";
        }
        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {
            CV.Foreground = System.Windows.Media.Brushes.Black;
            CV.Text = "CV3";
        }
        private void MenuItem_Click4(object sender, RoutedEventArgs e)
        {
            SC.Foreground = System.Windows.Media.Brushes.Black;
            SC.Text = "246";

        }
        private void MenuItem_Click5(object sender, RoutedEventArgs e)
        {
            SC.Foreground = System.Windows.Media.Brushes.Black;
            SC.Text = "357";

        }
        private void MenuItem_Click6(object sender, RoutedEventArgs e)
        {
            SC.Foreground = System.Windows.Media.Brushes.Black;
            SC.Text = "78";
         

        }

        private void rpass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //điều kiện để đăng ký thành công
            if (rpass.Visibility == Visibility.Visible)
                runpass.Text = rpass.Password;
            if(rpass.Password== "" && unpass.Text == "")
            {
                rptxt.Text = "*Repeat Password";
                rptxt.Foreground = System.Windows.Media.Brushes.Black;


            }    
            else
            {
                if (rpass.Password == pass.Password)
                {
                    rptxt.Text = "*Repeat Password";
                    rptxt.Foreground = System.Windows.Media.Brushes.ForestGreen;

                }
                else
                {
                    rptxt.Text = " Password doesn't match!";
                    rptxt.Foreground = System.Windows.Media.Brushes.Red;
                }

            }


        }

     
        private void runpass_TextChanged_1(object sender, TextChangedEventArgs e)
        {

            if (runpass.Visibility == Visibility.Visible)
                rpass.Password = runpass.Text;
          
     
            if (runpass.Text == "" && unpass.Text == "")
            {
                rptxt.Text = "*Repeat Password";
                rptxt.Foreground = System.Windows.Media.Brushes.Black;

            }
            else
            {
                if (runpass.Text == pass.Password)
                {
                    rptxt.Text = "*Repeat Password";
                    rptxt.Foreground = System.Windows.Media.Brushes.ForestGreen;

                }
                else
                {
                    rptxt.Text = " Password doesn't match!";
                    rptxt.Foreground = System.Windows.Media.Brushes.Red;
                }

            }
        }

        private void pass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pass.Visibility == Visibility.Visible)
                unpass.Text = pass.Password;


            if (runpass.Text == "" && unpass.Text == "")
            {
                rptxt.Text = "*Repeat Password";
                rptxt.Foreground = System.Windows.Media.Brushes.Black;

            }
            else
            {
                if (runpass.Text == pass.Password)
                {
                    rptxt.Text = "*Repeat Password";
                    rptxt.Foreground = System.Windows.Media.Brushes.ForestGreen;

                }
                else
                {
                    rptxt.Text = " Password doesn't match!";
                    rptxt.Foreground = System.Windows.Media.Brushes.Red;
                }

            }

        }

        private void unpass_TextChanged(object sender, TextChangedEventArgs e)
        {

           if(unpass.Visibility==Visibility.Visible)
            pass.Password = unpass.Text;
            if (runpass.Text == "" && unpass.Text=="")
            {
                rptxt.Text = "*Repeat Password";
                rptxt.Foreground = System.Windows.Media.Brushes.Black;

            }
            else
            {
                if (runpass.Text == pass.Password)
                {
                    rptxt.Text = "*Repeat Password";
                    rptxt.Foreground = System.Windows.Media.Brushes.ForestGreen;

                }
                else
                {
                    rptxt.Text = " Password doesn't match!";
                    rptxt.Foreground = System.Windows.Media.Brushes.Red;
                }

            }
        }

        string old;
        private void phone_TextChanged(object sender, TextChangedEventArgs e)
        {
        foreach(char i in phone.Text)
            {
                if((int)i-48>=0&& (int)i - 48 <= 9)
                {

                }
                else
                {
                    phone.Text = old;
                }
            }
        old= phone.Text;    

        }

    
        
        private void signUpbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            signUpbutton.Background = new SolidColorBrush(Colors.MediumPurple);
        }

        private void signUpbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            signUpbutton.Background = a.Background;
        }
    }
     
       
   
}
