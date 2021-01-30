using System;
using System.Collections.Generic;
using System.Text;
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
    /// Logique d'interaction pour LimitCharUC.xaml
    /// </summary>
    public partial class LimitCharUC : UserControl
    {
        public LimitCharUC(string titre, int maxlength)
        {
            InitializeComponent();
            titreUC.Content = titre;
            maxLength.Content += maxlength.ToString();
            entree.MaxLength = maxlength;
        }
    }
}
