using Mağaza_yeni.sayfalar;
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

namespace Mağaza_yeni
{
    /// <summary>
    /// MasterPage.xaml etkileşim mantığı
    /// </summary>
    public partial class MasterPage : Page
    {
        
        public MasterPage()
        {
            InitializeComponent();
            sayfa.Content = new MainPage();
            
        }

        private void Anasayfa_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new MainPage();
            GirisYap.Background = Brushes.White;
            KayıtOl.Background = Brushes.White;
            Hakkımızda.Background = Brushes.White;
            Mağaza.Background = Brushes.White;
            Anasayfa.Background = Brushes.OrangeRed;



        }

        private void sepetim_Click(object sender, RoutedEventArgs e)
        {
            maincolumn.Width = new GridLength(1119);
            Sepetim.Background = Brushes.OrangeRed;
        }

        private void magaza_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new UrunlerSayfa();

            GirisYap.Background = Brushes.White;
            KayıtOl.Background = Brushes.White;
            Anasayfa.Background = Brushes.White;
            Hakkımızda.Background = Brushes.White;
            Mağaza.Background = Brushes.OrangeRed;
        }

        private void iletişim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sepet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ara_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mağaza_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new UrunlerSayfa();
            GirisYap.Background = Brushes.White;
            KayıtOl.Background = Brushes.White;
            Anasayfa.Background = Brushes.White;
            Hakkımızda.Background = Brushes.White;
            Mağaza.Background = Brushes.OrangeRed;
        }

        private void Blog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hakkımızda_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new hakkımızda();
            GirisYap.Background = Brushes.White;
            KayıtOl.Background = Brushes.White;
            Anasayfa.Background = Brushes.White;
            Hakkımızda.Background = Brushes.OrangeRed;
            Mağaza.Background = Brushes.White;
        }

        private void Sepetim_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Hesabım_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GirisYap_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new girisYap();
            GirisYap.Background = Brushes.OrangeRed;
            KayıtOl.Background = Brushes.White;
            Anasayfa.Background = Brushes.White;
            Hakkımızda.Background = Brushes.White;
            Mağaza.Background = Brushes.White;
            
        }

        private void KayıtOl_Click(object sender, RoutedEventArgs e)
        {
            sayfa.Content = new KayitOlSayfa();
            KayıtOl.Background = Brushes.OrangeRed;
            GirisYap.Background = Brushes.White;
            Anasayfa.Background = Brushes.White;
            Hakkımızda.Background = Brushes.White;
            Mağaza.Background = Brushes.White;
            

        }

       

        private void sepetkapat_Click(object sender, RoutedEventArgs e)
        {
            maincolumn.Width = new GridLength(1519);
            Sepetim.Background = Brushes.White;
        }
    }
}


