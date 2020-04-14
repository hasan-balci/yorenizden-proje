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

namespace Mağaza_yeni.sayfalar
{
    /// <summary>
    /// girisYap.xaml etkileşim mantığı
    /// </summary>
    public partial class girisYap : Page
    {
        public girisYap()
        {
            InitializeComponent();
        }

        private void fotogif_MediaEnded(object sender, RoutedEventArgs e)
        {
            fotogif.Position = new TimeSpan(0, 0, 1);
        }
    }
}
