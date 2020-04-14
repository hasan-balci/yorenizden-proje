using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace Mağaza_yeni.sayfalar
{
    /// <summary>
    /// MainPage.xaml etkileşim mantığı
    /// </summary>
    public partial class MainPage : Page
    {
        
        int a;

        public MainPage()
        {
            InitializeComponent();

            
        }
        
        
       


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hediyelik_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gıda_urunleri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sirke_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sarküteri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void süt_ürün_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bakliyat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void salcavesos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tümünü_Click(object sender, RoutedEventArgs e)
        {

        }

        private void balbuton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            anasayfaGif.Position = new TimeSpan(0, 0, 1);
        }
        
        private void geri_Click(object sender, RoutedEventArgs e)
        {
            kaydirpanel.Margin = new Thickness(a, 1, 1, 1);

            if (a < 2)
            {
                a = 1;
            }

           else
            a += 234;


        }

        private void ileri_Click(object sender, RoutedEventArgs e)
        {
            kaydirpanel.Margin = new Thickness(a, 1, 1, 1);
            if(a<-702)
            {
                a = 1;
            }
            else
            a -= 234;
            
        }

        private void anasayfaGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            anasayfaGif.Position = new TimeSpan(0, 0, 1);
        }
    }
}





