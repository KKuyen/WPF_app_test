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

namespace login_screen
{
    /// <summary>
    /// Interaction logic for exit.xaml
    /// </summary>
    public partial class exit : Window
    {
        public exit(MainView a)
        {
            InitializeComponent();


        }
        
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
              
            this.Close(); 
        }
    }
}
