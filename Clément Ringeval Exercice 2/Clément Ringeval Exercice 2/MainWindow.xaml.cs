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

namespace Clément_Ringeval_Exercice_2
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
        private void TextBoxGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox source = e.Source as TextBox;

            if (source != null)
            {
                source.Clear();
                source.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LimitCharUC nvControle = new LimitCharUC(titre.Text, int.Parse(maxlength.Text));
                this.w1.Children.Add(nvControle);
                titre.FontStyle = FontStyles.Italic;
                maxlength.FontStyle = FontStyles.Italic;
                titre.Text = "Titre";
                maxlength.Text = "MaxLength";
            }
            catch
            {
                MessageBox.Show("MaxLength doit être un int");
            }
        }
    }
}
