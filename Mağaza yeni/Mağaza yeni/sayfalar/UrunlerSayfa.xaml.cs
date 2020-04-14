using Mağaza_yeni.model;
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
    /// UrunlerSayfa.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunlerSayfa : Page
    {
        public UrunlerSayfa()
        {
            InitializeComponent(); var urunler = Urunleri_Getir();
            if (urunler.Count > 0)
                Urunler_Listesi.ItemsSource = urunler;


        }

        private List<Urun> Urunleri_Getir()
        {
            return new List<Urun>()
        {
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
        new Urun("Ev Yapımı Erişte(800gr)","Stokta","22.50TL",""),
         };
        }

        private void Siralama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
